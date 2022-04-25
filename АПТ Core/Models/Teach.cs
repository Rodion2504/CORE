using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace АПТ_Core.Models
{
    public class Teach
    {
        public int Id { get; set; }
        public string Fam { get; set; }
        public string Im { get; set; }
        public string Gr { get; set; }
        public int Rost { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        public decimal ZarPlata { get; set; }
    }
}
