using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Estoque
    {
        public int EstoqueId { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto _Produto { get; set; }
    }
}
