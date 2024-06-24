using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.DataAccess;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Services
{
    public class RandevousService : IRandevousService
    {
        private readonly OnlineRandevousContext _context;
        private readonly IMapper _mapper;

        public RandevousService(OnlineRandevousContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<BaseResponse<List<Randevous>>> GetAll()
        {
            var response = new BaseResponse<List<Randevous>>();

            try
            {
                var result = await this._context.Randevous.Include(x => x.User).Include(x => x.Doctor).ThenInclude(x => x.Department).ThenInclude(x => x.Hospital).ToListAsync();

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
                                        DoctorId = x.Doctor.Id,
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

        public async Task<BaseResponse<Randevous>> AddRandevousAsync(Randevous randevous)
        {
            BaseResponse<Randevous> response = new BaseResponse<Randevous>();
            using (var transaction = _context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    Randevous randevousData = new Randevous();
                    randevousData = _mapper.Map<Randevous>(randevous);
                    await this._context.AddAsync(randevousData);
                    await this._context.SaveChangesAsync();

                    transaction.Commit();
                    response.SetSuccess("Randevu Kaydı Başarıyla Eklendi.");
                    response.Data = randevousData;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    response.Data = null;
                    response.HasError = true;
                    response.SetError($"Veritabanı Hatası - Hata Mesajı : {e.Message}");
                }
            }
            return response;
        }
    }
}