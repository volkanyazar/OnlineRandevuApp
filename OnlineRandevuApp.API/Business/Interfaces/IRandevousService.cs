using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Interfaces
{
    public interface IRandevousService
    {
        Task<BaseResponse<List<Randevous>>> GetAll();
    }
}
