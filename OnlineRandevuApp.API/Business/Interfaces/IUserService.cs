using OnlineRandevuApp.API.Core.Concrete;
using OnlineRandevuApp.API.Core.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Interfaces
{
    public interface IUserService
    {
        Task<BaseResponse<List<User>>> GetAll();
    }
}