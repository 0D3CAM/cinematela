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
    public partial class filme : Form
    {
        public filme()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void filme_Load(object sender, EventArgs e)
        {

        }

        private void filme1_Click(object sender, EventArgs e)
        {
            selecionarSessao selecionarSessao = new selecionarSessao();
            selecionarSessao.ShowDialog();

        }

        private void filme2_Click(object sender, EventArgs e)
        {
            selecionarSessao selecionarSessao = new selecionarSessao();
            selecionarSessao.ShowDialog();
        }

        private void filme3_Click(object sender, EventArgs e)
        {
            selecionarSessao selecionarSessao = new selecionarSessao();
            selecionarSessao.ShowDialog();
        }

        private void filme4_Click(object sender, EventArgs e)
        {
            selecionarSessao selecionarSessao = new selecionarSessao();
            selecionarSessao.ShowDialog();
        }

        private void filme5_Click(object sender, EventArgs e)
        {
            selecionarSessao selecionarSessao = new selecionarSessao();
            selecionarSessao.ShowDialog();
        }

        private void filme6_Click(object sender, EventArgs e)
        {
            selecionarSessao selecionarSessao = new selecionarSessao();
            selecionarSessao.ShowDialog();
        }
    }
}
