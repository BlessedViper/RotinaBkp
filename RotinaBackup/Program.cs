using RotinaBackupService.Forms;
using RotinaBackupService.Func.Conection;
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
            FormControll form = new FormControll();
            form.OpenHomeForm();


        }
    }
}
