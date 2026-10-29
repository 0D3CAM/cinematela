using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_cinema
{
    public class DAO
    {
        private MySqlConnection conexao = new MySqlConnection("server=localhost;database=clientecinema;uid=root;pwd=;");

        public DataTable BuscarFilmes()
        {
            DataTable dt = new DataTable();

            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                string query = "SELECT * FROM filme";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar filmes no banco: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            return dt;
        }

        public void CadastrarFilme(string titulo, string caminhoImagem)
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                string query = "INSERT INTO filme (titulo, caminhoImagem) VALUES (@titulo, @caminhoImagem)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@caminhoImagem", caminhoImagem);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Filme cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public DataTable BuscarFilmePorCodigo(int codigoFilme)
        {
            DataTable dt = new DataTable();

            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                string query = "SELECT * FROM filme WHERE codigo = @codigo";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigoFilme);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar filme no banco: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            return dt;
        }
    }
}