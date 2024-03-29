﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Features.Tag.Queries;
using Application.Features.Tag.Commands;
using Microsoft.AspNetCore.Authorization;
using Application.Interfaces.Repo;
using Application.Wrappers;
using Application.Interfaces.Service;
//using Application.Features.Tag.Commands;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class DashboardController : BaseApiController
    {
        #region Queries
        private readonly IDashboardRepository _dashboardRepo;
        private readonly IAuthenticatedUserService _authenService;
        public DashboardController(IDashboardRepository dashboardRepo, IAuthenticatedUserService authenService)
        {
            _dashboardRepo = dashboardRepo;
            _authenService = authenService;
        }

        [HttpGet("ChartSong")]
        public async Task<IActionResult> GetChartSong([FromQuery] string Type)
        {
            var songchart = await _dashboardRepo.GetNumberSong(Type);
            return Ok(new Response<object>() { Msg = "Dashboer numbersong", Data = songchart });
        }

        [HttpGet("ChartPlaylist")]
        public async Task<IActionResult> GetChartPlaylist([FromQuery] string Type)
        {
            var playlistchart = await _dashboardRepo.GetNumberPlaylist(Type);
            return Ok(new Response<object>() { Msg = "Dashboard number playlist", Data = playlistchart });
        }

        [HttpGet("TotalPlaylist")]
        public async Task<IActionResult> GetTotalPlaylist()
        {
            var playlistchart = await _dashboardRepo.GetTotalPlaylist();
            return Ok(new Response<object>() { Msg = "Dashboard total playlist", Data = playlistchart });
        }

        [HttpGet("TotalType")]
        public async Task<IActionResult> GetTotalType()
        {
            var typechart = await _dashboardRepo.GetTotalType();
            return Ok(new Response<object>() { Msg = "Dashboard total type", Data = typechart });
        }

        [HttpGet("TotalRole")]
        public async Task<IActionResult> GetTotalRole()
        {
            var rolechart = await _dashboardRepo.GetTotalRole();
            return Ok(new Response<object>() { Msg = "Dashboard total Role", Data = rolechart });
        }

        [HttpGet("ChartAll")]
        public async Task<IActionResult> GetAll([FromQuery] string type)
        {
            var all = await _dashboardRepo.GetAll(type);
            return Ok(new Response<object>() { Msg = "Dashboard all", Data = all });
        }

        [HttpGet("ChartAge")]
        public async Task<IActionResult> GetAge([FromQuery] string type)
        {
            var all = await _dashboardRepo.GetAge(type);
            return Ok(new Response<object>() { Msg = "Dashboard Age", Data = all });
        }

        [HttpGet("ChartCreateUser")]
        public async Task<IActionResult> GetCreateUser([FromQuery] string type)
        {
            var all = await _dashboardRepo.GetCreateUser(type);
            return Ok(new Response<object>() { Msg = "Dashboard Create User", Data = all });
        }

        [HttpGet("ChartRectionMySong")]
        public async Task<IActionResult> ChartRectionMySong([FromQuery] string type)
        {
            var all = await _dashboardRepo.GetAllReactionMySong(type,_authenService.GetCurrentUserId());
            return Ok(new Response<object>() { Msg = "Dashboard Song", Data = all });
        }

        [HttpGet("GetAllInfoMySong")]
        public async Task<IActionResult> GetAllInfoMySong()
        {
            var all =  _dashboardRepo.GetAllInfoMySong( _authenService.GetCurrentUserId());
            return Ok(new Response<object>() { Msg = "Dashboard all", Data = all });
        }

        [HttpGet("GetChartAllUser")]
        public async Task<IActionResult> GetChartAllUser()
        {
            var all =await _dashboardRepo.GetChartAllUser();
            return Ok(new Response<object>() { Msg = "Dashboard user all", Data = all });
        }
        #endregion

        #region Command

        #endregion
    }
}
