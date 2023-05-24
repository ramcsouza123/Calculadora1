namespace Calculadora1
{
    partial class CalculadoraEstudo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraEstudo));
            txtResultado = new TextBox();
            lblOperacao = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAdicao = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            buttonSub = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonIgual = new Button();
            buttonMulti = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonDivisao = new Button();
            buttonPonto = new Button();
            button0 = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(13, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(294, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            txtResultado.KeyPress += txtResultado_KeyPress;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.BackColor = Color.Transparent;
            lblOperacao.Location = new Point(23, 15);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 1;
            lblOperacao.TextAlign = ContentAlignment.TopRight;
            // 
            // button7
            // 
            button7.Location = new Point(13, 41);
            button7.Name = "button7";
            button7.Size = new Size(54, 45);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(73, 41);
            button8.Name = "button8";
            button8.Size = new Size(54, 45);
            button8.TabIndex = 3;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(133, 41);
            button9.Name = "button9";
            button9.Size = new Size(54, 45);
            button9.TabIndex = 4;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonAdicao
            // 
            buttonAdicao.Location = new Point(193, 41);
            buttonAdicao.Name = "buttonAdicao";
            buttonAdicao.Size = new Size(54, 45);
            buttonAdicao.TabIndex = 5;
            buttonAdicao.Text = "+";
            buttonAdicao.UseVisualStyleBackColor = true;
            buttonAdicao.Click += buttonAdicao_Click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(253, 41);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(54, 45);
            buttonCE.TabIndex = 7;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(253, 92);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(54, 45);
            buttonC.TabIndex = 12;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(193, 92);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(54, 45);
            buttonSub.TabIndex = 11;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // button6
            // 
            button6.Location = new Point(133, 92);
            button6.Name = "button6";
            button6.Size = new Size(54, 45);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(73, 92);
            button5.Name = "button5";
            button5.Size = new Size(54, 45);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(13, 92);
            button4.Name = "button4";
            button4.Size = new Size(54, 45);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Location = new Point(253, 143);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(54, 96);
            buttonIgual.TabIndex = 17;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Location = new Point(193, 143);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(54, 45);
            buttonMulti.TabIndex = 16;
            buttonMulti.Text = "X";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // button3
            // 
            button3.Location = new Point(133, 143);
            button3.Name = "button3";
            button3.Size = new Size(54, 45);
            button3.TabIndex = 15;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 143);
            button2.Name = "button2";
            button2.Size = new Size(54, 45);
            button2.TabIndex = 14;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 143);
            button1.Name = "button1";
            button1.Size = new Size(54, 45);
            button1.TabIndex = 13;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonDivisao
            // 
            buttonDivisao.Location = new Point(193, 194);
            buttonDivisao.Name = "buttonDivisao";
            buttonDivisao.Size = new Size(54, 45);
            buttonDivisao.TabIndex = 21;
            buttonDivisao.Text = "/";
            buttonDivisao.UseVisualStyleBackColor = true;
            buttonDivisao.Click += buttonDivisao_Click;
            // 
            // buttonPonto
            // 
            buttonPonto.Location = new Point(133, 194);
            buttonPonto.Name = "buttonPonto";
            buttonPonto.Size = new Size(54, 45);
            buttonPonto.TabIndex = 20;
            buttonPonto.Text = ".";
            buttonPonto.UseVisualStyleBackColor = true;
            buttonPonto.Click += buttonPonto_Click;
            // 
            // button0
            // 
            button0.Location = new Point(13, 194);
            button0.Name = "button0";
            button0.Size = new Size(114, 45);
            button0.TabIndex = 19;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // CalculadoraEstudo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 256);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonPonto);
            Controls.Add(button0);
            Controls.Add(buttonIgual);
            Controls.Add(buttonMulti);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonC);
            Controls.Add(buttonSub);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonCE);
            Controls.Add(buttonAdicao);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(lblOperacao);
            Controls.Add(txtResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CalculadoraEstudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculadoraEstudo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Label lblOperacao;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonAdicao;
        private Button buttonCE;
        private Button buttonC;
        private Button buttonSub;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonIgual;
        private Button buttonMulti;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonDivisao;
        private Button buttonPonto;
        private Button button0;
    }
}