using Models.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cargo
    {
        [Key]
        public int CargoId { get; set; }
        public String Descricao { get; set; }
        

        public static void Salvar(Cargo obj)
        {
            Contexto contexto = new Contexto();
            contexto.Cargos.Add(obj);
            contexto.SaveChanges();
        }

        public static Cargo GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.Cargos.Find(id);
        }

        public static List<Cargo> ListarCargos()
        {
            Contexto contexto = new Contexto();
            return contexto.Cargos.ToList();
        }
    }
}
