using Tyuiu.OsadetsAA.Sprint3.Task1.V7.Lib;
namespace Tyuiu.OsadetsAA.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;
            double value = 0.25;

            var res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -0.93;
            Assert.AreEqual(wait, res);
        }
    }
}