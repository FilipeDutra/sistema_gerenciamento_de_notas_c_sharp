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
    public partial class VendedorView : UserControl
    {
        VendedorController vendedorcontroller = new VendedorController();

        public VendedorView()
        {
            InitializeComponent();
            carregarVendedores();
        }

        private void ClickSalvarVendedor(object sender, RoutedEventArgs e)
        {
            try
            {
               // int IdVendedor = int.Parse(TbIdVendedor.Text);
                String Nome = TbNome.Text;
                float Comissao = float.Parse(TbComissao.Text);
                String Cpf = TbCpf.Text;


                Vendedor vendedor = new Vendedor();

                /*if (!Idcliente.Equals(""))
                    Idcliente = cliente.ClienteId;  
                else
                    throw new Exception("Não foi possível identificar o id do cliente!");
                */
                if (Nome != null && !Nome.Equals(""))

                    vendedor.Nome = Nome;
                else
                    throw new Exception("Não foi possível identificar o nome");

                if (Cpf != null && !Cpf.Equals(""))
                    vendedor.CPF = Cpf;
                else
                    throw new Exception("Não foi possível identificar o cpf");

                vendedor.Comissao = Comissao;


                vendedorcontroller.SalvarVendedor(vendedor);
                carregarVendedores();
            }
            catch (Exception s)
            {
                throw (s);
            }

        }

        private void ClickAlterarVendedor(object sender, RoutedEventArgs e)
        {

        }

        private void ClickExcluirVendedor(object sender, RoutedEventArgs e)
        {

        }

        private void carregarVendedores()
        {
            IList<Vendedor> ListaVendedor = vendedorcontroller.ListarVendedor();
            if (ListaVendedor != null)
            {
                DbGridVendedor.ItemsSource = ListaVendedor;
            }
            else
            {
                throw new Exception("Não foi carregar a lista de clientes");
            }
        }
    }
}