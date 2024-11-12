namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            int y = (x <= 0) || (x >= 10) ? 1 + x * 5 : 10 - 2 * x;
            Console.WriteLine(y);
        }
    }
}
