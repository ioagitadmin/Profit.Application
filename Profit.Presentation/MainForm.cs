using System.Collections.Concurrent;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace Profit.Presentation
{
    public partial class MainForm : Form
    {
        public const int DataBits = 8;
        public const int ReadBufferSize = 4096;
        public const StopBits StopBitsSetting = StopBits.One;
        public const Parity ParitySetting = Parity.None;
        public const int WriteTimeout = 5000;

        private readonly IDictionary<string, int> _baudRates;
        private readonly ConcurrentQueue<Message> _recieveOut;
        private readonly SerialPort _serialPort;
        private readonly IWebClient _webClient;

        private string sendOut;
        private object sendLocker = new object();
        private bool _inputFormatASCII;

        public MainForm(IWebClient webClient)
        {
            InitializeComponent();
            _webClient = webClient;
            _serialPort = new SerialPort();
            _recieveOut = new ConcurrentQueue<Message>();
            _baudRates = new Dictionary<string, int>() { };
            _baudRates.Add("9600", 9600);
            _baudRates.Add("19200", 19200);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();

            if (ports != null && ports.Any())
            {
                comboBoxSelectPort.Items.AddRange(ports);
                comboBoxSelectPort.SelectedIndex = 0;
            }
            else
                buttonOpen.Enabled = false;

            buttonClose.Enabled = false;

            comboBoxBaudrate.Items.AddRange(_baudRates.Keys.ToArray());
            comboBoxBaudrate.SelectedIndex = 0;

            radioButtonHex.Checked = true;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            _serialPort.PortName = comboBoxSelectPort.Text;
            _serialPort.BaudRate = _baudRates[comboBoxBaudrate.Text];
            _serialPort.Parity = ParitySetting;
            _serialPort.StopBits = StopBitsSetting;
            _serialPort.DataBits = DataBits;
            _serialPort.ReadBufferSize = ReadBufferSize;
            _serialPort.WriteTimeout = WriteTimeout;

            try
            {
                if (!_serialPort.IsOpen)
                    _serialPort.Open();

                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;

                _serialPort.DataReceived += Receive;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseSerialPort();
        }

        private void buttonClearSent_Click(object sender, EventArgs e)
        {
            textBoxSent.Clear();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
                return;

            if (string.IsNullOrEmpty(sendOut))
                return;

            if (!Monitor.TryEnter(sendLocker))
                return;

            try
            {
                Send();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Monitor.Exit(sendLocker);
            }
        }

        private void Send()
        {

            Action block = () =>
            {
                textBoxSend.Enabled = false;
                buttonSend.Enabled = false;
            };

            Action action = () =>
            {
                textBoxSent.AppendText(sendOut);
                textBoxSend.Clear();
            };

            Action unblock = () =>
            {
                textBoxSend.Enabled = true;
                buttonSend.Enabled = true;
            };


            Task.Run(() =>
            {
                try
                {
                    this.Invoke(block);
                    _serialPort.Write(sendOut + "\r\n");
                    this.Invoke(action);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Invoke(unblock);
                }
            });
        }

        private void CloseSerialPort()
        {
            try
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();

                buttonOpen.Enabled = true;
                buttonClose.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _serialPort.DataReceived -= Receive;
            }
        }
        private void ReadMessage(Message message)
        {
            _recieveOut.Enqueue(message);

            Task.Run(() =>
            {
                while (_recieveOut.Any())
                {
                    try
                    {
                        if (!_recieveOut.TryDequeue(out var item))
                            break;

                        _webClient.CreateMessage(item);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            });

            Action action = () =>
            {
                textBoxRecieve.AppendText(message.Data + "\r\n");
            };
            Invoke(action);
        }

        private void Receive(object sender, SerialDataReceivedEventArgs e)
        {
            if (_serialPort.BytesToRead == 0)
                return;

            var bytes = new List<int>(_serialPort.BytesToRead);

            try
            {
                while (_serialPort.BytesToRead > 0)
                    bytes.Add(_serialPort.ReadByte());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var data = bytes.Aggregate(new StringBuilder(), (result, b) => {

                result.Append(Convert.ToString(b, 16));
                return result;
            }).ToString();

            var message = new Message(data);
            ReadMessage(message);
        }

        private void textBoxSend_TextChanged(object sender, EventArgs e)
        {
            sendOut = textBoxSend.Text;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseSerialPort();
        }

        private void buttonClearRecieve_Click(object sender, EventArgs e)
        {
            textBoxRecieve.Clear();
        }

        private void radioButtonASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (_inputFormatASCII)
                return;

            _inputFormatASCII = true;

            ChangeInputFormat();
        }

        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            if (!_inputFormatASCII)
                return;

            _inputFormatASCII = false;

            ChangeInputFormat();
        }

        private void ChangeInputFormat()
        {
            Action action = () =>
            {
                Action();
            };

            if (InvokeRequired)
                Invoke(action);
            else
                Action();

            void Action()
            {
                if (_inputFormatASCII)
                {
                    radioButtonHex.Checked = false;
                    radioButtonASCII.Checked = true;
                }
                else
                {
                    radioButtonHex.Checked = true;
                    radioButtonASCII.Checked = false;
                }

                textBoxSend.Clear();
            }
        }

        private void textBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (_inputFormatASCII)
            {
                if ((number != 8) && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(number) && (number != 8) && (e.KeyChar < 65 || e.KeyChar > 70))
                {
                    e.Handled = true;
                }
            }
        }
    }
}