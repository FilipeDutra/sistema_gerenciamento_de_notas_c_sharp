using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public String Descricao { get; set; }
        public float Valor { get; set; }
    }
}
