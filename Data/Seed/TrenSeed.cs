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
    public class TrenSeed : IEntityTypeConfiguration<Tren>
    //Veri tabanım oluşurken tablolarıma default olarak değerler atamak ve doldurmuş olamak için bu classı kullanıyorum
    {
        public void Configure(EntityTypeBuilder<Tren> builder)
        {
            builder.HasData(
                            new Tren { Id = 1, Name = "Başkent Express",},
                            new Tren { Id = 2, Name = "Doğu Express" },
                            new Tren { Id = 3, Name = "Çukurova Express" },
                            new Tren { Id = 4, Name = "İst-Ank YHT" }
                 );
        }
    }
}
