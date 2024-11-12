using Tyuiu.SungurovSV.Sprint2.Task4.V23.Lib;
namespace Tyuiu.SungurovSV.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 1);

            Assert.AreEqual(12, res, 0.001);
        }
    }
}