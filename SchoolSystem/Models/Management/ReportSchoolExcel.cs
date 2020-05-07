using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Management
{
    public class ReportSchoolExcel
    {
        public int MainCode { get; set; }
        public DateTime InsertDateMiladi { get; set; }
        public string InsertDate
        {
            get
            {
                Conversion cn = new Conversion();
                return cn.PersianCalendar(InsertDateMiladi);
            }
        }
        public int SchoolCode { get; set; }
        public string Name { get; set; }
        public string IsCity { get; set; }
        public string Status { get; set; }
        public string AreaName { get; set; }
        public int AreaCode { get; set; }
        public string Period { get; set; }
        public string SubSet { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Tell1 { get; set; }
        public string Tell2 { get; set; }
        public string Tell3 { get; set; }
        public int StudentCount { get; set; }
        public int BasicCount { get; set; }
        public int TeacherCount { get; set; }
        public string StudyTime { get; set; }
        public string PostalCode { get; set; }
        public string MobileInternet { get; set; }
        public string ADSL { get; set; }
        public string ManagerName { get; set; }
        public string ManagerMobile { get; set; }
        public string ManagerNationalCode { get; set; }
        public string Amarcode { get; set; }
        public string OstanName { get; set; }
        public string ShahrestanName { get; set; }
        public string BakhshName { get; set; }
        public string DehestanName { get; set; }
        public string AbadiName { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string Comment { get; set; }
    }
}
