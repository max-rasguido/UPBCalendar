using System;
using System.Collections.Generic;
using System.Text;

namespace UPBCalendar
{
    public class Events
    {
        public string Event { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Type { get; set; }
        public bool IsHeader { get; set; }
        public Events(string ev,string da, string ho, string type)
        {
            Event = ev;
            Date = da;
            Hour = ho;
            Type = type;
            IsHeader = false;
        }
        public Events(string da, string ho,string type)
        {
            Date = da;
            Hour = ho;
            Type = type;
            IsHeader = false;
        }
        public Events(string he, bool IH,string type)
        {
            Event = he;
            IsHeader = IH;
            Type = type;
        }
        public string GetStringEvent()
        {
            return Date + "|" + Hour;
        }
    }
}
