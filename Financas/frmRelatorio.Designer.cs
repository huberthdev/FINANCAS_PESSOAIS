﻿using Setup.Controles;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas
{
    partial class frmRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lista.MultiSelect = true;
            this.lista.BorderStyle = BorderStyle.None;
            this.lista.GridColor = Color.FromArgb(25, 25, 26);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atualizar = new Setup.Controles.Cabecalho();
            this.excluir = new Setup.Controles.Cabecalho();
            this.alterar = new Setup.Controles.Cabecalho();
            this.limparFiltro = new Setup.Controles.Cabecalho();
            this.exportar = new Setup.Controles.Cabecalho();
            this.excel = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClasse = new Setup.Controles.cbCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.cbConta = new Setup.Controles.cbCombo();
            this.ckReceita = new System.Windows.Forms.CheckBox();
            this.ckDespesa = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new Setup.Controles.Txt();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor1 = new Setup.Controles.Decimal();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor2 = new Setup.Controles.Decimal();
            this.lista = new Setup.Controles.dgView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarBD = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirBD = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataFim = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.StatusStrip();
            this.total = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalLn = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lg1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lg2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lg3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lg4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.somaLn = new System.Windows.Forms.ToolStripStatusLabel();
            this.msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDown = new System.Windows.Forms.Label();
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.lblPorc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.pnFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizar,
            this.excluir,
            this.alterar,
            this.limparFiltro,
            this.exportar});
            this.menuStrip1.Location = new System.Drawing.Point(4, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.menuStrip1.MdiWindowListItem = this.atualizar;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // atualizar
            // 
            this.atualizar.ForeColor = System.Drawing.Color.White;
            this.atualizar.Image = ((System.Drawing.Image)(resources.GetObject("atualizar.Image")));
            this.atualizar.Name = "atualizar";
            this.atualizar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.atualizar.Size = new System.Drawing.Size(104, 20);
            this.atualizar.Text = "Atualizar {F5}";
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.ForeColor = System.Drawing.Color.White;
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.Name = "excluir";
            this.excluir.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluir.Size = new System.Drawing.Size(101, 20);
            this.excluir.Text = "Excluir {DEL}";
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // alterar
            // 
            this.alterar.ForeColor = System.Drawing.Color.White;
            this.alterar.Image = global::Setup.Properties.Resources.edit;
            this.alterar.Name = "alterar";
            this.alterar.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.alterar.Size = new System.Drawing.Size(93, 20);
            this.alterar.Text = "Alterar {F2}";
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // limparFiltro
            // 
            this.limparFiltro.ForeColor = System.Drawing.Color.White;
            this.limparFiltro.Image = ((System.Drawing.Image)(resources.GetObject("limparFiltro.Image")));
            this.limparFiltro.Name = "limparFiltro";
            this.limparFiltro.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.limparFiltro.Size = new System.Drawing.Size(102, 20);
            this.limparFiltro.Text = "Limpar Filtro";
            this.limparFiltro.Click += new System.EventHandler(this.limparFiltro_Click);
            // 
            // exportar
            // 
            this.exportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excel});
            this.exportar.ForeColor = System.Drawing.Color.White;
            this.exportar.Image = ((System.Drawing.Image)(resources.GetObject("exportar.Image")));
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(79, 20);
            this.exportar.Text = "Exportar";
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            // 
            // excel
            // 
            this.excel.Image = ((System.Drawing.Image)(resources.GetObject("excel.Image")));
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(101, 22);
            this.excel.Text = "Excel";
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "De:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(407, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Classe:";
            // 
            // cbClasse
            // 
            this.cbClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbClasse.DropDownHeight = 136;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClasse.ForeColor = System.Drawing.Color.White;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.IntegralHeight = false;
            this.cbClasse.Location = new System.Drawing.Point(456, 11);
            this.cbClasse.MaxDropDownItems = 10;
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(209, 23);
            this.cbClasse.Sorted = true;
            this.cbClasse.TabIndex = 3;
            this.cbClasse.SelectedValueChanged += new System.EventHandler(this.cbClasse_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(671, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Conta:";
            // 
            // cbConta
            // 
            this.cbConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbConta.DropDownHeight = 136;
            this.cbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConta.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbConta.ForeColor = System.Drawing.Color.White;
            this.cbConta.FormattingEnabled = true;
            this.cbConta.IntegralHeight = false;
            this.cbConta.Location = new System.Drawing.Point(719, 11);
            this.cbConta.MaxDropDownItems = 10;
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(209, 23);
            this.cbConta.TabIndex = 4;
            this.cbConta.SelectedValueChanged += new System.EventHandler(this.cbConta_SelectedValueChanged);
            // 
            // ckReceita
            // 
            this.ckReceita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ckReceita.AutoSize = true;
            this.ckReceita.ForeColor = System.Drawing.Color.White;
            this.ckReceita.Location = new System.Drawing.Point(796, 44);
            this.ckReceita.Name = "ckReceita";
            this.ckReceita.Size = new System.Drawing.Size(64, 19);
            this.ckReceita.TabIndex = 8;
            this.ckReceita.Text = "Receita";
            this.ckReceita.UseVisualStyleBackColor = true;
            this.ckReceita.CheckedChanged += new System.EventHandler(this.ckReceita_CheckedChanged);
            this.ckReceita.Click += new System.EventHandler(this.ckReceita_Click);
            // 
            // ckDespesa
            // 
            this.ckDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ckDespesa.AutoSize = true;
            this.ckDespesa.ForeColor = System.Drawing.Color.White;
            this.ckDespesa.Location = new System.Drawing.Point(865, 44);
            this.ckDespesa.Name = "ckDespesa";
            this.ckDespesa.Size = new System.Drawing.Size(69, 19);
            this.ckDespesa.TabIndex = 9;
            this.ckDespesa.Text = "Despesa";
            this.ckDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckDespesa.UseVisualStyleBackColor = true;
            this.ckDespesa.CheckedChanged += new System.EventHandler(this.ckDespesa_CheckedChanged);
            this.ckDespesa.Click += new System.EventHandler(this.ckDespesa_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(115, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(182, 42);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(297, 23);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(485, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valor Entre:";
            // 
            // txtValor1
            // 
            this.txtValor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtValor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor1.Enabled = false;
            this.txtValor1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor1.ForeColor = System.Drawing.Color.White;
            this.txtValor1.Location = new System.Drawing.Point(557, 42);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 23);
            this.txtValor1.TabIndex = 6;
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(663, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "e";
            // 
            // txtValor2
            // 
            this.txtValor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtValor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor2.Enabled = false;
            this.txtValor2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor2.ForeColor = System.Drawing.Color.White;
            this.txtValor2.Location = new System.Drawing.Point(682, 42);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 23);
            this.txtValor2.TabIndex = 7;
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.ID,
            this.TIPO,
            this.DATA,
            this.CLASSE,
            this.CONTA,
            this.VALOR,
            this.DESC,
            this.dataGridViewTextBoxColumn1});
            this.lista.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle5;
            this.lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista.Location = new System.Drawing.Point(4, 104);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(1040, 313);
            this.lista.TabIndex = 1;
            this.lista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.lista_DataBindingComplete);
            this.lista.SelectionChanged += new System.EventHandler(this.lista_SelectionChanged);
            this.lista.Sorted += new System.EventHandler(this.lista_Sorted);
            this.lista.DoubleClick += new System.EventHandler(this.lista_DoubleClick);
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
            // TIPO
            // 
            this.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Visible = false;
            this.TIPO.Width = 5;
            // 
            // DATA
            // 
            this.DATA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DATA.DataPropertyName = "DATA";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATA.HeaderText = "DATA";
            this.DATA.MinimumWidth = 90;
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 90;
            // 
            // CLASSE
            // 
            this.CLASSE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CLASSE.DataPropertyName = "CLASSE";
            this.CLASSE.HeaderText = "CLASSE";
            this.CLASSE.MinimumWidth = 230;
            this.CLASSE.Name = "CLASSE";
            this.CLASSE.ReadOnly = true;
            this.CLASSE.Width = 230;
            // 
            // CONTA
            // 
            this.CONTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CONTA.DataPropertyName = "CONTA";
            this.CONTA.HeaderText = "CONTA";
            this.CONTA.MinimumWidth = 225;
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.Width = 225;
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0,00";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle4;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.MinimumWidth = 90;
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 90;
            // 
            // DESC
            // 
            this.DESC.DataPropertyName = "DESC";
            this.DESC.HeaderText = "DESCRIÇÃO";
            this.DESC.MinimumWidth = 325;
            this.DESC.Name = "DESC";
            this.DESC.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn1.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarBD,
            this.excluirBD});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // alterarBD
            // 
            this.alterarBD.Image = ((System.Drawing.Image)(resources.GetObject("alterarBD.Image")));
            this.alterarBD.Name = "alterarBD";
            this.alterarBD.Size = new System.Drawing.Size(109, 22);
            this.alterarBD.Text = "Alterar";
            this.alterarBD.Click += new System.EventHandler(this.alterarBD_Click);
            // 
            // excluirBD
            // 
            this.excluirBD.Image = ((System.Drawing.Image)(resources.GetObject("excluirBD.Image")));
            this.excluirBD.Name = "excluirBD";
            this.excluirBD.Size = new System.Drawing.Size(109, 22);
            this.excluirBD.Text = "Excluir";
            this.excluirBD.Click += new System.EventHandler(this.excluirBD_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "alert.png");
            this.imageList1.Images.SetKeyName(1, "exit.png");
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDataInicio.CalendarForeColor = System.Drawing.Color.White;
            this.txtDataInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(145, 11);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.ShowCheckBox = true;
            this.txtDataInicio.Size = new System.Drawing.Size(109, 23);
            this.txtDataInicio.TabIndex = 10;
            this.txtDataInicio.ValueChanged += new System.EventHandler(this.txtDataInicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Até:";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDataFim.CalendarForeColor = System.Drawing.Color.White;
            this.txtDataFim.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFim.Location = new System.Drawing.Point(294, 11);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.ShowCheckBox = true;
            this.txtDataFim.Size = new System.Drawing.Size(109, 23);
            this.txtDataFim.TabIndex = 10;
            this.txtDataFim.ValueChanged += new System.EventHandler(this.txtDataFim_ValueChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(4, 443);
            this.label9.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(1044, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(4, 443);
            this.label10.TabIndex = 12;
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.total,
            this.sp1,
            this.totalLn,
            this.sp2,
            this.lg1,
            this.lg2,
            this.lg3,
            this.lg4,
            this.sp3,
            this.somaLn,
            this.msg});
            this.status.Location = new System.Drawing.Point(4, 417);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1040, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 13;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(48, 17);
            this.total.Text = "R$ 0,00";
            // 
            // sp1
            // 
            this.sp1.ForeColor = System.Drawing.Color.White;
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(10, 17);
            this.sp1.Text = "|";
            this.sp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalLn
            // 
            this.totalLn.BackColor = System.Drawing.Color.Transparent;
            this.totalLn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLn.ForeColor = System.Drawing.Color.White;
            this.totalLn.Name = "totalLn";
            this.totalLn.Size = new System.Drawing.Size(63, 17);
            this.totalLn.Text = "LINHAS: 0";
            // 
            // sp2
            // 
            this.sp2.ForeColor = System.Drawing.Color.White;
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(10, 17);
            this.sp2.Text = "|";
            this.sp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lg1
            // 
            this.lg1.ForeColor = System.Drawing.Color.LimeGreen;
            this.lg1.Name = "lg1";
            this.lg1.Size = new System.Drawing.Size(58, 17);
            this.lg1.Text = "■ Receita";
            this.lg1.Click += new System.EventHandler(this.lg1_Click);
            // 
            // lg2
            // 
            this.lg2.ForeColor = System.Drawing.Color.Tomato;
            this.lg2.Name = "lg2";
            this.lg2.Size = new System.Drawing.Size(63, 17);
            this.lg2.Text = "■ Despesa";
            this.lg2.Click += new System.EventHandler(this.lg2_Click);
            // 
            // lg3
            // 
            this.lg3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lg3.Name = "lg3";
            this.lg3.Size = new System.Drawing.Size(59, 17);
            this.lg3.Text = "■ Crédito";
            // 
            // lg4
            // 
            this.lg4.ForeColor = System.Drawing.Color.Fuchsia;
            this.lg4.Name = "lg4";
            this.lg4.Size = new System.Drawing.Size(89, 17);
            this.lg4.Text = "■ Transferência";
            // 
            // sp3
            // 
            this.sp3.ForeColor = System.Drawing.Color.White;
            this.sp3.Name = "sp3";
            this.sp3.Size = new System.Drawing.Size(10, 17);
            this.sp3.Text = "|";
            this.sp3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // somaLn
            // 
            this.somaLn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.somaLn.ForeColor = System.Drawing.Color.White;
            this.somaLn.Name = "somaLn";
            this.somaLn.Size = new System.Drawing.Size(25, 17);
            this.somaLn.Text = "<--";
            // 
            // msg
            // 
            this.msg.ForeColor = System.Drawing.Color.White;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 17);
            // 
            // lblDown
            // 
            this.lblDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lblDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDown.Location = new System.Drawing.Point(4, 102);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(1040, 2);
            this.lblDown.TabIndex = 14;
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.txtDataFim);
            this.pnFiltro.Controls.Add(this.label2);
            this.pnFiltro.Controls.Add(this.label3);
            this.pnFiltro.Controls.Add(this.label6);
            this.pnFiltro.Controls.Add(this.label7);
            this.pnFiltro.Controls.Add(this.label8);
            this.pnFiltro.Controls.Add(this.txtDataInicio);
            this.pnFiltro.Controls.Add(this.label4);
            this.pnFiltro.Controls.Add(this.label5);
            this.pnFiltro.Controls.Add(this.cbClasse);
            this.pnFiltro.Controls.Add(this.ckDespesa);
            this.pnFiltro.Controls.Add(this.cbConta);
            this.pnFiltro.Controls.Add(this.ckReceita);
            this.pnFiltro.Controls.Add(this.txtDescricao);
            this.pnFiltro.Controls.Add(this.txtValor2);
            this.pnFiltro.Controls.Add(this.txtValor1);
            this.pnFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFiltro.Location = new System.Drawing.Point(4, 24);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(1040, 78);
            this.pnFiltro.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(4, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 4);
            this.label1.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(4, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1040, 4);
            this.label11.TabIndex = 18;
            // 
            // progresso
            // 
            this.progresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progresso.Location = new System.Drawing.Point(728, 421);
            this.progresso.Maximum = 40;
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(311, 14);
            this.progresso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresso.TabIndex = 19;
            this.progresso.Visible = false;
            // 
            // lblPorc
            // 
            this.lblPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPorc.BackColor = System.Drawing.Color.Transparent;
            this.lblPorc.ForeColor = System.Drawing.Color.White;
            this.lblPorc.Location = new System.Drawing.Point(675, 419);
            this.lblPorc.Name = "lblPorc";
            this.lblPorc.Size = new System.Drawing.Size(56, 19);
            this.lblPorc.TabIndex = 11;
            this.lblPorc.Text = "%";
            this.lblPorc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPorc.Visible = false;
            // 
            // frmRelatorio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1048, 443);
            this.Controls.Add(this.lblPorc);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.pnFiltro);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRelatorio_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem excel;
        private Label label2;
        private Label label4;
        private Label label5;
        private Controles.cbCombo cbConta;
        private CheckBox ckReceita;
        private Label label6;
        private Controles.Txt txtDescricao;
        private Label label7;
        private Controles.Decimal txtValor1;
        private Label label8;
        private Controles.Decimal txtValor2;
        private ImageList imageList1;
        private Label label3;
        public DateTimePicker txtDataInicio;
        public DateTimePicker txtDataFim;
        public Controles.cbCombo cbClasse;
        public CheckBox ckDespesa;
        public Controles.dgView lista;
        private Label label9;
        private Label label10;
        private StatusStrip status;
        private ToolStripStatusLabel total;
        private ToolStripStatusLabel sp1;
        private ToolStripStatusLabel totalLn;
        private ToolStripStatusLabel sp2;
        private ToolStripStatusLabel lg1;
        private ToolStripStatusLabel lg2;
        private ToolStripStatusLabel lg3;
        private ToolStripStatusLabel lg4;
        private ToolStripStatusLabel sp3;
        private ToolStripStatusLabel somaLn;
        private ToolStripStatusLabel msg;
        private Label lblDown;
        private Cabecalho atualizar;
        private Cabecalho excluir;
        private Cabecalho alterar;
        private Cabecalho limparFiltro;
        private Cabecalho exportar;
        private Panel pnFiltro;
        private Label label1;
        private Label label11;
        private ProgressBar progresso;
        private Label lblPorc;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem alterarBD;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn CLASSE;
        private DataGridViewTextBoxColumn CONTA;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn DESC;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ToolStripMenuItem excluirBD;
    }
}