﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StayFIT_WFormUI
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyProfileForm frmMyProfileForm = new frmMyProfileForm();
            frmMyProfileForm.Show();
        }
    }
}