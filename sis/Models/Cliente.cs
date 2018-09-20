using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Endereco { get; set; }
        public String CPF { get; set; }
    }
}
