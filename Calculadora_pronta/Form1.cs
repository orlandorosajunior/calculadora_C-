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
        Calc calcBasica;
        
        public Form1()
        {
            InitializeComponent();
            this.calcBasica = new Calc();
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btIgual.Select();
        }
          
        private void bt0_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('0');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('1');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('2');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('3');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('4');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('5');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('6');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('7');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('8');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('9');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void btPontoFlutuante_Click(object sender, EventArgs e)
        {
            calcBasica.escreverNaTela('.');
            textBox1.Text = calcBasica.valorAtual;
        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            if(calcBasica.valorAtual != "")
                calcBasica.valorAtualNum = Convert.ToDecimal(calcBasica.valorAtual);
            calcBasica.raiz();
            textBox1.Text = calcBasica.valorAtual;
        }

        private void btInvSinal_Click(object sender, EventArgs e)
        {
            calcBasica.inverteSinal();
            textBox1.Text = calcBasica.valorAtual;
        }


        private void btInversao_Click(object sender, EventArgs e)
        {
            calcBasica.inverteOperacao();
            textBox1.Text = calcBasica.valorAtual;
        }


        private void btZerar_Click(object sender, EventArgs e)
        {
            calcBasica.valorAtual = "";
            calcBasica.valorAcumulado = 0;
            textBox1.Text = calcBasica.valorAtual;
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            calcBasica.op = '-';
            //primeira tentativa
            //calcBasica.valorAcumulado = Convert.ToDecimal(calcBasica.valorAtual);
            if (calcBasica.valorAtual != "")
            {
                if (calcBasica.valorAcumulado == 0)
                {
                    calcBasica.valorAcumulado = Convert.ToDecimal(calcBasica.valorAtual);
                    calcBasica.valorAtual = "";
                    textBox1.Text = "";
                }
                else
                {
                    calcBasica.valorAcumulado = calcBasica.valorAcumulado - Convert.ToDecimal(calcBasica.valorAtual);
                    textBox1.Text = calcBasica.valorAcumulado.ToString();
                    calcBasica.valorAtual = calcBasica.valorAcumulado.ToString();
                    calcBasica.valorAcumulado = 0;
                }
            }
        }


        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            calcBasica.op = 'x';
            if (calcBasica.valorAtual != "")
            {
                if (calcBasica.valorAcumulado == 0)
                {
                    calcBasica.valorAcumulado = Convert.ToDecimal(calcBasica.valorAtual);
                    calcBasica.valorAtual = "";
                    textBox1.Text = "";
                }
                else
                {
                    calcBasica.valorAcumulado = calcBasica.valorAcumulado * Convert.ToDecimal(calcBasica.valorAtual);
                    textBox1.Text = calcBasica.valorAcumulado.ToString();
                    calcBasica.valorAtual = calcBasica.valorAcumulado.ToString();
                    calcBasica.valorAcumulado = 0;
                }
            }
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            calcBasica.op = '/';
            if (calcBasica.valorAtual != "")
            {
                if (calcBasica.valorAcumulado == 0)
                {
                    calcBasica.valorAcumulado = Convert.ToDecimal(calcBasica.valorAtual);
                    calcBasica.valorAtual = "";
                    textBox1.Text = "";
                }
                else
                {
                    calcBasica.valorAcumulado = calcBasica.valorAcumulado / Convert.ToDecimal(calcBasica.valorAtual);
                    textBox1.Text = calcBasica.valorAcumulado.ToString();
                    calcBasica.valorAtual = calcBasica.valorAcumulado.ToString();
                    calcBasica.valorAcumulado = 0;
                }
            }
        }

        private void btAdicao_Click(object sender, EventArgs e)
        {
            calcBasica.op = '+';
            if (calcBasica.valorAtual != "")
            {
                if (calcBasica.valorAcumulado == 0)
                {
                    calcBasica.valorAcumulado = Convert.ToDecimal(calcBasica.valorAtual);
                    calcBasica.valorAtual = "";
                    textBox1.Text = "";
                }
                else
                {
                    calcBasica.valorAcumulado = calcBasica.valorAcumulado + Convert.ToDecimal(calcBasica.valorAtual);
                    textBox1.Text = calcBasica.valorAcumulado.ToString();
                    calcBasica.valorAtual = calcBasica.valorAcumulado.ToString();
                    calcBasica.valorAcumulado = 0;
                }
            }
        }

        private void btPorcentagem_Click(object sender, EventArgs e)
        {
            calcBasica.op = '%';
            calcBasica.operacao();
            calcBasica.valorAtual = "";
            textBox1.Text = calcBasica.valorAcumulado.ToString();
        }


        private void btIgual_Click(object sender, EventArgs e)
        {
            calcBasica.operacao();
            textBox1.Text = calcBasica.valorAcumulado.ToString();
            calcBasica.valorAtual = calcBasica.valorAcumulado.ToString();
            calcBasica.valorAcumulado = 0;
        }


        private void btPi_Click(object sender, EventArgs e)
        {
            calcBasica.gerarPi();
            textBox1.Text = calcBasica.valorAtual;
        }

        private void btResposta_Click(object sender, EventArgs e)
        {
            calcBasica.valorAtual = calcBasica.valorAcumulado.ToString();
            textBox1.Text = calcBasica.valorAtual;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla;
            tecla = e.KeyChar;

            switch(tecla)
            {
                case '0': this.bt0_Click(this,new EventArgs()); break;
                case '1': this.bt1_Click(this, new EventArgs()); break;
                case '2': this.bt2_Click(this, new EventArgs()); break;
                case '3': this.bt3_Click(this, new EventArgs()); break;
                case '4': this.bt4_Click(this, new EventArgs()); break;
                case '5': this.bt5_Click(this, new EventArgs()); break;
                case '6': this.bt6_Click(this, new EventArgs()); break;
                case '7': this.bt7_Click(this, new EventArgs()); break;
                case '8': this.bt8_Click(this, new EventArgs()); break;
                case '9': this.bt9_Click(this, new EventArgs()); break;
                case '.': this.btPontoFlutuante_Click(this, new EventArgs()); break;
                case '=': case '\0': this.btIgual_Click(this, new EventArgs()); break;
                case 'P': case 'p':  this.btPi_Click(this, new EventArgs()); break;
                case 'R': case 'r':  this.btRaiz_Click(this, new EventArgs()); break;
                case 'A': case 'a':  this.btResposta_Click(this, new EventArgs()); break;
                case '%': this.btPorcentagem_Click(this, new EventArgs()); break;
                case 'C': case 'c':  this.btZerar_Click(this, new EventArgs()); break;
                case '+': this.btAdicao_Click(this, new EventArgs()); break;
                case '-': this.btSubtracao_Click(this, new EventArgs()); break;
                case '/': this.btDivisao_Click(this, new EventArgs()); break;
                case '*': this.btMultiplicacao.PerformClick(); break;
            }
        }
    }


}
