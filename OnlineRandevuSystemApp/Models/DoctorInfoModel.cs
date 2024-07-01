using System;

namespace OnlineRandevuApp.API.Models
{
    public class DoctorInfoModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SicilNo { get; set; }
        public string TcNo { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentAd { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartHour { get; set; }
        public DateTime? EndHour { get; set; }
    }
}