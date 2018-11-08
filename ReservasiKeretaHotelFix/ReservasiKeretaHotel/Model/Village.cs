using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
    public class Village:BaseModel
    {
        public String Name { get; set; }
        public Regency regencies { get; set; }
    }
}
