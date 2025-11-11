using Tyuiu.KosyakovDS.Sprint4.Task2.V23.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Введите количество элементов массива:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                numsArray[i] = rnd.Next(3, 9);
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            int res = ds.Calculate(numsArray);
            Console.WriteLine(res);

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}