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
            this.filme1 = new System.Windows.Forms.Button();
            this.filme2 = new System.Windows.Forms.Button();
            this.filme3 = new System.Windows.Forms.Button();
            this.filme4 = new System.Windows.Forms.Button();
            this.filme5 = new System.Windows.Forms.Button();
            this.filme6 = new System.Windows.Forms.Button();
            this.selecao = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filme1
            // 
            this.filme1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.filme1.ForeColor = System.Drawing.Color.Black;
            this.filme1.Location = new System.Drawing.Point(392, 146);
            this.filme1.Name = "filme1";
            this.filme1.Size = new System.Drawing.Size(122, 170);
            this.filme1.TabIndex = 3;
            this.filme1.Text = "Toy Story 5";
            this.filme1.UseVisualStyleBackColor = true;
            this.filme1.Click += new System.EventHandler(this.filme1_Click);
            // 
            // filme2
            // 
            this.filme2.Location = new System.Drawing.Point(659, 146);
            this.filme2.Name = "filme2";
            this.filme2.Size = new System.Drawing.Size(127, 170);
            this.filme2.TabIndex = 4;
            this.filme2.Text = "Filme 2";
            this.filme2.UseVisualStyleBackColor = true;
            this.filme2.Click += new System.EventHandler(this.filme2_Click);
            // 
            // filme3
            // 
            this.filme3.Location = new System.Drawing.Point(936, 146);
            this.filme3.Name = "filme3";
            this.filme3.Size = new System.Drawing.Size(123, 170);
            this.filme3.TabIndex = 5;
            this.filme3.Text = "Filme 3";
            this.filme3.UseVisualStyleBackColor = true;
            this.filme3.Click += new System.EventHandler(this.filme3_Click);
            // 
            // filme4
            // 
            this.filme4.Location = new System.Drawing.Point(392, 391);
            this.filme4.Name = "filme4";
            this.filme4.Size = new System.Drawing.Size(122, 164);
            this.filme4.TabIndex = 6;
            this.filme4.Text = "Filme 4";
            this.filme4.UseVisualStyleBackColor = true;
            this.filme4.Click += new System.EventHandler(this.filme4_Click);
            // 
            // filme5
            // 
            this.filme5.Location = new System.Drawing.Point(659, 391);
            this.filme5.Name = "filme5";
            this.filme5.Size = new System.Drawing.Size(127, 164);
            this.filme5.TabIndex = 7;
            this.filme5.Text = "Filme 5";
            this.filme5.UseVisualStyleBackColor = true;
            this.filme5.Click += new System.EventHandler(this.filme5_Click);
            // 
            // filme6
            // 
            this.filme6.Location = new System.Drawing.Point(936, 391);
            this.filme6.Name = "filme6";
            this.filme6.Size = new System.Drawing.Size(123, 164);
            this.filme6.TabIndex = 8;
            this.filme6.Text = "Filme 6";
            this.filme6.UseVisualStyleBackColor = true;
            this.filme6.Click += new System.EventHandler(this.filme6_Click);
            // 
            // selecao
            // 
            this.selecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.selecao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecao.ForeColor = System.Drawing.Color.White;
            this.selecao.Location = new System.Drawing.Point(314, 104);
            this.selecao.Name = "selecao";
            this.selecao.Size = new System.Drawing.Size(174, 22);
            this.selecao.TabIndex = 14;
            this.selecao.Text = "Selecione o Filme";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projeto_cinema.Properties.Resources.Sidebar__7_;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 623);
            this.pictureBox2.TabIndex = 121;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_cinema.Properties.Resources.Cabeçalho;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1285, 43);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1275, 664);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selecao);
            this.Controls.Add(this.filme6);
            this.Controls.Add(this.filme5);
            this.Controls.Add(this.filme4);
            this.Controls.Add(this.filme3);
            this.Controls.Add(this.filme2);
            this.Controls.Add(this.filme1);
            this.Name = "filme";
            this.Text = "6";
            this.Load += new System.EventHandler(this.filme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button filme1;
        private System.Windows.Forms.Button filme2;
        private System.Windows.Forms.Button filme3;
        private System.Windows.Forms.Button filme4;
        private System.Windows.Forms.Button filme5;
        private System.Windows.Forms.Button filme6;
        private System.Windows.Forms.TextBox selecao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

