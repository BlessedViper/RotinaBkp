
namespace RotinaBackupService.Forms
{
    partial class frmConexaoForm
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
            this.lbBanco = new MaterialSkin.Controls.MaterialLabel();
            this.lbUser = new MaterialSkin.Controls.MaterialLabel();
            this.lbSenha = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.bntGravar = new MaterialSkin.Controls.MaterialButton();
            this.btCancela = new MaterialSkin.Controls.MaterialButton();
            this.btTesteCon = new MaterialSkin.Controls.MaterialButton();
            this.txtServidor = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBanco = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.lbServidor = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.Depth = 0;
            this.lbBanco.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBanco.Location = new System.Drawing.Point(8, 182);
            this.lbBanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBanco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(117, 19);
            this.lbBanco.TabIndex = 8;
            this.lbBanco.Text = "Banco de Dados";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.SystemColors.Control;
            this.lbUser.Depth = 0;
            this.lbUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUser.Location = new System.Drawing.Point(12, 254);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(55, 19);
            this.lbUser.TabIndex = 9;
            this.lbUser.Text = "Usuário";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Depth = 0;
            this.lbSenha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenha.Location = new System.Drawing.Point(12, 323);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSenha.Size = new System.Drawing.Size(46, 19);
            this.lbSenha.TabIndex = 10;
            this.lbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(181, 303);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Password = true;
            this.txtSenha.Size = new System.Drawing.Size(511, 50);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "";
            this.txtSenha.TrailingIcon = null;
            // 
            // bntGravar
            // 
            this.bntGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntGravar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntGravar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bntGravar.Depth = 0;
            this.bntGravar.HighEmphasis = true;
            this.bntGravar.Icon = null;
            this.bntGravar.Location = new System.Drawing.Point(614, 495);
            this.bntGravar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.bntGravar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bntGravar.Name = "bntGravar";
            this.bntGravar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bntGravar.Size = new System.Drawing.Size(78, 36);
            this.bntGravar.TabIndex = 5;
            this.bntGravar.Text = "Gravar";
            this.bntGravar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bntGravar.UseAccentColor = false;
            this.bntGravar.UseVisualStyleBackColor = false;
            this.bntGravar.Click += new System.EventHandler(this.GravarBt_Click);
            // 
            // btCancela
            // 
            this.btCancela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancela.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancela.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btCancela.Depth = 0;
            this.btCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancela.HighEmphasis = true;
            this.btCancela.Icon = null;
            this.btCancela.Location = new System.Drawing.Point(508, 495);
            this.btCancela.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btCancela.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCancela.Name = "btCancela";
            this.btCancela.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btCancela.Size = new System.Drawing.Size(96, 36);
            this.btCancela.TabIndex = 6;
            this.btCancela.Text = "Cancelar";
            this.btCancela.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btCancela.UseAccentColor = false;
            this.btCancela.UseVisualStyleBackColor = false;
            this.btCancela.Click += new System.EventHandler(this.Cancela_Click);
            // 
            // btTesteCon
            // 
            this.btTesteCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btTesteCon.AutoSize = false;
            this.btTesteCon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btTesteCon.BackColor = System.Drawing.SystemColors.Window;
            this.btTesteCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTesteCon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btTesteCon.Depth = 0;
            this.btTesteCon.HighEmphasis = true;
            this.btTesteCon.Icon = null;
            this.btTesteCon.Location = new System.Drawing.Point(204, 398);
            this.btTesteCon.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btTesteCon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btTesteCon.Name = "btTesteCon";
            this.btTesteCon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btTesteCon.Size = new System.Drawing.Size(328, 44);
            this.btTesteCon.TabIndex = 4;
            this.btTesteCon.Text = "Testar Conexão";
            this.btTesteCon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btTesteCon.UseAccentColor = false;
            this.btTesteCon.UseVisualStyleBackColor = false;
            this.btTesteCon.Click += new System.EventHandler(this.TesteConBt_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtServidor.AnimateReadOnly = false;
            this.txtServidor.BackColor = System.Drawing.SystemColors.Control;
            this.txtServidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServidor.Depth = 0;
            this.txtServidor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServidor.LeadingIcon = null;
            this.txtServidor.Location = new System.Drawing.Point(181, 97);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServidor.MaxLength = 50;
            this.txtServidor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServidor.Multiline = false;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(511, 50);
            this.txtServidor.TabIndex = 0;
            this.txtServidor.Text = "";
            this.txtServidor.TrailingIcon = null;
            // 
            // txtBanco
            // 
            this.txtBanco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBanco.AnimateReadOnly = false;
            this.txtBanco.BackColor = System.Drawing.SystemColors.Control;
            this.txtBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBanco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanco.Depth = 0;
            this.txtBanco.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBanco.LeadingIcon = null;
            this.txtBanco.Location = new System.Drawing.Point(181, 165);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(4);
            this.txtBanco.MaxLength = 50;
            this.txtBanco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBanco.Multiline = false;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(511, 50);
            this.txtBanco.TabIndex = 1;
            this.txtBanco.Text = "";
            this.txtBanco.TrailingIcon = null;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(181, 234);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MaxLength = 50;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(511, 50);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "";
            this.txtUser.TrailingIcon = null;
            // 
            // lbServidor
            // 
            this.lbServidor.AutoSize = true;
            this.lbServidor.Depth = 0;
            this.lbServidor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbServidor.Location = new System.Drawing.Point(7, 115);
            this.lbServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbServidor.Name = "lbServidor";
            this.lbServidor.Size = new System.Drawing.Size(59, 19);
            this.lbServidor.TabIndex = 11;
            this.lbServidor.Text = "Servidor";
            // 
            // frmConexaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btCancela;
            this.ClientSize = new System.Drawing.Size(711, 551);
            this.Controls.Add(this.lbServidor);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.btTesteCon);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.bntGravar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbBanco);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(711, 551);
            this.Name = "frmConexaoForm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Conexão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private MaterialSkin.Controls.MaterialLabel lbBanco;
        private MaterialSkin.Controls.MaterialLabel lbUser;
        private MaterialSkin.Controls.MaterialLabel lbSenha;
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private MaterialSkin.Controls.MaterialButton bntGravar;
        private MaterialSkin.Controls.MaterialButton btCancela;
        private MaterialSkin.Controls.MaterialButton btTesteCon;
        private MaterialSkin.Controls.MaterialTextBox txtServidor;
        private MaterialSkin.Controls.MaterialTextBox txtBanco;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialLabel lbServidor;
    }
}