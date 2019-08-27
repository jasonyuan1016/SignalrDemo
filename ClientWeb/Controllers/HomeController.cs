using Comm;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientWeb.Controllers
{
    public class HomeController : Controller
    {
        IncomeDal incomeDal = new IncomeDal();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QryList()
        {
            var incomes = incomeDal.QryList<Income>();
            return Content(incomes.ToJson());
        }

        public ActionResult Insert()
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras["amount"] = 500;
            incomeDal.Insert(paras);
            return Content("1");
        }
    }
}