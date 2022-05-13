using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString): base(connectionString)
        {

        }

        public override Connection Connect()
        {
            throw new NotImplementedException();
        }
    }
}
