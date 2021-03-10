using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BazaPoklonaWcfService.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(): base("BazaPoklona")
        {

        }
        public DbSet<Trgovina> Trgovina { get; set; }
    }
}