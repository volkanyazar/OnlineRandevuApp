using Microsoft.EntityFrameworkCore;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Concrete;
using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.DataAccess;
using OnlineRandevuApp.API.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Services
{
    public class RandevousService : IRandevousService
    {
        private readonly OnlineRandevousContext _context;

        public RandevousService(OnlineRandevousContext context)
        {
            this._context = context;
        }

        public async Task<BaseResponse<List<Randevous>>> GetAll()
        {
            var response = new BaseResponse<List<Randevous>>();

            try
            {
                var result = await this._context.Randevous.Include(x => x.User).ToListAsync();

                response.Data = result;
                response.HasError = false;
                response.SetSuccess("Randevu Bilgileri Başarıyla Getirildi.");
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
