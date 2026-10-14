namespace Projeto_cinema
{
    partial class filme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.filme1 = new System.Windows.Forms.Button();
            this.filme2 = new System.Windows.Forms.Button();
            this.filme3 = new System.Windows.Forms.Button();
            this.filme4 = new System.Windows.Forms.Button();
            this.filme5 = new System.Windows.Forms.Button();
            this.filme6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ajuda = new System.Windows.Forms.TextBox();
            this.selecao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "CineFlix";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 24);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "1. Selecione o Filme";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(12, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 24);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "2. Sessão";
            // 
            // filme1
            // 
            this.filme1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.filme1.ForeColor = System.Drawing.Color.Black;
            this.filme1.Location = new System.Drawing.Point(217, 84);
            this.filme1.Name = "filme1";
            this.filme1.Size = new System.Drawing.Size(100, 139);
            this.filme1.TabIndex = 3;
            this.filme1.Text = "Toy Story 5";
            this.filme1.UseVisualStyleBackColor = true;
            this.filme1.Click += new System.EventHandler(this.filme1_Click);
            // 
            // filme2
            // 
            this.filme2.Location = new System.Drawing.Point(395, 84);
            this.filme2.Name = "filme2";
            this.filme2.Size = new System.Drawing.Size(100, 139);
            this.filme2.TabIndex = 4;
            this.filme2.Text = "Filme 2";
            this.filme2.UseVisualStyleBackColor = true;
            this.filme2.Click += new System.EventHandler(this.filme2_Click);
            // 
            // filme3
            // 
            this.filme3.Location = new System.Drawing.Point(562, 84);
            this.filme3.Name = "filme3";
            this.filme3.Size = new System.Drawing.Size(100, 139);
            this.filme3.TabIndex = 5;
            this.filme3.Text = "Filme 3";
            this.filme3.UseVisualStyleBackColor = true;
            this.filme3.Click += new System.EventHandler(this.filme3_Click);
            // 
            // filme4
            // 
            this.filme4.Location = new System.Drawing.Point(217, 257);
            this.filme4.Name = "filme4";
            this.filme4.Size = new System.Drawing.Size(100, 142);
            this.filme4.TabIndex = 6;
            this.filme4.Text = "Filme 4";
            this.filme4.UseVisualStyleBackColor = true;
            this.filme4.Click += new System.EventHandler(this.filme4_Click);
            // 
            // filme5
            // 
            this.filme5.Location = new System.Drawing.Point(395, 257);
            this.filme5.Name = "filme5";
            this.filme5.Size = new System.Drawing.Size(100, 142);
            this.filme5.TabIndex = 7;
            this.filme5.Text = "Filme 5";
            this.filme5.UseVisualStyleBackColor = true;
            this.filme5.Click += new System.EventHandler(this.filme5_Click);
            // 
            // filme6
            // 
            this.filme6.Location = new System.Drawing.Point(562, 257);
            this.filme6.Name = "filme6";
            this.filme6.Size = new System.Drawing.Size(100, 142);
            this.filme6.TabIndex = 8;
            this.filme6.Text = "Filme 6";
            this.filme6.UseVisualStyleBackColor = true;
            this.filme6.Click += new System.EventHandler(this.filme6_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(12, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 24);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "3. Seleção de Assentos";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(12, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 24);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "4. Clube de Pontos";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(12, 273);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 24);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "5. Pagamento";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(12, 323);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(162, 24);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "6. Confirmação";
            // 
            // ajuda
            // 
            this.ajuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajuda.ForeColor = System.Drawing.Color.White;
            this.ajuda.Location = new System.Drawing.Point(12, 402);
            this.ajuda.Name = "ajuda";
            this.ajuda.Size = new System.Drawing.Size(144, 24);
            this.ajuda.TabIndex = 13;
            this.ajuda.Text = "Precisa de Ajuda?";
            this.ajuda.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // selecao
            // 
            this.selecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.selecao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecao.ForeColor = System.Drawing.Color.White;
            this.selecao.Location = new System.Drawing.Point(217, 37);
            this.selecao.Name = "selecao";
            this.selecao.Size = new System.Drawing.Size(174, 22);
            this.selecao.TabIndex = 14;
            this.selecao.Text = "Selecione o Filme";
            // 
            // filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selecao);
            this.Controls.Add(this.ajuda);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.filme6);
            this.Controls.Add(this.filme5);
            this.Controls.Add(this.filme4);
            this.Controls.Add(this.filme3);
            this.Controls.Add(this.filme2);
            this.Controls.Add(this.filme1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "filme";
            this.Text = "Selecionar Filme";
            this.Load += new System.EventHandler(this.filme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button filme1;
        private System.Windows.Forms.Button filme2;
        private System.Windows.Forms.Button filme3;
        private System.Windows.Forms.Button filme4;
        private System.Windows.Forms.Button filme5;
        private System.Windows.Forms.Button filme6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox ajuda;
        private System.Windows.Forms.TextBox selecao;
    }
}

