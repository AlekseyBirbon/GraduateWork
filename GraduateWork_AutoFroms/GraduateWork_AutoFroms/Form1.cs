using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.Diagnostics;
using Xceed.Document.NET;
using System.IO;
using Font = Xceed.Document.NET.Font;
using BorderStyle = Xceed.Document.NET.BorderStyle;
using Footer = Xceed.Document.NET.Footer;
using System.Xml.Linq;
using System.Diagnostics.Tracing;
using System.Windows.Forms.VisualStyles;
using System.Net.Http.Headers;

namespace GraduateWork_AutoFroms
{
    public partial class Form1 : Form
    {
        public void CreateSampleDocument()
        {
            try
            {

                // title formating
                var titleFormat = new Formatting();
                titleFormat.FontFamily = new Font("Times New Roman");
                titleFormat.Size = (double)manualTextSize.Value;
                titleFormat.Bold = true;

                // manual formatting
                var manualFormat = new Formatting();
                manualFormat.FontFamily = new Font("Times New Roman");
                manualFormat.Size = (double)manualTextSize.Value;
                manualFormat.Bold = false;

                List<string> theorQuestionArray = new List<string>(theorQuestionTextBox.Text.Split('\n'));
                List<string> practicQuestionArray = new List<string>(practicQuestionTextBox.Text.Split('\n'));
                Random rnd = new Random();

                string fileName = @"C:\Files\wow.docx";

                var doc = DocX.Create(fileName);

                doc.MarginTop = 56;
                doc.MarginBottom = 56;
                doc.MarginLeft = 56;
                doc.MarginRight = 43;

                for(int j = 0; j < (int)countChoice.Value; j++)
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
                            .Append(textBox_EI.Text + "\r")
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
                            .Append(textBox_EI.Text + "\r")
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
                            .Append(textBox_ControlMaterial.Text)
                            .Font("Times New Roman")
                            .FontSize((double)TextSize_ControlMaterial.Value)
                            .Bold(checkBox_ControlMaterial_bold.Checked)
                            .Italic(checkBox_ControlMaterial_italic.Checked)
                            .UnderlineStyle(UnderlineStyle.singleLine)
                            .Alignment = Alignment.center;
                            break;
                        default:
                            tableHeader.Rows[0].Cells[1].Paragraphs.Last()
                            .Append(textBox_ControlMaterial.Text)
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
                    doc.InsertParagraph(comboBox1.Text + " №"+ $"{j+1}", false, titleFormat).FontSize(14).Alignment = Alignment.center;
                    // adding text in manual
                    if (manualTextBox.Text.Length != 0) { doc.InsertParagraph("\tИнструкция по выполнению:", false, titleFormat); }
                    string manualText = "";
                    List<string> arrayStr = new List<string>(manualTextBox.Text.Split('\n'));
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
                    if (theorQuestionArray.Count <= 1) { theorQuestionArray = new List<string>(theorQuestionTextBox.Text.Split('\n')); }
                        int x = rnd.Next(1, theorQuestionArray.Count);
                        theorText += $"\t{i + 1}. " + theorQuestionArray[x];
                        theorQuestionArray.RemoveAt(x);
                    }
                    doc.InsertParagraph(theorText, false, manualFormat).FontSize(14);

                    doc.InsertParagraph("\tПрактический вопрос", false, titleFormat).FontSize(14);
                    string practicText = "";
                    for (int i = 0; i < (double)countPracticQuestion.Value; i++)
                    {
                    if (practicQuestionArray.Count <= 1) { practicQuestionArray = new List<string>(practicQuestionTextBox.Text.Split('\n')); }
                        int x = rnd.Next(1, practicQuestionArray.Count);
                        practicText += $"\t{i + 1}. " + practicQuestionArray[x];
                        practicQuestionArray.RemoveAt(x);
                    }
                    doc.InsertParagraph(practicText, false, manualFormat).FontSize(14);

                    /*           doc.InsertParagraph($"Преподаватель________________________{theacherTextBox.Text}", false, manualFormat).FontSize(14).Alignment = Alignment.center;*/
                    if (j == countChoice.Value-1)
                    {
                        continue;
                    }
                    else { doc.InsertSectionPageBreak(); }
                }

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFile.FileName;
                    doc.SaveAs(fileName);
                }

            }
            catch
            {
                
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            CreateSampleDocument();
        }
    }
}
