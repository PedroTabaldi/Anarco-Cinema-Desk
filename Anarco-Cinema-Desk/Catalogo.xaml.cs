using MySql.Data.MySqlClient;
using System;
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
    }
}
