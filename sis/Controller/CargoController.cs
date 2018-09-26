using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CargoController
    {
        public void SalvarCargo(Cargo cargo)
        {
            try
            {
                Cargo.Salvar(cargo);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public static List<Cargo> ListarCargos()
        {
            Contexto contexto = new Contexto();
            return contexto.Cargos.ToList();
        }

        public static Cargo GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.Cargos.Find(id);
        }
    }
}
