using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotinaBackup.Data.Models
{
    public class BackupSettings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Caminho { get; set; }
        public string CaminhoRed { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public bool Dbcc { get; set; }
        public virtual Server Server { get; set; }
    }
}
