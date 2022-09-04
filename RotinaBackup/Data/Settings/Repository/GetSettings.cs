using Microsoft.EntityFrameworkCore;
using RotinaBackup.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaBackup.Data.Settings.Repository
{
    public class GetSettings
    {
        private Context _context;
        public GetSettings(Context context)
        {
            _context = context;
        }

        public List<BackupSettings> GetAllSettings()
        {
            var list = _context.BackupSettings.ToList();
            return list;
        }
        public BackupSettings GetSettingsId(int id)
        {
            var settings = _context.BackupSettings.FirstOrDefault(t => t.Id.Equals(id));
            return settings;
        }
    }
}
