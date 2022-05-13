using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public static class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                                 .CreateConnector("minhaCs")
                                 .Connect();
            sqlCn.ExecuteCommand("select * from tabela");
            sqlCn.Close();

            Console.WriteLine("-------------------------------");

            var oracleCn = DbFactory.Database(DataBase.Oracle)
                                 .CreateConnector("minhaCs")
                                 .Connect();
            oracleCn.ExecuteCommand("select * from tabela");
            oracleCn.Close();

        }
    }
}
