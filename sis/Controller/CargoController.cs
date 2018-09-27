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
    	//salva cargo
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
        //lista cargo	
        public List<Cargo> ListarCargos()
        {
            Contexto contexto = new Contexto();
            return contexto.Cargos.ToList();
        }

        //retorna cargo por id
        public static Cargo GetById(int id)
        {
            Contexto contexto = new Contexto();
            return contexto.Cargos.Find(id);
        }
    }
}
