using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Wagon:BaseEntity
    { 
        public int Capasity { get; set; }
        public int fullseat { get; set; }  //Dolu koltuk adeti
        public int TrenId { get; set; }//EF Core'un foreign key olduğunu otomatik algılaması için bu şekilde isimlendiriyorum
    }
}
