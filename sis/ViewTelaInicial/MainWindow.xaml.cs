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
using ViewTelaInicial.Views;

namespace ViewTelaInicial
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GridDinamic.Children.Add(new BackgroundView());
        }

        private void BottonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selecionado = ListViewMenu.SelectedIndex;

            switch(selecionado)
            {
                case 0:
                    GridDinamic.Children.Clear();
                    GridDinamic.Children.Add(new ClienteView());
                    break;
                
                case 1:
                    GridDinamic.Children.Clear();
                    GridDinamic.Children.Add(new VendedorView());
                    break;
                case 2:
                    GridDinamic.Children.Clear();
                    GridDinamic.Children.Add(new CargoView());
                    break;
                case 3:
                    GridDinamic.Children.Clear();
                    GridDinamic.Children.Add(new ProdutoView());
                    break;
                case 4:
                    GridDinamic.Children.Clear();
                    GridDinamic.Children.Add(new RelatorioView());
                    break;
                default:
                    GridDinamic.Children.Clear();
                    GridDinamic.Children.Add(new BackgroundView());
                    break;
            }
        

        }
    }
}
