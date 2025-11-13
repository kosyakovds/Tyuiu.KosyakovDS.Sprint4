using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KosyakovDS.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, 3];
            }
            return sum;
        }
    }
}
