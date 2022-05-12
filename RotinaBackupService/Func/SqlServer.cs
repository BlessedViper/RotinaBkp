using System;
using System.Data.SqlClient;


namespace RotinaBackupService.Func.SqlServer
{
    public class SqlServer
    {
        
        SqlConnection conc;
        public string ConnectionString { get; private set; }


        public SqlServer(string connectionString)
        {
            connectionString = ConnectionString;

        }

        

        public void TestCon(string Connection)
        { 
            conc.ConnectionString = ConnectionString;
            conc.Open();

        }

    

        public void Bkp()
        { 
            

        }


    }
}
