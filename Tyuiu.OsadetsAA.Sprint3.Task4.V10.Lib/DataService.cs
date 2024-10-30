using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.OsadetsAA.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double sp = 1;
            for (x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                sp = sp * ((Math.Sin(x) - x) / x);
            }
            return Math.Round(sp, 3);
        }
    }
}
