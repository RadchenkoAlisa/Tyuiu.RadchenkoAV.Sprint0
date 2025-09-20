using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Tyuiu.RadchenkoAV.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestClass]
        public class DataServiceTest()
        {
            [TestMethod]
            public void CheckeValid()
            {
                Assert.AreEqual(10, DataService.Sum(static, s));
            }
        }
    }
}
