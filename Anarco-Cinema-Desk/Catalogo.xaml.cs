using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
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
using MySql.Data.MySqlClient;
using System.Configuration;

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

        private void SetEstrela(Button estrela)
        {
        int valor = 1;
        es_1  valor;


            if (estrela == es_1)
            {
                string querynome = "INSERT INTO estrela (estrelas) VALUES (@estrelas)";
                using (var command = new MySqlCommand(querynome, ConecxaoBanco.Conecxao))
                {
                    command.Parameters.AddWithValue("@Nome", estrela);
                    command.ExecuteNonQuery();
                }
            }
            
        }

        private void es_1_Click(object sender, RoutedEventArgs e)
        {
            es_1.Foreground = Brushes.Yellow;
            es_2.Foreground = Brushes.Black;
            es_3.Foreground = Brushes.Black;

        }

        private void es_2_Click(object sender, RoutedEventArgs e)
        {
            es_1.Foreground = Brushes.Yellow;
            es_2.Foreground = Brushes.Yellow;
            es_3.Foreground = Brushes.Black;
        }

        private void es_3_Click(object sender, RoutedEventArgs e)
        {
            es_1.Foreground = Brushes.Yellow;
            es_2.Foreground = Brushes.Yellow;
            es_3.Foreground = Brushes.Yellow;
        }

        private void ea_2_Click(object sender, RoutedEventArgs e)
        {
            es_1.Foreground = Brushes.Yellow;
            ea_2.Foreground = Brushes.Yellow;
            ea_3.Foreground = Brushes.Black;
        }

        private void ea_1_Click(object sender, RoutedEventArgs e)
        {
            ea_1.Foreground = Brushes.Yellow;
            ea_2.Foreground = Brushes.Black;
            ea_3.Foreground = Brushes.Black;
        }

        private void ea_3_Click(object sender, RoutedEventArgs e)
        {
            ea_1.Foreground = Brushes.Yellow;
            ea_2.Foreground = Brushes.Yellow;
            ea_3.Foreground = Brushes.Yellow;
        }

        private void ej_1_Click(object sender, RoutedEventArgs e)
        {
            ej_1.Foreground = Brushes.Yellow;
            ej_2.Foreground = Brushes.Black;
            ej_3.Foreground = Brushes.Black;
        }

        private void ej_2_Click(object sender, RoutedEventArgs e)
        {
            ej_1.Foreground = Brushes.Yellow;
            ej_2.Foreground = Brushes.Yellow;
            ej_3.Foreground = Brushes.Black;
        }

        private void ej_3_Click(object sender, RoutedEventArgs e)
        {
            ej_1.Foreground = Brushes.Yellow;
            ej_2.Foreground = Brushes.Yellow;
            ej_3.Foreground = Brushes.Yellow;
        }

        private void ev_3_Click(object sender, RoutedEventArgs e)
        {
            ev_1.Foreground = Brushes.Yellow;
            ev_2.Foreground = Brushes.Yellow;
            ev_3.Foreground = Brushes.Yellow;
        }

        private void ev_2_Click(object sender, RoutedEventArgs e)
        {
            ev_1.Foreground = Brushes.Yellow;
            ev_2.Foreground = Brushes.Yellow;
            ev_3.Foreground = Brushes.Black;
        }

        private void ev_1_Click(object sender, RoutedEventArgs e)
        {
            ev_1.Foreground = Brushes.Yellow;
            ev_2.Foreground = Brushes.Black;
            ev_3.Foreground = Brushes.Black;
        }

        private void ec_1_Click(object sender, RoutedEventArgs e)
        {
            ec_1.Foreground = Brushes.Yellow;
            ec_2.Foreground = Brushes.Black;
            ec_3.Foreground = Brushes.Black;
        }

        private void ec_2_Click(object sender, RoutedEventArgs e)
        {
            ec_1.Foreground = Brushes.Yellow;
            ec_2.Foreground = Brushes.Yellow;
            ec_3.Foreground = Brushes.Black;
        }

        private void ec_3_Click(object sender, RoutedEventArgs e)
        {
            ec_1.Foreground = Brushes.Yellow;
            ec_2.Foreground = Brushes.Yellow;
            ec_3.Foreground = Brushes.Yellow;

        }
    }
}
