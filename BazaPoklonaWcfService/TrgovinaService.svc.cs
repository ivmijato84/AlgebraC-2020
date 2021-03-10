using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BazaPoklonaWcfService.Models;

namespace BazaPoklonaWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TrgovinaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TrgovinaService.svc or TrgovinaService.svc.cs at the Solution Explorer and start debugging.
    public class TrgovinaService : ITrgovinaService
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        public List<Trgovina> DohvatiTrgovine()
        {
            var trgovine = from t in _db.Trgovina select t;
            return trgovine.ToList();
        }
    }
}
