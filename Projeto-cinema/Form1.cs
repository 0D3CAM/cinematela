using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_cinema
{
    public partial class filme : Form
    {
        DAO bd = new DAO();
        DataTable dtFilmes;

        public filme()
        {
            InitializeComponent();
            RecarregarDados();
        }

        public void RecarregarDados()
        {
            dtFilmes = bd.BuscarFilmes();

            if (dtFilmes != null && dtFilmes.Rows.Count > 0)
            {
                Button[] botoes = { filme1, filme2, filme3, filme4, filme5, filme6 };

                for (int i = 0; i < botoes.Length; i++)
                {
                    if (i < dtFilmes.Rows.Count)
                    {
                        DataRow linha = dtFilmes.Rows[i];

                        botoes[i].Size = new Size(200, 260);

                        botoes[i].Text = linha["titulo"].ToString();
                        CapaBD(botoes[i], linha);
                        botoes[i].Visible = true;
                    }
                    else
                    {
                        botoes[i].Visible = false;
                    }
                }
            }
        }


        private void CapaBD(Button botao, DataRow linhaFilme)
        {
            try
            {
                string caminhoDoBanco = "";

                // Verifica qual nome de coluna de imagem veio do MySQL
                if (linhaFilme.Table.Columns.Contains("caminhoImagem") && linhaFilme["caminhoImagem"] != DBNull.Value)
                    caminhoDoBanco = linhaFilme["caminhoImagem"].ToString().Trim();
                else if (linhaFilme.Table.Columns.Contains("capa") && linhaFilme["capa"] != DBNull.Value)
                    caminhoDoBanco = linhaFilme["capa"].ToString().Trim();

                // Se o caminho existir no PC, carrega e ajusta no botão
                if (!string.IsNullOrEmpty(caminhoDoBanco) && File.Exists(caminhoDoBanco))
                {
                    byte[] bytesImagem = File.ReadAllBytes(caminhoDoBanco);
                    using (MemoryStream ms = new MemoryStream(bytesImagem))
                    {
                        Image imgOriginal = Image.FromStream(ms);
                        int largura = Math.Max(botao.Width - 20, 10);
                        int altura = Math.Max(botao.Height - 50, 10);

                        botao.Image = new Bitmap(imgOriginal, new Size(largura, altura));
                    }

                    botao.ImageAlign = ContentAlignment.TopCenter;
                    botao.TextAlign = ContentAlignment.BottomCenter;
                    botao.TextImageRelation = TextImageRelation.ImageAboveText;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar capa: " + ex.Message);
            }
        }

        private void AbrirSessao(int indexFilme)
        {
            try
            {
                if (dtFilmes != null && indexFilme < dtFilmes.Rows.Count)
                {
                    DataRow linhaFilme = dtFilmes.Rows[indexFilme];

                    int idFilme = Convert.ToInt32(linhaFilme["codigo"]);
                    string nomeFilme = linhaFilme["titulo"].ToString();

                    string caminhoCapa = "";
                    if (linhaFilme.Table.Columns.Contains("caminhoImagem"))
                        caminhoCapa = linhaFilme["caminhoImagem"].ToString();
                    else if (linhaFilme.Table.Columns.Contains("capa"))
                        caminhoCapa = linhaFilme["capa"].ToString();

                    selecionarSessao telaSessao = new selecionarSessao(idFilme, nomeFilme, caminhoCapa, this);
                    telaSessao.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a tela de sessão: " + ex.Message);
            }
        }

        // Eventos de clique dos 6 botões
        private void filme1_Click(object sender, EventArgs e) { AbrirSessao(0); }
        private void filme2_Click(object sender, EventArgs e) { AbrirSessao(1); }
        private void filme3_Click(object sender, EventArgs e) { AbrirSessao(2); }
        private void filme4_Click(object sender, EventArgs e) { AbrirSessao(3); }
        private void filme5_Click(object sender, EventArgs e) { AbrirSessao(4); }
        private void filme6_Click(object sender, EventArgs e) { AbrirSessao(5); }
    }
}

