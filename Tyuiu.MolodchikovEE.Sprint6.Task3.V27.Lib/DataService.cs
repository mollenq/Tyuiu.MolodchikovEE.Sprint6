using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodchikovEE.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0); 
            int columns = matrix.GetLength(1); 

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (matrix[i, 3] > matrix[j, 3]) 
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[j, k];
                            matrix[j, k] = temp;
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
