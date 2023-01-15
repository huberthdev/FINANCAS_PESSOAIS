using System.Windows.Forms;
using System.Drawing;

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

        protected override void OnCreateControl()
        {
            this.lista.BorderStyle = BorderStyle.None;
            //this.lista.GridColor = Color.FromArgb(25, 25, 26);
            this.lista.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.lista.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.lista.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.lista.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

            base.OnCreateControl();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editar = new System.Windows.Forms.ToolStripMenuItem();
            this.excluir_ = new System.Windows.Forms.ToolStripMenuItem();
            this.treeFaturas = new System.Windows.Forms.TreeView();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.valorFatura = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.periodo = new System.Windows.Forms.ToolStripStatusLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lnRight = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFaturas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPagarFatura = new System.Windows.Forms.Button();
            this.cbFCartao = new Setup.Controles.cbCombo();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mesAnterior = new System.Windows.Forms.ToolStripMenuItem();
            this.mesProximo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.excluir,
            this.cartoes,
            this.limpar});
            this.menuStrip1.Location = new System.Drawing.Point(4, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 14;
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
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(494, 63);
            this.txtDesc.MaxLength = 200;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(233, 23);
            this.txtDesc.TabIndex = 5;
            // 
            // txtQtdeParc
            // 
            this.txtQtdeParc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQtdeParc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtQtdeParc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeParc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdeParc.ForeColor = System.Drawing.Color.White;
            this.txtQtdeParc.Location = new System.Drawing.Point(376, 63);
            this.txtQtdeParc.MaxLength = 3;
            this.txtQtdeParc.Name = "txtQtdeParc";
            this.txtQtdeParc.Size = new System.Drawing.Size(48, 23);
            this.txtQtdeParc.TabIndex = 4;
            this.txtQtdeParc.Tag = "\'Qtd. Parcelas\'";
            this.txtQtdeParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(196, 63);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(90, 23);
            this.txtValor.TabIndex = 3;
            this.txtValor.Tag = "\'Valor\'";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(61, 63);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(90, 23);
            this.txtData.TabIndex = 2;
            this.txtData.Tag = "\'Data\'";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbClasse
            // 
            this.cbClasse.AllowDrop = true;
            this.cbClasse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbClasse.DropDownHeight = 136;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClasse.ForeColor = System.Drawing.Color.White;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.IntegralHeight = false;
            this.cbClasse.Location = new System.Drawing.Point(422, 31);
            this.cbClasse.MaxDropDownItems = 10;
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(305, 23);
            this.cbClasse.TabIndex = 1;
            this.cbClasse.Tag = "\'Classe\'";
            // 
            // cbCartao
            // 
            this.cbCartao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbCartao.DropDownHeight = 136;
            this.cbCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCartao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCartao.ForeColor = System.Drawing.Color.White;
            this.cbCartao.FormattingEnabled = true;
            this.cbCartao.IntegralHeight = false;
            this.cbCartao.Location = new System.Drawing.Point(61, 31);
            this.cbCartao.MaxDropDownItems = 10;
            this.cbCartao.Name = "cbCartao";
            this.cbCartao.Size = new System.Drawing.Size(309, 23);
            this.cbCartao.TabIndex = 0;
            this.cbCartao.Tag = "\'Cartão\'";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Classe";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Qtd. Parcelas";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cartão";
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
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.lista.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle7;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista.Location = new System.Drawing.Point(9, 131);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(720, 271);
            this.lista.TabIndex = 1;
            this.lista.TabStop = false;
            this.lista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.lista_DataBindingComplete);
            this.lista.SelectionChanged += new System.EventHandler(this.lista_SelectionChanged);
            this.lista.Click += new System.EventHandler(this.lista_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0,00";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PARCELA.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.DATA_PGMTO.DefaultCellStyle = dataGridViewCellStyle6;
            this.DATA_PGMTO.HeaderText = "PAGAMENTO";
            this.DATA_PGMTO.MinimumWidth = 80;
            this.DATA_PGMTO.Name = "DATA_PGMTO";
            this.DATA_PGMTO.ReadOnly = true;
            this.DATA_PGMTO.Width = 80;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.MinimumWidth = 180;
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn1.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editar,
            this.excluir_});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editar
            // 
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(172, 22);
            this.editar.Text = "Alterar Compra Nº";
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // excluir_
            // 
            this.excluir_.Image = ((System.Drawing.Image)(resources.GetObject("excluir_.Image")));
            this.excluir_.Name = "excluir_";
            this.excluir_.Size = new System.Drawing.Size(172, 22);
            this.excluir_.Text = "Excluir";
            this.excluir_.Click += new System.EventHandler(this.excluir__Click);
            // 
            // treeFaturas
            // 
            this.treeFaturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeFaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.treeFaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFaturas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeFaturas.ForeColor = System.Drawing.Color.White;
            this.treeFaturas.Location = new System.Drawing.Point(747, 63);
            this.treeFaturas.Name = "treeFaturas";
            this.treeFaturas.Size = new System.Drawing.Size(293, 338);
            this.treeFaturas.TabIndex = 32;
            this.treeFaturas.TabStop = false;
            this.treeFaturas.DoubleClick += new System.EventHandler(this.treeFaturas_DoubleClick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label7.Location = new System.Drawing.Point(4, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(737, 4);
            this.label7.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(4, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1042, 4);
            this.label9.TabIndex = 37;
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.sp1,
            this.valorFatura,
            this.sp2,
            this.periodo});
            this.status.Location = new System.Drawing.Point(4, 410);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1042, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 36;
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(23, 17);
            this.statusLabel.Text = ">>";
            // 
            // sp1
            // 
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(10, 17);
            this.sp1.Text = "|";
            this.sp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valorFatura
            // 
            this.valorFatura.Name = "valorFatura";
            this.valorFatura.Size = new System.Drawing.Size(28, 17);
            this.valorFatura.Text = "R$ -";
            // 
            // sp2
            // 
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(10, 17);
            this.sp2.Text = "|";
            this.sp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // periodo
            // 
            this.periodo.Name = "periodo";
            this.periodo.Size = new System.Drawing.Size(0, 17);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Location = new System.Drawing.Point(0, 432);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1046, 4);
            this.label13.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(4, 432);
            this.label10.TabIndex = 39;
            // 
            // lnRight
            // 
            this.lnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnRight.Location = new System.Drawing.Point(1046, 0);
            this.lnRight.Name = "lnRight";
            this.lnRight.Size = new System.Drawing.Size(4, 436);
            this.lnRight.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label11.Location = new System.Drawing.Point(738, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(4, 382);
            this.label11.TabIndex = 41;
            // 
            // lblFaturas
            // 
            this.lblFaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFaturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFaturas.ForeColor = System.Drawing.Color.Silver;
            this.lblFaturas.Location = new System.Drawing.Point(747, 32);
            this.lblFaturas.Name = "lblFaturas";
            this.lblFaturas.Size = new System.Drawing.Size(293, 23);
            this.lblFaturas.TabIndex = 42;
            this.lblFaturas.Text = "Faturas";
            this.lblFaturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label12.Location = new System.Drawing.Point(748, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(292, 1);
            this.label12.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnPagarFatura);
            this.panel1.Controls.Add(this.cbFCartao);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(4, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 30);
            this.panel1.TabIndex = 44;
            // 
            // btnPagarFatura
            // 
            this.btnPagarFatura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPagarFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnPagarFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagarFatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagarFatura.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPagarFatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnPagarFatura.Location = new System.Drawing.Point(302, 3);
            this.btnPagarFatura.Name = "btnPagarFatura";
            this.btnPagarFatura.Size = new System.Drawing.Size(75, 23);
            this.btnPagarFatura.TabIndex = 9;
            this.btnPagarFatura.TabStop = false;
            this.btnPagarFatura.Text = "PAGAR";
            this.btnPagarFatura.UseVisualStyleBackColor = false;
            this.btnPagarFatura.Click += new System.EventHandler(this.btnPagarFatura_Click);
            // 
            // cbFCartao
            // 
            this.cbFCartao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbFCartao.DropDownHeight = 136;
            this.cbFCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFCartao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFCartao.ForeColor = System.Drawing.Color.White;
            this.cbFCartao.FormattingEnabled = true;
            this.cbFCartao.IntegralHeight = false;
            this.cbFCartao.Location = new System.Drawing.Point(56, 3);
            this.cbFCartao.MaxDropDownItems = 10;
            this.cbFCartao.Name = "cbFCartao";
            this.cbFCartao.Size = new System.Drawing.Size(241, 23);
            this.cbFCartao.TabIndex = 8;
            this.cbFCartao.TabStop = false;
            this.cbFCartao.SelectedValueChanged += new System.EventHandler(this.cbFCartao_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cartão";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.lblPeriodo.Location = new System.Drawing.Point(412, 3);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(282, 23);
            this.lblPeriodo.TabIndex = 20;
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesAnterior,
            this.mesProximo});
            this.menuStrip2.Location = new System.Drawing.Point(382, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(337, 24);
            this.menuStrip2.TabIndex = 40;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mesAnterior
            // 
            this.mesAnterior.Image = ((System.Drawing.Image)(resources.GetObject("mesAnterior.Image")));
            this.mesAnterior.Name = "mesAnterior";
            this.mesAnterior.Size = new System.Drawing.Size(28, 20);
            this.mesAnterior.Click += new System.EventHandler(this.mesAnterior_Click);
            // 
            // mesProximo
            // 
            this.mesProximo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mesProximo.Image = ((System.Drawing.Image)(resources.GetObject("mesProximo.Image")));
            this.mesProximo.Name = "mesProximo";
            this.mesProximo.Size = new System.Drawing.Size(28, 20);
            this.mesProximo.Click += new System.EventHandler(this.mesProximo_Click);
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1050, 436);
            this.Controls.Add(this.cbCartao);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQtdeParc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblFaturas);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.treeFaturas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnRight);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmCredito_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCredito_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private Label label7;
        private Controles.Cabecalho salvar;
        private Controles.Cabecalho limpar;
        private Controles.Cabecalho cartoes;
        private Controles.Cabecalho excluir;
        private Label label9;
        private StatusStrip status;
        private ToolStripStatusLabel statusLabel;
        private Label label13;
        private Label label10;
        private Label lnRight;
        private Label label11;
        private Label lblFaturas;
        private Label label12;
        private DataGridViewTextBoxColumn CHAVE;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn CLASSE;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn PARCELA;
        private DataGridViewTextBoxColumn DATA_PGMTO;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Panel panel1;
        private Button btnPagarFatura;
        private Controles.cbCombo cbFCartao;
        private Label label8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editar;
        private ToolStripStatusLabel valorFatura;
        private ToolStripStatusLabel sp1;
        private ToolStripStatusLabel sp2;
        private ToolStripStatusLabel periodo;
        private Label lblPeriodo;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem mesAnterior;
        private ToolStripMenuItem mesProximo;
        private ToolStripMenuItem excluir_;
    }
}