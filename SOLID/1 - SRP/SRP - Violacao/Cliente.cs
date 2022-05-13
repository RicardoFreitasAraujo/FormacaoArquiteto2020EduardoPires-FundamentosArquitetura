using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___SRP.SRP___Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
