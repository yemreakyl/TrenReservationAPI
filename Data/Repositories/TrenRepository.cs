using Core;
using Core.Dtos;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TrenRepository : ITrenRepository
    {
        
        private readonly AppDbContext _context;

        public TrenRepository(AppDbContext context)
        {

            _context = context;
        }
        public async Task<List<Tren>> GetTrenİnf()
        {
            var Response = await _context.Trens.Include(x => x.Wagons).ToListAsync();

            return Response;
        }
        public async Task<ReservationResponseDto> ReservationControl(TrenDto trenDto)
        {
            var response = await _context.Trens.Where(x => x.Name == trenDto.TrenName).Include(x => x.Wagons).FirstOrDefaultAsync();
            if (!(response == null))
            {
                if (!trenDto.DifferentWagonsAvaliable)
                {
                    foreach (Wagon item in response.Wagons)
                    {
                        if (!(item.fullseat >= item.Capasity * 70 / 100))
                        {
                            var emptyseat = item.Capasity - item.fullseat;
                            if (emptyseat >= trenDto.NumberOfPeopleToBook)
                            {
                                return new ReservationResponseDto { Placementdetail = $"Ad :{item.Name} Kişi Sayısı : {trenDto.NumberOfPeopleToBook}", ReservationAvaliable = true };
                            }

                        }

                    }
                    return new ReservationResponseDto { Placementdetail = null, ReservationAvaliable = false };

                }
                else
                {
                    foreach (Wagon item in response.Wagons)
                    {
                        if (!(item.fullseat >= item.Capasity * 70 / 100))
                        {
                            int emptySeat = item.Capasity - item.fullseat;
                            if (emptySeat >= trenDto.NumberOfPeopleToBook)
                            {
                                return new ReservationResponseDto { Placementdetail = $"Ad :{item.Name} Kişi Sayısı : {trenDto.NumberOfPeopleToBook}", ReservationAvaliable = true };
                            }
                            else if (emptySeat > 0 && emptySeat < trenDto.NumberOfPeopleToBook)
                            {
                                return new ReservationResponseDto { Placementdetail = $"Ad :{item.Name} Kişi Sayısı : {emptySeat}", ReservationAvaliable = true };
                                trenDto.NumberOfPeopleToBook -= emptySeat;
                            }
                        }

                    }
                    return new ReservationResponseDto { Placementdetail = null, ReservationAvaliable = false };
                }
            }

            else
            {
                return new ReservationResponseDto { Placementdetail = null, ReservationAvaliable = false };
            }
        }


    }
}
