//,kk
// аыа
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
    public partial class AboutForm : Form
    {
        private MainForm mainForm;
        public AboutForm(MainForm mForm)
        {
            InitializeComponent();
            this.mainForm = mForm;
            this.FormClosed += AboutForm_FormClosed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.Show();
            }
        }
        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
