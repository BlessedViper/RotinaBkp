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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConexaoForm));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.txtServidor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbServidor = new MaterialSkin.Controls.MaterialLabel();
            this.lbBanco = new MaterialSkin.Controls.MaterialLabel();
            this.lbUser = new MaterialSkin.Controls.MaterialLabel();
            this.lbSenha = new MaterialSkin.Controls.MaterialLabel();
            this.txtBanco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btGravar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btCancela = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbLogo = new MaterialSkin.Controls.MaterialLabel();
            this.btTesteCon = new MaterialSkin.Controls.MaterialFlatButton();
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
            // txtServidor
            // 
            this.txtServidor.BackColor = System.Drawing.SystemColors.Window;
            this.txtServidor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServidor.Depth = 0;
            this.txtServidor.Hint = "";
            this.txtServidor.Location = new System.Drawing.Point(199, 310);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(4);
            this.txtServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '\0';
            this.txtServidor.SelectedText = "";
            this.txtServidor.SelectionLength = 0;
            this.txtServidor.SelectionStart = 0;
            this.txtServidor.Size = new System.Drawing.Size(472, 28);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.UseSystemPasswordChar = false;
            // 
            // lbServidor
            // 
            this.lbServidor.AutoSize = true;
            this.lbServidor.BackColor = System.Drawing.SystemColors.Window;
            this.lbServidor.Depth = 0;
            this.lbServidor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbServidor.Location = new System.Drawing.Point(33, 310);
            this.lbServidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbServidor.Name = "lbServidor";
            this.lbServidor.Size = new System.Drawing.Size(79, 24);
            this.lbServidor.TabIndex = 2;
            this.lbServidor.Text = "Servidor";
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.BackColor = System.Drawing.SystemColors.Window;
            this.lbBanco.Depth = 0;
            this.lbBanco.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbBanco.Location = new System.Drawing.Point(33, 347);
            this.lbBanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBanco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(148, 24);
            this.lbBanco.TabIndex = 3;
            this.lbBanco.Text = "Banco de Dados";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.SystemColors.Window;
            this.lbUser.Depth = 0;
            this.lbUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUser.Location = new System.Drawing.Point(33, 385);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(74, 24);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "Usuário";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.lbSenha.Depth = 0;
            this.lbSenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenha.Location = new System.Drawing.Point(33, 428);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(61, 24);
            this.lbSenha.TabIndex = 5;
            this.lbSenha.Text = "Senha";
            // 
            // txtBanco
            // 
            this.txtBanco.BackColor = System.Drawing.SystemColors.Window;
            this.txtBanco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanco.Depth = 0;
            this.txtBanco.Hint = "";
            this.txtBanco.Location = new System.Drawing.Point(199, 347);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(4);
            this.txtBanco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.PasswordChar = '\0';
            this.txtBanco.SelectedText = "";
            this.txtBanco.SelectionLength = 0;
            this.txtBanco.SelectionStart = 0;
            this.txtBanco.Size = new System.Drawing.Size(472, 28);
            this.txtBanco.TabIndex = 6;
            this.txtBanco.UseSystemPasswordChar = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Depth = 0;
            this.txtUser.Hint = "";
            this.txtUser.Location = new System.Drawing.Point(199, 385);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(472, 28);
            this.txtUser.TabIndex = 7;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(199, 428);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(472, 28);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // btGravar
            // 
            this.btGravar.AutoSize = true;
            this.btGravar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGravar.Depth = 0;
            this.btGravar.Location = new System.Drawing.Point(412, 559);
            this.btGravar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btGravar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGravar.Name = "btGravar";
            this.btGravar.Primary = false;
            this.btGravar.Size = new System.Drawing.Size(80, 36);
            this.btGravar.TabIndex = 9;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.GravarBt_Click);
            // 
            // btCancela
            // 
            this.btCancela.AutoSize = true;
            this.btCancela.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancela.Depth = 0;
            this.btCancela.Location = new System.Drawing.Point(539, 559);
            this.btCancela.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btCancela.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCancela.Name = "btCancela";
            this.btCancela.Primary = false;
            this.btCancela.Size = new System.Drawing.Size(100, 36);
            this.btCancela.TabIndex = 10;
            this.btCancela.Text = "Cancelar";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.Cancela_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLogo.Depth = 0;
            this.lbLogo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLogo.Image = ((System.Drawing.Image)(resources.GetObject("lbLogo.Image")));
            this.lbLogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbLogo.Location = new System.Drawing.Point(67, 91);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(563, 199);
            this.lbLogo.TabIndex = 11;
            // 
            // btTesteCon
            // 
            this.btTesteCon.AutoSize = true;
            this.btTesteCon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btTesteCon.BackColor = System.Drawing.SystemColors.Window;
            this.btTesteCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTesteCon.Depth = 0;
            this.btTesteCon.Location = new System.Drawing.Point(147, 483);
            this.btTesteCon.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btTesteCon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btTesteCon.Name = "btTesteCon";
            this.btTesteCon.Primary = false;
            this.btTesteCon.Size = new System.Drawing.Size(159, 36);
            this.btTesteCon.TabIndex = 12;
            this.btTesteCon.Text = "Testar Conexão";
            this.btTesteCon.UseVisualStyleBackColor = false;
            this.btTesteCon.Click += new System.EventHandler(this.TesteConBt_Click);
            // 
            // ConexaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(689, 615);
            this.ControlBox = false;
            this.Controls.Add(this.btTesteCon);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbBanco);
            this.Controls.Add(this.lbServidor);
            this.Controls.Add(this.txtServidor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConexaoForm";
            this.Text = "Conexão com o Banco de Dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConexaoForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConexaoForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.TesteConBt_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServidor;
        private MaterialSkin.Controls.MaterialLabel lbServidor;
        private MaterialSkin.Controls.MaterialLabel lbBanco;
        private MaterialSkin.Controls.MaterialLabel lbUser;
        private MaterialSkin.Controls.MaterialLabel lbSenha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBanco;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialFlatButton btGravar;
        private MaterialSkin.Controls.MaterialFlatButton btCancela;
        private MaterialSkin.Controls.MaterialLabel lbLogo;
        private MaterialSkin.Controls.MaterialFlatButton btTesteCon;
    }
}