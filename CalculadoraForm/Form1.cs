using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        // variáveis globais:
        bool operadorClicado = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Implementar depois...


        }

        private void numero_Click(object sender, EventArgs e)
        { 
           // Obter o botão que esta chamando esse evento:
           Button botaoClicar = (Button)sender;

            // Adicionar o text do botão clicado no textnox:
            txbTela.Text += botaoClicar.Text;

            // "abaixar a bandeirinha"
            operadorClicado = false;

        }

        private void operador_Click(object sender, EventArgs e)
        {
            // verificar se o operador ainda não foi clicacdo:
            if (operadorClicado == false)
            {
                // Obter o botão que esta chamando esse evento:
                Button botaoClicar = (Button)sender;

                // Adicionar o text do botão clicado no textnox:
                txbTela.Text += botaoClicar.Text;

                // mudar o operadorClicado para true:
                operadorClicado = true;


            }


           

        }


    }
}
