
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fechar = new Setup.Controles.Cabecalho();
            this.menuStrip1.SuspendLayout();
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
            this.AtivarNotifLogin.Location = new System.Drawing.Point(12, 28);
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
            this.AtivarNotifVencimentos.Location = new System.Drawing.Point(12, 72);
            this.AtivarNotifVencimentos.Name = "AtivarNotifVencimentos";
            this.AtivarNotifVencimentos.Size = new System.Drawing.Size(222, 47);
            this.AtivarNotifVencimentos.TabIndex = 1;
            this.AtivarNotifVencimentos.Text = "Notificação de compromissos";
            this.AtivarNotifVencimentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fechar
            // 
            this.fechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fechar.ForeColor = System.Drawing.Color.White;
            this.fechar.Image = ((System.Drawing.Image)(resources.GetObject("fechar.Image")));
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(70, 20);
            this.fechar.Text = "Fechar";
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(346, 384);
            this.Controls.Add(this.AtivarNotifVencimentos);
            this.Controls.Add(this.AtivarNotifLogin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Configuracoes";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Activated += new System.EventHandler(this.Configuracoes_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Configuracoes_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.atv AtivarNotifLogin;
        private Controles.atv AtivarNotifVencimentos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Controles.Cabecalho fechar;
    }
}