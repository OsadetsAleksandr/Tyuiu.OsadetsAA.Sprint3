using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.OsadetsAA.Sprint3.Task1.V7.Lib
{
    public class DataService : ISprint3Task0V7
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double p = 1.0;
            while (startValue <= stopValue)
            {
                p *= (Math.Pow(value, startValue) + 1) * Math.Sin(5);
                startValue++;
            }
            return Math.Round(p, 3);
        }
    }
}
