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
            this.tbControlHome = new MaterialSkin.Controls.MaterialTabControl();
            this.tbBackup = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tbBanco = new System.Windows.Forms.TabPage();
            this.tbSettings = new System.Windows.Forms.TabPage();
            this.btAdicionar = new MaterialSkin.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.Servidor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Base = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAlterar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.HoraBkp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Caminho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbControlHome.SuspendLayout();
            this.tbBackup.SuspendLayout();
            this.tbSettings.SuspendLayout();
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
            // 
            // tbControlHome
            // 
            this.tbControlHome.Controls.Add(this.tbBackup);
            this.tbControlHome.Controls.Add(this.tbBanco);
            this.tbControlHome.Controls.Add(this.tbSettings);
            this.tbControlHome.Depth = 0;
            this.tbControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlHome.ImageList = this.imageList1;
            this.tbControlHome.Location = new System.Drawing.Point(3, 64);
            this.tbControlHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbControlHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbControlHome.Multiline = true;
            this.tbControlHome.Name = "tbControlHome";
            this.tbControlHome.SelectedIndex = 0;
            this.tbControlHome.Size = new System.Drawing.Size(1298, 631);
            this.tbControlHome.TabIndex = 0;
            // 
            // tbBackup
            // 
            this.tbBackup.Controls.Add(this.materialButton1);
            this.tbBackup.ImageKey = "home-202.png";
            this.tbBackup.Location = new System.Drawing.Point(4, 39);
            this.tbBackup.Margin = new System.Windows.Forms.Padding(4);
            this.tbBackup.Name = "tbBackup";
            this.tbBackup.Padding = new System.Windows.Forms.Padding(4);
            this.tbBackup.Size = new System.Drawing.Size(1042, 588);
            this.tbBackup.TabIndex = 2;
            this.tbBackup.Text = "Status";
            this.tbBackup.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(477, 160);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // tbBanco
            // 
            this.tbBanco.BackColor = System.Drawing.Color.White;
            this.tbBanco.ImageKey = "base.png";
            this.tbBanco.Location = new System.Drawing.Point(4, 39);
            this.tbBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBanco.Name = "tbBanco";
            this.tbBanco.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBanco.Size = new System.Drawing.Size(1042, 588);
            this.tbBanco.TabIndex = 1;
            this.tbBanco.Text = "Banco de Dados";
            // 
            // tbSettings
            // 
            this.tbSettings.BackColor = System.Drawing.Color.White;
            this.tbSettings.Controls.Add(this.btAdicionar);
            this.tbSettings.Controls.Add(this.materialListView1);
            this.tbSettings.Controls.Add(this.btAlterar);
            this.tbSettings.Controls.Add(this.materialLabel2);
            this.tbSettings.ImageKey = "config.png";
            this.tbSettings.Location = new System.Drawing.Point(4, 39);
            this.tbSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSettings.Size = new System.Drawing.Size(1290, 588);
            this.tbSettings.TabIndex = 0;
            this.tbSettings.Text = "Settings";
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
            this.btAdicionar.Location = new System.Drawing.Point(1154, 481);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAdicionar.Size = new System.Drawing.Size(98, 36);
            this.btAdicionar.TabIndex = 9;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAdicionar.UseAccentColor = false;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Servidor,
            this.Base,
            this.HoraBkp,
            this.Caminho});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(11, 4);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1276, 420);
            this.materialListView1.TabIndex = 8;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
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
            this.btAlterar.Location = new System.Drawing.Point(1061, 481);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAlterar.Size = new System.Drawing.Size(84, 36);
            this.btAlterar.TabIndex = 7;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAlterar.UseAccentColor = false;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(267, 491);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(10, 28);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = ":";
            // 
            // HoraBkp
            // 
            this.HoraBkp.Text = "Hora";
            this.HoraBkp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HoraBkp.Width = 150;
            // 
            // Caminho
            // 
            this.Caminho.Text = "Caminho";
            this.Caminho.Width = 450;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1304, 697);
            this.Controls.Add(this.tbControlHome);
            this.DrawerTabControl = this.tbControlHome;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1056, 697);
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotina de Backup";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tbControlHome.ResumeLayout(false);
            this.tbBackup.ResumeLayout(false);
            this.tbBackup.PerformLayout();
            this.tbSettings.ResumeLayout(false);
            this.tbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl tbControlHome;
        private System.Windows.Forms.TabPage tbSettings;
        private System.Windows.Forms.TabPage tbBanco;
        private System.Windows.Forms.TabPage tbBackup;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btAdicionar;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader Servidor;
        private System.Windows.Forms.ColumnHeader Base;
        private MaterialSkin.Controls.MaterialButton btAlterar;
        private System.Windows.Forms.ColumnHeader HoraBkp;
        private System.Windows.Forms.ColumnHeader Caminho;
    }
}