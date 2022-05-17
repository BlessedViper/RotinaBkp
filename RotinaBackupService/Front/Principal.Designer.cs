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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbControlPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tbSettings = new System.Windows.Forms.TabPage();
            this.tbBanco = new System.Windows.Forms.TabPage();
            this.tbControlPrincipal.SuspendLayout();
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
            // 
            // tbControlPrincipal
            // 
            this.tbControlPrincipal.Controls.Add(this.tbSettings);
            this.tbControlPrincipal.Controls.Add(this.tbBanco);
            this.tbControlPrincipal.Depth = 0;
            this.tbControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlPrincipal.ImageList = this.imageList1;
            this.tbControlPrincipal.Location = new System.Drawing.Point(3, 64);
            this.tbControlPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbControlPrincipal.Multiline = true;
            this.tbControlPrincipal.Name = "tbControlPrincipal";
            this.tbControlPrincipal.SelectedIndex = 0;
            this.tbControlPrincipal.Size = new System.Drawing.Size(829, 536);
            this.tbControlPrincipal.TabIndex = 1;
            // 
            // tbSettings
            // 
            this.tbSettings.BackColor = System.Drawing.Color.White;
            this.tbSettings.ImageKey = "config.png";
            this.tbSettings.Location = new System.Drawing.Point(4, 39);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbSettings.Size = new System.Drawing.Size(821, 493);
            this.tbSettings.TabIndex = 0;
            this.tbSettings.Text = "Settings";
            // 
            // tbBanco
            // 
            this.tbBanco.BackColor = System.Drawing.Color.White;
            this.tbBanco.ImageKey = "base.png";
            this.tbBanco.Location = new System.Drawing.Point(4, 39);
            this.tbBanco.Name = "tbBanco";
            this.tbBanco.Padding = new System.Windows.Forms.Padding(3);
            this.tbBanco.Size = new System.Drawing.Size(821, 493);
            this.tbBanco.TabIndex = 1;
            this.tbBanco.Text = "Banco de Dados";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(835, 603);
            this.Controls.Add(this.tbControlPrincipal);
            this.DrawerTabControl = this.tbControlPrincipal;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rotina de Backup";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tbControlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl tbControlPrincipal;
        private System.Windows.Forms.TabPage tbSettings;
        private System.Windows.Forms.TabPage tbBanco;
    }
}