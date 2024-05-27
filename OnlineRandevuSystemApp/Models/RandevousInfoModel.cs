using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRandevuSystemApp.Models
{
    public class RandevousInfoModel
    {
        public string RandevoNo { get; set; }
        public string DoktorAdSoyad { get; set; }
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }
        public string Bolum { get; set; }
    }
}
