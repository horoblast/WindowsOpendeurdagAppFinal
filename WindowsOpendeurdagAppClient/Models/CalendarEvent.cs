using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;

namespace WindowsOpendeurdagAppWeb.Models
{
    public class CalendarEvent
    {
        public int CalendarEventId { get; set; }

        public DateTime DayOfEvent { get; set; }

        public string Name { get; set; }

        public string Adres { get; set; }

        public string ForWhom { get; set; }

        public string Time { get; set; }

        public string Language { get; set; }

        public string Organizer { get; set; }

        public string Contact { get; set; }

        public string Website { get; set; }

        public string Tekst { get; set; }
    }
}