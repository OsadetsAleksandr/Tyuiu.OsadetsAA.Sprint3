using Tyuiu.OsadetsAA.Sprint3.Task0.V17.Lib;
namespace Tyuiu.OsadetsAA.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            var res = ds.GetSumSeries(startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}