using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodchikovEE.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[] numsArray = lines.Select(line => Convert.ToDouble(line)).ToArray();
            numsArray = numsArray.Where(val => val != 0).ToArray();
            return numsArray;
        }
    }
}
