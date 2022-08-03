using Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface ITrenRepository
    {
        Task<List<Tren>> GetTrenİnf();
        public Task<ReservationResponseDto> ReservationControl(TrenDto trenDto);
    }
}
