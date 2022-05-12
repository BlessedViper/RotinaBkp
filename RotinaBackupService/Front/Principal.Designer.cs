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
            this.lbTeste = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbTeste
            // 
            this.lbTeste.Depth = 0;
            this.lbTeste.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTeste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTeste.Location = new System.Drawing.Point(405, 153);
            this.lbTeste.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTeste.Name = "lbTeste";
            this.lbTeste.Size = new System.Drawing.Size(463, 388);
            this.lbTeste.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 721);
            this.Controls.Add(this.lbTeste);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Rotina de Backup";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbTeste;
    }
}