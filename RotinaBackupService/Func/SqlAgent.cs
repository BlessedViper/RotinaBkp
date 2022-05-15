using RotinaBackupService.Func.Conection.settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaBackupService.Func.Conection
{
    public class SqlAgent
    {

        public void Dbcc()
        {
            SettingsMani settings = new SettingsMani();
            var connection = settings.GetConnection();
            
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("DBCC CHECKDB",con);
            
            
        }
        public void Backup()
        {
            SettingsMani settings = new SettingsMani();
            var connection = settings.GetConnection();
            var banco = settings.GetBase();
            var caminho = settings.GetCaminho();
            var backupCmd = "BACKUP DATABASE " + banco +"TO DISK=" + caminho +"\\%backupName%.bak";

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(backupCmd,con);
        }

        


        
    }
}
