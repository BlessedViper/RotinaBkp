using RotinaBackupService.Func.Conection.settings;
using System;
using System.Data.SqlClient;

namespace RotinaBackupService.Func.Conection
{
    public class SqlAgent
    {
        private string _connection;
        
        
        public void DbccGeral()
        {
            SettingsMani settings = new SettingsMani();
            var id = settings.GetId();
            for (int i = 0; i < id; i++)
            {
                _connection = settings.GetConnection(i);
                var banco = settings.GetBase(i);
                SqlConnection con = new SqlConnection(_connection);
                SqlCommand cmd = new SqlCommand($"DBCC CHECKDB [{banco}]", con);
            }
            

        }
        public void BackupGeral()
        {
            SettingsMani settings = new SettingsMani();
            
            var id = settings.GetId();
            var caminho = settings.GetCaminho();
            var diaHora = DateTime.Now;
            for (int i = 0; i < id; i++)
            {
                _connection = settings.GetConnection(i);
                var banco = settings.GetBase(i);
                var backupCmd = $@"BACKUP DATABASE {banco} TO DISK={caminho}\{banco}_{diaHora}.bak";

                SqlConnection con = new SqlConnection(_connection);
                SqlCommand cmd = new SqlCommand(backupCmd, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }catch (Exception ex)
                {
                    throw new Exception
                    {
                        Source = ex.Source
                    };
                }
                
            }
            
        }

        public void TesteConnection(int id)
        {
            SettingsMani settings = new SettingsMani();
            _connection = settings.GetConnection(id);

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

        public void Dbcc(int id)
        {
            SettingsMani settings = new SettingsMani();
            _connection = settings.GetConnection(id);
            var banco = settings.GetBase(id);
            SqlConnection con = new SqlConnection(_connection);
            SqlCommand cmd = new SqlCommand($"DBCC CHECKDB [{banco}]", con);
        }
        
        public void Backup(int id)
        {
            SettingsMani settings = new SettingsMani();
            _connection = settings.GetConnection(id);
            var banco = settings.GetBase(id);
            var caminho = settings.GetCaminho();
            var diaHora = DateTime.Now;
            SqlConnection con = new SqlConnection(_connection);
            SqlCommand cmd = new SqlCommand($@"BACKUP DATABASE {banco} TO DISK={caminho}\{banco}_{diaHora}.bak", con);

            try
            {
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw new Exception (ex.Message)
                {
                    Source = ex.Source
                };
            }
        }
    }
}

