using MaterialSkin;
using MaterialSkin.Controls;
using RotinaBackupService.Func.Conection;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Windows.Forms;

namespace RotinaBackupService.Front
{
    public partial class HomeForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public HomeForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            

        }

        

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            ConexaoForm addCon = new ConexaoForm(0);
            addCon.ShowDialog();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            ConexaoForm addCon = new ConexaoForm(1);
            addCon.ShowDialog();
        }

        private void btCheckDb_Click(object sender, EventArgs e)
        {
            int id = 0;
            SqlAgent sql = new SqlAgent();
            sql.Dbcc(id);
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            int id = 0;
            SqlAgent sql = new SqlAgent();
            sql.Backup(id);
        }

        private void listarItens()
        {
            SettingsMani settings = new SettingsMani();
            
            var idBanco = settings.GetId();
            do
            {

            }
            while (idBanco < lvServers.Items.Count);
        }
    }
}
