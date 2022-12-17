using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbangom.Models;

namespace Webbangom.Controllers
{
    public class AmtraController : Controller
    {
        // GET: Amtra
        public ActionResult Index()
        {
            CompanyDB Db = new CompanyDB();
            List<Amtra> amtras = Db.Amtras.ToList();
            return View(amtras);
        }
    }
}