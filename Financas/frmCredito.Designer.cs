using System.Windows.Forms;

namespace Setup.Financas
{
    partial class frmCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvar = new Setup.Controles.Cabecalho();
            this.excluir = new Setup.Controles.Cabecalho();
            this.cartoes = new Setup.Controles.Cabecalho();
            this.limpar = new Setup.Controles.Cabecalho();
            this.txtDesc = new Setup.Controles.Txt();
            this.txtQtdeParc = new Setup.Controles.Inteiro();
            this.txtValor = new Setup.Controles.Decimal();
            this.txtData = new Setup.Controles.Data();
            this.cbClasse = new Setup.Controles.cbCombo();
            this.cbCartao = new Setup.Controles.cbCombo();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new Setup.Controles.dgView();
            this.CHAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARCELA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_PGMTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeFaturas = new System.Windows.Forms.TreeView();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFCartao = new Setup.Controles.cbCombo();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.btnPagarFatura = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.excluir,
            this.cartoes,
            this.limpar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
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
            // excluir
            // 
            this.excluir.ForeColor = System.Drawing.Color.White;
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(70, 20);
            this.excluir.Text = "Excluir";
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // cartoes
            // 
            this.cartoes.ForeColor = System.Drawing.Color.White;
            this.cartoes.Image = ((System.Drawing.Image)(resources.GetObject("cartoes.Image")));
            this.cartoes.Name = "cartoes";
            this.cartoes.Size = new System.Drawing.Size(75, 20);
            this.cartoes.Text = "Cartões";
            this.cartoes.Click += new System.EventHandler(this.cartoes_Click);
            // 
            // limpar
            // 
            this.limpar.ForeColor = System.Drawing.Color.White;
            this.limpar.Image = ((System.Drawing.Image)(resources.GetObject("limpar.Image")));
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(72, 20);
            this.limpar.Text = "Limpar";
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(493, 64);
            this.txtDesc.MaxLength = 200;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(237, 23);
            this.txtDesc.TabIndex = 30;
            // 
            // txtQtdeParc
            // 
            this.txtQtdeParc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtQtdeParc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeParc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdeParc.ForeColor = System.Drawing.Color.White;
            this.txtQtdeParc.Location = new System.Drawing.Point(375, 64);
            this.txtQtdeParc.MaxLength = 3;
            this.txtQtdeParc.Name = "txtQtdeParc";
            this.txtQtdeParc.Size = new System.Drawing.Size(48, 23);
            this.txtQtdeParc.TabIndex = 29;
            this.txtQtdeParc.Tag = "\'Qtd. Parcelas\'";
            this.txtQtdeParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(195, 64);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(90, 23);
            this.txtValor.TabIndex = 28;
            this.txtValor.Tag = "\'Valor\'";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(60, 64);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(90, 23);
            this.txtData.TabIndex = 27;
            this.txtData.Tag = "\'Data\'";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbClasse
            // 
            this.cbClasse.AllowDrop = true;
            this.cbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbClasse.DropDownHeight = 136;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClasse.ForeColor = System.Drawing.Color.White;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.IntegralHeight = false;
            this.cbClasse.Location = new System.Drawing.Point(421, 32);
            this.cbClasse.MaxDropDownItems = 10;
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(309, 23);
            this.cbClasse.TabIndex = 25;
            this.cbClasse.Tag = "\'Classe\'";
            // 
            // cbCartao
            // 
            this.cbCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbCartao.DropDownHeight = 136;
            this.cbCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCartao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCartao.ForeColor = System.Drawing.Color.White;
            this.cbCartao.FormattingEnabled = true;
            this.cbCartao.IntegralHeight = false;
            this.cbCartao.Location = new System.Drawing.Point(60, 32);
            this.cbCartao.MaxDropDownItems = 10;
            this.cbCartao.Name = "cbCartao";
            this.cbCartao.Size = new System.Drawing.Size(309, 23);
            this.cbCartao.TabIndex = 26;
            this.cbCartao.Tag = "\'Cartão\'";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Classe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Qtd. Parcelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cartão";
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHAVE,
            this.ID,
            this.DATA,
            this.CLASSE,
            this.VALOR,
            this.PARCELA,
            this.DATA_PGMTO,
            this.DESCRICAO,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle16;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.DimGray;
            this.lista.Location = new System.Drawing.Point(12, 130);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(718, 275);
            this.lista.TabIndex = 1;
            this.lista.DoubleClick += new System.EventHandler(this.lista_DoubleClick);
            // 
            // CHAVE
            // 
            this.CHAVE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CHAVE.DataPropertyName = "CHAVE";
            this.CHAVE.HeaderText = "CHAVE";
            this.CHAVE.Name = "CHAVE";
            this.CHAVE.ReadOnly = true;
            this.CHAVE.Visible = false;
            this.CHAVE.Width = 5;
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
            // DATA
            // 
            this.DATA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DATA.DataPropertyName = "DATA";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle12;
            this.DATA.HeaderText = "DATA";
            this.DATA.MinimumWidth = 80;
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 80;
            // 
            // CLASSE
            // 
            this.CLASSE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CLASSE.DataPropertyName = "CLASSE";
            this.CLASSE.HeaderText = "CLASSE";
            this.CLASSE.MinimumWidth = 175;
            this.CLASSE.Name = "CLASSE";
            this.CLASSE.ReadOnly = true;
            this.CLASSE.Width = 175;
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0,00";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle13;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.MinimumWidth = 80;
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 80;
            // 
            // PARCELA
            // 
            this.PARCELA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PARCELA.DataPropertyName = "PARCELA";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PARCELA.DefaultCellStyle = dataGridViewCellStyle14;
            this.PARCELA.HeaderText = "PARCELA";
            this.PARCELA.MinimumWidth = 60;
            this.PARCELA.Name = "PARCELA";
            this.PARCELA.ReadOnly = true;
            this.PARCELA.Width = 60;
            // 
            // DATA_PGMTO
            // 
            this.DATA_PGMTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DATA_PGMTO.DataPropertyName = "DATA_PGMTO";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.DATA_PGMTO.DefaultCellStyle = dataGridViewCellStyle15;
            this.DATA_PGMTO.HeaderText = "PAGAMENTO";
            this.DATA_PGMTO.MinimumWidth = 80;
            this.DATA_PGMTO.Name = "DATA_PGMTO";
            this.DATA_PGMTO.ReadOnly = true;
            this.DATA_PGMTO.Width = 80;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.MinimumWidth = 180;
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 180;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn1.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // treeFaturas
            // 
            this.treeFaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.treeFaturas.ForeColor = System.Drawing.Color.White;
            this.treeFaturas.Location = new System.Drawing.Point(740, 32);
            this.treeFaturas.Name = "treeFaturas";
            this.treeFaturas.Size = new System.Drawing.Size(222, 373);
            this.treeFaturas.TabIndex = 32;
            this.treeFaturas.DoubleClick += new System.EventHandler(this.treeFaturas_DoubleClick);
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 414);
            this.status.Name = "status";
            this.status.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.status.Size = new System.Drawing.Size(974, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 33;
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(23, 17);
            this.statusLabel.Text = ">>";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(12, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(718, 1);
            this.label7.TabIndex = 34;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cartão";
            // 
            // cbFCartao
            // 
            this.cbFCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbFCartao.DropDownHeight = 136;
            this.cbFCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFCartao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFCartao.ForeColor = System.Drawing.Color.White;
            this.cbFCartao.FormattingEnabled = true;
            this.cbFCartao.IntegralHeight = false;
            this.cbFCartao.Location = new System.Drawing.Point(60, 102);
            this.cbFCartao.MaxDropDownItems = 10;
            this.cbFCartao.Name = "cbFCartao";
            this.cbFCartao.Size = new System.Drawing.Size(309, 23);
            this.cbFCartao.TabIndex = 26;
            this.cbFCartao.TabStop = false;
            this.cbFCartao.SelectedIndexChanged += new System.EventHandler(this.cbFCartao_SelectedIndexChanged);
            this.cbFCartao.SelectedValueChanged += new System.EventHandler(this.cbFCartao_SelectedValueChanged);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeriodo.ForeColor = System.Drawing.Color.Silver;
            this.lblPeriodo.Location = new System.Drawing.Point(456, 102);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(274, 23);
            this.lblPeriodo.TabIndex = 24;
            this.lblPeriodo.Text = "2022/JANEIRO";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPagarFatura
            // 
            this.btnPagarFatura.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPagarFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagarFatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagarFatura.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPagarFatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnPagarFatura.Location = new System.Drawing.Point(375, 102);
            this.btnPagarFatura.Name = "btnPagarFatura";
            this.btnPagarFatura.Size = new System.Drawing.Size(75, 23);
            this.btnPagarFatura.TabIndex = 35;
            this.btnPagarFatura.Text = "PAGAR";
            this.btnPagarFatura.UseVisualStyleBackColor = false;
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(974, 436);
            this.Controls.Add(this.btnPagarFatura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.status);
            this.Controls.Add(this.treeFaturas);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtQtdeParc);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbFCartao);
            this.Controls.Add(this.cbCartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCredito";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmCredito_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCredito_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private Controles.Txt txtDesc;
        private Controles.Inteiro txtQtdeParc;
        private Controles.Decimal txtValor;
        private Controles.Data txtData;
        private Controles.cbCombo cbClasse;
        private Controles.cbCombo cbCartao;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Controles.dgView lista;
        private TreeView treeFaturas;
        private StatusStrip status;
        private ToolStripStatusLabel statusLabel;
        private DataGridViewTextBoxColumn CHAVE;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn CLASSE;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn PARCELA;
        private DataGridViewTextBoxColumn DATA_PGMTO;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Label label7;
        private Label label8;
        private Controles.cbCombo cbFCartao;
        private Label lblPeriodo;
        private Button btnPagarFatura;
        private Controles.Cabecalho salvar;
        private Controles.Cabecalho limpar;
        private Controles.Cabecalho cartoes;
        private Controles.Cabecalho excluir;
    }
}