using Tyuiu.SungurovSV.Sprint2.Task3.V7.Lib;
namespace Tyuiu.SungurovSV.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-12);
            Assert.AreEqual(20736.25, res, 0.001);
        }
    }
}