using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Net.Http;

using System.Collections.Generic;

namespace APIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetNews()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://localhost:4200/api/news").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            Assert.IsNotNull(json);
        }
    }
}
