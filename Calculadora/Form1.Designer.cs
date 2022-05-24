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
            this.txtbox_resultado = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_vezes = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_dividido = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_resultado
            // 
            this.txtbox_resultado.Location = new System.Drawing.Point(26, 47);
            this.txtbox_resultado.Name = "txtbox_resultado";
            this.txtbox_resultado.Size = new System.Drawing.Size(314, 22);
            this.txtbox_resultado.TabIndex = 0;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(26, 97);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(69, 23);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(214, 97);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(119, 97);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_mais
            // 
            this.btn_mais.Location = new System.Drawing.Point(307, 97);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(33, 23);
            this.btn_mais.TabIndex = 4;
            this.btn_mais.Text = "+";
            this.btn_mais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mais.UseVisualStyleBackColor = true;
            this.btn_mais.Click += new System.EventHandler(this.operadores);
            // 
            // btn_menos
            // 
            this.btn_menos.Location = new System.Drawing.Point(307, 142);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(33, 23);
            this.btn_menos.TabIndex = 8;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.operadores);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(119, 142);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 23);
            this.btn_5.TabIndex = 7;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(214, 142);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 23);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(26, 142);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(69, 23);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_vezes
            // 
            this.btn_vezes.Location = new System.Drawing.Point(307, 235);
            this.btn_vezes.Name = "btn_vezes";
            this.btn_vezes.Size = new System.Drawing.Size(33, 23);
            this.btn_vezes.TabIndex = 16;
            this.btn_vezes.Text = "*";
            this.btn_vezes.UseVisualStyleBackColor = true;
            this.btn_vezes.Click += new System.EventHandler(this.operadores);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(119, 235);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 23);
            this.btn_0.TabIndex = 15;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(214, 235);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(75, 23);
            this.btn_igual.TabIndex = 14;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(26, 235);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(69, 23);
            this.btn_limpar.TabIndex = 13;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_dividido
            // 
            this.btn_dividido.Location = new System.Drawing.Point(307, 191);
            this.btn_dividido.Name = "btn_dividido";
            this.btn_dividido.Size = new System.Drawing.Size(33, 23);
            this.btn_dividido.TabIndex = 12;
            this.btn_dividido.Text = "/";
            this.btn_dividido.UseVisualStyleBackColor = true;
            this.btn_dividido.Click += new System.EventHandler(this.operadores);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(119, 191);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 23);
            this.btn_8.TabIndex = 11;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(214, 191);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 23);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(26, 191);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(69, 23);
            this.btn_7.TabIndex = 9;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.gerarnumero);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 304);
            this.Controls.Add(this.btn_vezes);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_dividido);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_mais);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txtbox_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_resultado;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_mais;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_vezes;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_dividido;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_7;
    }
}

