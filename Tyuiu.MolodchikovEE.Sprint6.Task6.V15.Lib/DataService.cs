using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodchikovEE.Sprint6.Task6.V15.Lib
{
    public class DataService : ISprint6Task6V15
    {
        public string CollectTextFromFile(string str, string path)
        {            
            string[] lines = File.ReadAllLines(path);
            string result = "";
            foreach (string line in lines)
            {
                string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length > 0)
                {
                    result += words[words.Length - 1] + " ";
                }
            }

            return result.Trim();
        }
    }
}
