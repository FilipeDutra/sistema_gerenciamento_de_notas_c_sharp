using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    class Vendedor
    {
        [Key]
        public int VendedorId { get; set; }
        public String Nome { get; set; }
        public float Comissao { get; set; }
        public String CPF { get; set; }
    }
}
