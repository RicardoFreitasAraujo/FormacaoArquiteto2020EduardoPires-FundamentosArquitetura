using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._1___Command
{
    public class Usuario
    {
        //Initializers
        private readonly Calculadora _calculadora = new Calculadora();
        private readonly List<Commander> _commands = new List<Commander>();
        private int _total;

        public void Adicionar(char operador, int valor)
        {
            Commander command = new CalculadoraCommand(_calculadora, operador, valor);
            command.Executar();

            _commands.Add(command);
            _total++;
        }

        public void Retornar(int niveis)
        {
            Console.WriteLine("\n---- Retornando {0} niveis ", niveis);

            for(var i= 0; i < niveis; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Executar();
            }
        }


    }
}
