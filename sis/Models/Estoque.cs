using Models.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Models
{
    public class Estoque
    {
        [Key]
        public int EstoqueId { get; set; }
        // Faltou a descrição do estoque e não tem quantidade no cadastro e sim no produto!!!
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto _Produto { get; set; }

        public static void Salvar(Estoque obj)
        {
            Contexto contexto = new Contexto();
            contexto.Estoques.Add(obj);
            contexto.SaveChanges();
        }

        public static List<Estoque> ListarEstoques()
        {
            Contexto contexto = new Contexto();
            return contexto.Estoques.ToList();
        }

        public static Estoque GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.Estoques.Find(id);
        }

        public static void Remove(int id)
        {
            Contexto contexto = new Contexto();
            contexto.Estoques.Remove((Estoque)contexto.Estoques.Where(c => c.EstoqueId == id).First());
            contexto.Entry((Estoque)contexto.Estoques.Where(c => c.EstoqueId == id).First()).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public static void Atualizar(int id, int NovaQuantidade)
        {
            Contexto contexto = new Contexto();
            Estoque camp = contexto.Estoques.Find(id);
            camp.Quantidade = NovaQuantidade;

            contexto.Entry(camp).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

    }
}
