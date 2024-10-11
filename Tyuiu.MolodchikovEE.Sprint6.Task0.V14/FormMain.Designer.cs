
namespace Tyuiu.MolodchikovEE.Sprint6.Task0.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            textBoxCondition = new TextBox();
            groupBoxInput = new GroupBox();
            textBoxX = new TextBox();
            textBordVarA = new TextBox();
            groupBoxPrint = new GroupBox();
            textBoxResultText = new TextBox();
            textBoxResult = new TextBox();
            pictureBox = new PictureBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxCondition);
            groupBoxTask.Font = new Font("Segoe UI", 14F);
            groupBoxTask.Location = new Point(24, 22);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(522, 181);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBox1_Enter;
            // 
            // textBoxCondition
            // 
            textBoxCondition.Font = new Font("Segoe UI", 12F);
            textBoxCondition.Location = new Point(16, 27);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(489, 143);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = "Вычислить выражения по формуле.";
            textBoxCondition.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxX);
            groupBoxInput.Controls.Add(textBordVarA);
            groupBoxInput.Font = new Font("Segoe UI", 14F);
            groupBoxInput.Location = new Point(24, 221);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(522, 141);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxX
            // 
            textBoxX.BackColor = SystemColors.Window;
            textBoxX.Font = new Font("Segoe UI", 12F);
            textBoxX.Location = new Point(16, 50);
            textBoxX.Name = "textBoxX";
            textBoxX.ReadOnly = true;
            textBoxX.Size = new Size(184, 29);
            textBoxX.TabIndex = 1;
            textBoxX.Text = "Переменная Х:";
            // 
            // textBordVarA
            // 
            textBordVarA.Location = new Point(16, 85);
            textBordVarA.Name = "textBordVarA";
            textBordVarA.Size = new Size(184, 32);
            textBordVarA.TabIndex = 0;
            textBordVarA.KeyPress += textBordVarA_KeyPress;
            // 
            // groupBoxPrint
            // 
            groupBoxPrint.BackColor = Color.Transparent;
            groupBoxPrint.Controls.Add(textBoxResultText);
            groupBoxPrint.Controls.Add(textBoxResult);
            groupBoxPrint.Font = new Font("Segoe UI", 14F);
            groupBoxPrint.Location = new Point(552, 221);
            groupBoxPrint.Name = "groupBoxPrint";
            groupBoxPrint.Size = new Size(200, 141);
            groupBoxPrint.TabIndex = 3;
            groupBoxPrint.TabStop = false;
            groupBoxPrint.Text = "Вывод данных";
            // 
            // textBoxResultText
            // 
            textBoxResultText.BackColor = SystemColors.Window;
            textBoxResultText.Font = new Font("Segoe UI", 12F);
            textBoxResultText.Location = new Point(16, 50);
            textBoxResultText.Name = "textBoxResultText";
            textBoxResultText.ReadOnly = true;
            textBoxResultText.Size = new Size(168, 29);
            textBoxResultText.TabIndex = 7;
            textBoxResultText.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(16, 85);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(168, 32);
            textBoxResult.TabIndex = 6;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.formula014;
            pictureBox.Location = new Point(552, 70);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 96);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // buttonDone
            // 
            buttonDone.Font = new Font("Segoe UI", 12F);
            buttonDone.Location = new Point(622, 368);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(114, 41);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 14F);
            buttonHelp.Location = new Point(568, 368);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(48, 41);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.TextChanged += buttonHelp_Click;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 421);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(pictureBox);
            Controls.Add(groupBoxPrint);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант14 | Молодчиков Е.Е.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxPrint.ResumeLayout(false);
            groupBoxPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBordVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxPrint;
        private TextBox textBoxCondition;
        private PictureBox pictureBox;
        private Button buttonDone;
        private Button buttonHelp;
        private TextBox textBoxX;
        private TextBox textBoxResultText;
        private TextBox textBoxResult;
        private TextBox textBordVarA;
    }
}
