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

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void GravarBt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBanco.Text) | !string.IsNullOrEmpty(txtSenha.Text) | !string.IsNullOrEmpty(txtServidor.Text) | !string.IsNullOrEmpty(txtUser.Text))
            {
                try
                {
                    SettingsMani settings = new SettingsMani();
                    settings.SaveSettingsBanco(txtServidor.Text, txtBanco.Text, txtSenha.Text, txtUser.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sql Conection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Dados gravados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TesteConBt_Click(object sender, EventArgs e)
        {
            var connection = "Server = " + txtServidor.Text + "; Database = " + txtBanco.Text + "; Encrypt = True; User Id = " + txtUser.Text + "; Password = " + txtSenha.Text;

            try
            {
                btTesteCon.Enabled = false;
                btCancela.Enabled = false;
                btGravar.Enabled = false;
                TestaCon(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Conection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btTesteCon.Enabled = true;
                btCancela.Enabled = true;
                btGravar.Enabled = true;
            }

        }

        public void TestaCon(string connection)
        {
            if (!string.IsNullOrEmpty(txtBanco.Text) | !string.IsNullOrEmpty(txtSenha.Text) | !string.IsNullOrEmpty(txtServidor.Text) | !string.IsNullOrEmpty(txtUser.Text))
            {
                try
                {
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
            Application.Exit();
        }

        private void ConexaoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
