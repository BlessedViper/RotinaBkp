using MaterialSkin.Controls;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RotinaBackupService.Front
{
    public partial class ConexaoForm : MaterialForm
    {
        public ConexaoForm()
        {
            InitializeComponent();
        }
        private void GravarBt_Click(object sender, EventArgs e)
        {
            try
            {
                TestaCon();
                SettingsMani settings = new SettingsMani();
                settings.SaveSettingsBanco(txtServidor.Text, txtBanco.Text, txtSenha.Text, txtUser.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Dados gravados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TesteConBt_Click(object sender, EventArgs e)
        {
            try
            {
                btTesteCon.Enabled = false;
                btCancela.Enabled = false;
                btGravar.Enabled = false;
                TestaCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btTesteCon.Enabled = true;
                btCancela.Enabled = true;
                btGravar.Enabled = true;
                return;
            }
            MessageBox.Show("Teste realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btTesteCon.Enabled = true;
            btCancela.Enabled = true;
            btGravar.Enabled = true;

        }

        public void TestaCon()
        {
            if (!string.IsNullOrEmpty(txtBanco.Text) | !string.IsNullOrEmpty(txtSenha.Text) | !string.IsNullOrEmpty(txtServidor.Text) | !string.IsNullOrEmpty(txtUser.Text))
            {
                try
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = txtServidor.Text;
                    builder.InitialCatalog = txtBanco.Text;
                    builder.UserID = txtUser.Text;
                    builder.Password = txtSenha.Text;
                    builder.IntegratedSecurity = true;
                    var connection = builder.ToString();

                    SqlConnection sql = new SqlConnection(connection);
                    sql.Open();

                }
                catch (Exception ex)
                {
                    throw new Exception("Falha ao se conectar a base de dados - " + ex.Message)
                    {
                        Source = ex.Source
                    };
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private void Cancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
