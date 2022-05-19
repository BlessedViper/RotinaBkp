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

        

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            ConexaoForm addCon = new ConexaoForm();
            addCon.ShowDialog();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            ConexaoForm addCon = new ConexaoForm();
            addCon.ShowDialog();
        }
       
    }
}
