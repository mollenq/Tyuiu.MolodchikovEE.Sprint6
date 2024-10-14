using System.Windows.Forms.VisualStyles;
using Tyuiu.MolodchikovEE.Sprint6.Task6.V15.Lib;

namespace Tyuiu.MolodchikovEE.Sprint6.Task6.V15
{
    public partial class FormMain : Form
    {

        DataService ds = new DataService();
        private string openFilePath = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {  
            textBoxPrint.Text = ds.CollectTextFromFile(openFilePath);
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            this.openFilePath = openFileDialogTask.FileName;
            MessageBox.Show(openFilePath);
            textBoxInput.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
            buttonRun.Enabled = true;
        }
    }
}
