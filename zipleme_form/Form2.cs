﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zipleme_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.kaydedilen = textBox1.Text + ".zip";
            Form1.saniye = DateTime.Now;

            this.Close();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
