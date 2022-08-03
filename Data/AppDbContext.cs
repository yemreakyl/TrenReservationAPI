using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Tren> Trens{ get; set; }
        public DbSet<Wagon> Wagons{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity modellerim ile alakalı konfigürasyon işlemlerini kalabalık oluşturmamak adına farklı bir dosya içerisinde gerçekleştirdim ve daha sonra burda Configurations dosyası içerisinde oluşturmuş olduğum class lar IEntityTypeConfiguration interfacesini implement ettiği için sistem onları otomatik tanıyıp uygulayabiliyor.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
    
}
