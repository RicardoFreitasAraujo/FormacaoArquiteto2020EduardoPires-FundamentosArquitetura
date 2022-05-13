using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._3___Observer
{
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal valor) : base(simbolo, valor)
        {

        }
    }
}
