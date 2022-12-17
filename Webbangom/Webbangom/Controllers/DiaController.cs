using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbangom.Models;
namespace Webbangom.Controllers
{
    public class DiaController : Controller
    {
        // GET: Dia
        public ActionResult Index()
        {
            CompanyDB Db = new CompanyDB();
            List<Dia> dias = Db.Dias.ToList();
            return View(dias);
        }
    }
}