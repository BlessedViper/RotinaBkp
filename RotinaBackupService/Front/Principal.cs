﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using RotinaBackupService.Func;

namespace RotinaBackupService.Front
{
    public partial class Principal : MaterialSkin.Controls.MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            SettingsMani settings = new SettingsMani();
            settings.GetStringConnection();
            lbTeste.Text = settings.GetSqlConfigs();
        }
    }
}
