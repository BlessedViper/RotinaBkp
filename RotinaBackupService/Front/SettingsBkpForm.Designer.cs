
namespace RotinaBackupService.Front
{
    partial class SettingsBkpForm
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
            this.cbHora = new MaterialSkin.Controls.MaterialComboBox();
            this.cbMin = new MaterialSkin.Controls.MaterialComboBox();
            this.lbHoraBkp = new MaterialSkin.Controls.MaterialLabel();
            this.lbPontos = new System.Windows.Forms.Label();
            this.lbCaminhoRed = new MaterialSkin.Controls.MaterialLabel();
            this.btBuscaCamRed = new MaterialSkin.Controls.MaterialButton();
            this.ckbRedundancia = new MaterialSkin.Controls.MaterialCheckbox();
            this.btGravar = new MaterialSkin.Controls.MaterialButton();
            this.lbCaminhoBackpInfo = new MaterialSkin.Controls.MaterialLabel();
            this.lbCaminhoRedInfo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btBuscaCam
            // 
            this.btBuscaCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscaCam.AutoSize = false;
            this.btBuscaCam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBuscaCam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btBuscaCam.Depth = 0;
            this.btBuscaCam.HighEmphasis = true;
            this.btBuscaCam.Icon = global::RotinaBackupService.Properties.Resources.lupa;
            this.btBuscaCam.Location = new System.Drawing.Point(11, 240);
            this.btBuscaCam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btBuscaCam.MaximumSize = new System.Drawing.Size(50, 36);
            this.btBuscaCam.MinimumSize = new System.Drawing.Size(50, 36);
            this.btBuscaCam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btBuscaCam.Name = "btBuscaCam";
            this.btBuscaCam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btBuscaCam.Size = new System.Drawing.Size(50, 36);
            this.btBuscaCam.TabIndex = 2;
            this.btBuscaCam.Text = " ";
            this.btBuscaCam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btBuscaCam.UseAccentColor = false;
            this.btBuscaCam.UseVisualStyleBackColor = true;
            this.btBuscaCam.Click += new System.EventHandler(this.btBuscaCam_Click);
            // 
            // lbCaminho
            // 
            this.lbCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaminho.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCaminho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCaminho.Depth = 0;
            this.lbCaminho.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbCaminho.Location = new System.Drawing.Point(74, 245);
            this.lbCaminho.MaximumSize = new System.Drawing.Size(711, 26);
            this.lbCaminho.MinimumSize = new System.Drawing.Size(711, 26);
            this.lbCaminho.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCaminho.Name = "lbCaminho";
            this.lbCaminho.Size = new System.Drawing.Size(711, 26);
            this.lbCaminho.TabIndex = 1;
            // 
            // cbHora
            // 
            this.cbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHora.AutoResize = false;
            this.cbHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHora.Depth = 0;
            this.cbHora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbHora.DropDownHeight = 174;
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.DropDownWidth = 105;
            this.cbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.IntegralHeight = false;
            this.cbHora.ItemHeight = 43;
            this.cbHora.Location = new System.Drawing.Point(178, 94);
            this.cbHora.MaxDropDownItems = 4;
            this.cbHora.MouseState = MaterialSkin.MouseState.OUT;
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(105, 49);
            this.cbHora.StartIndex = 0;
            this.cbHora.TabIndex = 0;
            // 
            // cbMin
            // 
            this.cbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMin.AutoResize = false;
            this.cbMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMin.Depth = 0;
            this.cbMin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMin.DropDownHeight = 174;
            this.cbMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMin.DropDownWidth = 105;
            this.cbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMin.FormattingEnabled = true;
            this.cbMin.IntegralHeight = false;
            this.cbMin.ItemHeight = 43;
            this.cbMin.Location = new System.Drawing.Point(305, 94);
            this.cbMin.MaxDropDownItems = 4;
            this.cbMin.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(105, 49);
            this.cbMin.StartIndex = 0;
            this.cbMin.TabIndex = 1;
            // 
            // lbHoraBkp
            // 
            this.lbHoraBkp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHoraBkp.AutoSize = true;
            this.lbHoraBkp.Depth = 0;
            this.lbHoraBkp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbHoraBkp.Location = new System.Drawing.Point(11, 110);
            this.lbHoraBkp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbHoraBkp.Name = "lbHoraBkp";
            this.lbHoraBkp.Size = new System.Drawing.Size(114, 19);
            this.lbHoraBkp.TabIndex = 4;
            this.lbHoraBkp.Text = "Hora do Backup";
            // 
            // lbPontos
            // 
            this.lbPontos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontos.Location = new System.Drawing.Point(281, 95);
            this.lbPontos.Name = "lbPontos";
            this.lbPontos.Size = new System.Drawing.Size(31, 46);
            this.lbPontos.TabIndex = 5;
            this.lbPontos.Text = ":";
            // 
            // lbCaminhoRed
            // 
            this.lbCaminhoRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaminhoRed.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCaminhoRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCaminhoRed.Depth = 0;
            this.lbCaminhoRed.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbCaminhoRed.Location = new System.Drawing.Point(74, 329);
            this.lbCaminhoRed.MaximumSize = new System.Drawing.Size(711, 26);
            this.lbCaminhoRed.MinimumSize = new System.Drawing.Size(711, 26);
            this.lbCaminhoRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCaminhoRed.Name = "lbCaminhoRed";
            this.lbCaminhoRed.Size = new System.Drawing.Size(711, 26);
            this.lbCaminhoRed.TabIndex = 10;
            this.lbCaminhoRed.Visible = false;
            // 
            // btBuscaCamRed
            // 
            this.btBuscaCamRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscaCamRed.AutoSize = false;
            this.btBuscaCamRed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBuscaCamRed.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btBuscaCamRed.Depth = 0;
            this.btBuscaCamRed.HighEmphasis = true;
            this.btBuscaCamRed.Icon = global::RotinaBackupService.Properties.Resources.lupa;
            this.btBuscaCamRed.Location = new System.Drawing.Point(11, 324);
            this.btBuscaCamRed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btBuscaCamRed.MaximumSize = new System.Drawing.Size(50, 36);
            this.btBuscaCamRed.MinimumSize = new System.Drawing.Size(50, 36);
            this.btBuscaCamRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btBuscaCamRed.Name = "btBuscaCamRed";
            this.btBuscaCamRed.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btBuscaCamRed.Size = new System.Drawing.Size(50, 36);
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
            this.ckbRedundancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbRedundancia.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbRedundancia.AutoSize = true;
            this.ckbRedundancia.Depth = 0;
            this.ckbRedundancia.Location = new System.Drawing.Point(14, 496);
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
            this.btGravar.Location = new System.Drawing.Point(668, 497);
            this.btGravar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.lbCaminhoBackpInfo.Location = new System.Drawing.Point(299, 214);
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
            this.lbCaminhoRedInfo.Location = new System.Drawing.Point(235, 293);
            this.lbCaminhoRedInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCaminhoRedInfo.Name = "lbCaminhoRedInfo";
            this.lbCaminhoRedInfo.Size = new System.Drawing.Size(219, 19);
            this.lbCaminhoRedInfo.TabIndex = 14;
            this.lbCaminhoRedInfo.Text = "Caminho Backup Redundância";
            this.lbCaminhoRedInfo.Visible = false;
            // 
            // SettingsBkpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 553);
            this.Controls.Add(this.lbCaminhoRedInfo);
            this.Controls.Add(this.lbCaminhoBackpInfo);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.lbCaminhoRed);
            this.Controls.Add(this.btBuscaCamRed);
            this.Controls.Add(this.lbHoraBkp);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.lbCaminho);
            this.Controls.Add(this.btBuscaCam);
            this.Controls.Add(this.lbPontos);
            this.Controls.Add(this.ckbRedundancia);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(791, 553);
            this.MinimumSize = new System.Drawing.Size(791, 553);
            this.Name = "SettingsBkpForm";
            this.Text = "Configuração do Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btBuscaCam;
        private MaterialSkin.Controls.MaterialLabel lbCaminho;
        private MaterialSkin.Controls.MaterialComboBox cbHora;
        private MaterialSkin.Controls.MaterialComboBox cbMin;
        private MaterialSkin.Controls.MaterialLabel lbHoraBkp;
        private System.Windows.Forms.Label lbPontos;
        private MaterialSkin.Controls.MaterialLabel lbCaminhoRed;
        private MaterialSkin.Controls.MaterialButton btBuscaCamRed;
        private MaterialSkin.Controls.MaterialCheckbox ckbRedundancia;
        private MaterialSkin.Controls.MaterialButton btGravar;
        private MaterialSkin.Controls.MaterialLabel lbCaminhoBackpInfo;
        private MaterialSkin.Controls.MaterialLabel lbCaminhoRedInfo;
    }
}