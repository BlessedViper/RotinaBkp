namespace RotinaBackupService.Front
{
    partial class Principal
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
            this.lbCaminho = new MaterialSkin.Controls.MaterialLabel();
            this.tcPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.BackupSettings = new System.Windows.Forms.TabPage();
            this.EmailSettings = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tcPrincipal.SuspendLayout();
            this.BackupSettings.SuspendLayout();
            this.EmailSettings.SuspendLayout();
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
            // lbCaminho
            // 
            this.lbCaminho.AutoSize = true;
            this.lbCaminho.Depth = 0;
            this.lbCaminho.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCaminho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCaminho.Location = new System.Drawing.Point(16, 19);
            this.lbCaminho.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCaminho.Name = "lbCaminho";
            this.lbCaminho.Size = new System.Drawing.Size(180, 24);
            this.lbCaminho.TabIndex = 1;
            this.lbCaminho.Text = "Caminho do Backup";
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.BackupSettings);
            this.tcPrincipal.Controls.Add(this.EmailSettings);
            this.tcPrincipal.Depth = 0;
            this.tcPrincipal.Location = new System.Drawing.Point(12, 83);
            this.tcPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(811, 508);
            this.tcPrincipal.TabIndex = 3;
            // 
            // BackupSettings
            // 
            this.BackupSettings.BackColor = System.Drawing.Color.White;
            this.BackupSettings.Controls.Add(this.lbCaminho);
            this.BackupSettings.Location = new System.Drawing.Point(4, 25);
            this.BackupSettings.Name = "BackupSettings";
            this.BackupSettings.Padding = new System.Windows.Forms.Padding(3);
            this.BackupSettings.Size = new System.Drawing.Size(803, 479);
            this.BackupSettings.TabIndex = 0;
            this.BackupSettings.Text = "Backup Settings";
            this.BackupSettings.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // EmailSettings
            // 
            this.EmailSettings.BackColor = System.Drawing.Color.White;
            this.EmailSettings.Controls.Add(this.materialLabel1);
            this.EmailSettings.Location = new System.Drawing.Point(4, 25);
            this.EmailSettings.Name = "EmailSettings";
            this.EmailSettings.Padding = new System.Windows.Forms.Padding(3);
            this.EmailSettings.Size = new System.Drawing.Size(803, 479);
            this.EmailSettings.TabIndex = 1;
            this.EmailSettings.Text = "E-mails Settings";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(445, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(835, 603);
            this.Controls.Add(this.tcPrincipal);
            this.Controls.Add(this.materialDivider1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rotina de Backup";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.BackupSettings.ResumeLayout(false);
            this.BackupSettings.PerformLayout();
            this.EmailSettings.ResumeLayout(false);
            this.EmailSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lbCaminho;
        private MaterialSkin.Controls.MaterialTabControl tcPrincipal;
        private System.Windows.Forms.TabPage BackupSettings;
        private System.Windows.Forms.TabPage EmailSettings;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}