using Microsoft.EntityFrameworkCore;
using OnlineRandevuApp.API.Business.Interfaces;
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
                var result = await this._context.Doctor.Include(x => x.Department).ThenInclude(x => x.Hospital).ToListAsync();

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

        public async Task<BaseResponse<List<DoctorInfoModel>>> GetDoctorInfo()
        {
            var response = new BaseResponse<List<DoctorInfoModel>>();

            try
            {
                var result = await this._context.Doctor
                                    .Include(x => x.Department).
                                    Select(x => new DoctorInfoModel
                                    {
                                        DepartmentAd = x.Department.Name,
                                        DepartmentId = x.Department.Id,
                                        FirstName = x.FirstName,
                                        LastName = x.LastName,
                                        SicilNo = x.SicilNo,
                                        TcNo = x.TcNo,
                                        Id = x.Id,
                                        StartDate = x.StartDate,
                                        EndDate = x.EndDate,
                                        StartHour = x.StartHour,
                                        EndHour = x.EndHour,
                                    }).ToListAsync();

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

        public async Task<BaseResponse<List<DoctorInfoModel>>> GetDoctorInfoByDepartmentId(int departmentId)
        {
            var response = new BaseResponse<List<DoctorInfoModel>>();

            try
            {
                var result = await this._context.Doctor
                                    .Include(x => x.Department).
                                    Select(x => new DoctorInfoModel
                                    {
                                        DepartmentAd = x.Department.Name,
                                        DepartmentId = x.Department.Id,
                                        FirstName = x.FirstName,
                                        LastName = x.LastName,
                                        SicilNo = x.SicilNo,
                                        TcNo = x.TcNo,
                                        Id = x.Id,
                                        StartDate = x.StartDate,
                                        EndDate = x.EndDate,
                                        StartHour = x.StartHour,
                                        EndHour = x.EndHour,
                                    }).Where(x => x.DepartmentId == departmentId).ToListAsync();

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

        public async Task<BaseResponse<DoctorInfoModel>> GetDoctorInfoById(int doctorId)
        {
            var response = new BaseResponse<DoctorInfoModel>();

            try
            {
                var result = await this._context.Doctor
                                    .Include(x => x.Department).
                                    Select(x => new DoctorInfoModel
                                    {
                                        DepartmentAd = x.Department.Name,
                                        DepartmentId = x.Department.Id,
                                        FirstName = x.FirstName,
                                        LastName = x.LastName,
                                        SicilNo = x.SicilNo,
                                        TcNo = x.TcNo,
                                        Id = x.Id,
                                        StartDate = x.StartDate,
                                        EndDate = x.EndDate,
                                        StartHour = x.StartHour,
                                        EndHour = x.EndHour,
                                    }).FirstOrDefaultAsync(x => x.Id == doctorId);

                response.Data = result;
                response.HasError = false;
                response.SetSuccess("Doktor Bilgisi Başarıyla Getirildi.");
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