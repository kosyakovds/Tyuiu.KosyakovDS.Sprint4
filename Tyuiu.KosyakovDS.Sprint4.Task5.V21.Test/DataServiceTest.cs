using Tyuiu.KosyakovDS.Sprint4.Task5.V21.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 2, 2, 2, 1, 1 },
                                            { 2, 2, 2, 1, 1 },
                                            { 2, 2, 2, 2, 1 },
                                            { 2, 1, 2, 2, 1 },
                                            { 2, 1, 2, 2, 1 } };
            ds.Calculate(matrix);
            int[,] wait = new int[5, 5] { { 1, 1, 1, 1, 1 },
                                          { 1, 1, 1, 1, 1 },
                                          { 1, 1, 1, 1, 1 },
                                          { 1, 1, 1, 1, 1 },
                                          { 1, 1, 1, 1, 1 } };

            CollectionAssert.AreEqual(matrix, wait);

        }
    }
}
