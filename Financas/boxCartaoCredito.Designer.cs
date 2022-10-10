
namespace Setup.Financas
{
    partial class boxCartaoCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boxCartaoCredito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLimite = new Setup.Controles.Decimal();
            this.cbVenc = new Setup.Controles.cbCombo();
            this.cbFecha = new Setup.Controles.cbCombo();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.novo = new System.Windows.Forms.ToolStripMenuItem();
            this.excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.lista = new Setup.Controles.dgView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARTAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATIVO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ckStatus = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cbCartao = new Setup.Controles.cbCombo();
            this.lblCor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cartão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Limite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dia do Vencimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fechamento da Fatura:";
            // 
            // txtLimite
            // 
            this.txtLimite.BackColor = System.Drawing.Color.Black;
            this.txtLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLimite.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLimite.ForeColor = System.Drawing.Color.White;
            this.txtLimite.Location = new System.Drawing.Point(63, 66);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(204, 23);
            this.txtLimite.TabIndex = 2;
            this.txtLimite.Tag = "0";
            this.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbVenc
            // 
            this.cbVenc.BackColor = System.Drawing.Color.Black;
            this.cbVenc.DropDownHeight = 136;
            this.cbVenc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVenc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVenc.ForeColor = System.Drawing.Color.White;
            this.cbVenc.FormattingEnabled = true;
            this.cbVenc.IntegralHeight = false;
            this.cbVenc.Location = new System.Drawing.Point(150, 101);
            this.cbVenc.MaxDropDownItems = 10;
            this.cbVenc.Name = "cbVenc";
            this.cbVenc.Size = new System.Drawing.Size(177, 23);
            this.cbVenc.TabIndex = 3;
            this.cbVenc.Tag = "\'Dia Vencimento\'";
            // 
            // cbFecha
            // 
            this.cbFecha.BackColor = System.Drawing.Color.Black;
            this.cbFecha.DropDownHeight = 136;
            this.cbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFecha.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFecha.ForeColor = System.Drawing.Color.White;
            this.cbFecha.FormattingEnabled = true;
            this.cbFecha.IntegralHeight = false;
            this.cbFecha.Location = new System.Drawing.Point(150, 133);
            this.cbFecha.MaxDropDownItems = 10;
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(177, 23);
            this.cbFecha.TabIndex = 4;
            this.cbFecha.Tag = "\'Fechamento Fatura\'";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.novo,
            this.excluir,
            this.sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvar
            // 
            this.salvar.Image = ((System.Drawing.Image)(resources.GetObject("salvar.Image")));
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(66, 20);
            this.salvar.Text = "Salvar";
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // novo
            // 
            this.novo.Image = ((System.Drawing.Image)(resources.GetObject("novo.Image")));
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(64, 20);
            this.novo.Text = "Novo";
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // excluir
            // 
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(70, 20);
            this.excluir.Text = "Excluir";
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // sair
            // 
            this.sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sair.Image = ((System.Drawing.Image)(resources.GetObject("sair.Image")));
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(54, 20);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.Color.Black;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CARTAO,
            this.ATIVO});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle16;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.DimGray;
            this.lista.Location = new System.Drawing.Point(12, 175);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(315, 252);
            this.lista.TabIndex = 1;
            this.lista.TabStop = false;
            this.lista.Click += new System.EventHandler(this.lista_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 5;
            // 
            // CARTAO
            // 
            this.CARTAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CARTAO.DataPropertyName = "CARTAO";
            this.CARTAO.HeaderText = "CARTÃO";
            this.CARTAO.MinimumWidth = 210;
            this.CARTAO.Name = "CARTAO";
            this.CARTAO.ReadOnly = true;
            this.CARTAO.Width = 210;
            // 
            // ATIVO
            // 
            this.ATIVO.DataPropertyName = "ATIVO";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = "False";
            this.ATIVO.DefaultCellStyle = dataGridViewCellStyle15;
            this.ATIVO.HeaderText = "ATIVO";
            this.ATIVO.Name = "ATIVO";
            this.ATIVO.ReadOnly = true;
            // 
            // ckStatus
            // 
            this.ckStatus.AutoSize = true;
            this.ckStatus.Checked = true;
            this.ckStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckStatus.Location = new System.Drawing.Point(273, 70);
            this.ckStatus.Name = "ckStatus";
            this.ckStatus.Size = new System.Drawing.Size(54, 19);
            this.ckStatus.TabIndex = 6;
            this.ckStatus.TabStop = false;
            this.ckStatus.Text = "Ativo";
            this.ckStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckStatus.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.Tomato;
            this.lblID.Location = new System.Drawing.Point(12, 159);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(315, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Tag = "0";
            this.lblID.Text = "ID Selecionado: 0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCartao
            // 
            this.cbCartao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCartao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCartao.BackColor = System.Drawing.Color.Black;
            this.cbCartao.DropDownHeight = 136;
            this.cbCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCartao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCartao.ForeColor = System.Drawing.Color.White;
            this.cbCartao.FormattingEnabled = true;
            this.cbCartao.IntegralHeight = false;
            this.cbCartao.Location = new System.Drawing.Point(63, 37);
            this.cbCartao.MaxDropDownItems = 10;
            this.cbCartao.Name = "cbCartao";
            this.cbCartao.Size = new System.Drawing.Size(236, 23);
            this.cbCartao.TabIndex = 37;
            this.cbCartao.Tag = "\'Cartão\'";
            // 
            // lblCor
            // 
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor.Location = new System.Drawing.Point(305, 37);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(22, 23);
            this.lblCor.TabIndex = 38;
            this.lblCor.Click += new System.EventHandler(this.lblCor_Click);
            // 
            // boxCartaoCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(341, 441);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.cbCartao);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.cbVenc);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.ckStatus);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "boxCartaoCredito";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Controles.Decimal txtLimite;
        private Controles.cbCombo cbVenc;
        private Controles.cbCombo cbFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvar;
        private System.Windows.Forms.ToolStripMenuItem novo;
        private System.Windows.Forms.ToolStripMenuItem excluir;
        private Controles.dgView lista;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARTAO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ATIVO;
        private System.Windows.Forms.CheckBox ckStatus;
        private System.Windows.Forms.Label lblID;
        private Controles.cbCombo cbCartao;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}