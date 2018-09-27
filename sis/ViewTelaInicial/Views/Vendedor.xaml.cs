using Controller;
using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            CarregarCargos();
        }

        private void ClickSalvarVendedor(object sender, RoutedEventArgs e)
        {
            try
            {
               // int IdVendedor = int.Parse(TbIdVendedor.Text);
                String Nome = TbNome.Text;
                float Comissao = float.Parse(TbComissao.Text);
                String Cpf = TbCpf.Text;
                Cargo cargoSelecionado = CbCargo.SelectedItem as Cargo;


                Vendedor vendedor = new Vendedor();

                if (Nome != null && !Nome.Equals(""))

                    vendedor.Nome = Nome;
                else
                    throw new Exception("Não foi possível identificar o nome");

                if (Cpf != null && !Cpf.Equals(""))
                    vendedor.CPF = Cpf;
                else
                    throw new Exception("Não foi possível identificar o cpf"); 

                if (!String.IsNullOrEmpty(cargoSelecionado.CargoId.ToString()))
                    vendedor.CargoId = cargoSelecionado.CargoId;
                else
                    throw new Exception("Não foi possível identificar o Cargo");

                if (!Comissao.Equals(""))
                    vendedor.Comissao = Comissao;
                else
                    throw new Exception("Não foi possível identificar a comissão.");

                vendedorcontroller.SalvarVendedor(vendedor);
                LimparForm();
                carregarVendedores();
                MessageBox.Show("Vendedor cadastrado com sucesso!");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }

        }

        private void ClickAlterarVendedor(object sender, RoutedEventArgs e)
        {
            try
            {
                int IdVendedor = int.Parse(TbIdVendedor.Text);
                String Nome = TbNome.Text;
                float Comissao = float.Parse(TbComissao.Text);
                String Cpf = TbCpf.Text;
                int IdCargo = int.Parse(CbCargo.Text);


                if (Nome != null && !Nome.Equals(""))
                    throw new Exception("Não foi possível identificar o nome");

                if (!Comissao.Equals(""))
                    throw new Exception("Não foi possível identificar a comissão.");

                if (Cpf != null && !Cpf.Equals(""))
                    throw new Exception("Náo foi possível identificar o cpf.");

                if (IdCargo.Equals(""))
                    throw new Exception("Não foi possível identificar o cargo");

                vendedorcontroller.AlterarVendedor(IdVendedor, Nome, Comissao, Cpf, IdCargo);

                carregarVendedores();
            }
            catch (Exception s)
            {
                throw (s);
            }

        }

        private void CarregarCargos() {
            try {
                CargoController cargoCont = new CargoController();
                IList<Cargo> cargos = cargoCont.ListarCargos();
                if (cargos != null) {
                    CbCargo.ItemsSource = cargos;
                    CbCargo.DisplayMemberPath = "Descricao";
                }
            } catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void ClickExcluirVendedor(object sender, RoutedEventArgs e)
        {
            try {
                MessageBoxResult result = MessageBox.Show("Deseja excluir",
                "Confirma", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                if (result.Equals(MessageBoxResult.OK)) {
                    Vendedor vend = ((FrameworkElement)sender).DataContext as Vendedor;
                    VendedorController vController = new VendedorController();
                    vController.ExcluirVendedor(vend.VendedorId);
                    MessageBox.Show("Vendedor Excluído com sucesso");
                    carregarVendedores();
                }
            } catch (Exception s) {
                MessageBox.Show(s.Message);
            }
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

        //Lista de cargos para o combox e retornar id para model vendedorController

        private void CbListaCargos(object sender, ContextMenuEventArgs e)
        {

            //SqlConnection sqlcn = new SqlConnection(connetionString);
           // Contexto sqlcn = new Contexto(nomeStringConexao);




            /*
            Cargo cargo = new Cargo();
            IList<Cargo> ListaCargos = CargoController.ListarCargos();

            if(ListaCargos != null)
            {
                CbCargo = ListaCargos.
                /*
                CbCargo.DisplayMemberPath = "Cargo";
                CbCargo.DataContext = ListaCargos;
                CbCargo.GetValue
                
            }
            
            /*
            private void preencher_cbNome()
            {
                SqlConnection sqlcn = new SqlConnection(connetionString);
                try
                {
                    sqlcn.Open();
                    string consulta = "select * from Comprador";
                    SqlDataAdapter sqlda = new SqlDataAdapter(consulta, sqlcn);
                    DataTable dtRetorno = new DataTable();
                    dtRetorno.Clear();
                    sqlda.Fill(dtRetorno);
                    cbxNome.DataSource = dtRetorno;
                    cbxNome.ValueMember = "id";
                    cbxNome.DisplayMember = "nome";
                    cbxNome.SelectedItem = "";
                    cbxNome.Refresh();
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("Falha ao efetuar a conexão! Erro: " + sqlex);
                }

                */
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e) {
            LimparForm();
        }

        private void LimparForm() {
            TbIdVendedor.Text = "";
            TbNome.Text = "";
            TbCpf.Text = "";
            TbComissao.Text = "";
            CbCargo.SelectedItem = null;
        }
    }
}