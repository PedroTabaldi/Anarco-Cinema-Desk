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
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;


namespace Anarco_Cinema_Desk
{
    /// <summary>
    /// Interação lógica para Login.xam
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=root;";
            using (var connection = new MySqlConnection(connectionString))
            {
                
            }
        }

        private void bt_logar_Click(object sender, RoutedEventArgs e)
        {
            // Plano:
            // 1. Obter o texto do campo de email (TextBox).
            // 2. Conectar ao banco MySQL.
            // 3. Executar uma query para verificar se o email existe na tabela de usuários.
            // 4. Exibir mensagem de sucesso ou erro.

            string email = cx_email.Text.Trim(); // Supondo que o TextBox de email se chama txtEmail
            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=root;";
            bool emailExiste = false;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE Email = @Email";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    var result = cmd.ExecuteScalar();
                    if (result != null && Convert.ToInt32(result) > 0)
                    {
                        emailExiste = true;
                    }
                }
            }
            string senha = cx_senha.Text.Trim();
            string connectionString2 = "Server=localhost;Database=login;Uid=root;Pwd=root;";
            bool senhaExiste = false;

            using (var connection = new MySqlConnection(connectionString2))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE Senha = @Senha";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Senha", senha);
                    var result = cmd.ExecuteScalar();
                    if (result != null && Convert.ToInt32(result) > 0)
                    {
                        senhaExiste = true;
                    }
                }
            }

            if (emailExiste && senhaExiste)
            {
                
                NavigationService.Navigate(new Catalogo());
            }
            else
            {
                MessageBox.Show("Email não encontrado.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void bt_cadastrar_Click(object sender, RoutedEventArgs e)
        {
            // Navega para a página de cadastro sem verificar email ou senha
            NavigationService.Navigate(new Cadastro());
        }

        private void anarco_(object sender, MouseButtonEventArgs e)
        {

        }

        private void anarco_voltar(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Logar());
        }

        private void bt_cadastrar_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cadastro());
        }
    }
}
