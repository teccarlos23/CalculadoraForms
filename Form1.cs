using System.Linq.Expressions;

namespace Calculadora_Forms
{
    public partial class Form1 : Form
    {
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private Operadores operacao { get; set; }

        private string Vazio { get; set; }

        private enum Operadores
        {
            adicao, subtracao, divisao, multiplicacao,
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            txttela.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txttela.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txttela.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txttela.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txttela.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txttela.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txttela.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txttela.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txttela.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txttela.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txttela.Text += ",";

        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = Operadores.adicao;
            Valor = Convert.ToDecimal(txttela.Text);
            txttela.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacao = Operadores.subtracao;
            Valor = Convert.ToDecimal(txttela.Text);
            txttela.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacao = Operadores.multiplicacao;
            Valor = Convert.ToDecimal(txttela.Text);
            txttela.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao = Operadores.divisao;
            Valor = Convert.ToDecimal(txttela.Text);
            txttela.Text = "";
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
         
            switch (operacao)
            {
                case Operadores.adicao:
                    Resultado = Valor + Convert.ToDecimal(txttela.Text);
                    break;
                case Operadores.subtracao:
                    Resultado = Valor - Convert.ToDecimal(txttela.Text);
                    break;
                case Operadores.multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txttela.Text);
                    break;
                case Operadores.divisao:
                    Resultado = Valor / Convert.ToDecimal(txttela.Text);
                    break;

                default:
         
                    break;
            }


            txttela.Text = Resultado.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txttela.Text = "";

        }
    }
}
