using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._2___Strategy
{
    public class Pedido
    {
        public Pedido()
        {
            this.Produtos = new List<Produto>();
        }

        public Guid Id { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
