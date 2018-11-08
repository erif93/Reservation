using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
   public class Wagon:BaseModel
    {
        public String Name { get; set; }
        public TrainClass trainclas { get; set; }
        public ICollection<Train> trains { get; set; }
        
    }
}
