using Models.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Models
{
    public class CupomFiscal
    {
        [Key]
        public int CupomFiscalId { get; set; }
        public float Total { get; set; }
        public float Imposto { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int VendedorId { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public static void Salvar(CupomFiscal obj)
        {
            Contexto contexto = new Contexto();
            contexto.CupomFiscals.Add(obj);
            contexto.SaveChanges();
        }

        public static List<CupomFiscal> ListarCupomFiscals()
        {
            Contexto contexto = new Contexto();
            return contexto.CupomFiscals.ToList();
        }

        public static CupomFiscal GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.CupomFiscals.Find(id);
        }

        public static void Remove(int id)
        {
            Contexto contexto = new Contexto();
            contexto.CupomFiscals.Remove((CupomFiscal)contexto.CupomFiscals.Where(c => c.CupomFiscalId == id).First());
            contexto.Entry((CupomFiscal)contexto.CupomFiscals.Where(c => c.CupomFiscalId == id).First()).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

    }
}
