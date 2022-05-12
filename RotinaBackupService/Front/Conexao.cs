using RotinaBackupService.Func;
using RotinaBackupService.Func.SqlServer;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RotinaBackupService.Front
{
    public partial class Conexao : MaterialSkin.Controls.MaterialForm
    {
        
        public Conexao()
        {
            InitializeComponent();         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gravarBt_Click(object sender, EventArgs e)
        {
            try
            {
                TestaCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Conection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetSettings();
        }

        private void texteConBt_Click(object sender, EventArgs e)
        {
            try
            {
                TestaCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Conection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SetSettings()
        {
            Properties.Settings.Default.Servidor = txtServidor.Text;
            Properties.Settings.Default.Banco = txtBanco.Text;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.Senha = txtSenha.Text;
            Properties.Settings.Default.Save();
        }

        public void TestaCon()
        {
            
            SettingsMani settings = new SettingsMani();
            settings.GetSqlConfigs();
            SqlServer sql = new SqlServer(settings.Connection);
            try
            {
                sql.TestCon(sql.ConnectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao se conectar a base de dados - " + ex.Message);
            }
        }
    }
}
