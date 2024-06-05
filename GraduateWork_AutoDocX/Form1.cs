using Xceed.Words.NET;
using Xceed.Document.NET;
using Font = Xceed.Document.NET.Font;
using BorderStyle = Xceed.Document.NET.BorderStyle;
using YandexGPTWrapper;
using System.Text;
using System.IO;
using System;

namespace GraduateWork_AutoDocX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckedAndAddingItem();
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }
        public static object RemoveEmptyPracticList(List<string> arrayPractic)
        {
            for (int j = 0; j < arrayPractic.Count; j++)
            {
                if (arrayPractic[j].Length <= 5) { arrayPractic.RemoveAt(j); }
            }
            return arrayPractic;
        }
        public static object RemoveEmptyTheorList(List<string> arrayTheor)
        {

            for (int j = 0; j < arrayTheor.Count; j++)
            {
                if (arrayTheor[j].Length <= 5) { arrayTheor.RemoveAt(j); }
            }
            return arrayTheor;
        }
        public object AddTeacherText()
        {
            int lenghtTeacherName = 17;
            int lenghtLine = 40;
            lenghtLine += lenghtTeacherName - teacherTextBox.Text.Length;
            string teacher = "Преподаватель" + string.Concat(Enumerable.Repeat("_", lenghtLine)) + teacherTextBox.Text;
            // "Войцеховская Е.В." = 17 + 42
            return teacher;
        }
        public void CheckedAndAddingItem()
        {
            historyFile.Items.Clear();
            string mypath = Environment.CurrentDirectory + "\\" + "HistoryFiles" + "\\";
            Directory
                .GetFiles(mypath, "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => historyFile.Items.Add(Path.GetFileName(f.Replace(".txt", ""))));
        }
        public void CreateSampleDocument()
        {
            try
            {
                List<string> theorQuestionArray = new(theorQuestionTextBox.Text.Split('\n'));
                List<string> practicQuestionArray = new(practicQuestionTextBox.Text.Split('\n'));
                RemoveEmptyPracticList(practicQuestionArray);
                RemoveEmptyTheorList(theorQuestionArray);
                // title formating
                var titleFormat = new Formatting
                {
                    FontFamily = new Font("Times New Roman"),
                    Size = (double)manualTextSize.Value,
                    Bold = true
                };

                // manual formatting
                var manualFormat = new Formatting
                {
                    FontFamily = new Font("Times New Roman"),
                    Size = (double)manualTextSize.Value,
                    Bold = false
                };



                Random rnd = new();

                string fileName = @"C:\Files\wow.docx";

                var doc = DocX.Create(fileName);

                doc.MarginTop = 56;
                doc.MarginBottom = 56;
                doc.MarginLeft = 56;
                doc.MarginRight = 43;

                for (int j = 0; j < (int)countChoice.Value; j++)
                {
                    Table tableHeader = doc.AddTable(1, 3);
                    tableHeader.SetBorder(TableBorderType.Bottom, new Xceed.Document.NET.Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.Black));
                    tableHeader.SetBorder(TableBorderType.Top, new Xceed.Document.NET.Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.Black));
                    tableHeader.SetBorder(TableBorderType.Left, new Xceed.Document.NET.Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.Black));
                    tableHeader.SetBorder(TableBorderType.Right, new Xceed.Document.NET.Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.Black));
                    tableHeader.SetBorder(TableBorderType.InsideV, new Xceed.Document.NET.Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.Black));
                    tableHeader.Alignment = Alignment.center; //align

                    tableHeader.SetColumnWidth(0, 165, true); // 5.8
                    tableHeader.SetColumnWidth(1, 190, true); // 6.7
                    tableHeader.SetColumnWidth(2, 153, true); // 5.4

                    //tableHeader.SetWidths(new float[] { 200, 240, 200}, false);

                    //Fill first row adding text in three column

                    // adding text in left column
                    tableHeader.Rows[0].Cells[0].Paragraphs.First()
                        .Append(leftHeaderTextBox.Text)
                        .Font("Times New Roman")
                        .FontSize((double)TextSize_LeftHeader.Value)
                        .Alignment = Alignment.left;

                    /*tableHeader.Rows[0].Cells[1].Paragraphs.First().Append("2");*/

                    // adding text in EI_middle column
                    switch (checkBox_EI_underline.Checked)
                    {
                        case true:
                            tableHeader.Rows[0].Cells[1].Paragraphs.First()
                            .Append(textBox_EI.Text + Environment.NewLine + Environment.NewLine)
                            .Append("")
                            .Font("Times New Roman")
                            .FontSize((double)TextSize_EI.Value)
                            .Bold(checkBox_EI_bold.Checked)
                            .Italic(checkBox_EI_italic.Checked)
                            .UnderlineStyle(UnderlineStyle.singleLine)
                            .Alignment = Alignment.center;
                            break;
                        default:
                            tableHeader.Rows[0].Cells[1].Paragraphs.First()
                            .Append(textBox_EI.Text + Environment.NewLine + Environment.NewLine)
                            .Font("Times New Roman")
                            .FontSize((double)TextSize_EI.Value)
                            .Bold(checkBox_EI_bold.Checked)
                            .Italic(checkBox_EI_italic.Checked)
                            .Alignment = Alignment.center;
                            break;
                    }

                    // adding text in ControlMaterial_middle column
                    switch (checkBox_ControlMaterial_underline.Checked)
                    {
                        case true:
                            tableHeader.Rows[0].Cells[1].Paragraphs.Last()
                            .Append(textBox_ControlMaterial.Text + Environment.NewLine)
                            .Font("Times New Roman")
                            .FontSize((double)TextSize_ControlMaterial.Value)
                            .Bold(checkBox_ControlMaterial_bold.Checked)
                            .Italic(checkBox_ControlMaterial_italic.Checked)
                            .UnderlineStyle(UnderlineStyle.singleLine)
                            .Alignment = Alignment.center;
                            break;
                        default:
                            tableHeader.Rows[0].Cells[1].Paragraphs.Last()
                            .Append(textBox_ControlMaterial.Text + Environment.NewLine)
                            .Font("Times New Roman")
                            .FontSize((double)TextSize_ControlMaterial.Value)
                            .Bold(checkBox_ControlMaterial_bold.Checked)
                            .Italic(checkBox_ControlMaterial_italic.Checked)
                            .Alignment = Alignment.center;
                            break;
                    }
                    // adding text in middle column
                    switch (checkBox_MiddleHeader_underline.Checked)
                    {
                        case true:
                            tableHeader.Rows[0].Cells[1].Paragraphs.First()
                            .Append(middleHeaderTextBox.Text)
                            .Font("Times New Roman")
                            .FontSize((double)TextSize_MiddleHeader.Value)
                            .Bold(checkBox_MiddleHeader_bold.Checked)
                            .Italic(checkBox_MiddleHeader_italic.Checked)
                            .UnderlineStyle(UnderlineStyle.singleLine)
                            .Alignment = Alignment.center;
                            break;
                        default:
                            tableHeader.Rows[0].Cells[1].Paragraphs.First()
                            .Append(middleHeaderTextBox.Text)
                            .Font("Times New Roman")
                            .FontSize((double)TextSize_MiddleHeader.Value)
                            .Bold(checkBox_MiddleHeader_bold.Checked)
                            .Italic(checkBox_MiddleHeader_italic.Checked)
                            .Alignment = Alignment.center;
                            break;
                    }
                    // adding text in right column

                    tableHeader.Rows[0].Cells[2].Paragraphs.First()
                        .Append(rightHeaderTextBox.Text)
                        .Font("Times New Roman")
                        .FontSize((double)TextSize_RightHeader.Value)
                        .Alignment = Alignment.left;

                    doc.InsertTable(tableHeader);
                    doc.InsertParagraph();
                    doc.InsertParagraph(comboBox1.Text + " №" + $"{j + 1}" + Environment.NewLine, false, titleFormat).FontSize(14).Alignment = Alignment.center;
                    // adding text in manual
                    if (manualTextBox.Text.Length != 0) { doc.InsertParagraph("\tИнструкция по выполнению:", false, titleFormat); }
                    string manualText = "";
                    List<string> arrayStr = new(manualTextBox.Text.Split('\n'));
                    for (int i = 0; i < arrayStr.Count; i++)
                    {
                        if (arrayStr[i].Length >= 5)
                        {
                            manualText += "\t" + $"{i + 1}. " + arrayStr[i];
                        }
                    }
                    doc.InsertParagraph(manualText, false, manualFormat);

                    doc.InsertParagraph();

                    doc.InsertParagraph("\tТеоретический вопрос", false, titleFormat).FontSize(14);


                    string theorText = "";
                    for (int i = 0; i < (double)countTheorQuestion.Value; i++)
                    {
                        if (theorQuestionArray.Count <= 1)
                        {
                            theorQuestionArray = new List<string>(theorQuestionTextBox.Text.Split('\n'));
                            RemoveEmptyTheorList(theorQuestionArray);
                        }

                        int x = rnd.Next(1, theorQuestionArray.Count);

                        if (theorQuestionArray[x].Contains('\r'))
                        {
                            theorText += $"\t{i + 1}. " + theorQuestionArray[x];
                        }
                        else
                        {
                            theorText += $"\t{i + 1}. " + theorQuestionArray[x] + "\r";
                        }
                        theorQuestionArray.RemoveAt(x);
                    }
                    doc.InsertParagraph(theorText, false, manualFormat).FontSize(14);



                    doc.InsertParagraph("\tПрактический вопрос", false, titleFormat).FontSize(14);
                    string practicText = "";
                    for (int i = 0; i < (double)countPracticQuestion.Value; i++)
                    {
                        if (practicQuestionArray.Count <= 1)
                        {
                            practicQuestionArray = new List<string>(practicQuestionTextBox.Text.Split('\n'));
                            RemoveEmptyPracticList(practicQuestionArray);
                        }

                        int x = rnd.Next(1, practicQuestionArray.Count);

                        if (practicQuestionArray[x].Contains('\r'))
                        {
                            practicText += $"\t{i + 1}. " + practicQuestionArray[x];
                        }
                        else
                        {
                            practicText += $"\t{i + 1}. " + practicQuestionArray[x] + "\r";
                        }
                        practicQuestionArray.RemoveAt(x);
                    }
                    doc.InsertParagraph(practicText, false, manualFormat).FontSize(14);

                    doc.InsertParagraph(Environment.NewLine + Environment.NewLine + Environment.NewLine + $"{AddTeacherText()}", false, manualFormat).FontSize(14).Alignment = Alignment.center;
                    if (j == countChoice.Value - 1)
                    {
                        continue;
                    }
                    else { doc.InsertSectionPageBreak(); }
                }

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFile.FileName;
                    doc.SaveAs(fileName);
                    AddItemOnHistoryAsync(fileName);
                }

            }
            catch
            {

            }
        }
        public void AddItemOnHistoryAsync(string fileName)
        {
            List<string> list = new(fileName.Split('\\'));
            string after = list[^1];
            string nameItem = after.Replace(".docx", "");

            /*Environment.CurrentDirectory + "\\" + "HistoryFiles" + "\\" + nameItem + ".txt";*/
            using FileStream fstream = new($"{Environment.CurrentDirectory + "\\" + "HistoryFiles" + "\\" + nameItem + ".txt"}", FileMode.Create);
            {
                byte[] buffer = Encoding.Default.GetBytes(
                    textBox_EI.Text + "&&&" + TextSize_EI.Value + "&&&" + checkBox_EI_bold.Checked + "&&&" + checkBox_EI_italic.Checked + "&&&" + checkBox_EI_underline.Checked + "&&&" +
                    textBox_ControlMaterial.Text + "&&&" + TextSize_ControlMaterial.Value + "&&&" + checkBox_ControlMaterial_bold.Checked + "&&&" + checkBox_ControlMaterial_italic.Checked + "&&&" + checkBox_ControlMaterial_underline.Checked + "&&&" +
                    leftHeaderTextBox.Text + "&&&" + TextSize_LeftHeader.Value + "&&&" +
                    middleHeaderTextBox.Text + "&&&" + TextSize_MiddleHeader.Value + "&&&" + checkBox_MiddleHeader_bold.Checked + "&&&" + checkBox_MiddleHeader_italic.Checked + "&&&" + checkBox_MiddleHeader_underline.Checked + "&&&" +
                    rightHeaderTextBox.Text + "&&&" + TextSize_RightHeader.Value + "&&&" +
                    manualTextBox.Text + "&&&" + manualTextSize.Value + "&&&" +
                    theorQuestionTextBox.Text + "&&&" + practicQuestionTextBox.Text + "&&&" +
                    countTheorQuestion.Value + "&&&" + countPracticQuestion.Value + "&&&" +
                    comboBox1.Text + "&&&" + countChoice.Value + "&&&" + teacherTextBox.Text);
                fstream.Write(buffer, 0, buffer.Length);
            }
            CheckedAndAddingItem();

        }
        private void GenerationQuestionButton_Click(object sender, EventArgs e)
        {
            string subject = genQuestionTextBox.Text;
            Thread newThread = new(GenerationQuestion); // Создание нового потока
            newThread.Start(); // Запуск потока
            async void GenerationQuestion()
            {
                string answer = "";
                YaGPT yagpt = new(); // Объявляем класс
                answer = await yagpt.SendMessageAsync($"{subject}");
                List<string> questionArray = new(answer.Split("\n"));
                string result = "";
                foreach (string question in questionArray)
                {
                    result += question + "\r\n";
                }

                Invoke(new Action(() =>
                {
                    resultGenQuestionTextBox.Text = result;
                }));
            }
            MessageBox.Show("Генерация вопросов займет некоторое время");
        }

        private void ButtonCreateDocument_Click(object sender, EventArgs e)
        {
            CreateSampleDocument();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
        public async Task OpenAndWritingText()
        {
            using FileStream fstream = File.OpenRead(Environment.CurrentDirectory + "\\" + "HistoryFiles" + "\\" + historyFile.SelectedItem + ".txt");
            byte[] buffer = new byte[fstream.Length];
            await fstream.ReadAsync(buffer);
            string textFromFile = Encoding.Default.GetString(buffer);
            List<string> result = new(textFromFile.Split("&&&"));
            foreach (string question in result)
            {
                Console.WriteLine(question);
            }
            string a = result[0];
            Console.WriteLine(a);
            try
            {
                textBox_EI.Text = result[0];
                Console.WriteLine(result[1]);
                TextSize_EI.Value = Convert.ToDecimal(result[1]);
                checkBox_EI_bold.Checked = Convert.ToBoolean(result[2]);
                checkBox_EI_italic.Checked = Convert.ToBoolean(result[3]);
                checkBox_EI_underline.Checked = Convert.ToBoolean(result[4]);
                textBox_ControlMaterial.Text = result[5];
                TextSize_ControlMaterial.Value = Convert.ToDecimal(result[6]);
                checkBox_ControlMaterial_bold.Checked = Convert.ToBoolean(result[7]);
                checkBox_ControlMaterial_italic.Checked = Convert.ToBoolean(result[8]);
                checkBox_ControlMaterial_underline.Checked = Convert.ToBoolean(result[9]);
                leftHeaderTextBox.Text = result[10];
                TextSize_LeftHeader.Value = Convert.ToDecimal(result[11]);
                middleHeaderTextBox.Text = result[12];
                TextSize_MiddleHeader.Value = Convert.ToDecimal(result[13]);
                checkBox_MiddleHeader_bold.Checked = Convert.ToBoolean(result[14]);
                checkBox_MiddleHeader_italic.Checked = Convert.ToBoolean(result[15]);
                checkBox_MiddleHeader_underline.Checked = Convert.ToBoolean(result[16]);
                rightHeaderTextBox.Text = result[17];
                TextSize_RightHeader.Value = Convert.ToDecimal(result[18]);
                manualTextBox.Text = result[19];
                manualTextSize.Value = Convert.ToDecimal(result[20]);
                theorQuestionTextBox.Text = result[21];
                practicQuestionTextBox.Text = result[22];
                countTheorQuestion.Value = Convert.ToDecimal(result[23]);
                countPracticQuestion.Value = Convert.ToDecimal(result[24]);
                comboBox1.Text = result[25];
                countChoice.Value = Convert.ToDecimal(result[26]);
                teacherTextBox.Text = result[27];
            }
            catch
            {

            }
        }
        private void ApplySelectedItem_Click(object sender, EventArgs e)
        {
            _ = OpenAndWritingText();
        }

        private void RemoveSelectedItemButton_Click(object sender, EventArgs e)
        {
            FileInfo fileInf = new(Environment.CurrentDirectory + "\\" + "HistoryFiles" + "\\" + historyFile.SelectedItem + ".txt");
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
            CheckedAndAddingItem();
        }

        private void RemoveAllItemsButton_Click(object sender, EventArgs e)
        {
            foreach (string item in historyFile.Items)
            {
                FileInfo fileInf = new(Environment.CurrentDirectory + "\\" + "HistoryFiles" + "\\" + item + ".txt");
                if (fileInf.Exists)
                {
                    fileInf.Delete();
                }
            }
            CheckedAndAddingItem();
        }
    }

}