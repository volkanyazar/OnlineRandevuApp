using Microsoft.EntityFrameworkCore;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Concrete;
using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Services
{
    public class UserService : IUserService
    {
        private readonly OnlineRandevousContext _context;

        public UserService(OnlineRandevousContext context)
        {
            this._context = context;
        }

        public async Task<BaseResponse<List<User>>> GetAll()
        {
            var response = new BaseResponse<List<User>>();

            try
            {
                var result = await this._context.User.ToListAsync();

                response.Data = result;
                response.HasError = false;
                response.SetSuccess("Kullanıcı Bilgileri Başarıyla Getirildi.");
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