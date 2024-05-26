﻿using Microsoft.AspNetCore.Mvc;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Utilities;
using OnlineRandevuApp.API.Entities;
using OnlineRandevuApp.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Controllers
{
    [Route("api/randevous")]
    [ApiController]
    public class RandevousController : ControllerBase
    {
        private readonly IRandevousService _randevousService;
        public RandevousController(IRandevousService randevousService)
        {
            this._randevousService = randevousService;
        }

        [HttpGet("getall")]
        public async Task<BaseResponse<List<Randevous>>> GetAll()
        {
            return await this._randevousService.GetAll();
        }

        [HttpGet("getByUserId/{userId}")]
        public async Task<BaseResponse<List<RandevousInfoModel>>> GetByUserId(int userId)
        {
            return await this._randevousService.GetByUserId(userId);
        }
    }
}
