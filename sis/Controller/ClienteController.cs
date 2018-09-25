using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.DAL;

namespace Controller
{
    public class ClienteController
    {
        public void SalvarCliente(Cliente cliente)
        {
            try
            {
                Cliente.Salvar(cliente);
            }
            catch(Exception e)
            {
                throw (e);
            }
        }
        public void AlterarCliente(int id, String NovoNome, String NovoTelefone, String NovoEndereco, String NovoCPF)
        {
            try
            {
                Cliente.Atualizar(id, NovoTelefone, NovoTelefone, NovoEndereco, NovoCPF);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public void ExclirCliente(int id)
        {
            try
            {
                Cliente.Remove(id);
            }
            catch(Exception e)
            {
                throw (e);
            }
        }
        public IList<Cliente> ListarCliente()
        {
            IList<Cliente> ListaClientes;
            try
            {
                ListaClientes = Cliente.ListarClientes();
                Cliente.ListarClientes();
            }
            catch(Exception e)
            {
                throw (e);
            }
            return ListaClientes;
        }
        /*
        public  GetById(int id)
        {
            int ide;
            
            Cliente IdCliente;
            try
            {
                
                IdCliente = Cliente.GetById(id.);
            }
            catch(Exception e)
            {
                throw (e);
            }
            return IdCliente;
        }*/
    }
}
