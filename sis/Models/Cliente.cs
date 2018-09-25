using System;
using Models.DAL;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Endereco { get; set; }
        public String CPF { get; set; }

        public static void Salvar(Cliente obj)
        {
            Contexto contexto = new Contexto();
            contexto.Clientes.Add(obj);
            contexto.SaveChanges();
        }

        public static List<Cliente> ListarClientes()
        {
            Contexto contexto = new Contexto();
            return contexto.Clientes.ToList();
        }

        public static Cliente GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.Clientes.Find(id);
        }

        public static void Remove(int id)
        {
            Contexto contexto = new Contexto();
            contexto.Clientes.Remove((Cliente)contexto.Clientes.Where(c => c.ClienteId == id).First());
            contexto.Entry((Cliente)contexto.Clientes.Where(c => c.ClienteId == id).First()).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public static void Atualizar(int id, String NovoNome, String NovoTelefone, String NovoEndereco, String NovoCPF)
        {
            Contexto contexto = new Contexto();
            Cliente camp = contexto.Clientes.Find(id);
            camp.Nome = NovoNome;
            camp.Telefone = NovoTelefone;
            camp.Endereco = NovoEndereco;
            camp.CPF = NovoCPF;

            contexto.Entry(camp).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

    }


}
