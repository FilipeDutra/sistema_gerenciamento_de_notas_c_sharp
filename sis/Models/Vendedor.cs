using Models.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Models
{
    public class Vendedor
    {
        [Key]
        public int VendedorId { get; set; }
        public String Nome { get; set; }
        public float Comissao { get; set; }
        public String CPF { get; set; }
        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }

        public static void Salvar(Vendedor obj)
        {
            Contexto contexto = new Contexto();
            contexto.Vendedors.Add(obj);
            contexto.SaveChanges();
        }

        public static List<Vendedor> ListarVendedors()
        {
            Contexto contexto = new Contexto();
            return contexto.Vendedors.ToList();
        }

        public static Vendedor GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.Vendedors.Find(id);
        }

        public static void Remove(int id)
        {
            Contexto contexto = new Contexto();
            contexto.Vendedors.Remove((Vendedor)contexto.Vendedors.Where(c => c.VendedorId == id).First());
            contexto.Entry((Vendedor)contexto.Vendedors.Where(c => c.VendedorId == id).First()).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public static void Atualizar(int id, String NovoNome, float NovaComissao, String NovoCPF, int idCargo)
        {
            Contexto contexto = new Contexto();
            Vendedor camp = contexto.Vendedors.Find(id);
            camp.Nome = NovoNome;
            camp.Comissao = NovaComissao;
            camp.CPF = NovoCPF;
            camp.CargoId = idCargo;

            contexto.Entry(camp).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

    }
}
