﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineRandevuApp.API.Core.Abstract;
using OnlineRandevuApp.API.Core.Concrete;

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
        public int DoctorId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }
}
