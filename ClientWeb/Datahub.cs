using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DAL;
using Microsoft.AspNet.SignalR;

namespace ClientWeb
{
    public class Datahub : Hub
    {
        IncomeDal incomeDal = new IncomeDal();

        public void Send(string x)
        {
            //if (x.Equals("n"))
            //{
            //    Dictionary<string, object> paras = new Dictionary<string, object>();
            //    paras["amount"] = 500;
            //    incomeDal.Insert(paras);
            //}
            //else if(x.StartsWith("c:"))
            //{
            //    x = x.Substring(2);
            //    Dictionary<string, object> paras = new Dictionary<string, object>();
            //    paras["id"] = x;
            //    paras["state"] = 1;
            //    paras["modifier"] = "user1";
            //    paras["utime"] = DateTime.Now;
            //    bool b = incomeDal.Update(paras);
            //}
            // 调用所有客户端的sendMessage方法
            Clients.All.sendMessage(x);
        }
    }
}