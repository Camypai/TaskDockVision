using System;

namespace TaskTwoWCF
{
    public class Mail
    {
        public string Caption { get; set; }
        public DateTime Date { get; set; }
        public string AddressTo { get; set; }
        public string AddressFrom { get; set; }
        public string Content { get; set; }
    }
}