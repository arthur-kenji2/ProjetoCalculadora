using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoED2Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn9.Text;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            txtResultado.Clear();
            lbSequencias.Text = "Pósfixa";
        }

        private void btnParentesesAbre_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btnParentesesAbre.Text;
        }

        private void btnParentesesFecha_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btnParentesesFecha.Text;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btnPonto.Text;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btnMais.Text;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btnMenos.Text;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btnMultiplicacao.Text;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btnDivisao.Text;
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btnPotencia.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }
    }
}
