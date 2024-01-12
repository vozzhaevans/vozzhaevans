using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class TestForm : Form
    {
        private MainForm mainForm;
        private ControlTest controlTestForm;
        public TestForm(MainForm mForm)
        {
            InitializeComponent();
            this.mainForm = mForm;
            this.controlTestForm = new ControlTest(this);
            this.FormClosed += TestForm_FormClosed;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.Show();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (controlTestForm == null || controlTestForm.IsDisposed)
            {
                controlTestForm = new ControlTest(this);
            }

            controlTestForm.Show();
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
