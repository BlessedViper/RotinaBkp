using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace RotinaBackupService.Func
{
    partial class RotinaBkp : ServiceBase
    {
        public RotinaBkp()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer rotina = new Timer(10000);
            rotina.Elapsed += new System.Timers.ElapsedEventHandler(RealizaBkp);
            rotina.Enabled = true;

        }
        public void RealizaBkp(Object sender, ElapsedEventArgs e)
        {
            var horaAtual = DateTime.Now;
            if (horaAtual == horaAtual)
            {

            }

        }

        protected override void OnStop()
        {
            // TODO: Adicione aqui o código para realizar qualquer desmontagem necessária para interromper seu serviço.
        }
    }
}
