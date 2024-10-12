using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodchikovEE.Sprint6.Task1.V26.Lib
{
    public class DataService : ISprint6Task1V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i < stopValue; i++) 
            {
                y = Math.Round((2 * Math.Cos(i) + 2)/(2 * i - 1) + Math.Cos(i) - 5 * i + 3,2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
