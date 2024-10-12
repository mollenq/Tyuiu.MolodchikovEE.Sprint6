using System.Windows.Forms.VisualStyles;
using Tyuiu.MolodchikovEE.Sprint6.Task1.V26.Lib;

namespace Tyuiu.MolodchikovEE.Sprint6.Task1.V26
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

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);
                textBoxResult.AppendText("|     X    |  f(X)  |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |{1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);

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
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-1 Молодчиков Егор Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
