using Tyuiu.MolodchikovEE.Sprint6.Task0.V14.Lib;

namespace Tyuiu.MolodchikovEE.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ����-24-1 ���������� ���� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBoxVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58 || e.KeyChar ==45) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBordVarA.Text)));

            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
