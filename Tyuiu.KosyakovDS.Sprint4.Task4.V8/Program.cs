using System.Data.Common;
using Tyuiu.KosyakovDS.Sprint4.Task4.V8.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Введите количество строк массива:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива:");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i }, {j} элемент массива: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            ds.Calculate(matrix);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}