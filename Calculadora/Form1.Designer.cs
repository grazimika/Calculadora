
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnZero = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.bntPonto = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnInversao = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEleva = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnFracao = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.IndianRed;
            this.btnZero.Location = new System.Drawing.Point(49, 313);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(102, 39);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnUm
            // 
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.ForeColor = System.Drawing.Color.IndianRed;
            this.btnUm.Location = new System.Drawing.Point(49, 268);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(48, 39);
            this.btnUm.TabIndex = 1;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(49, 43);
            this.txtDisplay.MaxLength = 10;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisplay.Size = new System.Drawing.Size(286, 26);
            this.txtDisplay.TabIndex = 999;
            this.txtDisplay.TabStop = false;
            // 
            // bntPonto
            // 
            this.bntPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPonto.ForeColor = System.Drawing.Color.IndianRed;
            this.bntPonto.Location = new System.Drawing.Point(157, 313);
            this.bntPonto.Name = "bntPonto";
            this.bntPonto.Size = new System.Drawing.Size(48, 39);
            this.bntPonto.TabIndex = 10;
            this.bntPonto.Text = ",";
            this.bntPonto.UseVisualStyleBackColor = true;
            this.bntPonto.Click += new System.EventHandler(this.bntPonto_Click);
            // 
            // btnDois
            // 
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDois.Location = new System.Drawing.Point(103, 268);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(48, 39);
            this.btnDois.TabIndex = 2;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.IndianRed;
            this.btnTres.Location = new System.Drawing.Point(157, 268);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(48, 39);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.IndianRed;
            this.btnQuatro.Location = new System.Drawing.Point(49, 223);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(48, 39);
            this.btnQuatro.TabIndex = 4;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSeis.Location = new System.Drawing.Point(157, 223);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(48, 39);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCinco.Location = new System.Drawing.Point(103, 223);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(48, 39);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSete
            // 
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSete.Location = new System.Drawing.Point(49, 178);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(48, 39);
            this.btnSete.TabIndex = 7;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnNove
            // 
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.IndianRed;
            this.btnNove.Location = new System.Drawing.Point(157, 178);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(48, 39);
            this.btnNove.TabIndex = 9;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnOito
            // 
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.IndianRed;
            this.btnOito.Location = new System.Drawing.Point(103, 178);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(48, 39);
            this.btnOito.TabIndex = 8;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSoma.Location = new System.Drawing.Point(211, 268);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(48, 39);
            this.btnSoma.TabIndex = 1;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSubtracao.Location = new System.Drawing.Point(211, 223);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(48, 39);
            this.btnSubtracao.TabIndex = 6;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplica.ForeColor = System.Drawing.Color.IndianRed;
            this.btnMultiplica.Location = new System.Drawing.Point(211, 178);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(48, 39);
            this.btnMultiplica.TabIndex = 9;
            this.btnMultiplica.Text = "*";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnInversao
            // 
            this.btnInversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversao.ForeColor = System.Drawing.Color.IndianRed;
            this.btnInversao.Location = new System.Drawing.Point(211, 313);
            this.btnInversao.Name = "btnInversao";
            this.btnInversao.Size = new System.Drawing.Size(48, 39);
            this.btnInversao.TabIndex = 10;
            this.btnInversao.Text = "+/-";
            this.btnInversao.UseVisualStyleBackColor = true;
            this.btnInversao.Click += new System.EventHandler(this.btnInversao_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.IndianRed;
            this.btnC.Location = new System.Drawing.Point(49, 133);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(48, 39);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBackspace.Location = new System.Drawing.Point(157, 133);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(48, 39);
            this.btnBackspace.TabIndex = 9;
            this.btnBackspace.Text = "<=";
            this.btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCE.Location = new System.Drawing.Point(103, 133);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(48, 39);
            this.btnCE.TabIndex = 8;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDivide.Location = new System.Drawing.Point(211, 133);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(48, 39);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnEleva
            // 
            this.btnEleva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleva.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEleva.Location = new System.Drawing.Point(265, 133);
            this.btnEleva.Name = "btnEleva";
            this.btnEleva.Size = new System.Drawing.Size(70, 39);
            this.btnEleva.TabIndex = 0;
            this.btnEleva.Text = "x^2";
            this.btnEleva.UseVisualStyleBackColor = true;
            this.btnEleva.Click += new System.EventHandler(this.btnEleva_Click);
            // 
            // btnPower
            // 
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPower.Location = new System.Drawing.Point(265, 178);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(70, 39);
            this.btnPower.TabIndex = 0;
            this.btnPower.Text = "x^y";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnFracao
            // 
            this.btnFracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFracao.ForeColor = System.Drawing.Color.IndianRed;
            this.btnFracao.Location = new System.Drawing.Point(265, 268);
            this.btnFracao.Name = "btnFracao";
            this.btnFracao.Size = new System.Drawing.Size(70, 39);
            this.btnFracao.TabIndex = 0;
            this.btnFracao.Text = "1/x";
            this.btnFracao.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSqrt.Location = new System.Drawing.Point(265, 223);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(70, 39);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Text = "Sqrt(x)";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.IndianRed;
            this.btnIgual.Location = new System.Drawing.Point(265, 313);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(70, 39);
            this.btnIgual.TabIndex = 0;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 393);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnInversao);
            this.Controls.Add(this.bntPonto);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnFracao);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnEleva);
            this.Controls.Add(this.btnZero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button bntPonto;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnInversao;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEleva;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnFracao;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnIgual;
    }
}

