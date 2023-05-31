using System.Configuration;
using System.Globalization;

namespace Calculadora1
{
    public partial class CalculadoraEstudo : Form
    {

        double valor = 0, valor2 = 0;
        double valorFinal = 0;
        string operacao = "";
        
        bool result = false;
        public CalculadoraEstudo()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {   
            if(result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "0";
            result = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "1";
            result = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "2";
            result = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "3";
            result = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "4";
            result = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "5";
            result = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "6";
            result = false; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "7";
            result = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "8";
            result = false; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += "9";
            result = false;
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            if (result == true)
            {
                txtResultado.Text = " ";
                valor = 0;
                valor2 = 0;
                operacao = " ";
                lblOperacao.Text = " ";
            }
            txtResultado.Text += ".";
            result = true;
        }

        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = " ";
            operacao = "SOMA";
            lblOperacao.Text = "+";
            result = false;
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
           
            valor = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUBTRACAO";
            lblOperacao.Text = "-";
            result = false;
        }
        private void buttonMulti_Click(object sender, EventArgs e)
        {
            
            valor = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULTIPLICACAO";
            lblOperacao.Text = "X";
            result = false;
        }
        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            
            valor = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIVISAO";
            lblOperacao.Text = "/";
            result = false;
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            
            valor2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor + valor2);
                result = true;
            }
            else if (operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor - valor2);
                result = true;
            }
            else if (operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor * valor2);
                result = true;
            }
            else if (operacao == "DIVISAO")
            {
                txtResultado.Text = Convert.ToString(valor / valor2);
                result = true;
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