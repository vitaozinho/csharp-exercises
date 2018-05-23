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

        double n1, r, n2;

        int op, v = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtVisor.Text = "0";
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
           
           
            if (txtVisor.Text == "0")
                txtVisor.Text = "7";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "7";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 7;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 7;
            }
           
             
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            
            if (txtVisor.Text == "0")
                txtVisor.Text = "8";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "8";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 8;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 8;
            }
           
          
          
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
           
            if (txtVisor.Text == "0")
                txtVisor.Text = "4";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "4";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 4;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 4;
            }
           
          
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            
            if (txtVisor.Text == "0")
                txtVisor.Text = "5";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "5";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 5;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 5;
            }
           
     
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            
            if (txtVisor.Text == "0")
                txtVisor.Text = "6";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "6";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 6;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 6;
            }
           
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            
            if (txtVisor.Text == "0")
                txtVisor.Text = "2";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "2";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 2;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 2;
            }
           
           
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            
            if (txtVisor.Text == "0")
                txtVisor.Text = "3";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "3";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 3;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 3;
            }
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (txtVisor.Text == "0")
                txtVisor.Text = "9";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "9";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 9;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 9;
            }
           
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            if (txtVisor.Text == "0")
                txtVisor.Text = "1";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "1";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 1;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 1;
            }
           
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            if (txtVisor.Text == "0")
                txtVisor.Text = "7";

            else
            {
                txtVisor.Text = (txtVisor.Text) + "0";
            }

            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 0;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 0;
            }
           
           
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (n2 == 0)
            {
                op = 1;
            }
            if (v >= 1)
            {


                switch (op)
                {
                    case 1: r = n1 + n2; break;
                    case 2: r = n1 - n2; break;
                    case 3: r = n1 * n2; break;
                    case 4: r = n1 / n2; break;

                }
                n1 = r;
                n2 = 0;

                
                v = 1;
                op = 0;
            }

            txtVisor.Text += "+";
            op = 1;
            v++;
           }



        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {


                switch (op)
                {
                    case 1: r = n1 + n2; break;
                    case 2: r = n1 - n2; break;
                    case 3: r = n1 * n2; break;
                    case 4: r = n1 / n2; break;
                }
                n1 = r;
                n2 = 0;


                v = 1;
                op = 0;
            }

            txtVisor.Text += "-";
            op = 2;
            v++;

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

            if (v >= 1)
            {


                switch (op)
                {
                    case 1: r = n1 + n2; break;
                    case 2: r = n1 - n2; break;
                    case 3: r = n1 * n2; break;
                    case 4: r = n1 / n2; break;
                }
                n1 = r;
                n2 = 0;



                v = 1;
                op = 0;
            }

            txtVisor.Text += "*";
            op = 3;
            v++;
        }
            
        
        private void button13_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {

                switch (op)
                {
                    case 1: r = n1 + n2; break;
                    case 2: r = n1 - n2; break;
                    case 3: r = n1 * n2; break;
                    case 4: r = n1 / n2; break;
                }
                n1 = r;
                n2 = 0;

                
                v = 1;
                op = 0;
            }

            txtVisor.Text += "/";
            op = 4;
            v++;

        }
                
            
           
        

        private void btnIgual_Click(object sender, EventArgs e)
        {
                         if (n2 == 0)
            {
                
                txtVisor.Text = n1 +" = " + n1;
            }
            else
            {
                switch (op)
                {
                    case 1: r = n1 + n2; break;
                    case 2: r = n1 - n2; break;
                    case 3: r = n1 * n2; break;
                    case 4: r = n1 / n2; break;

                }
              
                txtVisor.Text += " = ";
                

                n1 = r;
                v = 0;

                n2 = 0;
            }
        
            

            n1 = r;
            n2 = 0;
             txtVisor.Text =  txtVisor.Text + r;
        
           
        }
        
       


            
        

        private void C_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            n1 = 0;
            n2 = 0;
            r = 0; 
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
