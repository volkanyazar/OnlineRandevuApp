using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.DataAccess;
using OnlineRandevuApp.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using OnlineRandevuApp.API.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace OnlineRandevuApp.API.Business.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly OnlineRandevousContext _context;

        public HospitalService(OnlineRandevousContext context)
        {
            this._context = context;
        }

        public async Task<BaseResponse<List<Hospital>>> GetAll()
        {
            var response = new BaseResponse<List<Hospital>>();

            try
            {
                var result = await this._context.Hospital.OrderBy(x => x.HospitalCode).ToListAsync();

                response.Data = result;
                response.HasError = false;
                response.SetSuccess("Hastane Bilgileri Başarıyla Getirildi.");
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
