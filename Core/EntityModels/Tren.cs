using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tren :BaseEntity
    {      
        public ICollection<Wagon> Wagons { get; set; }
    }
}
