﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtShow.Text = "Hello World!"; //你可以直接複製貼過去
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
