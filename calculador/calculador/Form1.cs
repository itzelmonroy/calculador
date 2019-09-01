using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculador
{
    public partial class calculadora : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operación;
        


        public calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void Txtdeunpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
            
        }

        private void Txtbotonde0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
            
        }

        private void Txtboton3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+"3";
            


        }

        private void Txtboton2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
            
        }

        private void Txtboton1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
            
        }

        private void Txtboton6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
            

        }

        private void Txtboton5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
            
        }

        private void Txtboton4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
            
        }

        private void Txtboton9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
           
        }

        private void Txtboton8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
           
        }

        private void Txtboton7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
           
        }

        private void Txtmas_Click(object sender, EventArgs e)
        {
            operación = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Txtmenos_Click(object sender, EventArgs e)
        {
            operación = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Txtpor_Click(object sender, EventArgs e)
        {
            operación = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Txtdiagonal_Click(object sender, EventArgs e)
        {
            operación = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Txtigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            switch(operación)
            {
                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "%":
                    resultado = primero /100 * segundo;
                    pantalla.Text = resultado.ToString();
                    break;

            }
        }


        private void Txtesce_Click(object sender, EventArgs e)
        {
            if(pantalla.Text.Length==1)
            {
                pantalla.Text="";
            }
            else
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
            }
        }

        private void Txtporciernto_Click(object sender, EventArgs e)
        {

            operación = "%";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();

        }

        private void Txtesc_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }
    }
}
