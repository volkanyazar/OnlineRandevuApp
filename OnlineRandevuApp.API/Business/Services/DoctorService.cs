using Microsoft.EntityFrameworkCore;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.DataAccess;
using OnlineRandevuApp.API.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly OnlineRandevousContext _context;

        public DoctorService(OnlineRandevousContext context)
        {
            this._context = context;
        }
        public async Task<BaseResponse<List<Doctor>>> GetAll()
        {
            var response = new BaseResponse<List<Doctor>>();

            try
            {
                var result = await this._context.Doctor.Include(x => x.Department).ToListAsync();

                response.Data = result;
                response.HasError = false;
                response.SetSuccess("Doktor Bilgileri Başarıyla Getirildi.");
            }
            catch (Exception e)
            {
                response.Data = null;
                response.HasError = true;
                response.SetError($"Veritabanı Hatası - Hata Mesajı : {e.Message}");
            }
            return response;
        }
    }
}
