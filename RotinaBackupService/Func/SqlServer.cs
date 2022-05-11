using System;
using System.Data.SqlClient;


namespace RotinaBackupService.Func.SqlServer
{
    public class SqlServer
    {
        
        SqlConnection conc;
        
        
        public SqlServer()
        {
            
        }

        

        public void TestCon(string Connection)
        {
                conc.ConnectionString = Connection;
                conc.Open();

        }

    

        public void Bkp()
        { 
            

        }


    }
}
