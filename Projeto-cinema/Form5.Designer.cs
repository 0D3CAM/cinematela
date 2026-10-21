namespace Projeto_cinema
{
    partial class Form5
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
            this.botaoAvancar02 = new System.Windows.Forms.PictureBox();
            this.botaoVoltar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.botaoAvancar02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoAvancar02
            // 
            this.botaoAvancar02.Image = global::Projeto_cinema.Properties.Resources.BotaoAvancar__1_;
            this.botaoAvancar02.Location = new System.Drawing.Point(999, 619);
            this.botaoAvancar02.Name = "botaoAvancar02";
            this.botaoAvancar02.Size = new System.Drawing.Size(263, 56);
            this.botaoAvancar02.TabIndex = 113;
            this.botaoAvancar02.TabStop = false;
            this.botaoAvancar02.Click += new System.EventHandler(this.botaoAvancar02_Click);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Image = global::Projeto_cinema.Properties.Resources.BotaoVoltar;
            this.botaoVoltar.Location = new System.Drawing.Point(46, 619);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(127, 41);
            this.botaoVoltar.TabIndex = 112;
            this.botaoVoltar.TabStop = false;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projeto_cinema.Properties.Resources.Footer;
            this.pictureBox3.Location = new System.Drawing.Point(-6, 612);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1473, 63);
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projeto_cinema.Properties.Resources.Sidebar__3_;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 568);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Projeto_cinema.Properties.Resources.Cabeçalho;
            this.pictureBox7.Location = new System.Drawing.Point(-6, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1382, 49);
            this.pictureBox7.TabIndex = 106;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_cinema.Properties.Resources.cartaoFidelidade;
            this.pictureBox1.Location = new System.Drawing.Point(431, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 543);
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1274, 672);
            this.Controls.Add(this.botaoAvancar02);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "CartaoFiel";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botaoAvancar02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox botaoVoltar;
        private System.Windows.Forms.PictureBox botaoAvancar02;
    }
}