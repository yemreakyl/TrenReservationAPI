using Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ITrenService<T> where T : class
    {    
        Task<List<Tren>> GetTrenİnf();
        public Task<ReservationResponseDto> ReservationControl(TrenDto trenDto);
    }
}
