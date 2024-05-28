﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRandevuApp.API.Entities
{
    [Table("Doctor")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SicilNo { get; set; }
        public string TcNo { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmanId")]
        public Department Department { get; set; }
    }
}