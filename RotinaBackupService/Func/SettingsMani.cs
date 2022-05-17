using System;
using System.Data.SqlClient;

namespace RotinaBackupService.Func.Conection.settings
{
    public class SettingsMani
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
        private string _getBanco = "SELECT banco FROM conenctions";
        private string _getServer = "SELECT Server FROM connections";
        private string _getUser = "SELECT User FROM Connections";
        private string _getPass = "SELECT Pass FROM Connections";

        public void SaveSettingsBanco(string servidor, string banco, string pass, string user)
        {
            Cripto cripto = new Cripto(pass);
            SqlConnection sqlCon = new SqlConnection(_connectionString);
            string sql = "UPDATE Connection SET Servidor = @parm1, Banco = @parm2, User = @parm3, Pass = @parm4";

            try
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.Add("@parm1", System.Data.SqlDbType.VarChar).Value = servidor;
                    cmd.Parameters.Add("@parm2", System.Data.SqlDbType.VarChar).Value = banco;
                    cmd.Parameters.Add("@parm3", System.Data.SqlDbType.VarChar).Value = user;
                    cmd.Parameters.Add("@parm4", System.Data.SqlDbType.VarChar).Value = cripto.SetCripto();
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar salvar as configurações - " + ex.Message);

            }
        }

        public string GetConnection()
        {

            string connectionString;

            SqlConnection sqlCon = new SqlConnection(_connectionString);

            try
            {
                sqlCon.Open();
                SqlCommand getServer = new SqlCommand(_getServer, sqlCon);
                SqlCommand getBanco = new SqlCommand(_getBanco, sqlCon);
                SqlCommand getUser = new SqlCommand(_getUser, sqlCon);
                SqlCommand getPass = new SqlCommand(_getPass, sqlCon);

                var server = Convert.ToString(getServer.ExecuteReader());
                var banco = Convert.ToString(getBanco.ExecuteReader());
                var user = Convert.ToString(getUser.ExecuteReader());
                var pass = Convert.ToString(getPass.ExecuteReader());
                Cripto cripto = new Cripto(pass);
                pass = cripto.GetPass();

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = server;
                builder.InitialCatalog = banco;
                builder.UserID = user;
                builder.Password = pass;
                builder.IntegratedSecurity = true;

                connectionString = builder.ToString();

                sqlCon.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message)
                {
                    Source = ex.Source
                };
            }
            return connectionString;
        }



        public string GetCaminho()
        {
            SqlConnection sql = new SqlConnection(_connectionString);
            SqlCommand getCaminho = new SqlCommand("SELECT caminho FROM settings", sql);
            var caminho = Convert.ToString(getCaminho.ExecuteReader());
            return caminho;
        }

        public string GetBase()
        {
            SqlConnection sql = new SqlConnection(_connectionString);
            SqlCommand getBase = new SqlCommand("SELECT base FROM connections", sql);

            var banco = Convert.ToString(getBase.ExecuteReader());

            return banco;
        }

    }
}
