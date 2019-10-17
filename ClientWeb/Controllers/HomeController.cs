using Comm;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            string uid = GetRandomString(6);
            Session["uid"] = uid;
            ViewData["uid"] = uid;
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
            paras["creater"] = Session["uid"];
            incomeDal.Insert(paras);
            return Content("1");
        }

        public ActionResult CatchBill(string _id)
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras["id"] = _id;
            paras["state"] = 1;
            paras["modifier"] = Session["uid"];
            paras["utime"] = DateTime.Now;
            bool b = incomeDal.Update(paras);
            return Content("1");
        }

        private static string GetRandomString(int length)
        {
            const string key = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            if (length < 1)
                return string.Empty;

            Random rnd = new Random();
            byte[] buffer = new byte[8];

            ulong bit = 31;
            ulong result = 0;
            int index = 0;
            StringBuilder sb = new StringBuilder((length / 5 + 1) * 5);

            while (sb.Length < length)
            {
                rnd.NextBytes(buffer);

                buffer[5] = buffer[6] = buffer[7] = 0x00;
                result = BitConverter.ToUInt64(buffer, 0);

                while (result > 0 && sb.Length < length)
                {
                    index = (int)(bit & result);
                    sb.Append(key[index]);
                    result = result >> 5;
                }
            }
            return sb.ToString();
        }
    }
}