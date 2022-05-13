using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._2___Strategy
{
    public class Pagamento
    {
        public MeioPagamento MeioPagamento { get; set; }
        public string CartaoCredito { get; set; }
    }
}
