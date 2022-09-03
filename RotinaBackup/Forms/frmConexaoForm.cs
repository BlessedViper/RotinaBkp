using MaterialSkin;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RotinaBackupService.Forms
{
    public partial class frmConexaoForm : MaterialSkin.Controls.MaterialForm
    {
        public int Operacao { get; set; }
        public int IdBanco { get; set; }
        public frmConexaoForm(int operacao)
        {
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
            InitializeComponent();
            Operacao = operacao;
        }
        private void GravarBt_Click(object sender, EventArgs e)
        {
            if (Operacao.Equals(0))
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
                bntGravar.Enabled = false;
                TestaCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btTesteCon.Enabled = true;
                btCancela.Enabled = true;
                bntGravar.Enabled = true;
                return;
            }
            MessageBox.Show("Teste realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btTesteCon.Enabled = true;
            btCancela.Enabled = true;
            bntGravar.Enabled = true;
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
            FormClose();
        }

        private void GravarSettings()
        {

            TestaCon();
            SettingsMani settings = new SettingsMani();
            settings.SaveSettingsBanco(txtServidor.Text, txtBanco.Text, txtSenha.Text, txtUser.Text);
            MessageBox.Show("Dados gravados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormControll frm = new FormControll();
            frm.OpenSettingsForm();
            FormClose();
        }

        private void AlterarSettings(int idBanco)
        {
            TestaCon();
            SettingsMani settings = new SettingsMani();
            settings.UpdateSettingsBanco(txtServidor.Text, txtBanco.Text, txtSenha.Text, txtUser.Text, idBanco);
            MessageBox.Show("Dados gravados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormClose();
        }

        private void FormClose()
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }


    }
}
