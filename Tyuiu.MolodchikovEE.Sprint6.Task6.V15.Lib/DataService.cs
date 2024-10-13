using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodchikovEE.Sprint6.Task6.V15.Lib
{
    public class DataService : ISprint6Task6V15
    {
        public string CollectTextFromFile(string str, string path)
        {            
            string fullPath = Path.Combine(path, str);
            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"Файл не найден: {fullPath}");
            }
            string[] lines = File.ReadAllLines(fullPath);
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
