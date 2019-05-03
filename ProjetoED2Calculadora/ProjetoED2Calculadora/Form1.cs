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
            Atribuir();
        }

        private void Atribuir()
        {
            lbSequencias.Text = "";
            int n = 0;
            int h = 0;
            String[] infixa = new String[100];
            int unicode;
            char character;
            String expressao = txtVisor.Text;
            PilhaVetor vet = new PilhaVetor(100);
            PilhaVetor valores = new PilhaVetor(100);
            PilhaVetor operadores = new PilhaVetor(100);
            int inicio = 0;
            for (int i = 0; i < expressao.Length; i++)
            {
                int p = 0;
                while (Char.IsNumber(expressao, h))
                {
                    p++;
                    h++;
                    i++;
                    if (h >= expressao.Length)
                        break;
                }
                vet.empilhar(expressao.Substring(inicio, p));
                if (h < expressao.Length)
                    vet.empilhar(expressao.Substring(h, 1));
                h++;
                inicio = h;
                if (h < expressao.Length)
                {
                    if (!Char.IsNumber(expressao, h))
                        vet.empilhar(expressao.Substring(h, 1));
                }
                else
                    break;
            }
            int tamanho = vet.tamanho();
            for (int i = 0; i < tamanho; i++)
            {
                String s = vet.desempilhar().ToString();
                if (s.Length == 1)
                    if (!Char.IsNumber(Convert.ToChar(s)))
                    {
                        operadores.empilhar(s);
                        infixa[i] = operadores.desempilhar().ToString();
                    }

                    else
                    {
                        valores.empilhar(s);
                        infixa[i] = valores.desempilhar().ToString();
                    }
                else
                {
                    valores.empilhar(s);
                    infixa[i] = valores.desempilhar().ToString();
                }
            }

            for (int i = tamanho- 1; i >= 0; i--)
            {
                unicode = 65;
                if (Char.IsNumber(infixa[i], infixa[i].Length - 1))
                {
                    unicode += n;
                    character = (char)unicode;
                    lbSequencias.Text += character;
                    n++;
                }
                else
                lbSequencias.Text += infixa[i];
            }
        }

        private void Converter()
        {

            PilhaVetor pilha = new PilhaVetor(1000); // Instancia e inicia a Pilha
//Read(Entrada, Simbolo_Lido);
//            If Not(Simbolo_Lido In ['(',')','+','-','*','/','­']) Then
//Write(Simbolo_Lido)
//Else
//Begin
//Parar:= false;
//            While(not parar) and(not umaPilha.estaVazia()) and
//          (Ha_Precedencia(umaPilha.oTopo(), Simbolo_Lido)) Do
//          begin
//Operador_com_Maior_Precedencia:= umaPilha.desempilhar();
//            If operador_com_Maior_Precedencia<> ‘(‘ then
//            Write(Operador_com_Maior_Precedencia )
//            Else
//            Parar := true;
//            End;
//            If Simbolo_Lido<> ')' Then
//umaPilha.empilhar(Simbolo_Lido)
//Else { fará isso QUANDO o Pilha[TOPO] = '(' }
//            Operador_com_Maior_Precedencia:= umaPilha.desempilhar();
//            End;
//            End; // While not EOF
//            While not umaPilha.estaVazia() Do { Descarrega a Pilha Para a Saída }
//            Begin
//            Operador_com_Maior_Precedencia := umaPilha.desempilhar();
//            If Operador_com_Maior_Precedencia<> '(' Then
//Write(Operador_com_Maior_Precedencia);
//            End;

        }


    }

}
