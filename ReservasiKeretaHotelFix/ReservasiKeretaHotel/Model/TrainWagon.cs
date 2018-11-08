using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
   public class TrainWagon:BaseModel
    {
        public Train trains { get; set; }
        public Wagon wagons { get; set; }
    }
}
