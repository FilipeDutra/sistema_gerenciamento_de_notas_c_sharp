using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Vendas
    {
        public int idVenda { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public float ValorItem { get; set; }
        public int CupomFiscalId { get; set; }
        public virtual CupomFiscal CupomFiscal { get; set; }

    }
}
