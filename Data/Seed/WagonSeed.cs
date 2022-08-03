using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seed
{
    public class WagonSeed : IEntityTypeConfiguration<Wagon>
    {
       public void Configure(EntityTypeBuilder<Wagon> builder)
        {
            builder.HasData(
            new Wagon { Id = 1, Name = "Vagon 1", Capasity=100, fullseat=64, TrenId=1},
            new Wagon { Id = 2, Name = "Vagon 2", Capasity= 90 , fullseat = 75, TrenId=1},
            new Wagon { Id = 3, Name = "Vagon 3" , Capasity = 110 , fullseat = 61, TrenId=1},
            new Wagon { Id = 4, Name = "Vagon 4" , Capasity = 100 , fullseat = 88, TrenId=1},

            new Wagon { Id = 5, Name = "Vagon 1", Capasity = 100, fullseat = 64, TrenId = 2 },
            new Wagon { Id = 6, Name = "Vagon 2", Capasity = 70, fullseat = 70, TrenId = 2 },
            new Wagon { Id = 7, Name = "Vagon 3", Capasity = 110, fullseat = 51, TrenId = 2 },
            new Wagon { Id = 8, Name = "Vagon 4", Capasity = 120, fullseat = 84, TrenId = 2 },

            new Wagon { Id = 9, Name = "Vagon 1", Capasity = 90, fullseat = 74, TrenId = 3},
            new Wagon { Id = 10, Name = "Vagon 2", Capasity = 95, fullseat = 70, TrenId = 3 },
            new Wagon { Id = 11, Name = "Vagon 3", Capasity = 110, fullseat = 81, TrenId = 3 },
            new Wagon { Id = 12, Name = "Vagon 4", Capasity = 120, fullseat = 88, TrenId = 3 },

            new Wagon { Id = 13, Name = "Vagon 1", Capasity = 90, fullseat = 65, TrenId = 4 },
            new Wagon { Id = 14, Name = "Vagon 2", Capasity = 90, fullseat = 79, TrenId = 4 },
            new Wagon { Id = 15, Name = "Vagon 3", Capasity = 100, fullseat = 61, TrenId = 4 },
            new Wagon { Id = 16, Name = "Vagon 4", Capasity = 100, fullseat = 82, TrenId = 4 }

                );
        }
    }
}
