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
    public partial class PicPay : Form
    {
        public PicPay()
        {
            InitializeComponent();
        }

        private void botaoQRcode_Click(object sender, EventArgs e)
        {
            concluido pagamentoConcluido = new concluido();
            pagamentoConcluido.ShowDialog();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
