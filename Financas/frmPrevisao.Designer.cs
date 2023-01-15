using System.Windows.Forms;
using System.Drawing;
using System;

namespace Setup.Financas
{
    partial class frmPrevisao
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
            this.lista.GridColor = Color.FromArgb(25, 25, 26);
            this.lista.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.lista.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.lista.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.lista.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            
            this.lista.Columns["DIA"].CellTemplate.Style.BackColor = Color.FromArgb(58, 58, 58);
            this.lista.Columns["DIA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.lista.Columns["ORCADO"].CellTemplate.Style.BackColor = Color.FromArgb(58, 58, 58);
            this.lista.Columns["ORCADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.lista.Columns["OBS"].CellTemplate.Style.BackColor = Color.FromArgb(58, 58, 58);

            this.lista.Columns["REALIZADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.lista.Columns["DESVIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.lista.Columns["EDITAR"].SortMode = DataGridViewColumnSortMode.Automatic;
            this.lista.Columns["EDITAR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.lista.ReadOnly = false;
            this.lista.Columns["CLASSE"].ReadOnly = true;
            this.lista.Columns["TIPO"].ReadOnly = true;
            this.lista.Columns["REALIZADO"].ReadOnly = true;
            this.lista.Columns["DESVIO"].ReadOnly = true;
            this.lista.Columns["STATUSS"].ReadOnly = true;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrevisao));
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
            this.novo = new Setup.Controles.Cabecalho();
            this.excluir = new Setup.Controles.Cabecalho();
            this.replicar = new Setup.Controles.Cabecalho();
            this.atualizar = new Setup.Controles.Cabecalho();
            this.definicoes = new Setup.Controles.Cabecalho();
            this.ano = new System.Windows.Forms.ToolStripComboBox();
            this.mes = new System.Windows.Forms.ToolStripComboBox();
            this.next = new System.Windows.Forms.ToolStripMenuItem();
            this.back = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.lista = new Setup.Controles.dgView();
            this.CLASSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORCADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REALIZADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESVIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUSS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.replicar_ = new System.Windows.Forms.ToolStripMenuItem();
            this.alterar = new System.Windows.Forms.ToolStripMenuItem();
            this.excluir_ = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.receita = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.despesa = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saldo = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.restante = new System.Windows.Forms.ToolStripStatusLabel();
            this.sp4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagens = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novo,
            this.excluir,
            this.replicar,
            this.atualizar,
            this.definicoes,
            this.ano,
            this.mes,
            this.next,
            this.back});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 27);
            this.menuStrip1.TabIndex = 0;
            // 
            // novo
            // 
            this.novo.ForeColor = System.Drawing.Color.White;
            this.novo.Image = ((System.Drawing.Image)(resources.GetObject("novo.Image")));
            this.novo.Name = "novo";
            this.novo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novo.Size = new System.Drawing.Size(64, 23);
            this.novo.Text = "Novo";
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // excluir
            // 
            this.excluir.ForeColor = System.Drawing.Color.White;
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(70, 23);
            this.excluir.Text = "Excluir";
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // replicar
            // 
            this.replicar.ForeColor = System.Drawing.Color.White;
            this.replicar.Image = ((System.Drawing.Image)(resources.GetObject("replicar.Image")));
            this.replicar.Name = "replicar";
            this.replicar.Size = new System.Drawing.Size(77, 23);
            this.replicar.Text = "Replicar";
            this.replicar.Click += new System.EventHandler(this.replicar_Click);
            // 
            // atualizar
            // 
            this.atualizar.ForeColor = System.Drawing.Color.White;
            this.atualizar.Image = ((System.Drawing.Image)(resources.GetObject("atualizar.Image")));
            this.atualizar.Name = "atualizar";
            this.atualizar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.atualizar.Size = new System.Drawing.Size(81, 23);
            this.atualizar.Text = "Atualizar";
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // definicoes
            // 
            this.definicoes.ForeColor = System.Drawing.Color.White;
            this.definicoes.Image = ((System.Drawing.Image)(resources.GetObject("definicoes.Image")));
            this.definicoes.Name = "definicoes";
            this.definicoes.Size = new System.Drawing.Size(90, 23);
            this.definicoes.Text = "Definições";
            // 
            // ano
            // 
            this.ano.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ano.CausesValidation = false;
            this.ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ano.ForeColor = System.Drawing.Color.White;
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(121, 23);
            this.ano.SelectedIndexChanged += new System.EventHandler(this.ano_SelectedIndexChanged);
            // 
            // mes
            // 
            this.mes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.mes.CausesValidation = false;
            this.mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes.ForeColor = System.Drawing.Color.White;
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(121, 23);
            this.mes.SelectedIndexChanged += new System.EventHandler(this.mes_SelectedIndexChanged);
            // 
            // next
            // 
            this.next.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.next.ForeColor = System.Drawing.Color.White;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(28, 23);
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(28, 23);
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.lista);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1050, 468);
            this.panel.TabIndex = 1;
            this.panel.CausesValidationChanged += new System.EventHandler(this.panel_CausesValidationChanged);
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
            this.CLASSE,
            this.TIPO,
            this.DIA,
            this.ORCADO,
            this.REALIZADO,
            this.DESVIO,
            this.STATUSS,
            this.ORD,
            this.OBS,
            this.CHAVE,
            this.EDITAR,
            this.dataGridViewImageColumn1});
            this.lista.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle7;
            this.lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista.Location = new System.Drawing.Point(0, 0);
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
            this.lista.Size = new System.Drawing.Size(1050, 468);
            this.lista.TabIndex = 1;
            this.lista.DataSourceChanged += new System.EventHandler(this.lista_DataSourceChanged);
            this.lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellClick);
            this.lista.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellEndEdit);
            this.lista.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellMouseEnter);
            this.lista.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.lista_DataError);
            this.lista.Sorted += new System.EventHandler(this.lista_Sorted);
            this.lista.DoubleClick += new System.EventHandler(this.lista_DoubleClick);
            this.lista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lista_KeyDown);
            // 
            // CLASSE
            // 
            this.CLASSE.DataPropertyName = "CLASSE";
            this.CLASSE.HeaderText = "CLASSE";
            this.CLASSE.Name = "CLASSE";
            this.CLASSE.ReadOnly = true;
            // 
            // TIPO
            // 
            this.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.MinimumWidth = 150;
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 150;
            // 
            // DIA
            // 
            this.DIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DIA.DataPropertyName = "DIA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.DIA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DIA.HeaderText = "DIA";
            this.DIA.Name = "DIA";
            this.DIA.ReadOnly = true;
            this.DIA.Width = 52;
            // 
            // ORCADO
            // 
            this.ORCADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ORCADO.DataPropertyName = "ORCADO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.ORCADO.DefaultCellStyle = dataGridViewCellStyle4;
            this.ORCADO.HeaderText = "ORÇADO";
            this.ORCADO.MinimumWidth = 100;
            this.ORCADO.Name = "ORCADO";
            this.ORCADO.ReadOnly = true;
            // 
            // REALIZADO
            // 
            this.REALIZADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.REALIZADO.DataPropertyName = "REALIZADO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.REALIZADO.DefaultCellStyle = dataGridViewCellStyle5;
            this.REALIZADO.HeaderText = "REALIZADO";
            this.REALIZADO.MinimumWidth = 100;
            this.REALIZADO.Name = "REALIZADO";
            this.REALIZADO.ReadOnly = true;
            // 
            // DESVIO
            // 
            this.DESVIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DESVIO.DataPropertyName = "DESVIO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.DESVIO.DefaultCellStyle = dataGridViewCellStyle6;
            this.DESVIO.HeaderText = "RESTANTE";
            this.DESVIO.MinimumWidth = 100;
            this.DESVIO.Name = "DESVIO";
            this.DESVIO.ReadOnly = true;
            // 
            // STATUSS
            // 
            this.STATUSS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STATUSS.DataPropertyName = "STATUS";
            this.STATUSS.FalseValue = "0";
            this.STATUSS.HeaderText = "STATUS";
            this.STATUSS.IndeterminateValue = "0";
            this.STATUSS.Name = "STATUSS";
            this.STATUSS.ReadOnly = true;
            this.STATUSS.TrueValue = "1";
            this.STATUSS.Width = 54;
            // 
            // ORD
            // 
            this.ORD.DataPropertyName = "ORD";
            this.ORD.HeaderText = "ORD";
            this.ORD.Name = "ORD";
            this.ORD.ReadOnly = true;
            this.ORD.Visible = false;
            // 
            // OBS
            // 
            this.OBS.DataPropertyName = "OBS";
            this.OBS.HeaderText = "OBSERVAÇÃO";
            this.OBS.Name = "OBS";
            this.OBS.ReadOnly = true;
            // 
            // CHAVE
            // 
            this.CHAVE.DataPropertyName = "CHAVE";
            this.CHAVE.HeaderText = "CHAVE";
            this.CHAVE.Name = "CHAVE";
            this.CHAVE.ReadOnly = true;
            this.CHAVE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHAVE.Visible = false;
            // 
            // EDITAR
            // 
            this.EDITAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EDITAR.Description = "Editar";
            this.EDITAR.HeaderText = "";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.MinimumWidth = 40;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            this.EDITAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EDITAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EDITAR.Width = 40;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.Description = "Excluir";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 40;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detalhes,
            this.replicar_,
            this.alterar,
            this.excluir_});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // detalhes
            // 
            this.detalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.detalhes.Image = ((System.Drawing.Image)(resources.GetObject("detalhes.Image")));
            this.detalhes.Name = "detalhes";
            this.detalhes.Size = new System.Drawing.Size(119, 22);
            this.detalhes.Text = "Detalhes";
            this.detalhes.Click += new System.EventHandler(this.detalhes_Click);
            // 
            // replicar_
            // 
            this.replicar_.Image = ((System.Drawing.Image)(resources.GetObject("replicar_.Image")));
            this.replicar_.Name = "replicar_";
            this.replicar_.Size = new System.Drawing.Size(119, 22);
            this.replicar_.Text = "Replicar";
            this.replicar_.Click += new System.EventHandler(this.replicar__Click);
            // 
            // alterar
            // 
            this.alterar.Image = ((System.Drawing.Image)(resources.GetObject("alterar.Image")));
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(119, 22);
            this.alterar.Text = "Alterar";
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // excluir_
            // 
            this.excluir_.Image = ((System.Drawing.Image)(resources.GetObject("excluir_.Image")));
            this.excluir_.Name = "excluir_";
            this.excluir_.Size = new System.Drawing.Size(119, 22);
            this.excluir_.Text = "Excluir";
            this.excluir_.Click += new System.EventHandler(this.excluir__Click);
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receita,
            this.sp1,
            this.despesa,
            this.sp2,
            this.saldo,
            this.sp3,
            this.restante,
            this.sp4,
            this.msg});
            this.status.Location = new System.Drawing.Point(0, 495);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1050, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 7;
            // 
            // receita
            // 
            this.receita.Image = ((System.Drawing.Image)(resources.GetObject("receita.Image")));
            this.receita.Name = "receita";
            this.receita.Size = new System.Drawing.Size(104, 17);
            this.receita.Text = "Receita: R$ 0,00";
            this.receita.ToolTipText = "Total Receita";
            // 
            // sp1
            // 
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(10, 17);
            this.sp1.Text = "|";
            this.sp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // despesa
            // 
            this.despesa.Image = ((System.Drawing.Image)(resources.GetObject("despesa.Image")));
            this.despesa.Name = "despesa";
            this.despesa.Size = new System.Drawing.Size(109, 17);
            this.despesa.Text = "Despesa: R$ 0,00";
            this.despesa.ToolTipText = "Total Despesa";
            // 
            // sp2
            // 
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(10, 17);
            this.sp2.Text = "|";
            this.sp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saldo
            // 
            this.saldo.Image = ((System.Drawing.Image)(resources.GetObject("saldo.Image")));
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(135, 17);
            this.saldo.Text = "Saldo Contas: R$ 0,00";
            this.saldo.ToolTipText = "Saldo das Contas";
            // 
            // sp3
            // 
            this.sp3.Name = "sp3";
            this.sp3.Size = new System.Drawing.Size(10, 17);
            this.sp3.Text = "|";
            this.sp3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // restante
            // 
            this.restante.Image = ((System.Drawing.Image)(resources.GetObject("restante.Image")));
            this.restante.Name = "restante";
            this.restante.Size = new System.Drawing.Size(111, 17);
            this.restante.Text = "Restante: R$ 0,00";
            this.restante.ToolTipText = "Saldo Restante";
            // 
            // sp4
            // 
            this.sp4.Name = "sp4";
            this.sp4.Size = new System.Drawing.Size(10, 17);
            this.sp4.Text = "|";
            this.sp4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // msg
            // 
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(85, 17);
            this.msg.Text = "Desvio: R$ 0,00";
            // 
            // imagens
            // 
            this.imagens.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagens.ImageStream")));
            this.imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.imagens.Images.SetKeyName(0, "add");
            this.imagens.Images.SetKeyName(1, "clear");
            this.imagens.Images.SetKeyName(2, "credit");
            this.imagens.Images.SetKeyName(3, "edit");
            this.imagens.Images.SetKeyName(4, "delete");
            this.imagens.Images.SetKeyName(5, "list");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 468);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(1049, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 468);
            this.label2.TabIndex = 8;
            // 
            // lblDown
            // 
            this.lblDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lblDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDown.Location = new System.Drawing.Point(0, 517);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(1050, 1);
            this.lblDown.TabIndex = 8;
            // 
            // frmPrevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1050, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1066, 88);
            this.Name = "frmPrevisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrevisao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip status;
        private ImageList imagens;
        public Panel panel;
        private Controles.Cabecalho novo;
        private Controles.Cabecalho excluir;
        private Controles.Cabecalho replicar;
        public ToolStripComboBox ano;
        public ToolStripComboBox mes;
        private Controles.Cabecalho atualizar;
        private Controles.Cabecalho definicoes;
        private ToolStripMenuItem next;
        private ToolStripMenuItem back;
        private Label label1;
        private Label label2;
        private Label lblDown;
        private Controles.dgView lista;
        private ToolStripStatusLabel receita;
        private ToolStripStatusLabel sp1;
        private ToolStripStatusLabel despesa;
        private ToolStripStatusLabel sp2;
        private ToolStripStatusLabel restante;
        private ToolStripStatusLabel saldo;
        private ToolStripStatusLabel sp3;
        private ToolStripStatusLabel sp4;
        private ToolStripStatusLabel msg;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem detalhes;
        private ToolStripMenuItem replicar_;
        private DataGridViewTextBoxColumn CLASSE;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn DIA;
        private DataGridViewTextBoxColumn ORCADO;
        private DataGridViewTextBoxColumn REALIZADO;
        private DataGridViewTextBoxColumn DESVIO;
        private DataGridViewCheckBoxColumn STATUSS;
        private DataGridViewTextBoxColumn ORD;
        private DataGridViewTextBoxColumn OBS;
        private DataGridViewTextBoxColumn CHAVE;
        private DataGridViewImageColumn EDITAR;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private ToolStripMenuItem alterar;
        private ToolStripMenuItem excluir_;
    }
}