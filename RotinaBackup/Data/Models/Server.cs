
using System.ComponentModel.DataAnnotations.Schema;

namespace RotinaBackup.Data.Models
{
    public class Server
    {
        public int Id { get; set; }
        public string Instancia { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public virtual BackupSettings Settings { get; set; }
        [ForeignKey("IdSettings")]
        public int IdSettings { get; set; }
        
    }
}
