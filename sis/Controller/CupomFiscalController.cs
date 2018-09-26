using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CupomFiscalController
    {
        public void SalvarCupomFiscal(CupomFiscal cupom)
        {
            try
            {
                CupomFiscal.Salvar(cupom);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void ExclirCupomFiscal(int id)
        {
            try
            {
                CupomFiscal.Remove(id);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public IList<CupomFiscal> ListarCupomFiscal()
        {
            IList<CupomFiscal> ListaCupom;
            try
            {
                ListaCupom = CupomFiscal.ListarCupomFiscals();
                CupomFiscal.ListarCupomFiscals();
            }
            catch (Exception e)
            {
                throw (e);
            }
            return ListaCupom;
        }

        public CupomFiscal GetById(int id)
        {

            CupomFiscal obj = new CupomFiscal();
            try
            {

                obj = CupomFiscal.GetById(id);
            }
            catch (Exception e)
            {
                throw (e);
            }
            return obj;
        }
    }
}
