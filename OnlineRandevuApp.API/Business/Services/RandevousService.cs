using Microsoft.EntityFrameworkCore;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Concrete;
using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.DataAccess;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var result = await this._context.Randevous.Include(x => x.User).Include(x => x.Doctor).ThenInclude(x => x.Department).ToListAsync();

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

        public async Task<BaseResponse<List<RandevousInfoModel>>> GetByUserId(int userId)
        {
            var response = new BaseResponse<List<RandevousInfoModel>>();

            try
            {
                var result = await this._context.Randevous
                                    .Include(x => x.User)
                                    .Include(x => x.Doctor)
                                        .ThenInclude(x => x.Department)
                                    .Where(x => x.UserId == userId).
                                    Select(x => new RandevousInfoModel 
                                    { 
                                        Bolum = x.Doctor.Department.Name,
                                        DoctorId = x.DoctorId,
                                        RandevoNo = x.Id.ToString(), 
                                        UserId = x.UserId, 
                                        RandevuSaati = x.Hour, 
                                        RandevuTarihi = x.Date, 
                                        DoktorAdSoyad = x.Doctor.FirstName + " " + x.Doctor.LastName 
                                    }).ToListAsync();


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
