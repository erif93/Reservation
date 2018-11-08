using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
   public class TrainRate:BaseModel
    {

       public OriginStation origins { get; set; }
       public DestinationStation destinations { get; set; }      
       public int Price { get; set; }  

    }
}
