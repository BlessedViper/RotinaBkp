using RotinaBackup.Data.Models;
using RotinaBackupService.Func.Conection;
using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Timers;

namespace RotinaBackupService.Func
{
    partial class RotinaBkp : ServiceBase
    {
        private List<BackupSettings> _list = new();
        public RotinaBkp()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer rotina = new Timer(10000);
            rotina.Elapsed += new System.Timers.ElapsedEventHandler(DoBkp);
            rotina.Enabled = true;

        }
        public async void DoBkp(Object sender, ElapsedEventArgs e)
        {
            SettingsControll settings = new();
            SqlAgent sql = new();
            await Task.Run(() => _list = settings.GetSettings());
            var horaAtual = DateTime.Now.ToString("hh:mm");
            foreach (var obj in _list)
            {
                var horaBkp = $"{obj.Hora}:{obj.Minuto}";
                if (string.Equals(horaAtual, horaBkp))
                {
                    await Task.Run(() => sql.Backup(obj.Server.Id));
                    if (obj.Dbcc.Equals(true))
                    {
                        await Task.Run(() => sql.Dbcc(obj.Server.Id));
                    }
                }
                else break;
            }
        }

        protected override void OnStop()
        {
            // TODO: Adicione aqui o código para realizar qualquer desmontagem necessária para interromper seu serviço.
        }
    }
}
