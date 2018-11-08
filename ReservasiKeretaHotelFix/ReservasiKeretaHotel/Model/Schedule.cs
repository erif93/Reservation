using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
    public class Schedule:BaseModel
    {
        public Train trains { get; set; }
        public Station stations { get; set; }
        public Station destinations { get; set; }
        public string information { get; set; }
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }
    }
}
