using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRandevuApp.API.Entities
{
    [Table("Hospital")]
    public class Hospital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string HospitalCode { get; set; }

    }
}
