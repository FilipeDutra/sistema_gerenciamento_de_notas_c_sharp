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
        //salva cliente
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
        
        //altera cliente
        public void AlterarCliente(int id, String NovoNome, String NovoTelefone, String NovoEndereco, String NovoCPF)
        {
            try
            {
                Cliente cliente = GetById(id);
                
                if (cliente != null)
                {
                    Cliente.Atualizar(id, NovoTelefone, NovoTelefone, NovoEndereco, NovoCPF);
                }
                else
                {
                    throw new Exception("Cliente nao encontrado");
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        //exclui cliente
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

        //lista cliente
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
        
        public Cliente GetById(int id)
        {
            
            Cliente obj = new Cliente();
            try
            {

                obj = Cliente.GetById(id);
            }
            catch(Exception e)
            {
                throw (e);
            }
            return obj;
        }
    }
}
