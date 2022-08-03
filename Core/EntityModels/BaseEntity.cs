using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class BaseEntity
    {
        public int Id { get; set; }//EF Core'un primary key olduğunu otomatik algılaması için bu şekilde isimlendirme yaptım
        public string Name { get; set; }
    }
}
