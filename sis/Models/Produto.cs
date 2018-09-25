using Models.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public String Descricao { get; set; }
        public float Valor { get; set; }
        //faltou colocar a quantidade

        public static void Salvar(Produto obj)
        {
            Contexto contexto = new Contexto();
            contexto.Produtos.Add(obj);
            contexto.SaveChanges();
        }

        public static List<Produto> ListarProdutos()
        {
            Contexto contexto = new Contexto();
            return contexto.Produtos.ToList();
        }

        public static Produto GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.Produtos.Find(id);
        }

        public static void Remove(int id)
        {
            Contexto contexto = new Contexto();
            contexto.Produtos.Remove((Produto)contexto.Produtos.Where(c => c.ProdutoId == id).First());
            contexto.Entry((Produto)contexto.Produtos.Where(c => c.ProdutoId == id).First()).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public static void Atualizar(int id, String NovaDescricao, float NovoValor)
        {
            Contexto contexto = new Contexto();
            Produto camp = contexto.Produtos.Find(id);
            camp.Descricao = NovaDescricao;
            camp.Valor = NovoValor;

            contexto.Entry(camp).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

    }
}
