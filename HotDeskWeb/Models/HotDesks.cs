using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDeskWeb.Models
{
    public class HotDesks
    {
        public int DeskID { get; set; }
        public bool InUse { get; set; }
        public string UserName { get; set; }
        public DateTime CalendarDate { get; set; }

        public HotDesks()
        { }
    }
}