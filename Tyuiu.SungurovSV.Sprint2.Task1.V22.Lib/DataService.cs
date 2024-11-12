using System.Collections.Specialized;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SungurovSV.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
         public bool[] GetLogicOperations(int a, int b, int c, int d)
         {
             bool[] res = new bool[6];

             res[0] = (a == b) | (a < b);
             res[1] = (a != b) & (a != c);
             res[2] = (a < b) || (a > b);
             res[3] = (a > b) && (d > b);
             res[4] = !(!(a <= d));
             res[5] = (a >= b) ^ (c <= d);

             return res;
         }
    }
}
