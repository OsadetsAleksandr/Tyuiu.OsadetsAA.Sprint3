using Tyuiu.OsadetsAA.Sprint3.Task3.V1.Lib;
namespace Tyuiu.OsadetsAA.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "have a nice time";
            char chr = 'a';
            int wait = 2;
            int res = ds.GetCharCount(str, chr);
            Assert.AreEqual(wait, res);
        }
    }
}