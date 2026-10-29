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
    public partial class ClubePontos : Form
    {
        public ClubePontos()
        {
            InitializeComponent();
        }

        private void selecaoAssentos_Load(object sender, EventArgs e)
        {
           
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sim_Click(object sender, EventArgs e)
        {
            Form5 cartaoFiel = new Form5();
            cartaoFiel.ShowDialog();

        }

        private void nao_Click(object sender, EventArgs e)
        {
            Pagamento TelaPagamento = new Pagamento();
            TelaPagamento.ShowDialog();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void caixaSIM_Click(object sender, EventArgs e)
        {
            Form5 cartaoFiel = new Form5();
            cartaoFiel.ShowDialog();
        }

        private void caixaNAO_Click(object sender, EventArgs e)
        {
            Pagamento TelaPagamento = new Pagamento();
            TelaPagamento.ShowDialog();
        }

        private void labelSIM_Click(object sender, EventArgs e)
        {
            Form5 cartaoFiel = new Form5();
            cartaoFiel.ShowDialog();
        }

        private void labelNAO_Click(object sender, EventArgs e)
        {
            Pagamento TelaPagamento = new Pagamento();
            TelaPagamento.ShowDialog();
        }
    }
}
