using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Anarco_Cinema_Desk
{
    /// <summary>
    /// Interação lógica para Catalogo.xam
    /// </summary>
    public partial class Catalogo : Page
    {
        public Catalogo()
        {
            InitializeComponent();

            ImageBrush brush = new ImageBrush();
            //brush.ImageSource = new BitmapImage(new Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projeto Integrador\\Anarco-Cinema-Desk\\Anarco-Cinema-Desk\\img\\poster\\setimo.jpg", UriKind.Absolute));
            brush.Stretch = Stretch.UniformToFill;
            this.Background = brush;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new Logar());
            }
        }

        private void anarco_voltar(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Logar());
        }

        private void bt_setimo_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("setimo");
        }

        private void CarregarEstrelas(string nameFilme)
        {
            var userLogado = ((App)Application.Current).UsuarioLogado;
            string nomes = $"SELECT estrelas FROM estrela WHERE Nome = '{userLogado}' AND Filme = '{nameFilme}'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(nomes, ConecxaoBanco.Conecxao);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // lê linha por linha
                {
                    int estrelas = reader.GetInt32("estrelas");
                    switch (nameFilme)
                    {
                        case "setimo":
                            es_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            es_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            es_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Alien":
                            ea_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            ea_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            ea_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Jaw":
                            ej_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            ej_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            ej_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Vagabond":
                            ev_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            ev_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            ev_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Cure":
                            ec_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            ec_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            ec_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Meia":
                            em_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            em_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            em_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Futuro":
                            ef_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            ef_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            ef_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Blade":
                            eb_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            eb_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            eb_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Rio":
                            er_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            er_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            er_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;
                         case "Acossado":
                            eg_1.Foreground = estrelas >= 1 ? Brushes.Yellow : Brushes.Black;
                            eg_2.Foreground = estrelas >= 2 ? Brushes.Yellow : Brushes.Black;
                            eg_3.Foreground = estrelas >= 3 ? Brushes.Yellow : Brushes.Black;
                            break;

                    }
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void SetEstrela(string name, int pontos)
        {
            //string query = "INSERT INTO estrelas (Filme) VALUES (@Email, @Senha)";


            var userLogado = ((App)Application.Current).UsuarioLogado;
            string nomes = $"SELECT Filme FROM estrela WHERE Nome = '{userLogado}'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(nomes, ConecxaoBanco.Conecxao);
                MySqlDataReader reader = cmd.ExecuteReader();

                var userExiste = false;
                var filmeExiste = false;

                while (reader.Read()) // lê linha por linha
                {
                    string nomeFilme = reader["Filme"].ToString();

                    if (nomeFilme == name)
                    {
                        filmeExiste = true;
                    }
                }
                reader.Close();

                if (filmeExiste)
                {
                    string querynome = $"UPDATE estrela SET estrelas = {pontos} WHERE Nome = '{userLogado}'";

                    using (var command = new MySqlCommand(querynome, ConecxaoBanco.Conecxao))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    string queryInsert = "INSERT INTO estrela (Nome, estrelas, Filme) VALUES (@Nome, @estrelas,@Filme)";
                    using (var command = new MySqlCommand(queryInsert, ConecxaoBanco.Conecxao))
                    {
                        command.Parameters.AddWithValue("@Nome", ((App)Application.Current).UsuarioLogado);
                        command.Parameters.AddWithValue("@estrelas", pontos);
                        command.Parameters.AddWithValue("@Filme", name);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("cadastrados com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }


        private void es_1_Click(object sender, RoutedEventArgs e)
        {

            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("setimo", int.Parse(tag));

            switch (tag)
            {
                default:
                    es_1.Foreground = Brushes.Black;
                    es_2.Foreground = Brushes.Black;
                    es_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    es_1.Foreground = Brushes.Yellow;
                    es_2.Foreground = Brushes.Black;
                    es_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    es_1.Foreground = Brushes.Yellow;
                    es_2.Foreground = Brushes.Yellow;
                    es_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    es_1.Foreground = Brushes.Yellow;
                    es_2.Foreground = Brushes.Yellow;
                    es_3.Foreground = Brushes.Yellow;
                    break;

            }

        }

        private void ea_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Alien", int.Parse(tag));

            switch (tag)
            {
                default:
                    ea_1.Foreground = Brushes.Black;
                    ea_2.Foreground = Brushes.Black;
                    ea_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    ea_1.Foreground = Brushes.Yellow;
                    ea_2.Foreground = Brushes.Black;
                    ea_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    ea_1.Foreground = Brushes.Yellow;
                    ea_2.Foreground = Brushes.Yellow;
                    ea_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    ea_1.Foreground = Brushes.Yellow;
                    ea_2.Foreground = Brushes.Yellow;
                    ea_3.Foreground = Brushes.Yellow;
                    break;

            }
        }

        private void ej_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Jaw", int.Parse(tag));

            switch (tag)
            {
                default:
                    ej_1.Foreground = Brushes.Black;
                    ej_2.Foreground = Brushes.Black;
                    ej_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    ej_1.Foreground = Brushes.Yellow;
                    ej_2.Foreground = Brushes.Black;
                    ej_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    ej_1.Foreground = Brushes.Yellow;
                    ej_2.Foreground = Brushes.Yellow;
                    ej_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    ej_1.Foreground = Brushes.Yellow;
                    ej_2.Foreground = Brushes.Yellow;
                    ej_3.Foreground = Brushes.Yellow;
                    break;

            }
        }


        private void ev_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Vagabond", int.Parse(tag));

            switch (tag)
            {
                default:
                    ev_1.Foreground = Brushes.Black;
                    ev_2.Foreground = Brushes.Black;
                    ev_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    ev_1.Foreground = Brushes.Yellow;
                    ev_2.Foreground = Brushes.Black;
                    ev_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    ev_1.Foreground = Brushes.Yellow;
                    ev_2.Foreground = Brushes.Yellow;
                    ev_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    ev_1.Foreground = Brushes.Yellow;
                    ev_2.Foreground = Brushes.Yellow;
                    ev_3.Foreground = Brushes.Yellow;
                    break;

            }
        }

        private void ec_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Cure", int.Parse(tag));

            switch (tag)
            {
                default:
                    ec_1.Foreground = Brushes.Black;
                    ec_2.Foreground = Brushes.Black;
                    ec_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    ec_1.Foreground = Brushes.Yellow;
                    ec_2.Foreground = Brushes.Black;
                    ec_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    ec_1.Foreground = Brushes.Yellow;
                    ec_2.Foreground = Brushes.Yellow;
                    ec_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    ec_1.Foreground = Brushes.Yellow;
                    ec_2.Foreground = Brushes.Yellow;
                    ec_3.Foreground = Brushes.Yellow;
                    break;

            }
        }

        private void em_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Meia", int.Parse(tag));

            switch (tag)
            {
                default:
                    em_1.Foreground = Brushes.Black;
                    em_2.Foreground = Brushes.Black;
                    em_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    em_1.Foreground = Brushes.Yellow;
                    em_2.Foreground = Brushes.Black;
                    em_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    em_1.Foreground = Brushes.Yellow;
                    em_2.Foreground = Brushes.Yellow;
                    em_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    em_1.Foreground = Brushes.Yellow;
                    em_2.Foreground = Brushes.Yellow;
                    em_3.Foreground = Brushes.Yellow;
                    break;

            }
        }

        private void ef_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Futuro", int.Parse(tag));

            switch (tag)
            {
                default:
                    ef_1.Foreground = Brushes.Black;
                    ef_2.Foreground = Brushes.Black;
                    ef_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    ef_1.Foreground = Brushes.Yellow;
                    ef_2.Foreground = Brushes.Black;
                    ef_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    ef_1.Foreground = Brushes.Yellow;
                    ef_2.Foreground = Brushes.Yellow;
                    ef_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    ef_1.Foreground = Brushes.Yellow;
                    ef_2.Foreground = Brushes.Yellow;
                    ef_3.Foreground = Brushes.Yellow;
                    break;

            }
        }

        private void eb_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Blade", int.Parse(tag));

            switch (tag)
            {
                default:
                    eb_1.Foreground = Brushes.Black;
                    eb_2.Foreground = Brushes.Black;
                    eb_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    eb_1.Foreground = Brushes.Yellow;
                    eb_2.Foreground = Brushes.Black;
                    eb_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    eb_1.Foreground = Brushes.Yellow;
                    eb_2.Foreground = Brushes.Yellow;
                    eb_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    eb_1.Foreground = Brushes.Yellow;
                    eb_2.Foreground = Brushes.Yellow;
                    eb_3.Foreground = Brushes.Yellow;
                    break;

            }
        }

        private void er_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Rio", int.Parse(tag));

            switch (tag)
            {
                default:
                    er_1.Foreground = Brushes.Black;
                    er_2.Foreground = Brushes.Black;
                    er_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    er_1.Foreground = Brushes.Yellow;
                    er_2.Foreground = Brushes.Black;
                    er_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    er_1.Foreground = Brushes.Yellow;
                    er_2.Foreground = Brushes.Yellow;
                    er_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    er_1.Foreground = Brushes.Yellow;
                    er_2.Foreground = Brushes.Yellow;
                    er_3.Foreground = Brushes.Yellow;
                    break;

            }
        }

        private void eg_1_Click(object sender, RoutedEventArgs e)
        {
            var botao = sender as Button;

            string tag = botao.Tag.ToString();
            SetEstrela("Acossado", int.Parse(tag));

            switch (tag)
            {
                default:
                    eg_1.Foreground = Brushes.Black;
                    eg_2.Foreground = Brushes.Black;
                    eg_3.Foreground = Brushes.Black;
                    break;

                case "1":
                    eg_1.Foreground = Brushes.Yellow;
                    eg_2.Foreground = Brushes.Black;
                    eg_3.Foreground = Brushes.Black;
                    break;

                case "2":
                    eg_1.Foreground = Brushes.Yellow;
                    eg_2.Foreground = Brushes.Yellow;
                    eg_3.Foreground = Brushes.Black;
                    break;
                case "3":
                    eg_1.Foreground = Brushes.Yellow;
                    eg_2.Foreground = Brushes.Yellow;
                    eg_3.Foreground = Brushes.Yellow;
                    break;

            }
        }

        private void bt_alien_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Alien");
        }

        private void bt_jaw_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Jaw");
        }
        private void bt_vagabond_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Vagabond");
        }
        private void bt_cure_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Cure");
        }
        private void bt_meia_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Meia");
        }
        private void bt_futuro_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Futuro");
        }
        private void bt_blade_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Blade");
        }
        private void bt_rio_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Rio");
        }
        private void bt_acossado_Click(object sender, RoutedEventArgs e)
        {
            CarregarEstrelas("Acossado");
        }

    }
}























