using System;
using System.Collections.Generic;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IncomeDal incomeDal = new IncomeDal();

        [TestMethod]
        public void Insert()
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras["amount"] = 500;
            bool b = incomeDal.Insert(paras);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void Update()
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras["id"] = "5E30425C-FAD9-46DD-BCD2-903F03D6F6B8";
            paras["state"] = 1;
            paras["modifier"] = "user1";
            paras["utime"] = DateTime.Now;
            bool b = incomeDal.Update(paras);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void QryList()
        {
            var incomes = incomeDal.QryList<Income>();

        }
    }
}
