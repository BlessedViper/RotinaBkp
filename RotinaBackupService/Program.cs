using RotinaBackupService.Func;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Windows.Forms;

namespace RotinaBackupService
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            //if ()
            //{

            //}
            //Application.Run(new Front.ConexaoForm());
            Application.Run(new Front.Home());
            //SqlServer sql = new SqlServer();

            //if (sql.Servidor == null || sql.Banco == null || sql.User == null || sql.Pass == null )
            //{
            //    Application.Run(new Front.Conexao());
            //} else
            //{
            //    Application.Run(new Front.Principal());
            //}

        }
    }
}
