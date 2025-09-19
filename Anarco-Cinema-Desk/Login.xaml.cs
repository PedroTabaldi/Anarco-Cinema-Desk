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
            //using (var connection = new SqliteConnection(connectionString))
            //{
            //    connection.Open();

            //    string createTable = @"
            //        CREATE TABLE IF NOT EXISTS Pessoas (
            //         Id INTEGER PRIMARY KEY,
            //         Nome TEXT
            //         );";
            //    var cmd = new SQLiteCommand(createTable, connection);
            //    cmd.ExecuteNonQuery();

            //}
        }
    }
}
