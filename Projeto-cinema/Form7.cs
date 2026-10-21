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
    public partial class pagamentoPIX : Form
    {
        public pagamentoPIX()
        {
            InitializeComponent();
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagamentoPIX_Load(object sender, EventArgs e)
        {

        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void botaoQRcode_Click(object sender, EventArgs e)
        {
            concluido pagamentoConcluido = new concluido();
            pagamentoConcluido.ShowDialog();
        }
    }
}
