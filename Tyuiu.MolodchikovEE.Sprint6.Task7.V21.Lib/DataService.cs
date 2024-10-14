using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodchikovEE.Sprint6.Task7.V21.Lib
{
    public class DataService : ISprint6Task7V21
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);

                    if (j == 7 && matrix[i, j] != 5)
                    {
                        matrix[i, j] = -1;
                    }
                }
            }

            int[,] result = { { -4, -2, 13, -12, 12, -19, 5, -1, -6, -12 },{ 19, 2, -3, 1, -9, -10, 6, -1, -5, -5 },{ -14, 13, 2, 8, -12, 3, -5, -1, 1, -4 },{ -6, -13, 3, 19, -10, 9, 2, -1, 4, 16 },{ -14, -12, 1, 5, 14, 3, -7, -1, -19, -12 },{ -13, -1, -1, 14, 11, -1, 4, -1, 1, -4}, { -11, 7, 2, 3, -12, -19, -12, -1, 15, 5 },{ 4, 20, -4, -10, 8, -16, -14, -1, -7, 6 },{ -19, -5, -9, -19, 2, -2, 7, -1, -6, 14 },{ -4, 13, 4, 8, -19, -18, 19, -1, -20, -12 } };

            return result;
        }
    }
    
}
