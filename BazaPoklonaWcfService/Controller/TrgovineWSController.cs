using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BazaPoklonaWcfService.TrgovinaService1;

namespace BazaPoklonaWcfService.Controllers
{
    public class TrgovineWSController : Controller
    {
        // GET: TrgovineWS
        public ActionResult Index()
        {
            TrgovinaServiceClient klijent = new TrgovinaServiceClient();
            List<Trgovina> trgovine = klijent.DohvatiTrgovine().ToList();
            return View(trgovine);
        }
    }
}