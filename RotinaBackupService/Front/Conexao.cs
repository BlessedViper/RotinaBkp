using RotinaBackupService.Func;
using RotinaBackupService.Func.SqlServer;
using System;
using System.Data.SqlClient;

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
            SetSettings();
        }

        private void texteConBt_Click(object sender, EventArgs e)
        {
            TestaCon();
            
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
            var conec = string.Format("DataSource={0};Inicital Catalog={1};User ID={2};Password={3}", txtServidor.Text, txtBanco.Text, txtUser.Text, txtSenha.Text);
            SqlServer sql = new SqlServer();
            try 
            {
                sql.TestCon(conec);
            }
            

        }
    }
}
