using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaBackupService.Func
{
    public class SettingsMani
    {
        public string Connection { get; private set; }
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Pass { get; private set; }
        public string User { get; set; }

        public string GetStringConnection()
        {
            GetSqlConfigs();
            Connection = string.Format("DataSource={0};Inicital Catalog={1};User ID={2};Password={3}", Servidor, Banco, User, Pass);
            return Connection;
        }

        public void GetSqlConfigs()
        {
            Servidor = Properties.Settings.Default.Servidor;
            Banco = Properties.Settings.Default.Banco;
            User = Properties.Settings.Default.User;
            Pass = Properties.Settings.Default.Senha;
        }

    }
}
