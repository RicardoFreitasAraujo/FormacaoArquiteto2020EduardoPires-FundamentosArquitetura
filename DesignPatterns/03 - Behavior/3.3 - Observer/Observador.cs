using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._3___Observer
{
    public class Observador : IObservador
    {
        public Observador(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }

        public void Notificar(Investimento investimento)
        {
            Console.WriteLine("Notificando {0} que {1} " +
                              "teve preço alterado para {2:N}", 
                              Nome, investimento.Simbolo, investimento.Valor);
        }
    }
}
