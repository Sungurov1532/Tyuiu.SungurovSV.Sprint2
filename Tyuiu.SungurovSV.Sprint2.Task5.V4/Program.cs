using Tyuiu.SungurovSV.Sprint2.Task5.V4.Lib;
namespace Tyuiu.SungurovSV.Sprint2.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Сунгуров В.А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Сунгуров Владислав Александрович  | СМАРТб-24-1               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера     *");
            Console.WriteLine("* масти (пики) - 1, масти (трефы) - 2, масти (бубны) - 3, масти (черви) - *");
            Console.WriteLine("* 4. По заданному номеру масти m(1 <= m <= 4) определить название соотве- *");
            Console.WriteLine("* тствующей масти.                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите цифру:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.FindCardSuit(x);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
