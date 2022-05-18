using MaterialSkin;
using MaterialSkin.Controls;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Windows.Forms;

namespace RotinaBackupService.Front
{
    public partial class Home : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Home()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            for (var i = 00; i < 24; i++)
            {
                this.cbHour.Items.Add(i);
            }
            for (var i = 0; i < 60; i++)
            {
                this.cbMin.Items.Add(i);
            }

        }

        private void btSelectCam_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            txtCaminho.Text = dialog.SelectedPath;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            
            try
            {
                var hour = this.cbHour.SelectedItem.ToString();
                var min = this.cbMin.SelectedItem.ToString();
                var caminho = $@"{txtCaminho.Text}";
                testNull(hour,min,caminho);
                SettingsMani settings = new SettingsMani();
                settings.SetSettingsBackup(hour, min, caminho);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void testNull(string hour, string min, string caminho)
        {
            if (string.IsNullOrEmpty(hour) | string.IsNullOrEmpty(min) | string.IsNullOrEmpty(caminho))
            {
                throw new NullReferenceException("Preencha todos os campos!");
            } else
            {
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
