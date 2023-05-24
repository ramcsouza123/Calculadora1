using System.Globalization;

namespace Calculadora1
{
    public partial class CalculadoraEstudo : Form
    {

        double valor = 0, valor2 = 0;
        string operacao = "";
        public CalculadoraEstudo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = " ";
            operacao = "SOMA";
            lblOperacao.Text = "+";
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUBTRACAO";
            lblOperacao.Text = "-";
        }
        private void buttonMulti_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULTIPLICACAO";
            lblOperacao.Text = "X";
        }
        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIVISAO";
            lblOperacao.Text = "/";
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor + valor2);
            }
            else if (operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                txtResultado.Text = Convert.ToString(valor / valor2);
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = " ";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = " ";
            valor = 0;
            valor2 = 0;
            operacao = " ";
            lblOperacao.Text = " ";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }
}