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
        // Variaveis Globais:
        int numero1;
        string UltimoOp;
        bool i = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando A Tela:
            txbTela.Clear();
            i = false;
            numero1= 0;
            txbAux.Clear();
            
        }
        private void Operador_Click(object sender, EventArgs e)
        {


            // Obter os Botões que estão chamando o Evento:

                var botao = (Button)sender;

                if (i == false && txbTela.Text != "" && txbAux.Text == "" )
                {
                
                numero1 = int.Parse(txbTela.Text);
                txbTela.Clear();
                txbAux.Text = numero1.ToString() + " " + botao.Text;
                UltimoOp = botao.Text;
                i= true;
                }
                else if(txbTela.Text != "" && txbTela.Text != "")
                {

                btnIgual.PerformClick();
                txbAux.Text = txbTela.Text + botao.Text;
                numero1 = int.Parse(txbTela.Text);
                txbTela.Clear();
                
                }
            


        }
        private void Numero_Click(object sender, EventArgs e)
        {
            // Obter o Botão que está chamando o evento:

            var botao = (Button)sender;
            txbTela.Text += botao.Text;
            i = false;
            
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            // Obter o Botão que está chamando o evento:

            if (txbTela.Text != "" || txbAux.Text == "")
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

                    case "÷":                       
                        if (int.Parse(txbTela.Text) != 0)
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

                i = false;
              
            }
            else
            {
                MessageBox.Show("Dados Inválidos.");
            }
            


        }
    }
}
