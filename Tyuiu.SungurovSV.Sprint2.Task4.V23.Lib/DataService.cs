using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SungurovSV.Sprint2.Task4.V23.Lib
{
    public class DataService : ISprint2Task4V23
    {
        public double Calculate(double x, double y)
        {
            return x / 2 < Math.Sqrt(y) / 3 ? Math.Pow(1 + (1 / Math.Pow(y, 2)), x) : y + 12 * x - (1 / x);
        }
    }
}
