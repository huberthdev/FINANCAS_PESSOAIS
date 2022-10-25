using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas
{
    partial class frmCadastro
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
            this.listaConta.MultiSelect = true;
            this.listaConta.BorderStyle = BorderStyle.None;
            this.listaConta.GridColor = Color.FromArgb(25, 25, 26);
            this.listaConta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.listaConta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.listaConta.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.listaConta.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

            this.listaClasse.MultiSelect = true;
            this.listaClasse.BorderStyle = BorderStyle.None;
            this.listaClasse.GridColor =  Color.FromArgb(25, 25, 26);
            this.listaClasse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.listaClasse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.listaClasse.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.listaClasse.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

            base.OnCreateControl();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.listaClasse = new Setup.Controles.dgView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckAtivoClasse = new System.Windows.Forms.CheckBox();
            this.optDespesa = new System.Windows.Forms.RadioButton();
            this.optReceita = new System.Windows.Forms.RadioButton();
            this.txtClasse = new Setup.Controles.Txt();
            this.listaConta = new Setup.Controles.dgView();
            this.ID_CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ckAtivoConta = new System.Windows.Forms.CheckBox();
            this.txtConta = new Setup.Controles.Txt();
            this.pnCad = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.optClasse = new System.Windows.Forms.RadioButton();
            this.optConta = new System.Windows.Forms.RadioButton();
            this.pnConta = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.pnClasse = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaConta)).BeginInit();
            this.pnCad.SuspendLayout();
            this.pnConta.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnClasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaClasse
            // 
            this.listaClasse.AllowUserToAddRows = false;
            this.listaClasse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.listaClasse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listaClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaClasse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaClasse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaClasse.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listaClasse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClasse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listaClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.CLASS});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaClasse.DefaultCellStyle = dataGridViewCellStyle3;
            this.listaClasse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaClasse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaClasse.EnableHeadersVisualStyles = false;
            this.listaClasse.GridColor = System.Drawing.Color.DimGray;
            this.listaClasse.Location = new System.Drawing.Point(0, 63);
            this.listaClasse.MultiSelect = false;
            this.listaClasse.Name = "listaClasse";
            this.listaClasse.ReadOnly = true;
            this.listaClasse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClasse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaClasse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.listaClasse.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.listaClasse.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaClasse.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.listaClasse.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.listaClasse.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaClasse.RowTemplate.Height = 25;
            this.listaClasse.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaClasse.ShowEditingIcon = false;
            this.listaClasse.Size = new System.Drawing.Size(443, 320);
            this.listaClasse.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLASSE_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // CLASS
            // 
            this.CLASS.DataPropertyName = "CLASSE";
            this.CLASS.HeaderText = "CLASSE";
            this.CLASS.Name = "CLASS";
            this.CLASS.ReadOnly = true;
            // 
            // ckAtivoClasse
            // 
            this.ckAtivoClasse.AutoSize = true;
            this.ckAtivoClasse.Checked = true;
            this.ckAtivoClasse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAtivoClasse.Location = new System.Drawing.Point(386, 13);
            this.ckAtivoClasse.Name = "ckAtivoClasse";
            this.ckAtivoClasse.Size = new System.Drawing.Size(54, 19);
            this.ckAtivoClasse.TabIndex = 18;
            this.ckAtivoClasse.TabStop = false;
            this.ckAtivoClasse.Text = "Ativo";
            this.ckAtivoClasse.UseVisualStyleBackColor = true;
            // 
            // optDespesa
            // 
            this.optDespesa.AutoSize = true;
            this.optDespesa.Location = new System.Drawing.Point(314, 35);
            this.optDespesa.Name = "optDespesa";
            this.optDespesa.Size = new System.Drawing.Size(68, 19);
            this.optDespesa.TabIndex = 17;
            this.optDespesa.Text = "Despesa";
            this.optDespesa.UseVisualStyleBackColor = true;
            this.optDespesa.CheckedChanged += new System.EventHandler(this.optDespesa_CheckedChanged);
            // 
            // optReceita
            // 
            this.optReceita.AutoSize = true;
            this.optReceita.Checked = true;
            this.optReceita.Location = new System.Drawing.Point(245, 35);
            this.optReceita.Name = "optReceita";
            this.optReceita.Size = new System.Drawing.Size(63, 19);
            this.optReceita.TabIndex = 16;
            this.optReceita.TabStop = true;
            this.optReceita.Text = "Receita";
            this.optReceita.UseVisualStyleBackColor = true;
            this.optReceita.CheckedChanged += new System.EventHandler(this.optReceita_CheckedChanged);
            // 
            // txtClasse
            // 
            this.txtClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClasse.ForeColor = System.Drawing.Color.White;
            this.txtClasse.Location = new System.Drawing.Point(49, 6);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(331, 23);
            this.txtClasse.TabIndex = 0;
            this.txtClasse.Tag = "\'Classe\'";
            this.txtClasse.TextChanged += new System.EventHandler(this.txtClasse_TextChanged);
            // 
            // listaConta
            // 
            this.listaConta.AllowUserToAddRows = false;
            this.listaConta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.listaConta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.listaConta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaConta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaConta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaConta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listaConta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaConta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.listaConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONTA,
            this.CONT,
            this.CREDITO});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaConta.DefaultCellStyle = dataGridViewCellStyle9;
            this.listaConta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaConta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaConta.EnableHeadersVisualStyles = false;
            this.listaConta.GridColor = System.Drawing.Color.DimGray;
            this.listaConta.Location = new System.Drawing.Point(0, 38);
            this.listaConta.MultiSelect = false;
            this.listaConta.Name = "listaConta";
            this.listaConta.ReadOnly = true;
            this.listaConta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaConta.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.listaConta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.listaConta.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.listaConta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaConta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.listaConta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.listaConta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaConta.RowTemplate.Height = 25;
            this.listaConta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaConta.ShowEditingIcon = false;
            this.listaConta.Size = new System.Drawing.Size(443, 345);
            this.listaConta.TabIndex = 1;
            this.listaConta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaConta_CellContentClick);
            this.listaConta.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaConta_MouseEnter);
            // 
            // ID_CONTA
            // 
            this.ID_CONTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_CONTA.DataPropertyName = "CONTA_ID";
            this.ID_CONTA.HeaderText = "CONTA_ID";
            this.ID_CONTA.Name = "ID_CONTA";
            this.ID_CONTA.ReadOnly = true;
            this.ID_CONTA.Visible = false;
            this.ID_CONTA.Width = 5;
            // 
            // CONT
            // 
            this.CONT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CONT.DataPropertyName = "CONTA";
            this.CONT.HeaderText = "CONTA";
            this.CONT.MinimumWidth = 220;
            this.CONT.Name = "CONT";
            this.CONT.ReadOnly = true;
            this.CONT.Width = 220;
            // 
            // CREDITO
            // 
            this.CREDITO.DataPropertyName = "CREDITO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = false;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CREDITO.DefaultCellStyle = dataGridViewCellStyle8;
            this.CREDITO.FalseValue = "0";
            this.CREDITO.HeaderText = "FUNÇÃO CRÉDITO?";
            this.CREDITO.Name = "CREDITO";
            this.CREDITO.ReadOnly = true;
            this.CREDITO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CREDITO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CREDITO.TrueValue = "1";
            // 
            // ckAtivoConta
            // 
            this.ckAtivoConta.AutoSize = true;
            this.ckAtivoConta.Checked = true;
            this.ckAtivoConta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAtivoConta.Location = new System.Drawing.Point(386, 13);
            this.ckAtivoConta.Name = "ckAtivoConta";
            this.ckAtivoConta.Size = new System.Drawing.Size(54, 19);
            this.ckAtivoConta.TabIndex = 18;
            this.ckAtivoConta.TabStop = false;
            this.ckAtivoConta.Text = "Ativo";
            this.ckAtivoConta.UseVisualStyleBackColor = true;
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConta.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConta.ForeColor = System.Drawing.Color.White;
            this.txtConta.Location = new System.Drawing.Point(49, 6);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(331, 23);
            this.txtConta.TabIndex = 0;
            this.txtConta.Tag = "\'Conta\'";
            this.txtConta.TextChanged += new System.EventHandler(this.txtConta_TextChanged);
            // 
            // pnCad
            // 
            this.pnCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnCad.Controls.Add(this.label2);
            this.pnCad.Controls.Add(this.optClasse);
            this.pnCad.Controls.Add(this.optConta);
            this.pnCad.Controls.Add(this.pnConta);
            this.pnCad.Controls.Add(this.menuStrip1);
            this.pnCad.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCad.Location = new System.Drawing.Point(0, 0);
            this.pnCad.Name = "pnCad";
            this.pnCad.Size = new System.Drawing.Size(459, 417);
            this.pnCad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 393);
            this.label2.TabIndex = 17;
            // 
            // optClasse
            // 
            this.optClasse.AutoSize = true;
            this.optClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.optClasse.ForeColor = System.Drawing.Color.White;
            this.optClasse.Location = new System.Drawing.Point(215, 3);
            this.optClasse.Name = "optClasse";
            this.optClasse.Size = new System.Drawing.Size(58, 19);
            this.optClasse.TabIndex = 16;
            this.optClasse.Text = "Classe";
            this.optClasse.UseVisualStyleBackColor = false;
            this.optClasse.Click += new System.EventHandler(this.optClasse_Click);
            // 
            // optConta
            // 
            this.optConta.AutoSize = true;
            this.optConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.optConta.Checked = true;
            this.optConta.ForeColor = System.Drawing.Color.White;
            this.optConta.Location = new System.Drawing.Point(152, 3);
            this.optConta.Name = "optConta";
            this.optConta.Size = new System.Drawing.Size(57, 19);
            this.optConta.TabIndex = 16;
            this.optConta.TabStop = true;
            this.optConta.Text = "Conta";
            this.optConta.UseVisualStyleBackColor = false;
            this.optConta.CheckedChanged += new System.EventHandler(this.optConta_CheckedChanged);
            this.optConta.Click += new System.EventHandler(this.optConta_Click);
            // 
            // pnConta
            // 
            this.pnConta.Controls.Add(this.ckAtivoConta);
            this.pnConta.Controls.Add(this.label3);
            this.pnConta.Controls.Add(this.listaConta);
            this.pnConta.Controls.Add(this.txtConta);
            this.pnConta.ForeColor = System.Drawing.Color.White;
            this.pnConta.Location = new System.Drawing.Point(8, 27);
            this.pnConta.Name = "pnConta";
            this.pnConta.Size = new System.Drawing.Size(443, 383);
            this.pnConta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.excluir,
            this.sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
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
            // pnClasse
            // 
            this.pnClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnClasse.Controls.Add(this.listaClasse);
            this.pnClasse.Controls.Add(this.txtClasse);
            this.pnClasse.Controls.Add(this.ckAtivoClasse);
            this.pnClasse.Controls.Add(this.label4);
            this.pnClasse.Controls.Add(this.optDespesa);
            this.pnClasse.Controls.Add(this.optReceita);
            this.pnClasse.ForeColor = System.Drawing.Color.White;
            this.pnClasse.Location = new System.Drawing.Point(471, 27);
            this.pnClasse.Name = "pnClasse";
            this.pnClasse.Size = new System.Drawing.Size(443, 383);
            this.pnClasse.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 1);
            this.label1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(456, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 417);
            this.label5.TabIndex = 17;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(457, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnClasse);
            this.Controls.Add(this.pnCad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaConta)).EndInit();
            this.pnCad.ResumeLayout(false);
            this.pnCad.PerformLayout();
            this.pnConta.ResumeLayout(false);
            this.pnConta.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnClasse.ResumeLayout(false);
            this.pnClasse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.dgView listaClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.CheckBox ckAtivoClasse;
        private System.Windows.Forms.RadioButton optDespesa;
        private System.Windows.Forms.RadioButton optReceita;
        private Controles.Txt txtClasse;
        private Controles.dgView listaConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CREDITO;
        private System.Windows.Forms.CheckBox ckAtivoConta;
        private Controles.Txt txtConta;
        private System.Windows.Forms.Panel pnCad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvar;
        private System.Windows.Forms.ToolStripMenuItem excluir;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.Panel pnConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton optConta;
        private System.Windows.Forms.RadioButton optClasse;
        private System.Windows.Forms.Panel pnClasse;
        private System.Windows.Forms.Label label4;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}