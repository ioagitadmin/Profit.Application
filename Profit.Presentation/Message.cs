using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Profit.Presentation
{
    public sealed class Message
    {
        [JsonIgnore]
        public long? Id { get; set; }
        public string Data { get; set; }
        public DateTime CreationTime { get; set; } 

        public Message(string data)
        {
            Data = data;
            CreationTime = DateTime.Now;
        }
    }
}
