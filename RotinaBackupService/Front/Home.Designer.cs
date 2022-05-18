namespace RotinaBackupService.Front
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbControlHome = new MaterialSkin.Controls.MaterialTabControl();
            this.tbBackup = new System.Windows.Forms.TabPage();
            this.tbSettings = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbMin = new MaterialSkin.Controls.MaterialComboBox();
            this.cbHour = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btSelectCam = new MaterialSkin.Controls.MaterialButton();
            this.txtCaminho = new MaterialSkin.Controls.MaterialTextBox();
            this.tbBanco = new System.Windows.Forms.TabPage();
            this.btAlterar = new MaterialSkin.Controls.MaterialButton();
            this.lboxServerList = new MaterialSkin.Controls.MaterialListBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btGravar = new MaterialSkin.Controls.MaterialButton();
            this.tbControlHome.SuspendLayout();
            this.tbBackup.SuspendLayout();
            this.tbSettings.SuspendLayout();
            this.tbBanco.SuspendLayout();
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
            // 
            // tbControlHome
            // 
            this.tbControlHome.Controls.Add(this.tbBackup);
            this.tbControlHome.Controls.Add(this.tbSettings);
            this.tbControlHome.Controls.Add(this.tbBanco);
            this.tbControlHome.Depth = 0;
            this.tbControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlHome.ImageList = this.imageList1;
            this.tbControlHome.Location = new System.Drawing.Point(2, 52);
            this.tbControlHome.Margin = new System.Windows.Forms.Padding(2);
            this.tbControlHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbControlHome.Multiline = true;
            this.tbControlHome.Name = "tbControlHome";
            this.tbControlHome.SelectedIndex = 0;
            this.tbControlHome.Size = new System.Drawing.Size(622, 436);
            this.tbControlHome.TabIndex = 0;
            // 
            // tbBackup
            // 
            this.tbBackup.Controls.Add(this.materialButton1);
            this.tbBackup.ImageKey = "backupdatabase_5665.png";
            this.tbBackup.Location = new System.Drawing.Point(4, 39);
            this.tbBackup.Name = "tbBackup";
            this.tbBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tbBackup.Size = new System.Drawing.Size(614, 393);
            this.tbBackup.TabIndex = 2;
            this.tbBackup.Text = "Backup";
            this.tbBackup.UseVisualStyleBackColor = true;
            // 
            // tbSettings
            // 
            this.tbSettings.BackColor = System.Drawing.Color.White;
            this.tbSettings.Controls.Add(this.btGravar);
            this.tbSettings.Controls.Add(this.materialLabel2);
            this.tbSettings.Controls.Add(this.cbMin);
            this.tbSettings.Controls.Add(this.cbHour);
            this.tbSettings.Controls.Add(this.materialLabel1);
            this.tbSettings.Controls.Add(this.btSelectCam);
            this.tbSettings.Controls.Add(this.txtCaminho);
            this.tbSettings.ImageKey = "config.png";
            this.tbSettings.Location = new System.Drawing.Point(4, 39);
            this.tbSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Padding = new System.Windows.Forms.Padding(2);
            this.tbSettings.Size = new System.Drawing.Size(614, 393);
            this.tbSettings.TabIndex = 0;
            this.tbSettings.Text = "Settings";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(211, 88);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(11, 21);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = ":";
            // 
            // cbMin
            // 
            this.cbMin.AutoResize = false;
            this.cbMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMin.Depth = 0;
            this.cbMin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMin.DropDownHeight = 174;
            this.cbMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMin.DropDownWidth = 121;
            this.cbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMin.FormattingEnabled = true;
            this.cbMin.IntegralHeight = false;
            this.cbMin.ItemHeight = 43;
            this.cbMin.Location = new System.Drawing.Point(221, 71);
            this.cbMin.MaxDropDownItems = 4;
            this.cbMin.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(78, 49);
            this.cbMin.StartIndex = 0;
            this.cbMin.TabIndex = 4;
            // 
            // cbHour
            // 
            this.cbHour.AutoResize = false;
            this.cbHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHour.Depth = 0;
            this.cbHour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbHour.DropDownHeight = 174;
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.DropDownWidth = 121;
            this.cbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbHour.FormattingEnabled = true;
            this.cbHour.IntegralHeight = false;
            this.cbHour.ItemHeight = 43;
            this.cbHour.Location = new System.Drawing.Point(127, 71);
            this.cbHour.MaxDropDownItems = 4;
            this.cbHour.MouseState = MaterialSkin.MouseState.OUT;
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(78, 49);
            this.cbHour.StartIndex = 0;
            this.cbHour.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Hora do Backup";
            // 
            // btSelectCam
            // 
            this.btSelectCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectCam.AutoSize = false;
            this.btSelectCam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSelectCam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btSelectCam.Depth = 0;
            this.btSelectCam.HighEmphasis = true;
            this.btSelectCam.Icon = ((System.Drawing.Image)(resources.GetObject("btSelectCam.Icon")));
            this.btSelectCam.ImageKey = "lupa.png";
            this.btSelectCam.ImageList = this.imageList1;
            this.btSelectCam.Location = new System.Drawing.Point(10, 22);
            this.btSelectCam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSelectCam.MaximumSize = new System.Drawing.Size(39, 36);
            this.btSelectCam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSelectCam.Name = "btSelectCam";
            this.btSelectCam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btSelectCam.Size = new System.Drawing.Size(39, 36);
            this.btSelectCam.TabIndex = 0;
            this.btSelectCam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btSelectCam.UseAccentColor = false;
            this.btSelectCam.UseVisualStyleBackColor = false;
            this.btSelectCam.Click += new System.EventHandler(this.btSelectCam_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.AnimateReadOnly = false;
            this.txtCaminho.BackColor = System.Drawing.SystemColors.Control;
            this.txtCaminho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminho.Depth = 0;
            this.txtCaminho.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCaminho.LeadingIcon = null;
            this.txtCaminho.Location = new System.Drawing.Point(56, 15);
            this.txtCaminho.MaxLength = 50;
            this.txtCaminho.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCaminho.Multiline = false;
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(553, 50);
            this.txtCaminho.TabIndex = 1;
            this.txtCaminho.Text = "";
            this.txtCaminho.TrailingIcon = null;
            // 
            // tbBanco
            // 
            this.tbBanco.BackColor = System.Drawing.Color.White;
            this.tbBanco.Controls.Add(this.btAlterar);
            this.tbBanco.Controls.Add(this.lboxServerList);
            this.tbBanco.ImageKey = "base.png";
            this.tbBanco.Location = new System.Drawing.Point(4, 39);
            this.tbBanco.Margin = new System.Windows.Forms.Padding(2);
            this.tbBanco.Name = "tbBanco";
            this.tbBanco.Padding = new System.Windows.Forms.Padding(2);
            this.tbBanco.Size = new System.Drawing.Size(614, 393);
            this.tbBanco.TabIndex = 1;
            this.tbBanco.Text = "Banco de Dados";
            // 
            // btAlterar
            // 
            this.btAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAlterar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAlterar.Depth = 0;
            this.btAlterar.HighEmphasis = true;
            this.btAlterar.Icon = null;
            this.btAlterar.Location = new System.Drawing.Point(6, 329);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAlterar.Size = new System.Drawing.Size(84, 36);
            this.btAlterar.TabIndex = 1;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAlterar.UseAccentColor = false;
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // lboxServerList
            // 
            this.lboxServerList.BackColor = System.Drawing.Color.White;
            this.lboxServerList.BorderColor = System.Drawing.Color.LightGray;
            this.lboxServerList.Depth = 0;
            this.lboxServerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lboxServerList.Location = new System.Drawing.Point(5, 5);
            this.lboxServerList.MouseState = MaterialSkin.MouseState.HOVER;
            this.lboxServerList.Name = "lboxServerList";
            this.lboxServerList.SelectedIndex = -1;
            this.lboxServerList.SelectedItem = null;
            this.lboxServerList.Size = new System.Drawing.Size(604, 263);
            this.lboxServerList.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(358, 130);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // btGravar
            // 
            this.btGravar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btGravar.BackColor = System.Drawing.Color.Transparent;
            this.btGravar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btGravar.Depth = 0;
            this.btGravar.HighEmphasis = true;
            this.btGravar.Icon = null;
            this.btGravar.Location = new System.Drawing.Point(377, 349);
            this.btGravar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btGravar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGravar.Name = "btGravar";
            this.btGravar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btGravar.Size = new System.Drawing.Size(158, 36);
            this.btGravar.TabIndex = 6;
            this.btGravar.Text = "Gravar";
            this.btGravar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btGravar.UseAccentColor = true;
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(626, 490);
            this.Controls.Add(this.tbControlHome);
            this.DrawerTabControl = this.tbControlHome;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rotina de Backup";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tbControlHome.ResumeLayout(false);
            this.tbBackup.ResumeLayout(false);
            this.tbBackup.PerformLayout();
            this.tbSettings.ResumeLayout(false);
            this.tbSettings.PerformLayout();
            this.tbBanco.ResumeLayout(false);
            this.tbBanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl tbControlHome;
        private System.Windows.Forms.TabPage tbSettings;
        private System.Windows.Forms.TabPage tbBanco;
        private MaterialSkin.Controls.MaterialListBox lboxServerList;
        private MaterialSkin.Controls.MaterialButton btAlterar;
        private MaterialSkin.Controls.MaterialButton btSelectCam;
        private MaterialSkin.Controls.MaterialTextBox txtCaminho;
        private System.Windows.Forms.TabPage tbBackup;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbMin;
        private MaterialSkin.Controls.MaterialComboBox cbHour;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btGravar;
    }
}