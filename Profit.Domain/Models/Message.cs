namespace Profit.Domain.Models
{
    public class Message
    {
        public long Id { get; set; }
        public string Data { get; set; }
        public DateTime CreationTime { get; set; }
    }
}