
namespace Setup.Financas
{
    partial class Configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            this.AtivarNotifLogin = new Setup.Controles.atv();
            this.AtivarNotifVencimentos = new Setup.Controles.atv();
            this.SuspendLayout();
            // 
            // AtivarNotifLogin
            // 
            this.AtivarNotifLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtivarNotifLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtivarNotifLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AtivarNotifLogin.ForeColor = System.Drawing.Color.White;
            this.AtivarNotifLogin.Image = ((System.Drawing.Image)(resources.GetObject("AtivarNotifLogin.Image")));
            this.AtivarNotifLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtivarNotifLogin.Location = new System.Drawing.Point(12, 9);
            this.AtivarNotifLogin.Name = "AtivarNotifLogin";
            this.AtivarNotifLogin.Size = new System.Drawing.Size(166, 44);
            this.AtivarNotifLogin.TabIndex = 0;
            this.AtivarNotifLogin.Tag = "True";
            this.AtivarNotifLogin.Text = "Notificação de login";
            this.AtivarNotifLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AtivarNotifVencimentos
            // 
            this.AtivarNotifVencimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtivarNotifVencimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtivarNotifVencimentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AtivarNotifVencimentos.ForeColor = System.Drawing.Color.White;
            this.AtivarNotifVencimentos.Image = ((System.Drawing.Image)(resources.GetObject("AtivarNotifVencimentos.Image")));
            this.AtivarNotifVencimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtivarNotifVencimentos.Location = new System.Drawing.Point(12, 53);
            this.AtivarNotifVencimentos.Name = "AtivarNotifVencimentos";
            this.AtivarNotifVencimentos.Size = new System.Drawing.Size(222, 47);
            this.AtivarNotifVencimentos.TabIndex = 1;
            this.AtivarNotifVencimentos.Text = "Notificação de compromissos";
            this.AtivarNotifVencimentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(509, 384);
            this.Controls.Add(this.AtivarNotifVencimentos);
            this.Controls.Add(this.AtivarNotifLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Configuracoes";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Configuracoes_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Configuracoes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.atv AtivarNotifLogin;
        private Controles.atv AtivarNotifVencimentos;
    }
}