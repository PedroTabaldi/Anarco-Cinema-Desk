using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Anarco_Cinema_Desk
{
    /// <summary>
    /// Interação lógica para Cadastro.xam
    /// </summary>
    public partial class Cadastro : Page
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void anarco_voltar(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cx_nome.Text) || string.IsNullOrEmpty(cx_email_re.Text) || string.IsNullOrEmpty(cx_senha_re.Password))
            {
                MessageBox.Show("Por favor, insira os dados");
                return;
            }

            // Supondo que cx_email_re e cx_senha_re são TextBox no XAML
            string email = cx_email_re.Text;
            string senha = cx_senha_re.Password;
            string nome = cx_nome.Text;

            // Exemplo simples de inserção no banco de dados usando MySql.Data
            // Ajuste a string de conexão conforme necessário
            string nomes = $"SELECT Nome FROM estrela";
            var nomeExiste = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(nomes, ConecxaoBanco.Conecxao);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Nome"].ToString() == nome)
                    {
                        nomeExiste = true;
                    }
                    //string nomeExistente = reader.GetString("Nome");
                }

                reader.Close();
                if (nomeExiste)
                {
                    MessageBox.Show("Nome já cadastrado: " + nome);
                }
                else
                {
                    string querynome = "INSERT INTO estrela (Nome) VALUES (@Nome)";
                    using (var command = new MySqlCommand(querynome, ConecxaoBanco.Conecxao))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.ExecuteNonQuery();
                    }

                    string query = "INSERT INTO usuarios (Email, Senha, Nome) VALUES (@Email, @Senha, @Nome)";
                    using (var command = new MySqlCommand(query, ConecxaoBanco.Conecxao))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("E-mail e senha cadastrados com sucesso!");
                    NavigationService.Navigate(new Login());
                }


                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void cx_nome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
