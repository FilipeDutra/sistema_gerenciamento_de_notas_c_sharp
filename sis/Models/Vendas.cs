using Models.DAL;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Models
{
    public class Vendas
    {
        [Key]
        public int VendasId { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public float ValorItem { get; set; }

        public int CupomFiscalId { get; set; }
        public virtual CupomFiscal CupomFiscal { get; set; }

        public static void Salvar(Vendas obj)
        {
            Contexto contexto = new Contexto();
            contexto.Vendass.Add(obj);
            contexto.SaveChanges();
        }

        public static List<Vendas> ListarVendass()
        {
            Contexto contexto = new Contexto();
            return contexto.Vendass.ToList();
        }

        public static Vendas GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.Vendass.Find(id);
        }

        public static void Remove(int id)
        {
            Contexto contexto = new Contexto();
            contexto.Vendass.Remove((Vendas)contexto.Vendass.Where(c => c.VendasId == id).First());
            contexto.Entry((Vendas)contexto.Vendass.Where(c => c.VendasId == id).First()).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public static void Atualizar(int id, int NovoProdutoId, int NovaQuantidade, float NovoValorItem)
        {
            Contexto contexto = new Contexto();
            Vendas camp = contexto.Vendass.Find(id);
            camp.ProdutoId = NovoProdutoId;
            camp.Quantidade = NovaQuantidade;
            camp.ValorItem = NovoValorItem;

            contexto.Entry(camp).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }


    }
}
