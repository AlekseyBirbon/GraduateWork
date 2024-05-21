namespace GraduateWork_AutoFroms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.GenFile = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TextSize_MiddleHeader = new System.Windows.Forms.NumericUpDown();
            this.middleHeaderTextBox = new System.Windows.Forms.TextBox();
            this.checkBox_MiddleHeader_bold = new System.Windows.Forms.CheckBox();
            this.checkBox_MiddleHeader_italic = new System.Windows.Forms.CheckBox();
            this.checkBox_MiddleHeader_underline = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_ControlMaterial = new System.Windows.Forms.TextBox();
            this.TextSize_ControlMaterial = new System.Windows.Forms.NumericUpDown();
            this.checkBox_ControlMaterial_bold = new System.Windows.Forms.CheckBox();
            this.checkBox_ControlMaterial_italic = new System.Windows.Forms.CheckBox();
            this.checkBox_ControlMaterial_underline = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextSize_RightHeader = new System.Windows.Forms.NumericUpDown();
            this.rightHeaderTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_EI = new System.Windows.Forms.TextBox();
            this.TextSize_EI = new System.Windows.Forms.NumericUpDown();
            this.checkBox_EI_bold = new System.Windows.Forms.CheckBox();
            this.checkBox_EI_italic = new System.Windows.Forms.CheckBox();
            this.checkBox_EI_underline = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextSize_LeftHeader = new System.Windows.Forms.NumericUpDown();
            this.leftHeaderTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.manualTextSize = new System.Windows.Forms.NumericUpDown();
            this.manualTextBox = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.theorQuestionTextBox = new System.Windows.Forms.TextBox();
            this.practicQuestionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.countTheorQuestion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countPracticQuestion = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.countChoice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.theacherTextBox = new System.Windows.Forms.TextBox();
            this.GenFile.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_MiddleHeader)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_ControlMaterial)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_RightHeader)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_EI)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_LeftHeader)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualTextSize)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countTheorQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPracticQuestion)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFile
            // 
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // GenFile
            // 
            resources.ApplyResources(this.GenFile, "GenFile");
            this.GenFile.Controls.Add(this.tabPage1);
            this.GenFile.Controls.Add(this.tabPage2);
            this.GenFile.Controls.Add(this.tabPage5);
            this.GenFile.Name = "GenFile";
            this.GenFile.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Name = "tabPage1";
            // 
            // tabControl2
            // 
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TextSize_MiddleHeader);
            this.groupBox5.Controls.Add(this.middleHeaderTextBox);
            this.groupBox5.Controls.Add(this.checkBox_MiddleHeader_bold);
            this.groupBox5.Controls.Add(this.checkBox_MiddleHeader_italic);
            this.groupBox5.Controls.Add(this.checkBox_MiddleHeader_underline);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // TextSize_MiddleHeader
            // 
            resources.ApplyResources(this.TextSize_MiddleHeader, "TextSize_MiddleHeader");
            this.TextSize_MiddleHeader.Name = "TextSize_MiddleHeader";
            this.TextSize_MiddleHeader.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // middleHeaderTextBox
            // 
            resources.ApplyResources(this.middleHeaderTextBox, "middleHeaderTextBox");
            this.middleHeaderTextBox.Name = "middleHeaderTextBox";
            // 
            // checkBox_MiddleHeader_bold
            // 
            resources.ApplyResources(this.checkBox_MiddleHeader_bold, "checkBox_MiddleHeader_bold");
            this.checkBox_MiddleHeader_bold.Name = "checkBox_MiddleHeader_bold";
            this.checkBox_MiddleHeader_bold.UseVisualStyleBackColor = true;
            // 
            // checkBox_MiddleHeader_italic
            // 
            resources.ApplyResources(this.checkBox_MiddleHeader_italic, "checkBox_MiddleHeader_italic");
            this.checkBox_MiddleHeader_italic.Checked = true;
            this.checkBox_MiddleHeader_italic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MiddleHeader_italic.Name = "checkBox_MiddleHeader_italic";
            this.checkBox_MiddleHeader_italic.UseVisualStyleBackColor = true;
            // 
            // checkBox_MiddleHeader_underline
            // 
            resources.ApplyResources(this.checkBox_MiddleHeader_underline, "checkBox_MiddleHeader_underline");
            this.checkBox_MiddleHeader_underline.Checked = true;
            this.checkBox_MiddleHeader_underline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MiddleHeader_underline.Name = "checkBox_MiddleHeader_underline";
            this.checkBox_MiddleHeader_underline.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_ControlMaterial);
            this.groupBox4.Controls.Add(this.TextSize_ControlMaterial);
            this.groupBox4.Controls.Add(this.checkBox_ControlMaterial_bold);
            this.groupBox4.Controls.Add(this.checkBox_ControlMaterial_italic);
            this.groupBox4.Controls.Add(this.checkBox_ControlMaterial_underline);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // textBox_ControlMaterial
            // 
            resources.ApplyResources(this.textBox_ControlMaterial, "textBox_ControlMaterial");
            this.textBox_ControlMaterial.Name = "textBox_ControlMaterial";
            // 
            // TextSize_ControlMaterial
            // 
            resources.ApplyResources(this.TextSize_ControlMaterial, "TextSize_ControlMaterial");
            this.TextSize_ControlMaterial.Name = "TextSize_ControlMaterial";
            this.TextSize_ControlMaterial.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // checkBox_ControlMaterial_bold
            // 
            resources.ApplyResources(this.checkBox_ControlMaterial_bold, "checkBox_ControlMaterial_bold");
            this.checkBox_ControlMaterial_bold.Checked = true;
            this.checkBox_ControlMaterial_bold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ControlMaterial_bold.Name = "checkBox_ControlMaterial_bold";
            this.checkBox_ControlMaterial_bold.UseVisualStyleBackColor = true;
            // 
            // checkBox_ControlMaterial_italic
            // 
            resources.ApplyResources(this.checkBox_ControlMaterial_italic, "checkBox_ControlMaterial_italic");
            this.checkBox_ControlMaterial_italic.Checked = true;
            this.checkBox_ControlMaterial_italic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ControlMaterial_italic.Name = "checkBox_ControlMaterial_italic";
            this.checkBox_ControlMaterial_italic.UseVisualStyleBackColor = true;
            // 
            // checkBox_ControlMaterial_underline
            // 
            resources.ApplyResources(this.checkBox_ControlMaterial_underline, "checkBox_ControlMaterial_underline");
            this.checkBox_ControlMaterial_underline.Name = "checkBox_ControlMaterial_underline";
            this.checkBox_ControlMaterial_underline.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextSize_RightHeader);
            this.groupBox3.Controls.Add(this.rightHeaderTextBox);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // TextSize_RightHeader
            // 
            resources.ApplyResources(this.TextSize_RightHeader, "TextSize_RightHeader");
            this.TextSize_RightHeader.Name = "TextSize_RightHeader";
            this.TextSize_RightHeader.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rightHeaderTextBox
            // 
            resources.ApplyResources(this.rightHeaderTextBox, "rightHeaderTextBox");
            this.rightHeaderTextBox.Name = "rightHeaderTextBox";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_EI);
            this.groupBox1.Controls.Add(this.TextSize_EI);
            this.groupBox1.Controls.Add(this.checkBox_EI_bold);
            this.groupBox1.Controls.Add(this.checkBox_EI_italic);
            this.groupBox1.Controls.Add(this.checkBox_EI_underline);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBox_EI
            // 
            resources.ApplyResources(this.textBox_EI, "textBox_EI");
            this.textBox_EI.Name = "textBox_EI";
            // 
            // TextSize_EI
            // 
            resources.ApplyResources(this.TextSize_EI, "TextSize_EI");
            this.TextSize_EI.Name = "TextSize_EI";
            this.TextSize_EI.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // checkBox_EI_bold
            // 
            resources.ApplyResources(this.checkBox_EI_bold, "checkBox_EI_bold");
            this.checkBox_EI_bold.Checked = true;
            this.checkBox_EI_bold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_EI_bold.Name = "checkBox_EI_bold";
            this.checkBox_EI_bold.UseVisualStyleBackColor = true;
            // 
            // checkBox_EI_italic
            // 
            resources.ApplyResources(this.checkBox_EI_italic, "checkBox_EI_italic");
            this.checkBox_EI_italic.Name = "checkBox_EI_italic";
            this.checkBox_EI_italic.UseVisualStyleBackColor = true;
            // 
            // checkBox_EI_underline
            // 
            resources.ApplyResources(this.checkBox_EI_underline, "checkBox_EI_underline");
            this.checkBox_EI_underline.Name = "checkBox_EI_underline";
            this.checkBox_EI_underline.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextSize_LeftHeader);
            this.groupBox2.Controls.Add(this.leftHeaderTextBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // TextSize_LeftHeader
            // 
            resources.ApplyResources(this.TextSize_LeftHeader, "TextSize_LeftHeader");
            this.TextSize_LeftHeader.Name = "TextSize_LeftHeader";
            this.TextSize_LeftHeader.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // leftHeaderTextBox
            // 
            resources.ApplyResources(this.leftHeaderTextBox, "leftHeaderTextBox");
            this.leftHeaderTextBox.Name = "leftHeaderTextBox";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.manualTextSize);
            this.tabPage4.Controls.Add(this.manualTextBox);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // manualTextSize
            // 
            resources.ApplyResources(this.manualTextSize, "manualTextSize");
            this.manualTextSize.Name = "manualTextSize";
            this.manualTextSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // manualTextBox
            // 
            resources.ApplyResources(this.manualTextBox, "manualTextBox");
            this.manualTextBox.Name = "manualTextBox";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.theorQuestionTextBox);
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage7.Controls.Add(this.practicQuestionTextBox);
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage8.Controls.Add(this.groupBox7);
            this.tabPage8.Controls.Add(this.button1);
            this.tabPage8.Controls.Add(this.groupBox6);
            resources.ApplyResources(this.tabPage8, "tabPage8");
            this.tabPage8.Name = "tabPage8";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // tabPage5
            // 
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // theorQuestionTextBox
            // 
            resources.ApplyResources(this.theorQuestionTextBox, "theorQuestionTextBox");
            this.theorQuestionTextBox.Name = "theorQuestionTextBox";
            // 
            // practicQuestionTextBox
            // 
            resources.ApplyResources(this.practicQuestionTextBox, "practicQuestionTextBox");
            this.practicQuestionTextBox.Name = "practicQuestionTextBox";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.countPracticQuestion);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.countTheorQuestion);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countTheorQuestion
            // 
            resources.ApplyResources(this.countTheorQuestion, "countTheorQuestion");
            this.countTheorQuestion.Name = "countTheorQuestion";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // countPracticQuestion
            // 
            resources.ApplyResources(this.countPracticQuestion, "countPracticQuestion");
            this.countPracticQuestion.Name = "countPracticQuestion";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.theacherTextBox);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.countChoice);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // countChoice
            // 
            resources.ApplyResources(this.countChoice, "countChoice");
            this.countChoice.Name = "countChoice";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // theacherTextBox
            // 
            resources.ApplyResources(this.theacherTextBox, "theacherTextBox");
            this.theacherTextBox.Name = "theacherTextBox";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GenFile.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_MiddleHeader)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_ControlMaterial)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_RightHeader)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_EI)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize_LeftHeader)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualTextSize)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countTheorQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPracticQuestion)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TabControl GenFile;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox rightHeaderTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_EI;
        private System.Windows.Forms.NumericUpDown TextSize_EI;
        private System.Windows.Forms.CheckBox checkBox_EI_bold;
        private System.Windows.Forms.CheckBox checkBox_EI_italic;
        private System.Windows.Forms.CheckBox checkBox_EI_underline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox leftHeaderTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_ControlMaterial;
        private System.Windows.Forms.NumericUpDown TextSize_ControlMaterial;
        private System.Windows.Forms.CheckBox checkBox_ControlMaterial_bold;
        private System.Windows.Forms.CheckBox checkBox_ControlMaterial_italic;
        private System.Windows.Forms.CheckBox checkBox_ControlMaterial_underline;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox middleHeaderTextBox;
        private System.Windows.Forms.NumericUpDown TextSize_MiddleHeader;
        private System.Windows.Forms.CheckBox checkBox_MiddleHeader_bold;
        private System.Windows.Forms.CheckBox checkBox_MiddleHeader_italic;
        private System.Windows.Forms.CheckBox checkBox_MiddleHeader_underline;
        private System.Windows.Forms.NumericUpDown TextSize_RightHeader;
        private System.Windows.Forms.NumericUpDown TextSize_LeftHeader;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox manualTextBox;
        private System.Windows.Forms.NumericUpDown manualTextSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox theorQuestionTextBox;
        private System.Windows.Forms.TextBox practicQuestionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown countPracticQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown countTheorQuestion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown countChoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox theacherTextBox;
        private System.Windows.Forms.Label label6;
    }
}

