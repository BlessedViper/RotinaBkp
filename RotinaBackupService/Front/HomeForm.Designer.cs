namespace RotinaBackupService.Front
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btAdicionar = new MaterialSkin.Controls.MaterialButton();
            this.lvServers = new MaterialSkin.Controls.MaterialListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Servidor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Base = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoraBkp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Caminho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAlterar = new MaterialSkin.Controls.MaterialButton();
            this.btBackup = new MaterialSkin.Controls.MaterialButton();
            this.btCheckDb = new MaterialSkin.Controls.MaterialButton();
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "config.png");
            this.imageList1.Images.SetKeyName(1, "base.png");
            this.imageList1.Images.SetKeyName(2, "lupa.png");
            this.imageList1.Images.SetKeyName(3, "backupdatabase_5665.png");
            this.imageList1.Images.SetKeyName(4, "home-202.png");
            this.imageList1.Images.SetKeyName(5, "1333.png");
            this.imageList1.Images.SetKeyName(6, "a929d0a3f7f742dbe5fe0ac469e19c7d.png");
            // 
            // btAdicionar
            // 
            this.btAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAdicionar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAdicionar.Depth = 0;
            this.btAdicionar.HighEmphasis = true;
            this.btAdicionar.Icon = null;
            this.btAdicionar.Location = new System.Drawing.Point(1160, 534);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAdicionar.Size = new System.Drawing.Size(98, 36);
            this.btAdicionar.TabIndex = 12;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAdicionar.UseAccentColor = false;
            this.btAdicionar.UseVisualStyleBackColor = true;
            // 
            // lvServers
            // 
            this.lvServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvServers.AutoSizeTable = false;
            this.lvServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Servidor,
            this.Base,
            this.HoraBkp,
            this.Caminho});
            this.lvServers.Depth = 0;
            this.lvServers.FullRowSelect = true;
            this.lvServers.HideSelection = false;
            this.lvServers.Location = new System.Drawing.Point(6, 76);
            this.lvServers.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvServers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvServers.MouseState = MaterialSkin.MouseState.OUT;
            this.lvServers.MultiSelect = false;
            this.lvServers.Name = "lvServers";
            this.lvServers.OwnerDraw = true;
            this.lvServers.Size = new System.Drawing.Size(1276, 420);
            this.lvServers.TabIndex = 11;
            this.lvServers.UseCompatibleStateImageBehavior = false;
            this.lvServers.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Servidor
            // 
            this.Servidor.Text = "Servidor";
            this.Servidor.Width = 200;
            // 
            // Base
            // 
            this.Base.Text = "Base";
            this.Base.Width = 200;
            // 
            // HoraBkp
            // 
            this.HoraBkp.Text = "Hora";
            this.HoraBkp.Width = 150;
            // 
            // Caminho
            // 
            this.Caminho.Text = "Caminho";
            this.Caminho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Caminho.Width = 400;
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAlterar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAlterar.Depth = 0;
            this.btAlterar.HighEmphasis = true;
            this.btAlterar.Icon = null;
            this.btAlterar.Location = new System.Drawing.Point(1067, 534);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            this.btBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btBackup.Depth = 0;
            this.btBackup.HighEmphasis = true;
            this.btBackup.Icon = null;
            this.btBackup.Location = new System.Drawing.Point(6, 534);
            this.btBackup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.btCheckDb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCheckDb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCheckDb.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btCheckDb.Depth = 0;
            this.btCheckDb.HighEmphasis = true;
            this.btCheckDb.Icon = null;
            this.btCheckDb.Location = new System.Drawing.Point(92, 534);
            this.btCheckDb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1304, 697);
            this.Controls.Add(this.btCheckDb);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.lvServers);
            this.Controls.Add(this.btAlterar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1056, 697);
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotina de Backup";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btAdicionar;
        private MaterialSkin.Controls.MaterialListView lvServers;
        private System.Windows.Forms.ColumnHeader Servidor;
        private System.Windows.Forms.ColumnHeader Base;
        private System.Windows.Forms.ColumnHeader HoraBkp;
        private System.Windows.Forms.ColumnHeader Caminho;
        private MaterialSkin.Controls.MaterialButton btAlterar;
        private MaterialSkin.Controls.MaterialButton btBackup;
        private MaterialSkin.Controls.MaterialButton btCheckDb;
        private System.Windows.Forms.ColumnHeader id;
    }
}