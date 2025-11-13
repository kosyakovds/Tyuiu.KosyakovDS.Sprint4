using Tyuiu.KosyakovDS.Sprint4.Task6.V14.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            var week = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < week.Length; i++)
            {
                Console.Write(week[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            var res = ds.Calculate;

            for (int i = 0; i < week.Length; i++)
            {
                Console.Write(week[i] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}