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
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            this._doctorService = doctorService;
        }

        #region Get Methods

        [HttpGet("getDoctorInfo")]
        public async Task<BaseResponse<List<DoctorInfoModel>>> GetDoctorInfo()
        {
            return await this._doctorService.GetDoctorInfo();
        }

        [HttpGet("getDoctorInfoByDepartmentId/{departmentId}")]
        public async Task<BaseResponse<List<DoctorInfoModel>>> GetDoctorInfoByDepartmentId(int departmentId)
        {
            return await this._doctorService.GetDoctorInfoByDepartmentId(departmentId);
        }

        [HttpGet("getDoctorInfoById/{doctorId}")]
        public async Task<BaseResponse<DoctorInfoModel>> GetDoctorInfoById(int doctorId)
        {
            return await this._doctorService.GetDoctorInfoById(doctorId);
        }

        #endregion Get Methods
    }
}