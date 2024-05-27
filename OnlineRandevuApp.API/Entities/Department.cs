using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRandevuApp.API.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }
}