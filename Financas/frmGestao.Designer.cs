
namespace Setup.Financas
{
    partial class frmGestao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.next = new System.Windows.Forms.ToolStripMenuItem();
            this.back = new System.Windows.Forms.ToolStripMenuItem();
            this.ano = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.next,
            this.back,
            this.ano});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 27);
            this.menuStrip1.TabIndex = 1;
            // 
            // next
            // 
            this.next.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.next.ForeColor = System.Drawing.Color.White;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(28, 23);
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(28, 23);
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ano
            // 
            this.ano.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ano.CausesValidation = false;
            this.ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ano.ForeColor = System.Drawing.Color.White;
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(121, 23);
            // 
            // frmGestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(467, 402);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGestao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem next;
        private System.Windows.Forms.ToolStripMenuItem back;
        public System.Windows.Forms.ToolStripComboBox ano;
    }
}