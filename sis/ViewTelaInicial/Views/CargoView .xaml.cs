using Controller;
using Models;
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

namespace ViewTelaInicial.Views
{
    /// <summary>
    /// Interação lógica para EstoqueView.xam
    /// </summary>
    public partial class CargoView : UserControl
    {
        CargoController cargoController = new CargoController();
        public CargoView()
        {
            
            InitializeComponent();
            carregarCargos();
        }

        private void clickCargoSalvar(object sender, RoutedEventArgs e)
        {
            try
            {
                int IdCargo = int.Parse(TbIdCargo.Text);
                String Descricao = TbDescricao.Text;

                Cargo cargo  = new Cargo();

                if (Descricao == null)
                    throw new Exception("Não foi possível identificar o nome");

                cargo.Descricao = Descricao;                

                cargoController.SalvarCargo(cargo);
            }
            catch (Exception s)
            {
                throw (s);
            }

        }

        private void carregarCargos()

        {
            Cargo cargo = new Cargo();

            IList<Cargo> ListaCargos = CargoController.ListarCargos();

            //IList<Cargo> ListaCargos = cargoController.ListarCargos();
            if (ListaCargos != null)
            {
                DBGridCargo.ItemsSource = ListaCargos;
            }
            else
            {
                throw new Exception("Não foi carregar a lista de clientes");
            }
        }
    }
}
