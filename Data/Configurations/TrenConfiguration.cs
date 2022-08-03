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
    public class TrenConfiguration : IEntityTypeConfiguration<Tren>
    {
        //Bu class ın amacı veritabanı tarafındaki konfigürasyonları burda yapıp daha sonra bu ayarları AppDbContext içerisinde yer alan override etmiş olduğum OnModelCreating methoduiçerisinde kullanacağım
        public void Configure(EntityTypeBuilder<Tren> builder)
        {
            builder.HasKey(x => x.Id);// Primary key olacak olan property i bu şekilde belirtebilirim
            builder.Property(x => x.Name).HasMaxLength(100);//Kapasitesini ve nullable durumunu belirttim.
            builder.Property(x => x.Id).UseIdentityColumn();//Birer birer artsın

            builder.ToTable("Trenler");// Bu şekilde tabloya veri tabanında farklı bir isim verebiliriz eğer vermezsek default olarak Dbcontext te geçen isim yazılır
        }
    }
}
