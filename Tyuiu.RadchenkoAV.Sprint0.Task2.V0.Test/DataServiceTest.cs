using Microsoft.VisualStudio.TestTools/ UnitTesting;
using Tyuiu.RadchenkoAV.Sprint0.Task2.V0.Lib

namespace Tyuiu.RadchenkoAV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алиса";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Алиса", res);
        }
    }
}
