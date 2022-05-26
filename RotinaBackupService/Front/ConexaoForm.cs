using MaterialSkin.Controls;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RotinaBackupService.Front
{
    public partial class ConexaoForm : MaterialForm
    {
        public int Operacao { get; set; }
        public int IdBanco { get; set; }
        public ConexaoForm(int operacao)
        {
            InitializeComponent();
            Operacao = operacao;
        }
        private void GravarBt_Click(object sender, EventArgs e)
        {
            if (Operacao == 0)
            {
                try
                {
                    GravarSettings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
            {
                try
                {
                    AlterarSettings(IdBanco);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
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

        private void GravarSettings()
        {

            TestaCon();
            SettingsMani settings = new SettingsMani();
            settings.SaveSettingsBanco(txtServidor.Text, txtBanco.Text, txtSenha.Text, txtUser.Text);
            MessageBox.Show("Dados gravados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var caminhoForm = new SettingsBkpForm();
            caminhoForm.Closed += (s, args) => this.Close();
            caminhoForm.Show();

        }

        private void AlterarSettings(int idBanco)
        {
            TestaCon();
            SettingsMani settings = new SettingsMani();
            settings.UpdateSettingsBanco(txtServidor.Text, txtBanco.Text, txtSenha.Text, txtUser.Text, idBanco);
            MessageBox.Show("Dados gravados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


    }
}
