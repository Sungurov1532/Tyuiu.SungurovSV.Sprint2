using Tyuiu.SungurovSV.Sprint2.Task4.V23.Lib;
namespace Tyuiu.SungurovSV.Sprint2.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Сунгуров В.А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Сунгуров Владислав Александровчи  | СМАРТб-24-1               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* с использованием тенарного оператора где пользователь вводит значения   *");
            Console.WriteLine("* переменных с клавиатуры.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x, y);
            Console.WriteLine(Math.Round(res, 3));
            Console.ReadKey();
        }
    }
}
