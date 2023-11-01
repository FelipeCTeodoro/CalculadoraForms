using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
     
    public partial class Form1 : Form
    {
        int numero1;
        string UltimoOp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando A Tela:
            txbTela.Clear();
        }
        private void Operador_Click(object sender, EventArgs e)
        {
            // Obter os Botões que estão chamando o Evento:
            if(txbTela.Text == "")
            {
                MessageBox.Show("Operação Inválida!");
            }
            else
            {
                var botao = (Button)sender;
                numero1 = int.Parse(txbTela.Text);
                txbTela.Clear();
                txbAux.Text = numero1.ToString() + " " + botao.Text;
                UltimoOp = botao.Text;
            }
            


        }
        private void Numero_Click(object sender, EventArgs e)
        {
            // Obter o Botão que está chamando o evento:
            var botao = (Button)sender;
            txbTela.Text += botao.Text;
            
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            switch (UltimoOp)
            {
                case "+":
                    txbAux.Clear();
                    txbTela.Text = (numero1 + int.Parse(txbTela.Text)).ToString();
                    break;

                case "-":
                    txbAux.Clear();
                    txbTela.Text = (numero1 - int.Parse(txbTela.Text)).ToString();
                    break;

                case "x":
                    txbAux.Clear();
                    txbTela.Text = (numero1 * int.Parse(txbTela.Text)).ToString();
                    break;

                case "%":
                   if(int.Parse(txbTela.Text) != 0)
                    {
                        txbAux.Clear();
                        txbTela.Text = (numero1 / int.Parse(txbTela.Text)).ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show("Não é Possível Dividir Por Zero!");
                       
                    }
                    break;
            }


        }
    }
}
