using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    class CupomFiscal
    {
        [Key]
        public int CupumFiscalId { get; set; }
        public float Total { get; set; }
        public float Imposto { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int VendedorId { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}
