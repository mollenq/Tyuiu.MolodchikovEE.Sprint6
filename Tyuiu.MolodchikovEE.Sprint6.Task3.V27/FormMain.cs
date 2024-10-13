using Tyuiu.MolodchikovEE.Sprint6.Task3.V27.Lib;

namespace Tyuiu.MolodchikovEE.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { 9, 13, -14, 23, 1 }, { 15, -17, 21, 25, 23 }, { -4, 29, -20, -10, 14 }, { 27, 33, 12, 33, -12 }, { 18, -9, -5, 6, 3 } };


        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0)+1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++) 
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }
        private void DisplayMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {

            mtrx = ds.Calculate(mtrx);
            DisplayMatrix(mtrx);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-24-1 Молодчиков Егор Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
