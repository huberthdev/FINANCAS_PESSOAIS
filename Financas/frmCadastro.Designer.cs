
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpClasse = new System.Windows.Forms.GroupBox();
            this.listaClasse = new Setup.Controles.dgView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckAtivoClasse = new System.Windows.Forms.CheckBox();
            this.btnExcluirClasse = new System.Windows.Forms.Button();
            this.btnSalvarClasse = new System.Windows.Forms.Button();
            this.optDespesa = new System.Windows.Forms.RadioButton();
            this.optReceita = new System.Windows.Forms.RadioButton();
            this.txtClasse = new Setup.Controles.Txt();
            this.gpConta = new System.Windows.Forms.GroupBox();
            this.listaConta = new Setup.Controles.dgView();
            this.ID_CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ckAtivoConta = new System.Windows.Forms.CheckBox();
            this.btnExcluirConta = new System.Windows.Forms.Button();
            this.txtConta = new Setup.Controles.Txt();
            this.btnSalvarConta = new System.Windows.Forms.Button();
            this.gpClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClasse)).BeginInit();
            this.gpConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaConta)).BeginInit();
            this.SuspendLayout();
            // 
            // gpClasse
            // 
            this.gpClasse.BackColor = System.Drawing.Color.Transparent;
            this.gpClasse.Controls.Add(this.listaClasse);
            this.gpClasse.Controls.Add(this.ckAtivoClasse);
            this.gpClasse.Controls.Add(this.btnExcluirClasse);
            this.gpClasse.Controls.Add(this.btnSalvarClasse);
            this.gpClasse.Controls.Add(this.optDespesa);
            this.gpClasse.Controls.Add(this.optReceita);
            this.gpClasse.Controls.Add(this.txtClasse);
            this.gpClasse.ForeColor = System.Drawing.Color.White;
            this.gpClasse.Location = new System.Drawing.Point(12, 12);
            this.gpClasse.Name = "gpClasse";
            this.gpClasse.Size = new System.Drawing.Size(472, 350);
            this.gpClasse.TabIndex = 11;
            this.gpClasse.TabStop = false;
            this.gpClasse.Text = "Cadastrar Classe";
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
            this.listaClasse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaClasse.EnableHeadersVisualStyles = false;
            this.listaClasse.GridColor = System.Drawing.Color.DimGray;
            this.listaClasse.Location = new System.Drawing.Point(6, 81);
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
            this.listaClasse.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.listaClasse.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaClasse.RowTemplate.Height = 25;
            this.listaClasse.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaClasse.ShowEditingIcon = false;
            this.listaClasse.Size = new System.Drawing.Size(418, 234);
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
            this.ckAtivoClasse.Location = new System.Drawing.Point(363, 55);
            this.ckAtivoClasse.Name = "ckAtivoClasse";
            this.ckAtivoClasse.Size = new System.Drawing.Size(54, 19);
            this.ckAtivoClasse.TabIndex = 18;
            this.ckAtivoClasse.TabStop = false;
            this.ckAtivoClasse.Text = "Ativo";
            this.ckAtivoClasse.UseVisualStyleBackColor = true;
            // 
            // btnExcluirClasse
            // 
            this.btnExcluirClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnExcluirClasse.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirClasse.Image")));
            this.btnExcluirClasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirClasse.Location = new System.Drawing.Point(343, 24);
            this.btnExcluirClasse.Name = "btnExcluirClasse";
            this.btnExcluirClasse.Size = new System.Drawing.Size(81, 23);
            this.btnExcluirClasse.TabIndex = 2;
            this.btnExcluirClasse.Text = "Excluir";
            this.btnExcluirClasse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirClasse.UseVisualStyleBackColor = true;
            // 
            // btnSalvarClasse
            // 
            this.btnSalvarClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSalvarClasse.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarClasse.Image")));
            this.btnSalvarClasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarClasse.Location = new System.Drawing.Point(256, 24);
            this.btnSalvarClasse.Name = "btnSalvarClasse";
            this.btnSalvarClasse.Size = new System.Drawing.Size(81, 23);
            this.btnSalvarClasse.TabIndex = 1;
            this.btnSalvarClasse.Text = "Salvar";
            this.btnSalvarClasse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarClasse.UseVisualStyleBackColor = true;
            // 
            // optDespesa
            // 
            this.optDespesa.AutoSize = true;
            this.optDespesa.Location = new System.Drawing.Point(263, 54);
            this.optDespesa.Name = "optDespesa";
            this.optDespesa.Size = new System.Drawing.Size(68, 19);
            this.optDespesa.TabIndex = 17;
            this.optDespesa.Text = "Despesa";
            this.optDespesa.UseVisualStyleBackColor = true;
            // 
            // optReceita
            // 
            this.optReceita.AutoSize = true;
            this.optReceita.Checked = true;
            this.optReceita.Location = new System.Drawing.Point(183, 54);
            this.optReceita.Name = "optReceita";
            this.optReceita.Size = new System.Drawing.Size(63, 19);
            this.optReceita.TabIndex = 16;
            this.optReceita.TabStop = true;
            this.optReceita.Text = "Receita";
            this.optReceita.UseVisualStyleBackColor = true;
            // 
            // txtClasse
            // 
            this.txtClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClasse.ForeColor = System.Drawing.Color.White;
            this.txtClasse.Location = new System.Drawing.Point(4, 24);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(246, 23);
            this.txtClasse.TabIndex = 0;
            this.txtClasse.Tag = "\'Classe\'";
            // 
            // gpConta
            // 
            this.gpConta.BackColor = System.Drawing.Color.Transparent;
            this.gpConta.Controls.Add(this.listaConta);
            this.gpConta.Controls.Add(this.ckAtivoConta);
            this.gpConta.Controls.Add(this.btnExcluirConta);
            this.gpConta.Controls.Add(this.txtConta);
            this.gpConta.Controls.Add(this.btnSalvarConta);
            this.gpConta.ForeColor = System.Drawing.Color.White;
            this.gpConta.Location = new System.Drawing.Point(490, 13);
            this.gpConta.Name = "gpConta";
            this.gpConta.Size = new System.Drawing.Size(461, 349);
            this.gpConta.TabIndex = 12;
            this.gpConta.TabStop = false;
            this.gpConta.Text = "Cadastrar Conta";
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
            this.listaConta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaConta.EnableHeadersVisualStyles = false;
            this.listaConta.GridColor = System.Drawing.Color.DimGray;
            this.listaConta.Location = new System.Drawing.Point(7, 81);
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
            this.listaConta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.listaConta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaConta.RowTemplate.Height = 25;
            this.listaConta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaConta.ShowEditingIcon = false;
            this.listaConta.Size = new System.Drawing.Size(419, 234);
            this.listaConta.TabIndex = 1;
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
            this.ckAtivoConta.Location = new System.Drawing.Point(365, 53);
            this.ckAtivoConta.Name = "ckAtivoConta";
            this.ckAtivoConta.Size = new System.Drawing.Size(54, 19);
            this.ckAtivoConta.TabIndex = 18;
            this.ckAtivoConta.TabStop = false;
            this.ckAtivoConta.Text = "Ativo";
            this.ckAtivoConta.UseVisualStyleBackColor = true;
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnExcluirConta.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirConta.Image")));
            this.btnExcluirConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirConta.Location = new System.Drawing.Point(345, 24);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(81, 23);
            this.btnExcluirConta.TabIndex = 2;
            this.btnExcluirConta.Text = "Excluir";
            this.btnExcluirConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirConta.UseVisualStyleBackColor = true;
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConta.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConta.ForeColor = System.Drawing.Color.White;
            this.txtConta.Location = new System.Drawing.Point(6, 24);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(246, 23);
            this.txtConta.TabIndex = 0;
            this.txtConta.Tag = "\'Conta\'";
            // 
            // btnSalvarConta
            // 
            this.btnSalvarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSalvarConta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarConta.Image")));
            this.btnSalvarConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarConta.Location = new System.Drawing.Point(258, 24);
            this.btnSalvarConta.Name = "btnSalvarConta";
            this.btnSalvarConta.Size = new System.Drawing.Size(81, 23);
            this.btnSalvarConta.TabIndex = 1;
            this.btnSalvarConta.Text = "Salvar";
            this.btnSalvarConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarConta.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.gpConta);
            this.Controls.Add(this.gpClasse);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.gpClasse.ResumeLayout(false);
            this.gpClasse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClasse)).EndInit();
            this.gpConta.ResumeLayout(false);
            this.gpConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpClasse;
        private Controles.dgView listaClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.CheckBox ckAtivoClasse;
        private System.Windows.Forms.Button btnExcluirClasse;
        private System.Windows.Forms.Button btnSalvarClasse;
        private System.Windows.Forms.RadioButton optDespesa;
        private System.Windows.Forms.RadioButton optReceita;
        private Controles.Txt txtClasse;
        private System.Windows.Forms.GroupBox gpConta;
        private Controles.dgView listaConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CREDITO;
        private System.Windows.Forms.CheckBox ckAtivoConta;
        private System.Windows.Forms.Button btnExcluirConta;
        private Controles.Txt txtConta;
        private System.Windows.Forms.Button btnSalvarConta;
    }
}