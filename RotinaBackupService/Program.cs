using System;
using System.IO;
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

            if (File.Exists($@"{Application.StartupPath}\Data\Data.sdf"))
            {
                Application.Run(new Front.HomeForm());
            }
            else
            {
                Application.Run(new Front.ConexaoForm());
            }









        }
    }
}
