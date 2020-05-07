using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class Conversion
    {
        public string PersianCalendar(DateTime date)
        {
            var pc = new PersianCalendar();
            var result = $"{pc.GetYear(date).ToString("0000")}/{pc.GetMonth(date).ToString("00")}/{pc.GetDayOfMonth(date).ToString("00")}";
            return result;
        }



        public DateTime PersianToMiladiCalendar(string date)
        {

            DateTime dt = new DateTime();
            PersianCalendar pc = new PersianCalendar();

            int pYear = Convert.ToInt32(date.Substring(0, 4));
            int pMonth = Convert.ToInt32(date.Substring(5, 2));
            int pDay = Convert.ToInt32(date.Substring(8));
             
            dt = pc.ToDateTime(pYear, pMonth, pDay, 0, 0, 0, 0);
            return dt;

        }
    }
}
