using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Controllers
{
    [Route("api/hospital")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalService _hospitalService;

        public HospitalController(IHospitalService hospitalService)
        {
            this._hospitalService = hospitalService;
        }

        #region Get Methods

        [HttpGet("getAllHospital")]
        public async Task<BaseResponse<List<Hospital>>> GetAllHospital()
        {
            return await this._hospitalService.GetAll();
        }

        #endregion
    }
}
