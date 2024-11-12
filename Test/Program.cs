namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            x = Convert.ToInt32(Console.ReadLine());

            y = Convert.ToInt32(Console.ReadLine());

            int z = 0;

            if (x > y) z = y;

            else z = x;

            Console.WriteLine(z);
        }
    }
}
