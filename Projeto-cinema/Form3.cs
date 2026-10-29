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
        private int idFilme;
        private string nomeFilme;
        private string horario;
        private string tipoSala;
        private Form telaAnterior;

        public Form3(int idFilme, string nomeFilme, string horario, string tipoSala, Form telaAnterior)
        {
            InitializeComponent();
            this.idFilme = idFilme;
            this.nomeFilme = nomeFilme;
            this.horario = horario;
            this.tipoSala = tipoSala;
            this.telaAnterior = telaAnterior;
        }
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
            this.Close();
        }
    }
}
