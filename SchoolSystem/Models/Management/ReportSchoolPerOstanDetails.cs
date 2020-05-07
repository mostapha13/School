using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Management
{
    public class ReportSchoolPerOstanDetails
    {
        public string Amarcode { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public string ManagerMobile { get; set; }
        public DateTime InsertDateMiladi { get; set; }
        public string InsertDate
        {
            get
            {
                Conversion cn = new Conversion();
                return cn.PersianCalendar(InsertDateMiladi);
            }
        }
        public string IsCity { get; set; }
        public int EditCount { get; set; }
        public int MainCode { get; set; }
        public string Status { get; set; }
    }
}
