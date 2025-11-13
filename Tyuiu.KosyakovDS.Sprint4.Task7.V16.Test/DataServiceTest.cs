using Tyuiu.KosyakovDS.Sprint4.Task7.V16.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            string str = "382976421897948";
            int rows = 5;
            int columns = 3;
            int res = ds.Calculate(rows, columns, str);
            int wait = 196608;

            Assert.AreEqual(wait, res);
        }
    }
}
