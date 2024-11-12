using Tyuiu.SungurovSV.Sprint2.Task2.V27.Lib;
namespace Tyuiu.SungurovSV.Sprint2.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 8;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}