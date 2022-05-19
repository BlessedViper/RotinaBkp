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
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.Servidor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Base = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoraBkp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Caminho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAlterar = new MaterialSkin.Controls.MaterialButton();
            this.btBackup = new MaterialSkin.Controls.MaterialButton();
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
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Servidor,
            this.Base,
            this.HoraBkp,
            this.Caminho});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(6, 79);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1276, 420);
            this.materialListView1.TabIndex = 11;
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
            this.btBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btBackup.Depth = 0;
            this.btBackup.HighEmphasis = true;
            this.btBackup.Icon = null;
            this.btBackup.Location = new System.Drawing.Point(900, 534);
            this.btBackup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btBackup.Name = "btBackup";
            this.btBackup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btBackup.Size = new System.Drawing.Size(158, 36);
            this.btBackup.TabIndex = 13;
            this.btBackup.Text = "Backup";
            this.btBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btBackup.UseAccentColor = false;
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1304, 697);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.materialListView1);
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
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader Servidor;
        private System.Windows.Forms.ColumnHeader Base;
        private System.Windows.Forms.ColumnHeader HoraBkp;
        private System.Windows.Forms.ColumnHeader Caminho;
        private MaterialSkin.Controls.MaterialButton btAlterar;
        private MaterialSkin.Controls.MaterialButton btBackup;
    }
}