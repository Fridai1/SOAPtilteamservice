using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOAPtilteamservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPtilteamservice.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            Service1 s = new Service1();
            Assert.AreEqual("Nikolai",s.GetName());
        }
    }
}