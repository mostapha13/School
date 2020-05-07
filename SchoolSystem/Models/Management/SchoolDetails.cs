using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Management
{
    public class SchoolDetails
    {
        public int MainCode { get; set; }
        public DateTime InsertDateMiladi { get; set; }
        public string InsertDate
        {
            get {
                Conversion cn = new Conversion();
                return cn.PersianCalendar(InsertDateMiladi); 
            }
        }
        public int SchoolCode { get; set; }
        public bool SchoolCodeEdit { get; set; }
        public string Name { get; set; }
        public bool NameEdit { get; set; }
        public string AreaName { get; set; }
        public bool AreaNameEdit { get; set; }
        public int AreaCode { get; set; }
        public bool AreaCodeEdit { get; set; }
        public string Period { get; set; }
        public bool PeriodEdit { get; set; }
        public string SubSet { get; set; }
        public bool SubSetEdit { get; set; }
        public string Gender { get; set; }
        public bool GenderEdit { get; set; }
        public string Address { get; set; }
        public bool AddressEdit { get; set; }
        public string Tell1 { get; set; }
        public bool Tell1Edit { get; set; }
        public string Tell2 { get; set; }
        public bool Tell2Edit { get; set; }
        public string Tell3 { get; set; }
        public bool Tell3Edit { get; set; }
        public int StudentCount { get; set; }
        public bool StudentCountEdit { get; set; }
        public int BasicCount { get; set; }
        public bool BasicCountEdit { get; set; }
        public int TeacherCount { get; set; }
        public bool TeacherCountEdit { get; set; }
        public string StudyTime { get; set; }
        public bool StudyTimeEdit { get; set; }
        public string PostalCode { get; set; }
        public bool PostalCodeEdit { get; set; }
        public string MobileInternet { get; set; }
        public bool MobileInternetEdit { get; set; }
        public string ADSL { get; set; }
        public bool ADSLEdit { get; set; }
        public string ManagerName { get; set; }
        public bool ManagerNameEdit { get; set; }
        public string ManagerMobile { get; set; }
        public bool ManagerMobileEdit { get; set; }
        public string ManagerNationalCode { get; set; }
        public bool ManagerNationalCodeEdit { get; set; }
        public string Amarcode { get; set; }
        public bool AmarcodeEdit { get; set; }
        public string OstanName { get; set; }
        public bool OstanNameEdit { get; set; }
        public string ShahrestanName { get; set; }
        public bool ShahrestanNameEdit { get; set; }
        public string BakhshName { get; set; }
        public bool BakhshNameEdit { get; set; }
        public string DehestanName { get; set; }
        public bool DehestanNameEdit { get; set; }
        public string AbadiName { get; set; }
        public bool AbadiNameEdit { get; set; }
        public float Lat { get; set; }
        public bool LatEdit { get; set; }
        public float Lng { get; set; }
        public bool LngEdit { get; set; }
        public string Comment { get; set; }
        public bool CommentEdit { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
    }
}
