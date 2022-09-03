using MaterialSkin;
using MaterialSkin.Controls;
using RotinaBackupService.Func.Conection;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Text;
using System.Windows.Forms;

namespace RotinaBackupService.Forms
{
    public partial class frmHomeForm : MaterialForm
    {
        private int _count = 0;
        private SettingsMani _settings;
        public frmHomeForm()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.ColorScheme = new ColorScheme(
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Accent.DeepPurple700,
                TextShade.WHITE
                );
             
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            

        }

        

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmConexaoForm addCon = new frmConexaoForm(0);
            addCon.ShowDialog();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            frmConexaoForm addCon = new frmConexaoForm(1);
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

        private void btAdicionar_Click_1(object sender, EventArgs e)
        {
            FormControll frm = new FormControll();
            frm.OpenConexaoForm(0);
        }

        private void FeedGrid()
        {
            _settings = new SettingsMani();
        }
    }
}
