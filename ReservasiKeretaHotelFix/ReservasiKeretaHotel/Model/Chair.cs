using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
   public class Chair:BaseModel
    {
       
        public TrainWagon trainwagons { get; set; }
        public bool status { get; set; }
    }
}
