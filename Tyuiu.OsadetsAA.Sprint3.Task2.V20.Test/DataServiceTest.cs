using Tyuiu.OsadetsAA.Sprint3.Task2.V20.Lib;
namespace Tyuiu.OsadetsAA.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 6;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 914700.94;
            Assert.AreEqual(wait, res);
        }
    }
}