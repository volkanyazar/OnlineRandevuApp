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
    }
}
