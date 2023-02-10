
namespace Profit.Presentation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSelectPort = new System.Windows.Forms.Label();
            this.comboBoxSelectPort = new System.Windows.Forms.ComboBox();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxSent = new System.Windows.Forms.TextBox();
            this.buttonClearSent = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxRecieve = new System.Windows.Forms.TextBox();
            this.buttonClearRecieve = new System.Windows.Forms.Button();
            this.radioButtonASCII = new System.Windows.Forms.RadioButton();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.groupBoxSend = new System.Windows.Forms.GroupBox();
            this.groupBoxRead = new System.Windows.Forms.GroupBox();
            this.groupBoxControl.SuspendLayout();
            this.groupBoxSend.SuspendLayout();
            this.groupBoxRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectPort
            // 
            this.labelSelectPort.AutoSize = true;
            this.labelSelectPort.Location = new System.Drawing.Point(44, 30);
            this.labelSelectPort.Name = "labelSelectPort";
            this.labelSelectPort.Size = new System.Drawing.Size(63, 15);
            this.labelSelectPort.TabIndex = 0;
            this.labelSelectPort.Text = "Select Port";
            // 
            // comboBoxSelectPort
            // 
            this.comboBoxSelectPort.FormattingEnabled = true;
            this.comboBoxSelectPort.Location = new System.Drawing.Point(130, 27);
            this.comboBoxSelectPort.Name = "comboBoxSelectPort";
            this.comboBoxSelectPort.Size = new System.Drawing.Size(160, 23);
            this.comboBoxSelectPort.TabIndex = 1;
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(44, 60);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(54, 15);
            this.labelBaudrate.TabIndex = 2;
            this.labelBaudrate.Text = "Baudrate";
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Location = new System.Drawing.Point(130, 57);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(160, 23);
            this.comboBoxBaudrate.TabIndex = 3;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(130, 86);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(215, 86);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(6, 22);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(191, 23);
            this.textBoxSend.TabIndex = 5;
            this.textBoxSend.TextChanged += new System.EventHandler(this.textBoxSend_TextChanged);
            this.textBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSend_KeyPress);
            // 
            // textBoxSent
            // 
            this.textBoxSent.Location = new System.Drawing.Point(6, 76);
            this.textBoxSent.Multiline = true;
            this.textBoxSent.Name = "textBoxSent";
            this.textBoxSent.ReadOnly = true;
            this.textBoxSent.Size = new System.Drawing.Size(191, 239);
            this.textBoxSent.TabIndex = 5;
            // 
            // buttonClearSent
            // 
            this.buttonClearSent.Location = new System.Drawing.Point(203, 105);
            this.buttonClearSent.Name = "buttonClearSent";
            this.buttonClearSent.Size = new System.Drawing.Size(75, 23);
            this.buttonClearSent.TabIndex = 6;
            this.buttonClearSent.Text = "Clear";
            this.buttonClearSent.UseVisualStyleBackColor = true;
            this.buttonClearSent.Click += new System.EventHandler(this.buttonClearSent_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(203, 76);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxRecieve
            // 
            this.textBoxRecieve.Location = new System.Drawing.Point(6, 22);
            this.textBoxRecieve.Multiline = true;
            this.textBoxRecieve.Name = "textBoxRecieve";
            this.textBoxRecieve.ReadOnly = true;
            this.textBoxRecieve.Size = new System.Drawing.Size(199, 169);
            this.textBoxRecieve.TabIndex = 8;
            // 
            // buttonClearRecieve
            // 
            this.buttonClearRecieve.Location = new System.Drawing.Point(215, 22);
            this.buttonClearRecieve.Name = "buttonClearRecieve";
            this.buttonClearRecieve.Size = new System.Drawing.Size(75, 23);
            this.buttonClearRecieve.TabIndex = 9;
            this.buttonClearRecieve.Text = "Clear";
            this.buttonClearRecieve.UseVisualStyleBackColor = true;
            this.buttonClearRecieve.Click += new System.EventHandler(this.buttonClearRecieve_Click);
            // 
            // radioButtonASCII
            // 
            this.radioButtonASCII.AutoSize = true;
            this.radioButtonASCII.Location = new System.Drawing.Point(58, 51);
            this.radioButtonASCII.Name = "radioButtonASCII";
            this.radioButtonASCII.Size = new System.Drawing.Size(53, 19);
            this.radioButtonASCII.TabIndex = 10;
            this.radioButtonASCII.TabStop = true;
            this.radioButtonASCII.Text = "ASCII";
            this.radioButtonASCII.UseVisualStyleBackColor = true;
            this.radioButtonASCII.CheckedChanged += new System.EventHandler(this.radioButtonASCII_CheckedChanged);
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Location = new System.Drawing.Point(6, 51);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(46, 19);
            this.radioButtonHex.TabIndex = 10;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            this.radioButtonHex.CheckedChanged += new System.EventHandler(this.radioButtonHex_CheckedChanged);
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.labelSelectPort);
            this.groupBoxControl.Controls.Add(this.comboBoxSelectPort);
            this.groupBoxControl.Controls.Add(this.labelBaudrate);
            this.groupBoxControl.Controls.Add(this.comboBoxBaudrate);
            this.groupBoxControl.Controls.Add(this.buttonClose);
            this.groupBoxControl.Controls.Add(this.buttonOpen);
            this.groupBoxControl.Location = new System.Drawing.Point(303, 12);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(298, 117);
            this.groupBoxControl.TabIndex = 11;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Control";
            // 
            // groupBoxSend
            // 
            this.groupBoxSend.Controls.Add(this.textBoxSend);
            this.groupBoxSend.Controls.Add(this.radioButtonASCII);
            this.groupBoxSend.Controls.Add(this.radioButtonHex);
            this.groupBoxSend.Controls.Add(this.buttonClearSent);
            this.groupBoxSend.Controls.Add(this.buttonSend);
            this.groupBoxSend.Controls.Add(this.textBoxSent);
            this.groupBoxSend.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSend.Name = "groupBoxSend";
            this.groupBoxSend.Size = new System.Drawing.Size(285, 321);
            this.groupBoxSend.TabIndex = 11;
            this.groupBoxSend.TabStop = false;
            this.groupBoxSend.Text = "Data Send";
            // 
            // groupBoxRead
            // 
            this.groupBoxRead.Controls.Add(this.textBoxRecieve);
            this.groupBoxRead.Controls.Add(this.buttonClearRecieve);
            this.groupBoxRead.Location = new System.Drawing.Point(303, 135);
            this.groupBoxRead.Name = "groupBoxRead";
            this.groupBoxRead.Size = new System.Drawing.Size(298, 198);
            this.groupBoxRead.TabIndex = 12;
            this.groupBoxRead.TabStop = false;
            this.groupBoxRead.Text = "Data Read";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 340);
            this.Controls.Add(this.groupBoxRead);
            this.Controls.Add(this.groupBoxSend);
            this.Controls.Add(this.groupBoxControl);
            this.MaximumSize = new System.Drawing.Size(626, 379);
            this.MinimumSize = new System.Drawing.Size(626, 379);
            this.Name = "MainForm";
            this.Text = "Serial Port";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.groupBoxSend.ResumeLayout(false);
            this.groupBoxSend.PerformLayout();
            this.groupBoxRead.ResumeLayout(false);
            this.groupBoxRead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelSelectPort;
        private ComboBox comboBoxSelectPort;
        private Label labelBaudrate;
        private ComboBox comboBoxBaudrate;
        private Button buttonOpen;
        private Button buttonClose;
        private TextBox textBoxSend;
        private TextBox textBoxSent;
        private Button buttonClearSent;
        private Button buttonSend;
        private TextBox textBoxRecieve;
        private Button buttonClearRecieve;
        private RadioButton radioButtonASCII;
        private RadioButton radioButtonHex;
        private GroupBox groupBoxControl;
        private GroupBox groupBoxSend;
        private GroupBox groupBoxRead;
    }
}