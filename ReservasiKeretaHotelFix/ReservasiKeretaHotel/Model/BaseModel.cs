using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasiKeretaHotel.Model
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset Createdate { get; set; }
        public DateTimeOffset Updatedate { get; set; }
        public DateTimeOffset Deletedate { get; set; }
        public bool Isdelete { get; set; }
    }
}
