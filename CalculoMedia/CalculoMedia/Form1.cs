﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(txb1bim.Text);
            double num2 = System.Convert.ToDouble(txb2bim.Text);
            double num3 = System.Convert.ToDouble(txb3bim.Text);
            double num4 = System.Convert.ToDouble(txb4bim.Text);
            double calc = (num1 + num2 + num3 + num4) / 4;
            string nome = System.Convert.ToString (txbNome.Text);
            res.Text = txbNome.Text + ", sua média é " + calc.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
