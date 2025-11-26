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
    /// Interação lógica para Logar.xaml
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

        // PSEUDOCÓDIGO:
        // 1. Definir a URL a ser aberta.
        // 2. Criar um ProcessStartInfo com FileName = URL e UseShellExecute = true (para usar o navegador padrão).
        // 3. Chamar System.Diagnostics.Process.Start(processStartInfo) para abrir o link no navegador padrão.
        // 4. Capturar exceções e exibir uma MessageBox de erro caso algo falhe.

        private void bt_logar_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://linktr.ee/pedroaotabaldi";
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void bt_filme_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());

        }

        private void anarco_voltar(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Logar());
        }
    }
}
