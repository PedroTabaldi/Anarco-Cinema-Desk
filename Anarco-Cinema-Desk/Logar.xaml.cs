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

namespace Anarco_Cinema_Desk
{
    /// <summary>
    /// Interação lógica para Logar.xam
    /// </summary>
    public partial class Logar : Page
    {
        public Logar()
        {
            InitializeComponent();
        }

        private void bt_Inserir_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void bt_logar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Catalogo());
            
        }

        private void bt_filme_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Catalogo());
        }
    }
}
