
namespace Setup.Financas
{
    partial class boxAddPrev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boxAddPrev));
            this.lnL = new System.Windows.Forms.Label();
            this.lnR = new System.Windows.Forms.Label();
            this.lnD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClasse = new Setup.Controles.cbCombo();
            this.optReceita = new System.Windows.Forms.RadioButton();
            this.optDespesa = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMes = new Setup.Controles.cbCombo();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAno = new Setup.Controles.cbCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new Setup.Controles.Decimal();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDia = new Setup.Controles.cbCombo();
            this.txtObs = new Setup.Controles.Txt();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvar = new Setup.Controles.Cabecalho();
            this.excluir = new Setup.Controles.Cabecalho();
            this.replicar = new Setup.Controles.Cabecalho();
            this.sair = new Setup.Controles.Cabecalho();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnL
            // 
            this.lnL.BackColor = System.Drawing.Color.DimGray;
            this.lnL.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnL.Location = new System.Drawing.Point(0, 24);
            this.lnL.Name = "lnL";
            this.lnL.Size = new System.Drawing.Size(1, 172);
            this.lnL.TabIndex = 6;
            // 
            // lnR
            // 
            this.lnR.BackColor = System.Drawing.Color.DimGray;
            this.lnR.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnR.Location = new System.Drawing.Point(447, 24);
            this.lnR.Name = "lnR";
            this.lnR.Size = new System.Drawing.Size(1, 172);
            this.lnR.TabIndex = 7;
            // 
            // lnD
            // 
            this.lnD.BackColor = System.Drawing.Color.DimGray;
            this.lnD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnD.Location = new System.Drawing.Point(1, 195);
            this.lnD.Name = "lnD";
            this.lnD.Size = new System.Drawing.Size(446, 1);
            this.lnD.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Classe";
            // 
            // cbClasse
            // 
            this.cbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbClasse.DropDownHeight = 136;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClasse.ForeColor = System.Drawing.Color.White;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.IntegralHeight = false;
            this.cbClasse.Location = new System.Drawing.Point(58, 39);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(243, 23);
            this.cbClasse.TabIndex = 12;
            this.cbClasse.Tag = "\'Classe\'";
            // 
            // optReceita
            // 
            this.optReceita.AutoSize = true;
            this.optReceita.Location = new System.Drawing.Point(311, 40);
            this.optReceita.Name = "optReceita";
            this.optReceita.Size = new System.Drawing.Size(63, 19);
            this.optReceita.TabIndex = 13;
            this.optReceita.Text = "Receita";
            this.optReceita.UseVisualStyleBackColor = true;
            this.optReceita.Click += new System.EventHandler(this.optReceita_Click);
            // 
            // optDespesa
            // 
            this.optDespesa.AutoSize = true;
            this.optDespesa.Checked = true;
            this.optDespesa.Location = new System.Drawing.Point(376, 40);
            this.optDespesa.Name = "optDespesa";
            this.optDespesa.Size = new System.Drawing.Size(68, 19);
            this.optDespesa.TabIndex = 13;
            this.optDespesa.TabStop = true;
            this.optDespesa.Text = "Despesa";
            this.optDespesa.UseVisualStyleBackColor = true;
            this.optDespesa.Click += new System.EventHandler(this.optDespesa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mês";
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbMes.DropDownHeight = 136;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMes.ForeColor = System.Drawing.Color.White;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.IntegralHeight = false;
            this.cbMes.Location = new System.Drawing.Point(146, 76);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(113, 23);
            this.cbMes.TabIndex = 15;
            this.cbMes.Tag = "\'Mês\'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ano";
            // 
            // cbAno
            // 
            this.cbAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbAno.DropDownHeight = 136;
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAno.ForeColor = System.Drawing.Color.White;
            this.cbAno.FormattingEnabled = true;
            this.cbAno.IntegralHeight = false;
            this.cbAno.Location = new System.Drawing.Point(300, 76);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(89, 23);
            this.cbAno.TabIndex = 15;
            this.cbAno.Tag = "\'Ano\'";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(58, 115);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 25);
            this.txtValor.TabIndex = 16;
            this.txtValor.Tag = "\'Valor\'";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dia";
            // 
            // cbDia
            // 
            this.cbDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbDia.DropDownHeight = 136;
            this.cbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDia.ForeColor = System.Drawing.Color.White;
            this.cbDia.FormattingEnabled = true;
            this.cbDia.IntegralHeight = false;
            this.cbDia.Location = new System.Drawing.Point(58, 76);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(47, 23);
            this.cbDia.TabIndex = 15;
            this.cbDia.Tag = "\'Dia\'";
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObs.ForeColor = System.Drawing.Color.White;
            this.txtObs.Location = new System.Drawing.Point(58, 152);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(378, 23);
            this.txtObs.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Obs.:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.excluir,
            this.replicar,
            this.sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvar
            // 
            this.salvar.ForeColor = System.Drawing.Color.White;
            this.salvar.Image = ((System.Drawing.Image)(resources.GetObject("salvar.Image")));
            this.salvar.Name = "salvar";
            this.salvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvar.Size = new System.Drawing.Size(66, 20);
            this.salvar.Text = "Salvar";
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // excluir
            // 
            this.excluir.ForeColor = System.Drawing.Color.White;
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.Name = "excluir";
            this.excluir.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluir.Size = new System.Drawing.Size(70, 20);
            this.excluir.Text = "Excluir";
            // 
            // replicar
            // 
            this.replicar.ForeColor = System.Drawing.Color.White;
            this.replicar.Image = ((System.Drawing.Image)(resources.GetObject("replicar.Image")));
            this.replicar.Name = "replicar";
            this.replicar.Size = new System.Drawing.Size(77, 20);
            this.replicar.Text = "Replicar";
            // 
            // sair
            // 
            this.sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sair.ForeColor = System.Drawing.Color.White;
            this.sair.Image = ((System.Drawing.Image)(resources.GetObject("sair.Image")));
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(54, 20);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // boxAddPrev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(448, 196);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.optDespesa);
            this.Controls.Add(this.optReceita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnD);
            this.Controls.Add(this.lnR);
            this.Controls.Add(this.lnL);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "boxAddPrev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lnL;
        public System.Windows.Forms.Label lnR;
        public System.Windows.Forms.Label lnD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Controles.Cabecalho salvar;
        private Controles.Cabecalho excluir;
        private Controles.Cabecalho replicar;
        private Controles.Cabecalho sair;
        public Controles.cbCombo cbClasse;
        public System.Windows.Forms.RadioButton optReceita;
        public System.Windows.Forms.RadioButton optDespesa;
        public Controles.cbCombo cbMes;
        public Controles.cbCombo cbAno;
        public Controles.Decimal txtValor;
        public Controles.cbCombo cbDia;
        public Controles.Txt txtObs;
    }
}