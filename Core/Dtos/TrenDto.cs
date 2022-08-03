using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class TrenDto
    {
        //Kullanıcı tarafına göstermek istediğim properylerim için tren entity modele karşılık gelen bir tren dto hazırlıyorum
        public string TrenName { get; set; }
        public int NumberOfPeopleToBook { get; set; }
        public bool DifferentWagonsAvaliable { get; set; }
    }
}
