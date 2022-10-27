using System.Windows.Forms;

namespace Setup.Financas
{
    partial class boxDescricao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boxDescricao));
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.btnSair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnU = new System.Windows.Forms.Label();
            this.lnR = new System.Windows.Forms.Label();
            this.lnL = new System.Windows.Forms.Label();
            this.lnD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTexto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTexto.ForeColor = System.Drawing.Color.White;
            this.txtTexto.Location = new System.Drawing.Point(12, 32);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ReadOnly = true;
            this.txtTexto.Size = new System.Drawing.Size(424, 354);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Text = "";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(202, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(46, 42);
            this.btnSair.TabIndex = 1;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 1);
            this.label1.TabIndex = 2;
            // 
            // lnU
            // 
            this.lnU.BackColor = System.Drawing.Color.DimGray;
            this.lnU.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnU.Location = new System.Drawing.Point(0, 0);
            this.lnU.Name = "lnU";
            this.lnU.Size = new System.Drawing.Size(448, 15);
            this.lnU.TabIndex = 3;
            // 
            // lnR
            // 
            this.lnR.BackColor = System.Drawing.Color.DimGray;
            this.lnR.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnR.Location = new System.Drawing.Point(447, 15);
            this.lnR.Name = "lnR";
            this.lnR.Size = new System.Drawing.Size(1, 419);
            this.lnR.TabIndex = 4;
            // 
            // lnL
            // 
            this.lnL.BackColor = System.Drawing.Color.DimGray;
            this.lnL.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnL.Location = new System.Drawing.Point(0, 15);
            this.lnL.Name = "lnL";
            this.lnL.Size = new System.Drawing.Size(1, 419);
            this.lnL.TabIndex = 5;
            // 
            // lnD
            // 
            this.lnD.BackColor = System.Drawing.Color.DimGray;
            this.lnD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnD.Location = new System.Drawing.Point(1, 433);
            this.lnD.Name = "lnD";
            this.lnD.Size = new System.Drawing.Size(446, 1);
            this.lnD.TabIndex = 6;
            // 
            // boxDescricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(448, 434);
            this.Controls.Add(this.lnD);
            this.Controls.Add(this.lnL);
            this.Controls.Add(this.lnR);
            this.Controls.Add(this.lnU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtTexto);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "boxDescricao";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "boxDescricao";
            this.ResumeLayout(false);

        }

        #endregion
        private Label btnSair;
        public RichTextBox txtTexto;
        private Label label1;
        public Label lnU;
        public Label lnR;
        public Label lnL;
        public Label lnD;
    }
}