using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
    public class City:BaseModel
    {
        public String Name { get; set; }
        public Province provinces { get; set; }

    }
}
