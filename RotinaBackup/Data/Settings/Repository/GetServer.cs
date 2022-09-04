using RotinaBackup.Data;
using RotinaBackup.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaBackupService.Func.Settings.Repository
{
    public class GetServer
    {
        private Context _context;
        
        public GetServer(Context context)
        {
            _context = context;
        }

        public List<Server> GetAllServers()
        {
            return _context.Server.ToList();
        }
    }
}
