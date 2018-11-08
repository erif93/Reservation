using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
   public class Account:BaseModel
    {
        public String Email { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String address { get; set; }
        public DateTime BirthOfDate { get; set; }
        public double Handphone { get; set; }
    }
}
