using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        string connString = "datasource=localhost;username=root;" +
        "password=; database = db_agenda";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar a conexão com o MySQL
                Conexao = new MySqlConnection(connString);
                //Cria a conexão para inserir os dados
                string sql = "INSERT INTO contatos (nome,email,telefone) " +
                "VALUES ('" + txtNome.Text + "','" + txtEmail.Text + "'," +
                "'" + txtTelefone.Text + "')";
                //Cria o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                //Abre a conexão
                Conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato salvo com sucesso!!!",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao salvar o contato!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fechando a conexão
                Conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria a string SQL para consultar os dados

                string query = "'" + txtLocalizar.Text + "'";
                //cria a conexão com o mysql
                Conexao = new MySqlConnection(connString);
                //cria a string SQL para inserir dados
                string sql = "SELECT * " +
                "FROM contatos" +
                "WHERE nome LIKE " + query + "OR email like" + query;
                //CRIA O COMANDO SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                //Abre a conexão
                Conexao.Open();

                //Executa o comando
                MySqlDataReader reader = comando.ExecuteReader();
                //limpa a lista
                listView.Items.Clear();
                //lê os dados retornados
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader[0].ToString(),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),

};
                    //Cria um novo ListView com os dados lidos
                    var linha_listview = new ListViewItem(row);

                    //adiciona o listViewItem à lista
                    listView.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar registro no banco" + ex.Message);

            }
            finally
            {
                //fecha a conexão
                if (Conexao != null)
                {
                    Conexao.Close();
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE contatos SET " +
                    "nome='" + txtNome.Text + "'," +
                    "email='" + txtEmail.Text + "'," +
                    "telefone='" + txtTelefone.Text + "' " +
                    "WHERE id=" + txtLocalizar.Text;

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@id", txtLocalizar.Text);

                Conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Contato alterado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o contato! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }

        }
    }
}