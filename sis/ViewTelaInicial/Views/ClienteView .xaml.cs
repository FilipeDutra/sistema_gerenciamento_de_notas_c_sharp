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
    public partial class ClienteView : UserControl
    {
        ClienteController clienteController = new ClienteController();

        public ClienteView()
        {
            InitializeComponent();
            carregarClientes();
            
        }
        /*
        private void BtnSalvarVendedor_Click(object sender, RoutedEventArgs e)
        {

        }

        */

        private void ClickSalvarCliente(object sender, RoutedEventArgs e)
        {
            try
            {
                //int Idcliente = int.Parse(TbIdCliente.Text);
                String Nome = TbNome.Text;
                String Endereco = TbEndereco.Text;
                String Telefone = TbTelefone.Text;
                String Cpf = TbCpf.Text;

                Cliente cliente = new Cliente();

                /*if (!Idcliente.Equals(""))
                    Idcliente = cliente.ClienteId;  
                else
                    throw new Exception("Não foi possível identificar o id do cliente!");
                */
                if (Nome != null && !Nome.Equals(""))
                    
                    cliente.Nome = Nome;
                else
                    throw new Exception("Não foi possível identificar o nome");

                if (Endereco != null && !Endereco.Equals(""))
                    cliente.Endereco = Endereco;
                else
                    throw new Exception("Não foi possível identificar o endereço");

                if (Telefone != null && !Telefone.Equals(""))
                    cliente.Telefone = Telefone;
                else
                    throw new Exception("Náo foi possível identificar o telefone");

                if (Cpf != null && !Cpf.Equals(""))
                    cliente.CPF = Cpf;
                else
                    throw new Exception("Não foi possível identificar o cpf");


                clienteController.SalvarCliente(cliente);
                carregarClientes();
            }
            catch(Exception s)
            {
                throw (s);
            }
        }

        private void ClickAlterarCliente(object sender, RoutedEventArgs e)
        {
            try
            {
                int Idcliente = int.Parse(TbIdCliente.Text);
                String Nome = TbNome.Text;
                String Endereco = TbEndereco.Text;
                String Telefone = TbTelefone.Text;
                String Cpf = TbCpf.Text;

                //new Cliente();

                if (Idcliente.Equals(""))
                   throw new Exception("Não foi possível identificar o id do cliente!");

                if (Nome == null && Nome.Equals(""))
                    throw new Exception("Não foi possível identificar o nome");

                if (Endereco == null && Endereco.Equals(""))
                    throw new Exception("Não foi possível identificar o endereço");

                if (Telefone == null && Telefone.Equals(""))
                    throw new Exception("Náo foi possível identificar o telefone");

                if (Cpf == null && Cpf.Equals(""))
                    throw new Exception("Não foi possível identificar o cpf");

                clienteController.AlterarCliente(Idcliente, Nome, Endereco, Telefone, Cpf);

                carregarClientes();
            }
            catch (Exception s)
            {
                throw (s);
            }
        }

        private void ClickExcluirCliente(object sender, RoutedEventArgs e)
        {
            try
            {
                int IdCliente = int.Parse(TbIdCliente.Text);
                
                if (TbIdCliente.Text != null)
                {
                    clienteController.ExclirCliente(IdCliente);
                }
                else
                    throw new Exception("Não foi possível localizar o idCliente");
                carregarClientes();
            }
            
            catch (Exception s)
            {
                throw (s);
            }
        }
        private void carregarClientes()
        {
            IList<Cliente> ListaClientes = clienteController.ListarCliente();
            if(ListaClientes != null)
            {
                dbGridCliente.ItemsSource = ListaClientes;
            }
            else
            {
                throw new Exception("Não foi carregar a lista de clientes");
            }
        }
    }
}
