using MaterialSkin;
using MaterialSkin.Controls;
using RotinaBackupService.Func.Conection.settings;
using System;
using System.Windows.Forms;

namespace RotinaBackupService.Front
{
    public partial class HomeForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public HomeForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            

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

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            ConexaoForm addCon = new ConexaoForm();
            addCon.ShowDialog();


        }
    }
}
