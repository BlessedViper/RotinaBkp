namespace RotinaBackupService.Forms
{
    partial class frmHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btAdicionar = new MaterialSkin.Controls.MaterialButton();
            this.btAlterar = new MaterialSkin.Controls.MaterialButton();
            this.btBackup = new MaterialSkin.Controls.MaterialButton();
            this.btCheckDb = new MaterialSkin.Controls.MaterialButton();
            this.grdServer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdServer)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(0, 1);
            this.materialDivider1.TabIndex = 0;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAdicionar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAdicionar.Depth = 0;
            this.btAdicionar.HighEmphasis = true;
            this.btAdicionar.Icon = null;
            this.btAdicionar.Location = new System.Drawing.Point(1199, 814);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAdicionar.Size = new System.Drawing.Size(98, 36);
            this.btAdicionar.TabIndex = 12;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAdicionar.UseAccentColor = false;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click_1);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAlterar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAlterar.Depth = 0;
            this.btAlterar.HighEmphasis = true;
            this.btAlterar.Icon = null;
            this.btAlterar.Location = new System.Drawing.Point(1106, 814);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.btAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAlterar.Size = new System.Drawing.Size(84, 36);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAlterar.UseAccentColor = false;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Visible = false;
            // 
            // btBackup
            // 
            this.btBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btBackup.Depth = 0;
            this.btBackup.HighEmphasis = true;
            this.btBackup.Icon = null;
            this.btBackup.Location = new System.Drawing.Point(10, 814);
            this.btBackup.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btBackup.Name = "btBackup";
            this.btBackup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btBackup.Size = new System.Drawing.Size(78, 36);
            this.btBackup.TabIndex = 13;
            this.btBackup.Text = "Backup";
            this.btBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btBackup.UseAccentColor = false;
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Visible = false;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btCheckDb
            // 
            this.btCheckDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCheckDb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCheckDb.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btCheckDb.Depth = 0;
            this.btCheckDb.HighEmphasis = true;
            this.btCheckDb.Icon = null;
            this.btCheckDb.Location = new System.Drawing.Point(96, 814);
            this.btCheckDb.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btCheckDb.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCheckDb.Name = "btCheckDb";
            this.btCheckDb.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btCheckDb.Size = new System.Drawing.Size(91, 36);
            this.btCheckDb.TabIndex = 14;
            this.btCheckDb.Text = "Check Db";
            this.btCheckDb.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btCheckDb.UseAccentColor = false;
            this.btCheckDb.UseVisualStyleBackColor = true;
            this.btCheckDb.Visible = false;
            this.btCheckDb.Click += new System.EventHandler(this.btCheckDb_Click);
            // 
            // grdServer
            // 
            this.grdServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdServer.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServer.Location = new System.Drawing.Point(10, 108);
            this.grdServer.Name = "grdServer";
            this.grdServer.RowHeadersWidth = 51;
            this.grdServer.RowTemplate.Height = 29;
            this.grdServer.Size = new System.Drawing.Size(1287, 675);
            this.grdServer.TabIndex = 15;
            // 
            // frmHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1304, 871);
            this.Controls.Add(this.grdServer);
            this.Controls.Add(this.btCheckDb);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btAlterar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1056, 871);
            this.Name = "frmHomeForm";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotina de Backup";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton btAdicionar;
        private MaterialSkin.Controls.MaterialButton btAlterar;
        private MaterialSkin.Controls.MaterialButton btBackup;
        private MaterialSkin.Controls.MaterialButton btCheckDb;
        private System.Windows.Forms.DataGridView grdServer;
    }
}