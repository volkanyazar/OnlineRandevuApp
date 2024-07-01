using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Business.Interfaces
{
    public interface IDoctorService
    {
        Task<BaseResponse<List<Doctor>>> GetAll();

        Task<BaseResponse<List<DoctorInfoModel>>> GetDoctorInfo();

        Task<BaseResponse<List<DoctorInfoModel>>> GetDoctorInfoByDepartmentId(int departmentId);
    }
}