using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class WagonConfiguration : IEntityTypeConfiguration<Wagon>
    {
        //Bu class ın amacı veritabanı tarafındaki konfigürasyonları burda yapıp daha sonra bu ayarları AppDbContext içerisinde yer alan override etmiş olduğum OnModelCreating methoduiçerisinde kullanacağım
        public void Configure(EntityTypeBuilder<Wagon> builder)
        {
            //Entity modellerimizi girerken zaten nullable olarak ayarlamadık ancak nullable olup olmama durumunu burda da ayarlayabiliriz
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Capasity).IsRequired();
            
        }
    }
}
