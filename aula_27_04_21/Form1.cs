using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_27_04_21
{
    public partial class Form1 : Form
    {
        // Monta o caminho ate o arquivo de banco de dados
        readonly string caminhoBancoDados = @"C:\Users\yasmi\source\repos\aula_27_04_21\aula_27_04_21\database\database.mdf";

        // Monta a string de conexao com o banco de dados 
        //private string 

        public Form1()
        {
            InitializeComponent();
        }
        // void = sem retorno, nao vai retornar nada para quem esta chamando o metodo 

        private int ExecutarSql(string sql, List<(string name, object value)> parametros)
        {
            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                              @$"AttachDbFilename={caminhoBancoDados};" +
                                              @"Integrated Security=True;Connect Timeout=30";

            // Executa a conexao com o Banco de Dados
            var connection = new System.Data.SqlClient.SqlConnection
            {
                ConnectionString = connString
            };
            // Abre a conexao
            connection.Open();

            try
            {
                var command = connection.CreateCommand();

                // Monta o string SQL para a tabela clientes
                command.CommandText = sql;

                foreach (var (name, value) in parametros)
                {
                    command.Parameters.AddWithValue(name, value);

                }

                int rowAffected = command.ExecuteNonQuery();

                return rowAffected;
            }
            finally
            {
                // Fecha a conexao com o banco de dados
                connection.Close();
            }

        }

        private void LimparDados()
        {
            text_codigo.Clear();
            text_cnpj.Clear();
            text_nome.Clear();
            text_rua.Clear();
            text_cep.Clear();
        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            var codigo = text_codigo.Text;
            var cnpj = text_cnpj.Text;
            var nome = text_nome.Text;
            var rua = text_rua.Text;
            var cep = text_cep.Text;

            try
            {
                var sql = "INSERT INTO Clientes  " +
                    " (Codigo, CNPJ, Razao_Social,Rua, Cep)" +
                    "VALUES " +
                    " (@Codigo, @Cnpj, @Razao_Social, @Rua, @Cep);";
                // Cria o comando do SQL na conexao aberta

                var parametros = new List<(string name, object value)>
                {
                    ("Codigo", codigo),
                    ("Cnpj", cnpj),
                    ("Razao_Social", nome),
                    ("Rua", rua),
                    ("Cep", cep)
                };

                // Metodo para executar o comando SQL que nao retorna dados
                int rowAffected = ExecutarSql(sql, parametros);

                MessageBox.Show("Dados inseridos com sucesso");

                // Limpa os dados em tela 

                LimparDados();

                PopularDataGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocorreu um erro: " + exception.Message);

            }
        }

        private void Button_atualizar_Click(object sender, EventArgs e)
        {
            var codigo = text_codigo.Text;
            var cnpj = text_cnpj.Text;
            var nome = text_nome.Text;
            var rua = text_rua.Text;
            var cep = text_cep.Text;

            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                           @$"AttachDbFilename={caminhoBancoDados};" +
                                           @"Integrated Security=True;Connect Timeout=30";

            // Executa a conexao com o Banco de Dados
            var connection = new System.Data.SqlClient.SqlConnection
            {
                ConnectionString = connString
            };
            // Abre a conexao
            connection.Open();
            try
            {
                // Cria o comando do SQL na conexao aberta
                var command = connection.CreateCommand();

                // Monta o string SQL para a tabela clientes
                command.CommandText = "UPDATE Clientes SET   " +
                    " Codigo = @Codigo, Razao_Social = @Razao_Social," +
                    " Rua = @Rua, Cep = @Cep" +
                    " WHERE CNPJ = @Cnpj;";

                command.Parameters.AddWithValue("Codigo", codigo);
                command.Parameters.AddWithValue("Cnpj", cnpj);
                command.Parameters.AddWithValue("Razao_Social", nome);
                command.Parameters.AddWithValue("Rua", rua);
                command.Parameters.AddWithValue("Cep", cep);

                // Metodo para executar o comando SQL que nao retorna dados
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected == 0)
                {
                    MessageBox.Show("Nenhuma linha encontrada.");
                }
                else
                {
                    MessageBox.Show("Dados alterados com sucesso");
                }

                connection.Close();

                // Limpa os dados em tela 
                LimparDados();

                PopularDataGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocorreu um erro: " + exception.Message);

                // Fecha a conexao com o banco de dados
                connection.Close();
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            var cnpj = text_cnpj.Text;

            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                           @$"AttachDbFilename={caminhoBancoDados};" +
                                           @"Integrated Security=True;Connect Timeout=30";

            // Executa a conexao com o Banco de Dados
            var connection = new System.Data.SqlClient.SqlConnection
            {
                ConnectionString = connString
            };
            // Abre a conexao
            connection.Open();
            try
            {
                // Cria o comando do SQL na conexao aberta
                var command = connection.CreateCommand();

                command.CommandText = "DELETE FROM Clientes WHERE cnpj = @Cnpj;";

                command.Parameters.AddWithValue("Cnpj", cnpj);

                // Metodo para executar o comando SQL que nao retorna dados
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected == 0)
                {
                    MessageBox.Show("Nenhuma linha encontrada.");
                }
                else
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                }

                connection.Close();

                // Limpa os dados em tela 
                LimparDados();

                PopularDataGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao deletar: " + exception.Message);
                connection.Close();
            }
        }

        private void PopularDataGrid()
        {
            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                           @$"AttachDbFilename={caminhoBancoDados};" +
                                           @"Integrated Security=True;Connect Timeout=30";

            var connection = new System.Data.SqlClient.SqlConnection
            {
                ConnectionString = connString
            };
            // Abre a conexao
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = "SELECT Codigo, CNPJ, " +
                                         "Razao_Social, Rua, Cep" +
                                  " FROM Clientes;";

            var reader = command.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);

            this.dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopularDataGrid();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataTable = (DataTable)this.dataGridView1.DataSource;

            var row = dataTable.Rows[e.RowIndex];

            text_codigo.Text = (string)row[0];
            text_cnpj.Text = (string)row[1];
            text_nome.Text = (string)row[2];
            text_rua.Text = (string)row[3];
            text_cep.Text = (string)row[4];
        }
    }

}

