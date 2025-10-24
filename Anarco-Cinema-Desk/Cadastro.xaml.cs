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

            // Exemplo simples de inserção no banco de dados usando MySql.Data
            // Ajuste a string de conexão conforme necessário
            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=root;";
            string query = "INSERT INTO usuarios (Email, Senha) VALUES (@Email, @Senha)";

            try
            {
                using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("E-mail e senha cadastrados com sucesso!");
                NavigationService.Navigate(new Login());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }
    }
}
