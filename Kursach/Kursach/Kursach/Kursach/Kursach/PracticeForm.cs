using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;

namespace Kursach
{
    public partial class PracticeForm : Form
    {
        private MainForm mainForm;
        private Word.Application wordApp;
        private Word.Document wordDoc;

        public PracticeForm(MainForm mForm)
        {
            InitializeComponent();
            this.mainForm = mForm;

            wordApp = new Word.Application();
            wordApp.Visible = false;
        }

        private void DisplayDocxContent(string filePath)
        {
            try
            {
                var document = wordApp.Documents.Open(filePath);

                string fileContent = "";

                foreach (Paragraph paragraph in document.Paragraphs)
                {
                    fileContent += paragraph.Range.Text + Environment.NewLine;
                }

                PracticeBox.Text = fileContent;

                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();

            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.Show();
            }
        }

        private void Practice1_Click(object sender, EventArgs e)
        {
            DisplayDocxContent("C:\\examples\\practice\\pr1.docx");
        }

        private void Practice2_Click(object sender, EventArgs e)
        {
            DisplayDocxContent("C:\\examples\\practice\\pr2.docx");
        }

        private void Practice3_Click(object sender, EventArgs e)
        {
            DisplayDocxContent("C:\\examples\\practice\\pr3.docx");
        }
    }
}
