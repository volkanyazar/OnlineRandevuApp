using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRandevuSystemApp.Models
{
    public class RandevousModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int DoctorId { get; set; }
        public DateTime? Date { get; set; }
        public string Hour { get; set; }
    }
}
