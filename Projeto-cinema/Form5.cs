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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void avancarPagamento_Click(object sender, EventArgs e)
        {
            Pagamento TelaPagamento = new Pagamento();
            TelaPagamento.ShowDialog();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void botaoAvancar02_Click(object sender, EventArgs e)
        {
            Pagamento TelaPagamento = new Pagamento();
            TelaPagamento.ShowDialog();
            this.Close();
        }
    }
}
