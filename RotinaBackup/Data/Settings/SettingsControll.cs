using RotinaBackup.Data;
using RotinaBackup.Data.Models;
using RotinaBackup.Data.Settings.Repository;
using RotinaBackupService.Func.Conection.settings;
using RotinaBackupService.Func.Settings.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RotinaBackupService.Func
{
    public class SettingsControll
    {
        private GetSettings _getSettings;
        private GetServer _getServer;
        private Context _context = new();

        public List<BackupSettings> GetSettings()
        {
            _getSettings = new(_context);
            var settings = _getSettings.GetAllSettings();
            return settings;
        }
        public BackupSettings GetSettingsId(int id)
        {
            _getSettings = new(_context);
            var settings = _getSettings.GetSettingsId(id);
            return settings;
        }
        public List<Server> GetServers()
        {
            _getServer = new(_context);
            var servers = _getServer.GetAllServers();
            return servers;
        }
        
    }
}
