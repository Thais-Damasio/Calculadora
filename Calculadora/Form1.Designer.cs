namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.btnSom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNegativo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(21, 89);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(21, 135);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(21, 181);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(67, 181);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(67, 135);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(67, 89);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(113, 181);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btn0
            // 
            this.btn0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn0.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(21, 227);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(159, 181);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(40, 40);
            this.btnMul.TabIndex = 13;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.Operacao_Click);
            this.btnMul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(205, 135);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(40, 40);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.Operacao_Click);
            this.btnSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(205, 181);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(40, 40);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.Operacao_Click);
            this.btnDiv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // tela
            // 
            this.tela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tela.Enabled = false;
            this.tela.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tela.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tela.Location = new System.Drawing.Point(21, 20);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(227, 15);
            this.tela.TabIndex = 17;
            this.tela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Resultado
            // 
            this.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resultado.Enabled = false;
            this.Resultado.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Resultado.Location = new System.Drawing.Point(21, 36);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(227, 29);
            this.Resultado.TabIndex = 17;
            this.Resultado.Text = "0";
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(159, 227);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(86, 40);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.Igual_Click);
            this.btnIgual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(113, 227);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(40, 40);
            this.btnVirgula.TabIndex = 16;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.InserirNumero_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(205, 89);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(40, 40);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(113, 89);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(113, 135);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.InserirNumero_Click);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.Location = new System.Drawing.Point(159, 89);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(40, 40);
            this.btnLimparTudo.TabIndex = 3;
            this.btnLimparTudo.Text = "CE";
            this.btnLimparTudo.UseVisualStyleBackColor = true;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            this.btnLimparTudo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // btnSom
            // 
            this.btnSom.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSom.Location = new System.Drawing.Point(159, 135);
            this.btnSom.Name = "btnSom";
            this.btnSom.Size = new System.Drawing.Size(40, 40);
            this.btnSom.TabIndex = 8;
            this.btnSom.Text = "+";
            this.btnSom.UseVisualStyleBackColor = true;
            this.btnSom.Click += new System.EventHandler(this.Operacao_Click);
            this.btnSom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Create By Thaís Damásio";
            // 
            // btnNegativo
            // 
            this.btnNegativo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNegativo.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegativo.Location = new System.Drawing.Point(67, 227);
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Size = new System.Drawing.Size(40, 40);
            this.btnNegativo.TabIndex = 22;
            this.btnNegativo.Text = "M";
            this.btnNegativo.UseVisualStyleBackColor = true;
            this.btnNegativo.Click += new System.EventHandler(this.btnNegativo_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 297);
            this.Controls.Add(this.btnNegativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSom);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox tela;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNegativo;
    }
}

