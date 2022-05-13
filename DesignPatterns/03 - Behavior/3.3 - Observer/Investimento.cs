using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._3___Observer
{
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObservador> _observadores = new List<IObservador>();

        public Investimento(string simbolo, decimal valor)
        {
            Simbolo = simbolo;
            _valor = valor;
        }

        public string Simbolo { get; }
        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) return;
                _valor = value;
                Notificar();
            }
        }

        public void Subscribe(IObservador observador)
        {
            _observadores.Add(observador);
            Console.WriteLine($"Notificando que {observador.Nome} está recebendo atualizações de {Simbolo}");
        }

        public void UnSubscribe(IObservador observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine($"Notificando que {observador.Nome} NÃO está recebendo atualizações de {Simbolo}");
        }

        private void Notificar()
        {
            foreach (var investor in _observadores)
            {
                investor.Notificar(this);
            }

            Console.WriteLine("");
        }


    }
}
