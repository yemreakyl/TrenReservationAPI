using AutoMapper;
using Core;
using Core.Dtos;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    public class ReservationController : CustomBaseController
    {     
        private readonly ITrenService _service;
        public ReservationController( ITrenService tren_Service)
        {
        
            _service = tren_Service;
        }
        [HttpGet]
        public async Task<IActionResult> GetTrensİnfo()
        {
            var Trens = await _service.GetTrenİnf();
                    
            return CreateActionResult(CustomResponseDto<List<Tren>>.Success(200,Trens));
        }

        [HttpPost]       
        public async Task<IActionResult> DoReservation([FromBody]TrenDto trenDto)
        {
            var data=await _service.ReservationControl(trenDto);
            return CreateActionResult(CustomResponseDto<ReservationResponseDto>.Success(200, data));
        }


    }
}
