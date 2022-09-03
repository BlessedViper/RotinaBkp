using MaterialSkin;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Windows.Forms;

namespace RotinaBackupService.Forms
{
    public partial class frmSettingsBkpForm : MaterialSkin.Controls.MaterialForm
    {
        
        public frmSettingsBkpForm()
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

        }
        #region Events
        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                var caminho = $@"{lbCaminho.Text}";

                SettingsMani settings = new SettingsMani();
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmClose();
            
        }

        private void ckbRedundancia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRedundancia.Checked) 
            {
                this.btBuscaCamRed.Visible = true;
                this.lbCaminhoRed.Visible = true;
                this.lbCaminhoRedInfo.Visible = true;
            } else 
            {
                this.btBuscaCamRed.Visible = false;
                this.lbCaminhoRed.Visible = false;
                this.lbCaminhoRedInfo.Visible = false;
            }
        }
        private void frmSettingsBkpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmClose();
        }

        private void btBuscaCam_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            lbCaminho.Text = dialog.SelectedPath;
        }

        private void btBuscaCamRed_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            lbCaminhoRed.Text = dialog.SelectedPath;
        }
        #endregion

        private void FrmClose()
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

    }
}
