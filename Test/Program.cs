namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0, k = 4;

            if (k > 5)

                if (k > 10) y = 1;

                else y = 2;

            else if (k > 0) y = 3;

            else y = 4;

            Console.WriteLine(y);
        }
    }
}
