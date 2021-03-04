using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BazaPoklona.Models
{
    
    public class OstvareniPrometViewModel
    {
        public string NazivRobe { get; set; }
        public string VrstaRobe { get; set; }
        public double UkupnoLovePoVrstiRobe { get; set; }
    }
}
