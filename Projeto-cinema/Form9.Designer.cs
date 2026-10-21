namespace Projeto_cinema
{
    partial class PicPay
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botaoVoltar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.botaoQRcode = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_cinema.Properties.Resources.MainContent__2_;
            this.pictureBox1.Location = new System.Drawing.Point(216, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1066, 98);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Image = global::Projeto_cinema.Properties.Resources.BotaoVoltar;
            this.botaoVoltar.Location = new System.Drawing.Point(12, 730);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(127, 41);
            this.botaoVoltar.TabIndex = 118;
            this.botaoVoltar.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projeto_cinema.Properties.Resources.Sidebar__5_;
            this.pictureBox3.Location = new System.Drawing.Point(-3, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 683);
            this.pictureBox3.TabIndex = 117;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Projeto_cinema.Properties.Resources.Footer__2_;
            this.pictureBox4.Location = new System.Drawing.Point(-3, 716);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1285, 69);
            this.pictureBox4.TabIndex = 119;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Projeto_cinema.Properties.Resources.Cabeçalho;
            this.pictureBox7.Location = new System.Drawing.Point(1, -5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1382, 52);
            this.pictureBox7.TabIndex = 116;
            this.pictureBox7.TabStop = false;
            // 
            // botaoQRcode
            // 
            this.botaoQRcode.Image = global::Projeto_cinema.Properties.Resources.qr_1__1;
            this.botaoQRcode.Location = new System.Drawing.Point(520, 177);
            this.botaoQRcode.Name = "botaoQRcode";
            this.botaoQRcode.Size = new System.Drawing.Size(380, 370);
            this.botaoQRcode.TabIndex = 121;
            this.botaoQRcode.TabStop = false;
            this.botaoQRcode.Click += new System.EventHandler(this.botaoQRcode_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(541, 565);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 49);
            this.textBox1.TabIndex = 122;
            this.textBox1.Text = "Tempo para realizar o pagamento: \r\n                      3 Minutos";
            // 
            // PicPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1279, 783);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botaoQRcode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Name = "PicPay";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox botaoVoltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox botaoQRcode;
        private System.Windows.Forms.TextBox textBox1;
    }
}