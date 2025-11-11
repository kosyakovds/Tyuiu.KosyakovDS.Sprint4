using Tyuiu.KosyakovDS.Sprint4.Task0.V29.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            int wait = 6;
            int res = ds.GetSumOddArrEl(numsArray);

            Assert.AreEqual(wait, res);
        }
    }
}
