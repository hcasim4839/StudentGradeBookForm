﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeBookForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginFrm objLF = new loginFrm();

            this.Hide();

            objLF.ShowDialog();

            this.Show();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            RegistFrm objRF = new RegistFrm();

            this.Hide();
            objRF.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
