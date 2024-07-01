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
    public class DepartmentService : IDepartmentService
    {
        private readonly OnlineRandevousContext _context;

        public DepartmentService(OnlineRandevousContext context)
        {
            this._context = context;
        }

        public async Task<BaseResponse<List<Department>>> GetAll()
        {
            var response = new BaseResponse<List<Department>>();

            try
            {
                var result = await this._context.Department.Include(x => x.Hospital).ToListAsync();

                response.Data = result;
                response.HasError = false;
                response.SetSuccess("Departman Bilgileri Başarıyla Getirildi.");
            }
            catch (Exception e)
            {
                response.Data = null;
                response.HasError = true;
                response.SetError($"Veritabanı Hatası - Hata Mesajı : {e.Message}");
            }
            return response;
        }

        public async Task<BaseResponse<List<DepartmentInfoModel>>> GetDepartmentInfoByHospitalId(int hospitalId)
        {
            var response = new BaseResponse<List<DepartmentInfoModel>>();

            try
            {
                var result = await this._context.Department.Include(x => x.Hospital).Select(x => new DepartmentInfoModel { Id = x.Id, Name = x.Name, HospitalId = x.Hospital.Id, HospitalAd = x.Hospital.Name }).OrderBy(x => x.Name).Where(x => x.HospitalId == hospitalId).ToListAsync();

                response.Data = result;
                response.HasError = false;
                response.SetSuccess("Departman Bilgileri Başarıyla Getirildi.");
            }
            catch (Exception e)
            {
                response.Data = null;
                response.HasError = true;
                response.SetError($"Veritabanı Hatası - Hata Mesajı : {e.Message}");
            }
            return response;
        }

        public async Task<BaseResponse<List<DepartmentInfoModel>>> GetDepartmentInfo()
        {
            var response = new BaseResponse<List<DepartmentInfoModel>>();

            try
            {
                var result = await this._context.Department.Include(x => x.Hospital).Select(x => new DepartmentInfoModel { Id = x.Id, Name = x.Name, HospitalId = x.Hospital.Id, HospitalAd = x.Hospital.Name }).OrderBy(x => x.Name).ToListAsync();

                response.Data = result;
                response.HasError = false;
                response.SetSuccess("Departman Bilgileri Başarıyla Getirildi.");
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