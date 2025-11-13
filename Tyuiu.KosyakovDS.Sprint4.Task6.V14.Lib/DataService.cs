using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KosyakovDS.Sprint4.Task6.V14.Lib
{
    public class DataService : ISprint4Task6V14
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, week => week.Length > 3);
            return res;
        }
    }
}
