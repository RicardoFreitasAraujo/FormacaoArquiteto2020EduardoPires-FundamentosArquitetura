using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    //Abstract product
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}
