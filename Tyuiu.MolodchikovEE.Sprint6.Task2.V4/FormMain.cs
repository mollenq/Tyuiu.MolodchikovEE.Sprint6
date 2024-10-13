using System.Windows.Forms.VisualStyles;
using Tyuiu.MolodchikovEE.Sprint6.Task2.V4.Lib;

namespace Tyuiu.MolodchikovEE.Sprint6.Task2.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonRunClick(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                //this.chartFunction.Titles.Add("График функции sin(x)");

                //this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                //this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    //this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены невенрные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-1 Молодчиков Егор Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
