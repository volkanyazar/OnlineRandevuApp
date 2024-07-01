using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Interfaces
{
    public interface IDepartmentService
    {
        Task<BaseResponse<List<Department>>> GetAll();

        Task<BaseResponse<List<DepartmentInfoModel>>> GetDepartmentInfo();

        Task<BaseResponse<List<DepartmentInfoModel>>> GetDepartmentInfoByHospitalId(int hospitalId);
    }
}