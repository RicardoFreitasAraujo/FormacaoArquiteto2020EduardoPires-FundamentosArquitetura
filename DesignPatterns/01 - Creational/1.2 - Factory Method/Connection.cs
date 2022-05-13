using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando Commando: " + command);
        }

        public void Open()
        {
            this.Opened = true;
            Console.WriteLine("Conexão aberta");
        }

        public void Close()
        {
            this.Opened = false;
            Console.WriteLine("Conexão fechada");
        }
        
    }
}
