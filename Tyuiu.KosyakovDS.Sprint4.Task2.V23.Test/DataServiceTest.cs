using Tyuiu.KosyakovDS.Sprint4.Task2.V23.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            int[] numsArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            int res = ds.Calculate(numsArray);
            int wait = 56;

            Assert.AreEqual(wait, res);
        }
    }
}
