using Tyuiu.KosyakovDS.Sprint4.Task6.V14.Lib;

namespace Tyuiu.KosyakovDS.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            var week = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

            var res = ds.Calculate(week);
            var wait = new string[] { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
