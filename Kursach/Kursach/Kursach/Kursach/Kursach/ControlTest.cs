using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Kursach
{
    public partial class ControlTest : Form
    {
        private TestForm testForm;
        private Microsoft.Office.Interop.Word.Application wordApp;
        private Document doc;
        private int currentPosition = 1; 

        private List<string> correctAnswers = new List<string> { "B", "C", "B", "A", "A", "B", "A", "B" };
        private List<string> userAnswers = new List<string>();

        public ControlTest(TestForm cTest)
        {
            InitializeComponent();
            this.testForm = cTest;
            InitializeWordApplication();
            ReadAndDisplayContent();
            this.FormClosed += ControlTest_FormClosed;
        }

        private void InitializeWordApplication()
        {
            try
            {
                
                if (wordApp == null)
                {
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                }

                string filePath = "C:\\examples\\test\\test.docx";

                
                foreach (Document d in wordApp.Documents)
                {
                    if (d.FullName == filePath)
                    {
                        doc = d;
                        return; 
                    }
                }

                
                doc = wordApp.Documents.Open(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing Word application: {ex.Message}");
                if (doc != null)
                {
                    Marshal.ReleaseComObject(doc);
                    doc.Close();
                    doc = null;
                }
                if (wordApp != null)
                {
                    Marshal.ReleaseComObject(wordApp);
                    wordApp.Quit();
                    wordApp = null;

                    while (Process.GetProcessesByName("WINWORD").Length > 0)
                    {
                        Thread.Sleep(500);
                    }
                }
            }

        }


        private void ReadAndDisplayContent()
        {
            controlTextBox.Clear();

            int linesToRead = Math.Min(5, doc.Paragraphs.Count - currentPosition + 1);

            for (int i = 0; i < linesToRead; i++)
            {
                Range paragraphRange = doc.Paragraphs[currentPosition + i].Range;

                paragraphRange.Copy();

                controlTextBox.Paste();
            }

            currentPosition += linesToRead;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string selectedAnswer = GetSelectedAnswer();
            userAnswers.Add(selectedAnswer);

            if (currentPosition + 1 >= doc.Paragraphs.Count)
            {
                int correctCount = 0;
                int totalQuestions = correctAnswers.Count;

                for (int i = 0; i < totalQuestions; i++)
                {
                    if (i < userAnswers.Count && correctAnswers[i] == userAnswers[i])
                    {
                        correctCount++;
                    }
                }

                double percentage = (double)correctCount / totalQuestions * 100;

                MessageBox.Show($"Вы завершили тест!\nВаш результат: {percentage}% правильности");

                this.Close();
            }
            else
            {
                ReadAndDisplayContent();
            }
        }


        private string GetSelectedAnswer()
        {
            if (answerA.Checked)
            {
                return "A";
            }
            else if (answerB.Checked)
            {
                return "B";
            }
            else if (answerC.Checked)
            {
                return "C";
            }
            else
            {
                
                return ""; 
            }
        }


        private void ControlTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (doc != null)
                {
                    doc.Close();
                    Marshal.ReleaseComObject(doc);
                    doc = null;
                }

                if (wordApp != null)
                {
                    wordApp.Quit();
                    Marshal.ReleaseComObject(wordApp);
                    wordApp = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during form closure: {ex.Message}");
            }
            finally
            {
                System.Windows.Forms.Application.Exit();
            }
        }

    }
}
