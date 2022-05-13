using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._3___Observer
{
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
