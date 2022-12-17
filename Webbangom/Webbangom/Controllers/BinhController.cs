using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbangom.Models;
namespace Webbangom.Controllers
{
    public class BinhController : Controller
    {
        // GET: Binh
        public ActionResult Index()
        {
            CompanyDB Db = new CompanyDB();
            List<Binh> binhs = Db.Binhs.ToList();
            return View(binhs);
        }
    }
}