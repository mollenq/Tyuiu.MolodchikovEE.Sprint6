using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodchikovEE.Sprint6.Task4.V12.Lib
{
    public class DataService : ISprint6Task4V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(Math.Sin(i) + (2)/(3 * i + 0.5) - 2 * Math.Cos(i) * (2 *i), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
