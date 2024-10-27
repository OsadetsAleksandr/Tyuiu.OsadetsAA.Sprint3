using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.OsadetsAA.Sprint3.Task0.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double s = 1.0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                s *= (Math.Cos(i * (1 / 2)));
            }
            return Math.Round(s, 3);
        }
    }
}
