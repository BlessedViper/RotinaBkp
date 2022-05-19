using MaterialSkin.Controls;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotinaBackupService.Front
{
    public partial class SettingsBkpForm : MaterialForm
    {
        public SettingsBkpForm()
        {
            InitializeComponent();

            for (var i = 00; i < 24; i++)
            {
                this.cbHora.Items.Add(i);
            }
            for (var i = 0; i < 60; i++)
            {
                this.cbMin.Items.Add(i);
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                var hour = this.cbHora.SelectedItem.ToString();
                var min = this.cbMin.SelectedItem.ToString();
                var caminho = $@"{lbCaminho.Text}";
                testNull(hour, min, caminho);
                SettingsMani settings = new SettingsMani();
                settings.SetSettingsBackup(hour, min, caminho);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var caminhoForm = new SettingsBkpForm();
            caminhoForm.Closed += (s, args) => this.Close();
            caminhoForm.Show();

        }
        private void testNull(string hour, string min, string caminho)
        {
            if (string.IsNullOrEmpty(hour) | string.IsNullOrEmpty(min) | string.IsNullOrEmpty(caminho))
            {
                throw new NullReferenceException("Preencha todos os campos!");
            }
           
        }

        private void ckbRedundancia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRedundancia.Checked == true) 
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

    }
}
