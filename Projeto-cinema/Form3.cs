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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void avancar_Click(object sender, EventArgs e)
        {
            ClubePontos ClubePontos = new ClubePontos();
            ClubePontos.ShowDialog();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void botaoAvancar_Click(object sender, EventArgs e)
        {
            ClubePontos ClubePontos = new ClubePontos();
            ClubePontos.ShowDialog();
        }
    }
}
