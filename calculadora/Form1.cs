using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text + "8";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text + "0";

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            
            switch (operacion)

            {

                case 1:
                    resultado = valor1 + valor2;
                    break;

                case 2:
                    resultado = valor1 - valor2;
                    break;

                case 3:
                    resultado = valor1 * valor2;
                    break;

                case 4: 
                    resultado = valor1 / valor2;
                    break;
            }

            valor2 = Convert.ToDouble(tbresultado.Text);
            
            tbresultado.Text = resultado.ToString();
            tbresultado.Text = tbresultado.Text + "";






        }
        
        private void btnpunto_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text + ".";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text +  "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text +  "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text +  "7";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbresultado.Text = tbresultado.Text +  "9";
        }

        private void btnsuma_Click(object sender, EventArgs e)

        {
            operacion = 1;
            valor1 = Convert.ToDouble(tbresultado.Text);
            tbresultado.Text = "";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(tbresultado.Text);
            tbresultado.Text = "";



        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(tbresultado.Text);
            tbresultado.Text = "";


        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(tbresultado.Text);
            tbresultado.Text = "";
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            operacion = 5;
            valor1 = Convert.ToDouble(tbresultado.Text);
            tbresultado.Text = "";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            tbresultado.Text = "";
        }
    }
}
