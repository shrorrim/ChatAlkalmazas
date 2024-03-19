using System;

namespace Models
{
    public class Message
    {
        public string Sender { get; set; }

        public DateTime SendDate { get; set; } = DateTime.Now;

        public string SentMessage { get; set; }
    }
}
