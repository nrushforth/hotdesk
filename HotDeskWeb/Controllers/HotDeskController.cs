using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotDeskWeb.Models;

namespace HotDeskWeb.Controllers
{
    public class HotDeskController
    {

        public HotDeskController()
        { }

        public Models.HotDesks PopulateModel(HotDesks objectToPopulate)
        {
            objectToPopulate.DeskID = 1;
            objectToPopulate.InUse = true;
            objectToPopulate.UserName = "Neal";
            objectToPopulate.CalendarDate = DateTime.Today;

            return objectToPopulate;
        }
    }
}