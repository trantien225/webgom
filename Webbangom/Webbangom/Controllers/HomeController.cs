using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbangom.Models;

namespace Webbangom.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CompanyDB Db = new CompanyDB();
            List<Main> mains = Db.Mains.ToList();
            return View(mains);
        }
    }
}