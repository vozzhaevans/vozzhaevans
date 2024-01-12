using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Drawing;
using System.Linq;

namespace Kursach
{
    public partial class TheoryForm : Form
    {
        private MainForm mainForm;
        private Word.Application wordApp;
        private Word.Document wordDoc;
        private int currentImageIndex = 0;
        private List<string> imagePaths = new List<string>();


        public TheoryForm(MainForm mForm)
        {
            InitializeComponent();

            this.mainForm = mForm;
            this.FormClosed += TheoryForm_FormClosed;
            wordApp = GetRunningWordApplication() ?? new Word.Application();
            wordApp.Visible = false;

        }

        private Word.Application GetRunningWordApplication()
        {
            try
            {
                return (Word.Application)Marshal.GetActiveObject("Word.Application");
            }
            catch (COMException)
            {
                return null;
            }
        }

        private void DisplayDocxContent(string filePath)
        {
            try
            {
                var document = wordApp.Documents.Open(filePath);

                ClearImages();
                imagePaths.Clear();
                currentImageIndex = 0;
               
                foreach (InlineShape shape in document.InlineShapes)
                {
                    if (shape.Type == WdInlineShapeType.wdInlineShapePicture)
                    {
                        string tempImagePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".png");
                        shape.Range.Select();

                        shape.Select();
                        wordApp.Selection.CopyAsPicture();
                        IDataObject data = Clipboard.GetDataObject();
                        if (data != null && data.GetDataPresent(DataFormats.Bitmap))
                        {
                            Image image = (Image)data.GetData(DataFormats.Bitmap, true);

                            image.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Png);

                            imagePaths.Add(tempImagePath);
                        }
                    }
                }

                ShowImage(currentImageIndex);

                ThemeBox.Text = document.Content.Text;

                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ClearImages()
        {
            foreach (Control control in Controls.OfType<PictureBox>().ToList())
            {
                Controls.Remove(control);
                control.Dispose();
            }

            
        }

        private void ShowImage(int index)
        {
            if (index >= 0 && index < imagePaths.Count)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagePaths[index]);
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.Location = new System.Drawing.Point(ThemeBox.Right + 10, ThemeBox.Top);
                Controls.Add(pictureBox);
            }
        }

        private void NextImage()
        {
            if (currentImageIndex < imagePaths.Count - 1)
            {
                currentImageIndex++;
                ClearImages(); 
                ShowImage(currentImageIndex);
            }
        }

        private void PreviousImage()
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                ClearImages(); 
                ShowImage(currentImageIndex);
            }
        }

        private void Theme1_Click(object sender, EventArgs e)
        {
            DisplayDocxContent("C:\\examples\\theory\\lec1.docx");
        }

        private void Theme2_Click(object sender, EventArgs e)
        {
            DisplayDocxContent("C:\\examples\\theory\\lec2.docx");
        }

        private void Theme3_Click(object sender, EventArgs e)
        {
            DisplayDocxContent("C:\\examples\\theory\\lec3.docx");
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.Show();
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                ClearImages();  
                ShowImage(currentImageIndex);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < imagePaths.Count - 1)
            {
                currentImageIndex++;
                ClearImages();  
                ShowImage(currentImageIndex);
            }
        }

        private void TheoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ThemeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
