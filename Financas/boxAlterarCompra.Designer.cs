
namespace Setup.Financas
{
    partial class boxAlterarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boxAlterarCompra));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtValor = new Setup.Controles.Decimal();
            this.txtData = new Setup.Controles.Data();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new Setup.Controles.Txt();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.cancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvar
            // 
            this.salvar.ForeColor = System.Drawing.Color.White;
            this.salvar.Image = ((System.Drawing.Image)(resources.GetObject("salvar.Image")));
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(66, 20);
            this.salvar.Text = "Salvar";
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Image = ((System.Drawing.Image)(resources.GetObject("cancelar.Image")));
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(81, 20);
            this.cancelar.Text = "Cancelar";
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(183, 14);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(90, 23);
            this.txtValor.TabIndex = 32;
            this.txtValor.Tag = "\'Valor\'";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(45, 14);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(90, 23);
            this.txtData.TabIndex = 31;
            this.txtData.Tag = "\'Data\'";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(144, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Data";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(72, 43);
            this.txtDesc.MaxLength = 200;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(278, 23);
            this.txtDesc.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Descrição";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(5, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 83);
            this.panel1.TabIndex = 35;
            // 
            // boxAlterarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(368, 112);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "boxAlterarCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvar;
        private System.Windows.Forms.ToolStripMenuItem cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public Controles.Decimal txtValor;
        public Controles.Data txtData;
        public Controles.Txt txtDesc;
        private System.Windows.Forms.Panel panel1;
    }
}