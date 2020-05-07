using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Home
{
    public class FormData
    {
        public string MainCode { get; set; }
        public string SchoolCode { get; set; }
        public string Name { get; set; }
        public string AreaName { get; set; }
        public string AreaCode { get; set; }
        public string SubSet { get; set; }
        public string Period { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Tell1 { get; set; }
        public string Tell2 { get; set; }
        public string Tell3 { get; set; }
        public string StudentCount { get; set; }
        public string BasicCount { get; set; }
        public string ManagerName { get; set; }
        public string ManagerMobile { get; set; }
        public string ManagerNationalCode { get; set; }
        public string AmarCode { get; set; }
        public string OstanName { get; set; }
        public string ShahrestanName { get; set; }
        public string BakhshName { get; set; }
        public string DehestanName { get; set; }
        public string AbadiName { get; set; }
        public string Status { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
        public string MobileInternet { get; set; }
        public string Adsl { get; set; }
        public string PostalCode { get; set; }
        public string TeacherCount { get; set; }
        public string StudyTime { get; set; }
        public string Comment { get; set; }
        public List<string> Images { get; set; }

    }
}
