using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Anarco_Cinema_Desk
{
    internal class ConecxaoBanco
    {
        public static MySqlConnection? Conecxao { get; private set; }

        public static void Conectar()
        {
            try
            {
                if (Conecxao == null)
                {
                    
                    Conecxao = new MySqlConnection("Server=localhost;Database=login;Uid=root;Pwd=root;");
                    Conecxao.Open();
                }
            }
            catch (MySqlException ex)
            {
                // Trate erros de conexão aqui
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                Conecxao = null;
            }

        }   
        public static void Desconectar()
        {
            if (Conecxao != null)
            {
                Conecxao.Close();
                Conecxao = null;
            }
        }
    }
}
