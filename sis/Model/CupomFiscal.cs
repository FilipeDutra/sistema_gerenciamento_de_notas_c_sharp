using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class CupomFiscal
    {
        public int CupumFiscalId { get; set; }
        public float Total { get; set; }
        public float Imposto { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int VendedorId { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}
