using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    class Estoque
    {
        [Key]
        public int EstoqueId { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto _Produto { get; set; }
    }
}
