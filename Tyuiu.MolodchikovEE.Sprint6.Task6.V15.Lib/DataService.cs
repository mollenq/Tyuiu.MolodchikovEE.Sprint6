using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodchikovEE.Sprint6.Task6.V15.Lib
{
    public class DataService : ISprint6Task6V15
    {
        public string CollectTextFromFile(string path)
        {
            Console.WriteLine(path);
            string[] lines = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();
            foreach (string line in lines)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (words.Length > 0)
                {
                    result.Append(words[^1] + " ");
                }
            }

            return result.ToString().Trim();
        }
    }
    
}
