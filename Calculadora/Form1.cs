using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double total;
        double ultimonumero;
        string operador;

        private void Limpar()
        {
            total = 0;
            ultimonumero = 0;
            operador = "+";
            txtbox_resultado.Text = "";
        }

        private void Calcular()
        {
            switch (operador) {

                case "+": total = total + ultimonumero;
                    break;
                case "-":
                    total = total - ultimonumero;
                    break;
                case "/":
                    total = total / ultimonumero;
                    break;
                case "*":
                    total = total * ultimonumero;
                    break;
            }
            ultimonumero = 0;
            txtbox_resultado.Text = total.ToString();
    }
        public Form1()
        {
            InitializeComponent();
            Limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void gerarnumero(object sender, EventArgs e)
        {
            if (ultimonumero == 0)
            {
                txtbox_resultado.Text = (sender as Button).Text;
            }
            else
            {
                txtbox_resultado.Text = txtbox_resultado.Text + (sender as Button).Text;
            }
            ultimonumero = Convert.ToDouble(txtbox_resultado.Text);
        }

        private void operadores(object sender, EventArgs e)
        {
            ultimonumero = Convert.ToDouble(txtbox_resultado.Text);
            Calcular();
            operador = (sender as Button).Text;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            ultimonumero = Convert.ToDouble(txtbox_resultado);
            Calcular();
            operador = "+";
            total = 0;
        }
    }
}
