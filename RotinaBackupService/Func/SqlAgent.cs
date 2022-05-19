using RotinaBackupService.Func.Conection.settings;
using System;
using System.Data.SqlClient;

namespace RotinaBackupService.Func.Conection
{
    public class SqlAgent
    {
        private string _connection;
        
        
        public void Dbcc()
        {
            SettingsMani settings = new SettingsMani();
            _connection = settings.GetConnection();

            SqlConnection con = new SqlConnection(_connection);
            SqlCommand cmd = new SqlCommand("DBCC CHECKDB", con);


        }
        public void Backup()
        {
            SettingsMani settings = new SettingsMani();
            _connection = settings.GetConnection();
            //var banco = settings.GetBase();
            var caminho = settings.GetCaminho();
            //var backupCmd = $@"BACKUP DATABASE {banco} TO DISK={caminho}\%backupName%.bak";

            SqlConnection con = new SqlConnection(_connection);
            //SqlCommand cmd = new SqlCommand(backupCmd,con);
        }

        public void TesteConnection()
        {
            SettingsMani settings = new SettingsMani();
            _connection = settings.GetConnection();

            SqlConnection sql = new SqlConnection(_connection);
            try 
            {
                sql.Open();
            } catch(Exception ex)
            {
                throw new Exception("Erro ao se conectar a base de dados - " + ex.Message)
                {
                    Source = ex.Source
                };
            }
            
        }

    }
}

