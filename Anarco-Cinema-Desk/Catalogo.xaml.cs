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
            brush.ImageSource = new BitmapImage(new Uri("C:\\Users\\PEDROAUGUSTOPEDROSOT\\Documents\\Projeto Integrador\\Anarco-Cinema-Desk\\Anarco-Cinema-Desk\\img\\poster\\setimo.jpg", UriKind.Absolute));
            brush.Stretch = Stretch.UniformToFill;
            this.Background = brush;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else {
                NavigationService.Navigate(new Logar());
            }
        }

        private void anarco_voltar(object sender, MouseButtonEventArgs e)
        {

        }

        private void bt_img2_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void bt_setimo_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
