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
            // Supondo que cx_email_re e cx_senha_re são TextBox no XAML
            string email = cx_email_re.Text;
            string senha = cx_senha_re.Text;
            string nome = cx_nome.Text;

            // Exemplo simples de inserção no banco de dados usando MySql.Data
            // Ajuste a string de conexão conforme necessário
            string query = "INSERT INTO usuarios (Email, Senha) VALUES (@Email, @Senha)";
            string nomes = $"SELECT * FROM estrela";

            try
            {
                MySqlCommand cmd = new MySqlCommand(nomes, ConecxaoBanco.Conecxao);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nomeExistente = reader.GetString("Nome");

                    if (nomeExistente == nome)
                    {
                        MessageBox.Show("Nome já cadastrado: " + nomeExistente);
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        string querynome = "INSERT INTO estrela (Nome) VALUES (@Nome)";
                        using (var command = new MySqlCommand(querynome, ConecxaoBanco.Conecxao))
                        {
                            command.Parameters.AddWithValue("@Nome", nome);
                            command.ExecuteNonQuery();
                        }

                        using (var command = new MySqlCommand(query, ConecxaoBanco.Conecxao))
                        {
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Senha", senha);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("E-mail e senha cadastrados com sucesso!");
                        NavigationService.Navigate(new Login());
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }
    }
}
