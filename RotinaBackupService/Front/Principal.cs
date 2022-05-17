using RotinaBackupService.Func;
using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace RotinaBackupService.Front
{
    public partial class Principal : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Principal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
