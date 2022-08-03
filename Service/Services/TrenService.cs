using Core;
using Core.Dtos;
using Core.Repository;
using Core.Services;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TrenService : ITrenService
    {
        private readonly ITrenRepository _repository;

        public TrenService(ITrenRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Tren>> GetTrenİnf()
        {
           var response=_repository.GetTrenİnf();
            return response;
        }

        public Task<ReservationResponseDto> ReservationControl(TrenDto trenDto)
        {
            var response = _repository.ReservationControl(trenDto);
            return response;
        }
    }
}

