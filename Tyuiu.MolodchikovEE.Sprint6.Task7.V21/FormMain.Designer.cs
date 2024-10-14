namespace Tyuiu.MolodchikovEE.Sprint6.Task7.V21
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBoxOutPutData = new GroupBox();
            textBoxInput = new TextBox();
            groupBox3 = new GroupBox();
            textBoxPrint = new TextBox();
            buttonOpenFile = new Button();
            buttonRun = new Button();
            buttonHelp = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1053, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxInput);
            groupBoxOutPutData.Location = new Point(12, 132);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(452, 377);
            groupBoxOutPutData.TabIndex = 1;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(6, 22);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(440, 349);
            textBoxInput.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxPrint);
            groupBox3.Location = new Point(470, 132);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(595, 377);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // textBoxPrint
            // 
            textBoxPrint.Location = new Point(6, 22);
            textBoxPrint.Multiline = true;
            textBoxPrint.Name = "textBoxPrint";
            textBoxPrint.ScrollBars = ScrollBars.Vertical;
            textBoxPrint.Size = new Size(583, 349);
            textBoxPrint.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = Properties.Resources.download_folder_file_icon_219533;
            buttonOpenFile.Location = new Point(12, 2);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(105, 58);
            buttonOpenFile.TabIndex = 3;
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonRun
            // 
            buttonRun.Enabled = false;
            buttonRun.Image = Properties.Resources.clipboard_paper_file_correct_done_list_document_icon_219518;
            buttonRun.Location = new Point(123, 2);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(111, 58);
            buttonRun.TabIndex = 4;
            toolTip.SetToolTip(buttonRun, "Запустить программу");
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.curriculum_vitae_paper_document_icon_219537;
            buttonHelp.Location = new Point(954, 2);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(111, 58);
            buttonHelp.TabIndex = 5;
            toolTip.SetToolTip(buttonHelp, "Информация о создателе приложения");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(964, 57);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 521);
            Controls.Add(buttonHelp);
            Controls.Add(buttonRun);
            Controls.Add(buttonOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 15 | Молодчиков Е.Е.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBoxOutPutData;
        private GroupBox groupBox3;
        private Button buttonOpenFile;
        private Button buttonRun;
        private Button buttonHelp;
        private Label label1;
        private TextBox textBoxInput;
        private TextBox textBoxPrint;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private Label label2;
    }
}
