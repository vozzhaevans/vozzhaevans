﻿using System;
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
    public partial class InstructionForm : Form
    {
        private MainForm mainForm;
        public InstructionForm(MainForm mForm)
        {
            InitializeComponent();
            this.mainForm = mForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.Show();
            }
        }
    }
}
