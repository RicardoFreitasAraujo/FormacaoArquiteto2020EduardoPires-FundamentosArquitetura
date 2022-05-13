using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class SqlFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
