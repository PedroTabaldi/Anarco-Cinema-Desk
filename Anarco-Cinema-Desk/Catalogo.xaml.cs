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
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void bt_img2_Click(object sender, RoutedEventArgs e)
        {


        }

        private void bt_setimo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SetEstrela(string name, int pontos)
        {
            string querynome = $"UPDATE estrela SET estrelas = {pontos}, Filme = '{name}' WHERE nome = 'g'";

            using (var command = new MySqlCommand(querynome, ConecxaoBanco.Conecxao))
            {
                command.ExecuteNonQuery();
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
            SetEstrela("Rio", int.Parse(tag));

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
    }
}
