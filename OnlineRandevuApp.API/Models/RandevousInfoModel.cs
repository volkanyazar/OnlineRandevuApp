﻿using System;

namespace OnlineRandevuApp.API.Models
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