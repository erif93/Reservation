using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
    public class Regency:BaseModel
    {
        public string Name { get; set; }
        public City cities{ get; set; }
    }
}
