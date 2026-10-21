using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_cinema
{
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opcaoPix_Click(object sender, EventArgs e)
        {
            pagamentoPIX pix = new pagamentoPIX();
            pix.ShowDialog();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picPay_Click(object sender, EventArgs e)
        {
            PicPay pagamentoPicPay = new PicPay();
            pagamentoPicPay.ShowDialog();
        }
    }
}
