using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projeto_cinema
{
    public partial class selecionarSessao : Form
    {
        DAO bd = new DAO();
        DataTable dtSessoes;
        private int idFilme;
        private string nomeFilme;
        private string caminhoCapa;
        private Form telaAnterior;


        public selecionarSessao(int idFilme, string nomeFilme, string caminhoCapa, Form telaAnterior)
        {
            InitializeComponent();
            this.idFilme = idFilme;
            this.nomeFilme = nomeFilme;
            this.caminhoCapa = caminhoCapa;
            this.telaAnterior = telaAnterior;
        }

        public void CarregarSessoesDoBanco()
        {
            DataTable dtFilme = bd.BuscarFilmePorCodigo(this.idFilme);

            if (dtFilme != null && dtFilme.Rows.Count > 0)
            {
                DataRow linha = dtFilme.Rows[0];

                if (linha.Table.Columns.Contains("horarios") && linha["horarios"] != DBNull.Value)
                {
                    string stringHorarios = linha["horarios"].ToString();

                    string[] listaHorarios = stringHorarios.Split(',');

                    Button[] botoesHorarios = { horario1, horario2, horario3, horario4, horario5, horario6 };

                    for (int i = 0; i < botoesHorarios.Length; i++)
                    {
                        if (i < listaHorarios.Length)
                        {
                            botoesHorarios[i].Text = listaHorarios[i].Trim();
                            botoesHorarios[i].Visible = true;
                        }
                        else
                        {
                            botoesHorarios[i].Visible = false;
                        }
                    }
                }
            }
        
        }

        public void FiltrarHorariosPorDia(string dataFormatada)
        {
            Button[] botoes2D = { horario1, horario2, horario3, horario4 };

            DataRow[] sessoesDoDia = dtSessoes.Select($"data_sessao = '{dataFormatada}'");

            for (int i = 0; i < botoes2D.Length; i++)
            {
                if (i < sessoesDoDia.Length)
                {
                    botoes2D[i].Text = sessoesDoDia[i]["horario"].ToString();
                    botoes2D[i].Visible = true;
                }
                else
                {
                    botoes2D[i].Visible = false;
                }
            }
        }

        

        private void selecionarSessao_Load(object sender, EventArgs e)
        {
            filme1.Text = this.nomeFilme;

            if (!string.IsNullOrEmpty(this.caminhoCapa) && File.Exists(this.caminhoCapa))
            {
                byte[] bytesImagem = File.ReadAllBytes(this.caminhoCapa);
                using (MemoryStream ms = new MemoryStream(bytesImagem))
                {
                    Image imgOriginal = Image.FromStream(ms);

                    int largura = Math.Max(filme1.Width - 10, 10);
                    int altura = Math.Max(filme1.Height - 40, 10);

                    filme1.Image = new Bitmap(imgOriginal, new Size(largura, altura));
                }

                filme1.ImageAlign = ContentAlignment.TopCenter;
                filme1.TextAlign = ContentAlignment.BottomCenter;
                filme1.TextImageRelation = TextImageRelation.ImageAboveText;
                CarregarSessoesDoBanco();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (this.telaAnterior != null)
            {
                this.telaAnterior.Show();
            }
            this.Close();
        }

        private void horario1_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(horario1.Text)) AbrirForm3(horario1.Text, "2D"); }
        private void horario2_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(horario2.Text)) AbrirForm3(horario2.Text, "2D"); }
        private void horario3_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(horario3.Text)) AbrirForm3(horario3.Text, "2D"); }
        private void horario4_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(horario4.Text)) AbrirForm3(horario4.Text, "2D"); }
        private void horario5_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(horario5.Text)) AbrirForm3(horario5.Text, "2D"); }
        private void horario6_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(horario6.Text)) AbrirForm3(horario6.Text, "2D"); }

        private void imax1_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(imax1.Text)) AbrirForm3(imax1.Text, "IMAX"); }
        private void imax2_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(imax2.Text)) AbrirForm3(imax2.Text, "IMAX"); }
        private void imax3_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(imax3.Text)) AbrirForm3(imax3.Text, "IMAX"); }
        private void imax4_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(imax4.Text)) AbrirForm3(imax4.Text, "IMAX"); }
        private void imax5_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(imax5.Text)) AbrirForm3(imax5.Text, "IMAX"); }


        private void filme1_Click(object sender, EventArgs e) { }
        private void filme_Load(object sender, EventArgs e)
        {
        }

        private void dia1_Click(object sender, EventArgs e) { if (dia1.Tag != null) FiltrarHorariosPorDia(dia1.Tag.ToString()); }
        private void dia2_Click(object sender, EventArgs e) { if (dia2.Tag != null) FiltrarHorariosPorDia(dia2.Tag.ToString()); }
        private void dia3_Click(object sender, EventArgs e) { if (dia3.Tag != null) FiltrarHorariosPorDia(dia3.Tag.ToString()); }
        private void dia4_Click(object sender, EventArgs e) { if (dia4.Tag != null) FiltrarHorariosPorDia(dia4.Tag.ToString()); }
        private void dia5_Click(object sender, EventArgs e) { if (dia5.Tag != null) FiltrarHorariosPorDia(dia5.Tag.ToString()); } 

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            if (this.telaAnterior != null)
            {
                this.telaAnterior.Show();
            }
            this.Close();
        }
        private void AbrirForm3(string horarioSelecionado, string tipoSala)
        {
            Form3 telaAssentos = new Form3(this.idFilme, this.nomeFilme, horarioSelecionado, tipoSala, this);

            telaAssentos.Show();

            this.Hide();
        }
    }
}
    