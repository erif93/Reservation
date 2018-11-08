using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
   public class Admin:BaseModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
