using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("nomeStringConexao")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CupomFiscal> CupomFiscals { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Vendas> Vendass { get; set; }
        public DbSet<Vendedor> Vendedors { get; set; }
    }
}

