using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this._departmentService = departmentService;
        }

        #region Get Methods

        [HttpGet("getAllDepartment")]
        public async Task<BaseResponse<List<Department>>> GetAllDepartment()
        {
            return await this._departmentService.GetAll();
        }

        [HttpGet("getDepartmentInfo")]
        public async Task<BaseResponse<List<DepartmentInfoModel>>> GetDepartmentInfo()
        {
            return await this._departmentService.GetDepartmentInfo();
        }

        [HttpGet("getDepartmentInfoByHospitalId/{hospitalId}")]
        public async Task<BaseResponse<List<DepartmentInfoModel>>> GetDepartmentInfoByHospitalId(int hospitalId)
        {
            return await this._departmentService.GetDepartmentInfoByHospitalId(hospitalId);
        }

        #endregion Get Methods
    }
}