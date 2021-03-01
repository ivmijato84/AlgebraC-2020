using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class Trgovina
    {
        public int IdTrgovina { get; set; }
        public string NazivTrgovina { get; set; }
        public int VrstaRobe { get; set; }

        public virtual VrstaRobe VrstaRobeNavigation { get; set; }
    }
}
