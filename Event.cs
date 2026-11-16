using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEFcore02.Classes
{
    public class Event
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }             // optional
        public int MaxAttendees { get; set; }
    }
}
