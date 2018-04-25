using System;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Nm1 = System.Convert.ToDouble(txtNum1.Text);
            double Nm2 = System.Convert.ToDouble(txtNum2.Text);
            double Nm3 = System.Convert.ToDouble(txtNum3.Text);

            if (Nm1 > Nm2 && Nm1 > Nm3) {
                txtRes.Text = "O Maior Valor é A";
            }

            else if (Nm2 > Nm1 && Nm2 > Nm3) {
                txtRes.Text = "O Maior valor é B";
            }

            else if (Nm3 > Nm1 && Nm3 > Nm2) {
                txtRes.Text = "O Maior valor é C";
            }

            else if (Nm1 == Nm2 && Nm1 == Nm3 && Nm2 == Nm3) {
                txtRes.Text = "Todos tem o mesmo valor";
            }
        }
    }
}
