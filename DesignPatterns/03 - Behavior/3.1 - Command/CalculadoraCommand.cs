using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._1___Command
{
    internal class CalculadoraCommand : Commander
    {
        private char _operador;
        private int _valor;
        private readonly Calculadora _calculadora;

        public CalculadoraCommand(Calculadora calculadora, char operador, int valor)
        {
            _calculadora = calculadora;
            _operador = operador;
            _valor = valor;
        }

        public char Operator
        {
            set => _operador = value;
        }

        public int Operand
        {
            set => _valor = value;
        }


        public override void Desfazer()
        {
            _calculadora.Operacao(DesafazerKK(_operador), _valor);
        }

        public override void Executar()
        {
            _calculadora.Operacao(_operador, _valor);
        }

        
        private static char DesafazerKK(char operador)
        {
            switch (operador)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Operador desconhecido");
            }
        }

    }
}
