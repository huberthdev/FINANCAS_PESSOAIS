using System.Windows.Forms;

namespace Setup.Financas
{
    partial class frmTransf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransf));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            this.menuStrip1 = new MenuStrip();
            this.salvar = new ToolStripMenuItem();
            this.excluir = new ToolStripMenuItem();
            this.limpar = new ToolStripMenuItem();
            this.atualizar = new ToolStripMenuItem();
            this.label1 = new Label();
            this.cbContaDebito = new Setup.Controles.cbCombo();
            this.label5 = new Label();
            this.label2 = new Label();
            this.cbContaCredito = new Setup.Controles.cbCombo();
            this.label3 = new Label();
            this.txtData = new Setup.Controles.Data();
            this.label6 = new Label();
            this.txtValor = new Setup.Controles.Decimal();
            this.label4 = new Label();
            this.txtDescricao = new Setup.Controles.Txt();
            this.label7 = new Label();
            this.status = new StatusStrip();
            this.statusLabel = new ToolStripStatusLabel();
            this.label8 = new Label();
            this.lista = new Setup.Controles.dgView();
            this.TRANSFERENCIA_ID = new DataGridViewTextBoxColumn();
            this.DATA = new DataGridViewTextBoxColumn();
            this.CONTA = new DataGridViewTextBoxColumn();
            this.VALOR = new DataGridViewTextBoxColumn();
            this.DESCRICAO = new DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.salvar,
            this.excluir,
            this.limpar,
            this.atualizar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // salvar
            // 
            this.salvar.ForeColor = System.Drawing.Color.White;
            this.salvar.Image = ((System.Drawing.Image)(resources.GetObject("salvar.Image")));
            this.salvar.Name = "salvar";
            this.salvar.ShortcutKeys = ((Keys)((Keys.Control | Keys.S)));
            this.salvar.Size = new System.Drawing.Size(66, 20);
            this.salvar.Text = "Salvar";
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // excluir
            // 
            this.excluir.ForeColor = System.Drawing.Color.White;
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.Name = "excluir";
            this.excluir.ShortcutKeys = Keys.Delete;
            this.excluir.Size = new System.Drawing.Size(70, 20);
            this.excluir.Text = "Excluir";
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // limpar
            // 
            this.limpar.ForeColor = System.Drawing.Color.White;
            this.limpar.Image = ((System.Drawing.Image)(resources.GetObject("limpar.Image")));
            this.limpar.Name = "limpar";
            this.limpar.ShortcutKeys = ((Keys)(((Keys.Control | Keys.Shift) 
            | Keys.Delete)));
            this.limpar.Size = new System.Drawing.Size(72, 20);
            this.limpar.Text = "Limpar";
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // atualizar
            // 
            this.atualizar.Alignment = ToolStripItemAlignment.Right;
            this.atualizar.ForeColor = System.Drawing.Color.White;
            this.atualizar.Image = ((System.Drawing.Image)(resources.GetObject("atualizar.Image")));
            this.atualizar.Name = "atualizar";
            this.atualizar.ShortcutKeys = Keys.F5;
            this.atualizar.Size = new System.Drawing.Size(81, 20);
            this.atualizar.Text = "Atualizar";
            this.atualizar.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 1);
            this.label1.TabIndex = 1;
            // 
            // cbContaDebito
            // 
            this.cbContaDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbContaDebito.DropDownHeight = 136;
            this.cbContaDebito.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbContaDebito.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbContaDebito.ForeColor = System.Drawing.Color.White;
            this.cbContaDebito.FormattingEnabled = true;
            this.cbContaDebito.IntegralHeight = false;
            this.cbContaDebito.Location = new System.Drawing.Point(89, 33);
            this.cbContaDebito.Name = "cbContaDebito";
            this.cbContaDebito.Size = new System.Drawing.Size(209, 23);
            this.cbContaDebito.TabIndex = 6;
            this.cbContaDebito.Tag = "\'Conta Débito\'";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Conta Débito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Conta Crédito:";
            // 
            // cbContaCredito
            // 
            this.cbContaCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbContaCredito.DropDownHeight = 136;
            this.cbContaCredito.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbContaCredito.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbContaCredito.ForeColor = System.Drawing.Color.White;
            this.cbContaCredito.FormattingEnabled = true;
            this.cbContaCredito.IntegralHeight = false;
            this.cbContaCredito.Location = new System.Drawing.Point(394, 33);
            this.cbContaCredito.Name = "cbContaCredito";
            this.cbContaCredito.Size = new System.Drawing.Size(209, 23);
            this.cbContaCredito.TabIndex = 6;
            this.cbContaCredito.Tag = "\'Conta Crédito\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtData.BorderStyle = BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(44, 62);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(110, 23);
            this.txtData.TabIndex = 8;
            this.txtData.Tag = "\'Data\'";
            this.txtData.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValor.BorderStyle = BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(202, 62);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 10;
            this.txtValor.Tag = "\'Valor\'";
            this.txtValor.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(375, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(228, 23);
            this.txtDescricao.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(698, 1);
            this.label7.TabIndex = 14;
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.status.Items.AddRange(new ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 314);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(609, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 15;
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(23, 17);
            this.statusLabel.Text = ">>";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Dock = DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(0, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(609, 1);
            this.label8.TabIndex = 16;
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.BorderStyle = BorderStyle.Fixed3D;
            this.lista.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            this.lista.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new DataGridViewColumn[] {
            this.TRANSFERENCIA_ID,
            this.DATA,
            this.CONTA,
            this.VALOR,
            this.DESCRICAO});
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle5;
            this.lista.EditMode = DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.DimGray;
            this.lista.Location = new System.Drawing.Point(6, 97);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.lista.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = DataGridViewTriState.True;
            this.lista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(597, 213);
            this.lista.TabIndex = 1;
            // 
            // TRANSFERENCIA_ID
            // 
            this.TRANSFERENCIA_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TRANSFERENCIA_ID.DataPropertyName = "TRANSFERENCIA_ID";
            this.TRANSFERENCIA_ID.HeaderText = "TRANSFERENCIA_ID";
            this.TRANSFERENCIA_ID.Name = "TRANSFERENCIA_ID";
            this.TRANSFERENCIA_ID.ReadOnly = true;
            this.TRANSFERENCIA_ID.Visible = false;
            this.TRANSFERENCIA_ID.Width = 5;
            // 
            // DATA
            // 
            this.DATA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.DATA.DataPropertyName = "DATA";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATA.HeaderText = "DATA";
            this.DATA.MinimumWidth = 80;
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 80;
            // 
            // CONTA
            // 
            this.CONTA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.CONTA.DataPropertyName = "CONTA";
            this.CONTA.HeaderText = "CONTA";
            this.CONTA.MinimumWidth = 175;
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.Width = 175;
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0,00";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle4;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.MinimumWidth = 80;
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 80;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.MinimumWidth = 200;
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 200;
            // 
            // frmTransf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(609, 336);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbContaDebito);
            this.Controls.Add(this.cbContaCredito);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmTransf";
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyDown += new KeyEventHandler(this.frmTransf_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salvar;
        private ToolStripMenuItem excluir;
        private ToolStripMenuItem limpar;
        private Label label1;
        private Controles.cbCombo cbContaDebito;
        private Label label5;
        private Label label2;
        private Controles.cbCombo cbContaCredito;
        private Label label3;
        private Controles.Data txtData;
        private Label label6;
        private Controles.Decimal txtValor;
        private Label label4;
        private Controles.Txt txtDescricao;
        private Label label7;
        private StatusStrip status;
        private ToolStripStatusLabel statusLabel;
        private ToolStripMenuItem atualizar;
        private Label label8;
        private Controles.dgView lista;
        private DataGridViewTextBoxColumn TRANSFERENCIA_ID;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn CONTA;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn DESCRICAO;
    }
}