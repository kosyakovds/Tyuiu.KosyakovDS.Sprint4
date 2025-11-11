using Tyuiu.KosyakovDS.Sprint4.Task1.V2.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2};

            int wait = 34;
            int res = ds.Calculate(numsArray);

            Assert.AreEqual(wait, res);
        }
    }
}
