using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
    public class Train:BaseModel
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public ICollection<Wagon> wagons { get; set; }
        
    } 
}
