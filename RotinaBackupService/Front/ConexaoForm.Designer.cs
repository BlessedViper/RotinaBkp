namespace RotinaBackupService.Front
{
    partial class ConexaoForm
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.lbServidor = new MaterialSkin.Controls.MaterialLabel();
            this.lbBanco = new MaterialSkin.Controls.MaterialLabel();
            this.lbUser = new MaterialSkin.Controls.MaterialLabel();
            this.lbSenha = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.btGravar = new MaterialSkin.Controls.MaterialButton();
            this.btCancela = new MaterialSkin.Controls.MaterialButton();
            this.btTesteCon = new MaterialSkin.Controls.MaterialButton();
            this.txtServidor = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBanco = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbServidor
            // 
            this.lbServidor.AutoSize = true;
            this.lbServidor.BackColor = System.Drawing.SystemColors.Window;
            this.lbServidor.Depth = 0;
            this.lbServidor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbServidor.Location = new System.Drawing.Point(33, 279);
            this.lbServidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbServidor.Name = "lbServidor";
            this.lbServidor.Size = new System.Drawing.Size(59, 19);
            this.lbServidor.TabIndex = 2;
            this.lbServidor.Text = "Servidor";
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.BackColor = System.Drawing.SystemColors.Window;
            this.lbBanco.Depth = 0;
            this.lbBanco.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBanco.Location = new System.Drawing.Point(33, 327);
            this.lbBanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBanco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(117, 19);
            this.lbBanco.TabIndex = 3;
            this.lbBanco.Text = "Banco de Dados";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.SystemColors.Window;
            this.lbUser.Depth = 0;
            this.lbUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUser.Location = new System.Drawing.Point(33, 376);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(55, 19);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "Usuário";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.lbSenha.Depth = 0;
            this.lbSenha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenha.Location = new System.Drawing.Point(33, 425);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(46, 19);
            this.lbSenha.TabIndex = 5;
            this.lbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(160, 394);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(511, 50);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.Text = "";
            this.txtSenha.TrailingIcon = null;
            // 
            // btGravar
            // 
            this.btGravar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGravar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btGravar.Depth = 0;
            this.btGravar.HighEmphasis = true;
            this.btGravar.Icon = null;
            this.btGravar.Location = new System.Drawing.Point(412, 559);
            this.btGravar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btGravar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGravar.Name = "btGravar";
            this.btGravar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btGravar.Size = new System.Drawing.Size(78, 36);
            this.btGravar.TabIndex = 9;
            this.btGravar.Text = "Gravar";
            this.btGravar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btGravar.UseAccentColor = false;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.GravarBt_Click);
            // 
            // btCancela
            // 
            this.btCancela.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancela.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btCancela.Depth = 0;
            this.btCancela.HighEmphasis = true;
            this.btCancela.Icon = null;
            this.btCancela.Location = new System.Drawing.Point(539, 559);
            this.btCancela.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btCancela.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCancela.Name = "btCancela";
            this.btCancela.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btCancela.Size = new System.Drawing.Size(96, 36);
            this.btCancela.TabIndex = 10;
            this.btCancela.Text = "Cancelar";
            this.btCancela.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btCancela.UseAccentColor = false;
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.Cancela_Click);
            // 
            // btTesteCon
            // 
            this.btTesteCon.AutoSize = false;
            this.btTesteCon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btTesteCon.BackColor = System.Drawing.SystemColors.Window;
            this.btTesteCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTesteCon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btTesteCon.Depth = 0;
            this.btTesteCon.HighEmphasis = true;
            this.btTesteCon.Icon = null;
            this.btTesteCon.Location = new System.Drawing.Point(226, 482);
            this.btTesteCon.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btTesteCon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btTesteCon.Name = "btTesteCon";
            this.btTesteCon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btTesteCon.Size = new System.Drawing.Size(264, 36);
            this.btTesteCon.TabIndex = 12;
            this.btTesteCon.Text = "Testar Conexão";
            this.btTesteCon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btTesteCon.UseAccentColor = false;
            this.btTesteCon.UseVisualStyleBackColor = false;
            this.btTesteCon.Click += new System.EventHandler(this.TesteConBt_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.AnimateReadOnly = false;
            this.txtServidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServidor.Depth = 0;
            this.txtServidor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServidor.LeadingIcon = null;
            this.txtServidor.Location = new System.Drawing.Point(160, 248);
            this.txtServidor.MaxLength = 50;
            this.txtServidor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServidor.Multiline = false;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(511, 50);
            this.txtServidor.TabIndex = 13;
            this.txtServidor.Text = "";
            this.txtServidor.TrailingIcon = null;
            // 
            // txtBanco
            // 
            this.txtBanco.AnimateReadOnly = false;
            this.txtBanco.BackColor = System.Drawing.SystemColors.Window;
            this.txtBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBanco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanco.Depth = 0;
            this.txtBanco.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBanco.LeadingIcon = null;
            this.txtBanco.Location = new System.Drawing.Point(160, 296);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(4);
            this.txtBanco.MaxLength = 50;
            this.txtBanco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBanco.Multiline = false;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(511, 50);
            this.txtBanco.TabIndex = 6;
            this.txtBanco.Text = "";
            this.txtBanco.TrailingIcon = null;
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(160, 345);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MaxLength = 50;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(511, 50);
            this.txtUser.TabIndex = 7;
            this.txtUser.Text = "";
            this.txtUser.TrailingIcon = null;
            // 
            // ConexaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btCancela;
            this.ClientSize = new System.Drawing.Size(689, 615);
            this.ControlBox = false;
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.btTesteCon);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbBanco);
            this.Controls.Add(this.lbServidor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConexaoForm";
            this.Text = "Conexão com o Banco de Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.TesteConBt_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialLabel lbServidor;
        private MaterialSkin.Controls.MaterialLabel lbBanco;
        private MaterialSkin.Controls.MaterialLabel lbUser;
        private MaterialSkin.Controls.MaterialLabel lbSenha;
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private MaterialSkin.Controls.MaterialButton btGravar;
        private MaterialSkin.Controls.MaterialButton btCancela;
        private MaterialSkin.Controls.MaterialButton btTesteCon;
        private MaterialSkin.Controls.MaterialTextBox txtServidor;
        private MaterialSkin.Controls.MaterialTextBox txtBanco;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
    }
}