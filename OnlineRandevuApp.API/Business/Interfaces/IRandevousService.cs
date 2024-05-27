using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Interfaces
{
    public interface IRandevousService
    {
        Task<BaseResponse<List<Randevous>>> GetAll();

        Task<BaseResponse<List<RandevousInfoModel>>> GetByUserId(int userId);

        Task<BaseResponse<Randevous>> AddRandevousAsync(Randevous randevous);
    }
}