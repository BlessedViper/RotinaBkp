
namespace RotinaBackupService.Forms
{
    partial class frmSettingsBkpForm
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
            this.btBuscaCam = new MaterialSkin.Controls.MaterialButton();
            this.lbCaminho = new MaterialSkin.Controls.MaterialLabel();
            this.lbHoraBkp = new MaterialSkin.Controls.MaterialLabel();
            this.lbCaminhoRed = new MaterialSkin.Controls.MaterialLabel();
            this.btBuscaCamRed = new MaterialSkin.Controls.MaterialButton();
            this.ckbRedundancia = new MaterialSkin.Controls.MaterialCheckbox();
            this.btGravar = new MaterialSkin.Controls.MaterialButton();
            this.lbCaminhoBackpInfo = new MaterialSkin.Controls.MaterialLabel();
            this.lbCaminhoRedInfo = new MaterialSkin.Controls.MaterialLabel();
            this.dtpTimer = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btBuscaCam
            // 
            this.btBuscaCam.AutoSize = false;
            this.btBuscaCam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBuscaCam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btBuscaCam.Depth = 0;
            this.btBuscaCam.HighEmphasis = true;
            this.btBuscaCam.Icon = global::RotinaBackup.Properties.Resources.lupa;
            this.btBuscaCam.Location = new System.Drawing.Point(11, 300);
            this.btBuscaCam.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btBuscaCam.MaximumSize = new System.Drawing.Size(50, 45);
            this.btBuscaCam.MinimumSize = new System.Drawing.Size(50, 45);
            this.btBuscaCam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btBuscaCam.Name = "btBuscaCam";
            this.btBuscaCam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btBuscaCam.Size = new System.Drawing.Size(50, 45);
            this.btBuscaCam.TabIndex = 2;
            this.btBuscaCam.Text = " ";
            this.btBuscaCam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btBuscaCam.UseAccentColor = false;
            this.btBuscaCam.UseVisualStyleBackColor = true;
            this.btBuscaCam.Click += new System.EventHandler(this.btBuscaCam_Click);
            // 
            // lbCaminho
            // 
            this.lbCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaminho.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCaminho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCaminho.Depth = 0;
            this.lbCaminho.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbCaminho.Location = new System.Drawing.Point(74, 306);
            this.lbCaminho.MaximumSize = new System.Drawing.Size(711, 32);
            this.lbCaminho.MinimumSize = new System.Drawing.Size(711, 32);
            this.lbCaminho.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCaminho.Name = "lbCaminho";
            this.lbCaminho.Size = new System.Drawing.Size(711, 32);
            this.lbCaminho.TabIndex = 1;
            // 
            // lbHoraBkp
            // 
            this.lbHoraBkp.AutoSize = true;
            this.lbHoraBkp.Depth = 0;
            this.lbHoraBkp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbHoraBkp.Location = new System.Drawing.Point(11, 138);
            this.lbHoraBkp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbHoraBkp.Name = "lbHoraBkp";
            this.lbHoraBkp.Size = new System.Drawing.Size(114, 19);
            this.lbHoraBkp.TabIndex = 4;
            this.lbHoraBkp.Text = "Hora do Backup";
            // 
            // lbCaminhoRed
            // 
            this.lbCaminhoRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaminhoRed.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCaminhoRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCaminhoRed.Depth = 0;
            this.lbCaminhoRed.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbCaminhoRed.Location = new System.Drawing.Point(74, 411);
            this.lbCaminhoRed.MaximumSize = new System.Drawing.Size(711, 32);
            this.lbCaminhoRed.MinimumSize = new System.Drawing.Size(711, 32);
            this.lbCaminhoRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCaminhoRed.Name = "lbCaminhoRed";
            this.lbCaminhoRed.Size = new System.Drawing.Size(711, 32);
            this.lbCaminhoRed.TabIndex = 10;
            this.lbCaminhoRed.Visible = false;
            // 
            // btBuscaCamRed
            // 
            this.btBuscaCamRed.AutoSize = false;
            this.btBuscaCamRed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBuscaCamRed.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btBuscaCamRed.Depth = 0;
            this.btBuscaCamRed.HighEmphasis = true;
            this.btBuscaCamRed.Icon = global::RotinaBackup.Properties.Resources.lupa;
            this.btBuscaCamRed.Location = new System.Drawing.Point(11, 405);
            this.btBuscaCamRed.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btBuscaCamRed.MaximumSize = new System.Drawing.Size(50, 45);
            this.btBuscaCamRed.MinimumSize = new System.Drawing.Size(50, 45);
            this.btBuscaCamRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btBuscaCamRed.Name = "btBuscaCamRed";
            this.btBuscaCamRed.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btBuscaCamRed.Size = new System.Drawing.Size(50, 45);
            this.btBuscaCamRed.TabIndex = 5;
            this.btBuscaCamRed.Text = " ";
            this.btBuscaCamRed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btBuscaCamRed.UseAccentColor = false;
            this.btBuscaCamRed.UseVisualStyleBackColor = true;
            this.btBuscaCamRed.Visible = false;
            this.btBuscaCamRed.Click += new System.EventHandler(this.btBuscaCamRed_Click);
            // 
            // ckbRedundancia
            // 
            this.ckbRedundancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbRedundancia.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbRedundancia.AutoSize = true;
            this.ckbRedundancia.Depth = 0;
            this.ckbRedundancia.Location = new System.Drawing.Point(14, 629);
            this.ckbRedundancia.Margin = new System.Windows.Forms.Padding(0);
            this.ckbRedundancia.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbRedundancia.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbRedundancia.Name = "ckbRedundancia";
            this.ckbRedundancia.ReadOnly = false;
            this.ckbRedundancia.Ripple = true;
            this.ckbRedundancia.Size = new System.Drawing.Size(262, 37);
            this.ckbRedundancia.TabIndex = 4;
            this.ckbRedundancia.Text = "Utiliza Backup de Redundancia?";
            this.ckbRedundancia.UseVisualStyleBackColor = false;
            this.ckbRedundancia.CheckedChanged += new System.EventHandler(this.ckbRedundancia_CheckedChanged);
            // 
            // btGravar
            // 
            this.btGravar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btGravar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btGravar.Depth = 0;
            this.btGravar.HighEmphasis = true;
            this.btGravar.Icon = null;
            this.btGravar.Location = new System.Drawing.Point(690, 621);
            this.btGravar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btGravar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGravar.Name = "btGravar";
            this.btGravar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btGravar.Size = new System.Drawing.Size(78, 36);
            this.btGravar.TabIndex = 6;
            this.btGravar.Text = "Gravar";
            this.btGravar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btGravar.UseAccentColor = false;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // lbCaminhoBackpInfo
            // 
            this.lbCaminhoBackpInfo.AutoSize = true;
            this.lbCaminhoBackpInfo.Depth = 0;
            this.lbCaminhoBackpInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbCaminhoBackpInfo.Location = new System.Drawing.Point(299, 268);
            this.lbCaminhoBackpInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCaminhoBackpInfo.Name = "lbCaminhoBackpInfo";
            this.lbCaminhoBackpInfo.Size = new System.Drawing.Size(122, 19);
            this.lbCaminhoBackpInfo.TabIndex = 13;
            this.lbCaminhoBackpInfo.Text = "Caminho Backup";
            // 
            // lbCaminhoRedInfo
            // 
            this.lbCaminhoRedInfo.AutoSize = true;
            this.lbCaminhoRedInfo.Depth = 0;
            this.lbCaminhoRedInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbCaminhoRedInfo.Location = new System.Drawing.Point(235, 366);
            this.lbCaminhoRedInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCaminhoRedInfo.Name = "lbCaminhoRedInfo";
            this.lbCaminhoRedInfo.Size = new System.Drawing.Size(219, 19);
            this.lbCaminhoRedInfo.TabIndex = 14;
            this.lbCaminhoRedInfo.Text = "Caminho Backup Redundância";
            this.lbCaminhoRedInfo.Visible = false;
            // 
            // dtpTimer
            // 
            this.dtpTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTimer.CalendarMonthBackground = System.Drawing.SystemColors.GrayText;
            this.dtpTimer.CustomFormat = "hh:mm";
            this.dtpTimer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimer.Location = new System.Drawing.Point(148, 138);
            this.dtpTimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTimer.Name = "dtpTimer";
            this.dtpTimer.ShowUpDown = true;
            this.dtpTimer.Size = new System.Drawing.Size(100, 27);
            this.dtpTimer.TabIndex = 15;
            // 
            // frmSettingsBkpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 691);
            this.Controls.Add(this.dtpTimer);
            this.Controls.Add(this.lbCaminhoRedInfo);
            this.Controls.Add(this.lbCaminhoBackpInfo);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.lbCaminhoRed);
            this.Controls.Add(this.btBuscaCamRed);
            this.Controls.Add(this.lbHoraBkp);
            this.Controls.Add(this.lbCaminho);
            this.Controls.Add(this.btBuscaCam);
            this.Controls.Add(this.ckbRedundancia);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(791, 691);
            this.MinimumSize = new System.Drawing.Size(791, 691);
            this.Name = "frmSettingsBkpForm";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração do Backup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSettingsBkpForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btBuscaCam;
        private MaterialSkin.Controls.MaterialLabel lbCaminho;
        private MaterialSkin.Controls.MaterialLabel lbHoraBkp;
        private MaterialSkin.Controls.MaterialLabel lbCaminhoRed;
        private MaterialSkin.Controls.MaterialButton btBuscaCamRed;
        private MaterialSkin.Controls.MaterialCheckbox ckbRedundancia;
        private MaterialSkin.Controls.MaterialButton btGravar;
        private MaterialSkin.Controls.MaterialLabel lbCaminhoBackpInfo;
        private MaterialSkin.Controls.MaterialLabel lbCaminhoRedInfo;
        private System.Windows.Forms.DateTimePicker dtpTimer;
    }
}