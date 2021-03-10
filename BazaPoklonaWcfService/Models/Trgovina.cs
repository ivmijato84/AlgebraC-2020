using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BazaPoklonaWcfService.Models
{
    [DataContract]
    public class Trgovina
    {
        [DataMember] [Key]
        public int IdTrgovina { get; set; }

        [DataMember]
        public string NazivTrgovina { get; set; }

        [DataMember]
        public int VrstaRobe { get; set; }
    }
}