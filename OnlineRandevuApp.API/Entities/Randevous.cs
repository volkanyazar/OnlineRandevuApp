using OnlineRandevuApp.API.Core.Abstract;
using OnlineRandevuApp.API.Core.Concrete;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRandevuApp.API.Entities
{
    [Table("Randevous")]
    public class Randevous : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? Date { get; set; }
        public string Hour { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}