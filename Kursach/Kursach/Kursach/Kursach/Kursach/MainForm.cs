using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach
{
    public partial class MainForm : Form
    {
        private TheoryForm theoryForm;
        private PracticeForm practiceForm;
        private TestForm testForm;
        private AboutForm aboutForm;
        private InstructionForm instructionForm;
        
        public MainForm()
        {
            InitializeComponent();
            this.theoryForm = new TheoryForm(this); 
            this.aboutForm = new AboutForm(this);
            this.testForm = new TestForm(this);
            this.instructionForm = new InstructionForm(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
              
            if (theoryForm == null || theoryForm.IsDisposed)
            {
                theoryForm = new TheoryForm(this);
            }

            theoryForm.Show();
        }

        private void buttonToPract_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (practiceForm == null || practiceForm.IsDisposed)
            {
                practiceForm = new PracticeForm(this);
            }

            practiceForm.Show();
        }

        private void buttonToTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (testForm == null || testForm.IsDisposed)
            {
                testForm = new TestForm(this);
            }

            testForm.Show();
        }

        private void оПрограммеToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (aboutForm == null || aboutForm.IsDisposed)
            {
                aboutForm = new AboutForm(this);
            }

            aboutForm.Show();
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (instructionForm == null || instructionForm.IsDisposed)
            {
                instructionForm = new InstructionForm(this);
            }

            instructionForm.Show();
        }
    }
}
