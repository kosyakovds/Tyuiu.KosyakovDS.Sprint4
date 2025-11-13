using System.Data.Common;
using Tyuiu.KosyakovDS.Sprint4.Task3.V17.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            int[,] matrix = new int[5, 5] { { 6, 4, 2, 2, 1 },
                                            { 3, 6, 5, 4, 1 },
                                            { 5, 2, 3, 1, 6 },
                                            { 8, 8, 4, 5, 3 },
                                            { 7, 4, 5, 1, 6 } };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

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

            int res = ds.Calculate(matrix);
            Console.WriteLine(res);

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}