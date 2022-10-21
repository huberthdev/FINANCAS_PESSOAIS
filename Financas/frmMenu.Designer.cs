﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas
{
    partial class frmMenu
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
            this.lista_Gastos_Classe.Columns[2].CellTemplate.Style.ForeColor = Color.FromArgb(236, 35, 0);
            this.lista_Gastos_Classe.BorderStyle = BorderStyle.None;
            this.lista_Gastos_Classe.GridColor = Color.FromArgb(37, 37, 38);
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

            this.listaSaldo_Contas.BorderStyle = BorderStyle.None;
            this.listaSaldo_Contas.GridColor = Color.FromArgb(37, 37, 38);
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new Setup.Controles.Cabecalho();
            this.novoLancamento = new System.Windows.Forms.ToolStripMenuItem();
            this.receitaDespesa = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.transferencia = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.classesDeCustoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cartaoDeCreditoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.exportar = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previsaoDeCustos = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.connBD = new System.Windows.Forms.ToolStripMenuItem();
            this.query = new System.Windows.Forms.ToolStripMenuItem();
            this.anotacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolLancamento = new Setup.Controles.Cabecalho();
            this.compraCredito = new Setup.Controles.Cabecalho();
            this.transf = new Setup.Controles.Cabecalho();
            this.ToolRelatorio = new Setup.Controles.Cabecalho();
            this.ToolVisaoGeral = new Setup.Controles.Cabecalho();
            this.ToolPrevisao = new Setup.Controles.Cabecalho();
            this.ToolCalculadora = new Setup.Controles.Cabecalho();
            this.listaSaldo_Contas = new Setup.Controles.dgView();
            this.CONTA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lista_Gastos_Classe = new Setup.Controles.dgView();
            this.CLASSE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSalvar = new System.Windows.Forms.Panel();
            this.pnSalvarIn = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbClasse = new Setup.Controles.cbCombo();
            this.opReceita = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new Setup.Controles.Decimal();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConta = new Setup.Controles.cbCombo();
            this.txtData = new Setup.Controles.Data();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new Setup.Controles.Txt();
            this.opDespesa = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.stSalvar = new System.Windows.Forms.MenuStrip();
            this.salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.limpar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.pnListaClasse = new System.Windows.Forms.Panel();
            this.lnLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lnRight = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSaldo_Contas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Gastos_Classe)).BeginInit();
            this.pnSalvar.SuspendLayout();
            this.pnSalvarIn.SuspendLayout();
            this.stSalvar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.pnListaClasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.ToolLancamento,
            this.compraCredito,
            this.transf,
            this.ToolRelatorio,
            this.ToolVisaoGeral,
            this.ToolPrevisao,
            this.ToolCalculadora});
            this.menuStrip1.Location = new System.Drawing.Point(5, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoLancamento,
            this.relatorios,
            this.cadastros,
            this.exportar,
            this.previsaoDeCustos,
            this.configuracoes,
            this.query,
            this.anotacoes,
            this.sair});
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Name = "menu";
            this.menu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menu.Size = new System.Drawing.Size(66, 20);
            this.menu.Text = "Menu";
            // 
            // novoLancamento
            // 
            this.novoLancamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receitaDespesa,
            this.comprasCredito,
            this.transferencia});
            this.novoLancamento.Image = ((System.Drawing.Image)(resources.GetObject("novoLancamento.Image")));
            this.novoLancamento.Name = "novoLancamento";
            this.novoLancamento.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.novoLancamento.Size = new System.Drawing.Size(246, 22);
            this.novoLancamento.Text = "Novo Lançamento";
            // 
            // receitaDespesa
            // 
            this.receitaDespesa.Image = ((System.Drawing.Image)(resources.GetObject("receitaDespesa.Image")));
            this.receitaDespesa.Name = "receitaDespesa";
            this.receitaDespesa.Size = new System.Drawing.Size(255, 22);
            this.receitaDespesa.Text = "Receitas • Despesas";
            // 
            // comprasCredito
            // 
            this.comprasCredito.Image = ((System.Drawing.Image)(resources.GetObject("comprasCredito.Image")));
            this.comprasCredito.Name = "comprasCredito";
            this.comprasCredito.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.comprasCredito.Size = new System.Drawing.Size(255, 22);
            this.comprasCredito.Text = "Compras no Crédito";
            this.comprasCredito.Click += new System.EventHandler(this.comprasCredito_Click);
            // 
            // transferencia
            // 
            this.transferencia.Image = ((System.Drawing.Image)(resources.GetObject("transferencia.Image")));
            this.transferencia.Name = "transferencia";
            this.transferencia.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.transferencia.Size = new System.Drawing.Size(255, 22);
            this.transferencia.Text = "Transferências";
            this.transferencia.Click += new System.EventHandler(this.transnferênciasToolStripMenuItem_Click);
            // 
            // relatorios
            // 
            this.relatorios.Image = ((System.Drawing.Image)(resources.GetObject("relatorios.Image")));
            this.relatorios.Name = "relatorios";
            this.relatorios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relatorios.Size = new System.Drawing.Size(246, 22);
            this.relatorios.Text = "Relatório";
            this.relatorios.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // cadastros
            // 
            this.cadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesDeCustoAdd,
            this.contasAdd,
            this.cartaoDeCreditoAdd});
            this.cadastros.Image = ((System.Drawing.Image)(resources.GetObject("cadastros.Image")));
            this.cadastros.Name = "cadastros";
            this.cadastros.Size = new System.Drawing.Size(246, 22);
            this.cadastros.Text = "Cadastros";
            // 
            // classesDeCustoAdd
            // 
            this.classesDeCustoAdd.Image = ((System.Drawing.Image)(resources.GetObject("classesDeCustoAdd.Image")));
            this.classesDeCustoAdd.Name = "classesDeCustoAdd";
            this.classesDeCustoAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.classesDeCustoAdd.Size = new System.Drawing.Size(205, 22);
            this.classesDeCustoAdd.Text = "Classes de Custo";
            // 
            // contasAdd
            // 
            this.contasAdd.Image = ((System.Drawing.Image)(resources.GetObject("contasAdd.Image")));
            this.contasAdd.Name = "contasAdd";
            this.contasAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.contasAdd.Size = new System.Drawing.Size(205, 22);
            this.contasAdd.Text = "Contas";
            // 
            // cartaoDeCreditoAdd
            // 
            this.cartaoDeCreditoAdd.Image = ((System.Drawing.Image)(resources.GetObject("cartaoDeCreditoAdd.Image")));
            this.cartaoDeCreditoAdd.Name = "cartaoDeCreditoAdd";
            this.cartaoDeCreditoAdd.Size = new System.Drawing.Size(205, 22);
            this.cartaoDeCreditoAdd.Text = "Cartão de Crédito";
            this.cartaoDeCreditoAdd.Click += new System.EventHandler(this.cartaoDeCreditoAdd_Click);
            // 
            // exportar
            // 
            this.exportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.exportar.Image = ((System.Drawing.Image)(resources.GetObject("exportar.Image")));
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(246, 22);
            this.exportar.Text = "Exportar";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pDFToolStripMenuItem.Image")));
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excelToolStripMenuItem.Image")));
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // previsaoDeCustos
            // 
            this.previsaoDeCustos.Image = ((System.Drawing.Image)(resources.GetObject("previsaoDeCustos.Image")));
            this.previsaoDeCustos.Name = "previsaoDeCustos";
            this.previsaoDeCustos.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.previsaoDeCustos.Size = new System.Drawing.Size(246, 22);
            this.previsaoDeCustos.Text = "Previsão de Custos";
            // 
            // configuracoes
            // 
            this.configuracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioAdd,
            this.connBD});
            this.configuracoes.Image = ((System.Drawing.Image)(resources.GetObject("configuracoes.Image")));
            this.configuracoes.Name = "configuracoes";
            this.configuracoes.Size = new System.Drawing.Size(246, 22);
            this.configuracoes.Text = "Configurações";
            // 
            // usuarioAdd
            // 
            this.usuarioAdd.Image = ((System.Drawing.Image)(resources.GetObject("usuarioAdd.Image")));
            this.usuarioAdd.Name = "usuarioAdd";
            this.usuarioAdd.Size = new System.Drawing.Size(209, 22);
            this.usuarioAdd.Text = "Usuários";
            this.usuarioAdd.Click += new System.EventHandler(this.usuarioAdd_Click);
            // 
            // connBD
            // 
            this.connBD.Image = ((System.Drawing.Image)(resources.GetObject("connBD.Image")));
            this.connBD.Name = "connBD";
            this.connBD.Size = new System.Drawing.Size(209, 22);
            this.connBD.Text = "Conexão Banco de Dados";
            this.connBD.Click += new System.EventHandler(this.connBD_Click);
            // 
            // query
            // 
            this.query.Image = ((System.Drawing.Image)(resources.GetObject("query.Image")));
            this.query.Name = "query";
            this.query.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.query.Size = new System.Drawing.Size(246, 22);
            this.query.Text = "SQL";
            this.query.Click += new System.EventHandler(this.queryDesenvolvedorToolStripMenuItem_Click);
            // 
            // anotacoes
            // 
            this.anotacoes.Image = ((System.Drawing.Image)(resources.GetObject("anotacoes.Image")));
            this.anotacoes.Name = "anotacoes";
            this.anotacoes.Size = new System.Drawing.Size(246, 22);
            this.anotacoes.Text = "Anotações";
            this.anotacoes.Click += new System.EventHandler(this.anotaçõesToolStripMenuItem_Click);
            // 
            // sair
            // 
            this.sair.Image = ((System.Drawing.Image)(resources.GetObject("sair.Image")));
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(246, 22);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ToolLancamento
            // 
            this.ToolLancamento.ForeColor = System.Drawing.Color.White;
            this.ToolLancamento.Image = ((System.Drawing.Image)(resources.GetObject("ToolLancamento.Image")));
            this.ToolLancamento.Name = "ToolLancamento";
            this.ToolLancamento.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.ToolLancamento.Size = new System.Drawing.Size(137, 20);
            this.ToolLancamento.Text = "Receitas • Despesas";
            // 
            // compraCredito
            // 
            this.compraCredito.ForeColor = System.Drawing.Color.White;
            this.compraCredito.Image = ((System.Drawing.Image)(resources.GetObject("compraCredito.Image")));
            this.compraCredito.Name = "compraCredito";
            this.compraCredito.Size = new System.Drawing.Size(142, 20);
            this.compraCredito.Text = "Compras no Crédito";
            this.compraCredito.Click += new System.EventHandler(this.compraCredito_Click);
            // 
            // transf
            // 
            this.transf.ForeColor = System.Drawing.Color.White;
            this.transf.Image = ((System.Drawing.Image)(resources.GetObject("transf.Image")));
            this.transf.Name = "transf";
            this.transf.Size = new System.Drawing.Size(109, 20);
            this.transf.Text = "Transferências";
            this.transf.Click += new System.EventHandler(this.transf_Click);
            // 
            // ToolRelatorio
            // 
            this.ToolRelatorio.ForeColor = System.Drawing.Color.White;
            this.ToolRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("ToolRelatorio.Image")));
            this.ToolRelatorio.Name = "ToolRelatorio";
            this.ToolRelatorio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ToolRelatorio.Size = new System.Drawing.Size(82, 20);
            this.ToolRelatorio.Text = "Relatório";
            this.ToolRelatorio.Click += new System.EventHandler(this.ToolRelatorio_Click);
            // 
            // ToolVisaoGeral
            // 
            this.ToolVisaoGeral.ForeColor = System.Drawing.Color.White;
            this.ToolVisaoGeral.Image = ((System.Drawing.Image)(resources.GetObject("ToolVisaoGeral.Image")));
            this.ToolVisaoGeral.Name = "ToolVisaoGeral";
            this.ToolVisaoGeral.Size = new System.Drawing.Size(93, 20);
            this.ToolVisaoGeral.Text = "Visão Geral";
            this.ToolVisaoGeral.Click += new System.EventHandler(this.ToolVisaoGeral_Click);
            // 
            // ToolPrevisao
            // 
            this.ToolPrevisao.ForeColor = System.Drawing.Color.White;
            this.ToolPrevisao.Image = ((System.Drawing.Image)(resources.GetObject("ToolPrevisao.Image")));
            this.ToolPrevisao.Name = "ToolPrevisao";
            this.ToolPrevisao.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.ToolPrevisao.Size = new System.Drawing.Size(134, 20);
            this.ToolPrevisao.Text = "Previsão de Custos";
            this.ToolPrevisao.Click += new System.EventHandler(this.ToolPrevisao_Click);
            // 
            // ToolCalculadora
            // 
            this.ToolCalculadora.ForeColor = System.Drawing.Color.White;
            this.ToolCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("ToolCalculadora.Image")));
            this.ToolCalculadora.Name = "ToolCalculadora";
            this.ToolCalculadora.Size = new System.Drawing.Size(98, 20);
            this.ToolCalculadora.Text = "Calculadora";
            this.ToolCalculadora.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // listaSaldo_Contas
            // 
            this.listaSaldo_Contas.AllowUserToAddRows = false;
            this.listaSaldo_Contas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.listaSaldo_Contas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listaSaldo_Contas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listaSaldo_Contas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaSaldo_Contas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaSaldo_Contas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaSaldo_Contas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listaSaldo_Contas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listaSaldo_Contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSaldo_Contas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONTA_ID,
            this.CONTA,
            this.SALDO});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaSaldo_Contas.DefaultCellStyle = dataGridViewCellStyle4;
            this.listaSaldo_Contas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaSaldo_Contas.EnableHeadersVisualStyles = false;
            this.listaSaldo_Contas.GridColor = System.Drawing.Color.DimGray;
            this.listaSaldo_Contas.Location = new System.Drawing.Point(7, 213);
            this.listaSaldo_Contas.MultiSelect = false;
            this.listaSaldo_Contas.Name = "listaSaldo_Contas";
            this.listaSaldo_Contas.ReadOnly = true;
            this.listaSaldo_Contas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaSaldo_Contas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listaSaldo_Contas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.listaSaldo_Contas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.listaSaldo_Contas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaSaldo_Contas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.listaSaldo_Contas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.listaSaldo_Contas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaSaldo_Contas.RowTemplate.Height = 25;
            this.listaSaldo_Contas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaSaldo_Contas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listaSaldo_Contas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaSaldo_Contas.ShowEditingIcon = false;
            this.listaSaldo_Contas.Size = new System.Drawing.Size(335, 188);
            this.listaSaldo_Contas.TabIndex = 1;
            // 
            // CONTA_ID
            // 
            this.CONTA_ID.DataPropertyName = "CONTA_ID";
            this.CONTA_ID.HeaderText = "ID";
            this.CONTA_ID.Name = "CONTA_ID";
            this.CONTA_ID.ReadOnly = true;
            this.CONTA_ID.Visible = false;
            // 
            // CONTA
            // 
            this.CONTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CONTA.DataPropertyName = "CONTA";
            this.CONTA.HeaderText = "CONTA";
            this.CONTA.MinimumWidth = 180;
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CONTA.Width = 180;
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "SALDO";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0,00";
            this.SALDO.DefaultCellStyle = dataGridViewCellStyle3;
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            this.SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lista_Gastos_Classe
            // 
            this.lista_Gastos_Classe.AllowUserToAddRows = false;
            this.lista_Gastos_Classe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.lista_Gastos_Classe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.lista_Gastos_Classe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista_Gastos_Classe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista_Gastos_Classe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista_Gastos_Classe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.lista_Gastos_Classe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.lista_Gastos_Classe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_Gastos_Classe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLASSE_ID,
            this.CLASSE,
            this.VALOR});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_Gastos_Classe.DefaultCellStyle = dataGridViewCellStyle10;
            this.lista_Gastos_Classe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista_Gastos_Classe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista_Gastos_Classe.EnableHeadersVisualStyles = false;
            this.lista_Gastos_Classe.GridColor = System.Drawing.Color.DimGray;
            this.lista_Gastos_Classe.Location = new System.Drawing.Point(0, 0);
            this.lista_Gastos_Classe.MultiSelect = false;
            this.lista_Gastos_Classe.Name = "lista_Gastos_Classe";
            this.lista_Gastos_Classe.ReadOnly = true;
            this.lista_Gastos_Classe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_Gastos_Classe.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.lista_Gastos_Classe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.lista_Gastos_Classe.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.lista_Gastos_Classe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista_Gastos_Classe.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista_Gastos_Classe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista_Gastos_Classe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista_Gastos_Classe.RowTemplate.Height = 25;
            this.lista_Gastos_Classe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_Gastos_Classe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lista_Gastos_Classe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_Gastos_Classe.ShowEditingIcon = false;
            this.lista_Gastos_Classe.Size = new System.Drawing.Size(352, 401);
            this.lista_Gastos_Classe.TabIndex = 1;
            this.lista_Gastos_Classe.DoubleClick += new System.EventHandler(this.lista_Gastos_Classe_DoubleClick);
            // 
            // CLASSE_ID
            // 
            this.CLASSE_ID.DataPropertyName = "CLASSE_ID";
            this.CLASSE_ID.HeaderText = "CLASSE_ID";
            this.CLASSE_ID.Name = "CLASSE_ID";
            this.CLASSE_ID.ReadOnly = true;
            this.CLASSE_ID.Visible = false;
            // 
            // CLASSE
            // 
            this.CLASSE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CLASSE.DataPropertyName = "CLASSE";
            this.CLASSE.HeaderText = "CLASSE";
            this.CLASSE.MinimumWidth = 180;
            this.CLASSE.Name = "CLASSE";
            this.CLASSE.ReadOnly = true;
            this.CLASSE.Width = 180;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0,00";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle9;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // pnSalvar
            // 
            this.pnSalvar.Controls.Add(this.pnSalvarIn);
            this.pnSalvar.Controls.Add(this.label8);
            this.pnSalvar.Controls.Add(this.listaSaldo_Contas);
            this.pnSalvar.Controls.Add(this.stSalvar);
            this.pnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSalvar.Location = new System.Drawing.Point(5, 26);
            this.pnSalvar.Name = "pnSalvar";
            this.pnSalvar.Size = new System.Drawing.Size(348, 401);
            this.pnSalvar.TabIndex = 0;
            // 
            // pnSalvarIn
            // 
            this.pnSalvarIn.Controls.Add(this.label11);
            this.pnSalvarIn.Controls.Add(this.cbClasse);
            this.pnSalvarIn.Controls.Add(this.opReceita);
            this.pnSalvarIn.Controls.Add(this.label4);
            this.pnSalvarIn.Controls.Add(this.txtValor);
            this.pnSalvarIn.Controls.Add(this.label5);
            this.pnSalvarIn.Controls.Add(this.label2);
            this.pnSalvarIn.Controls.Add(this.cbConta);
            this.pnSalvarIn.Controls.Add(this.txtData);
            this.pnSalvarIn.Controls.Add(this.label6);
            this.pnSalvarIn.Controls.Add(this.label3);
            this.pnSalvarIn.Controls.Add(this.txtDescricao);
            this.pnSalvarIn.Controls.Add(this.opDespesa);
            this.pnSalvarIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSalvarIn.Location = new System.Drawing.Point(0, 28);
            this.pnSalvarIn.Name = "pnSalvarIn";
            this.pnSalvarIn.Size = new System.Drawing.Size(348, 184);
            this.pnSalvarIn.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(0, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(348, 4);
            this.label11.TabIndex = 47;
            // 
            // cbClasse
            // 
            this.cbClasse.AllowDrop = true;
            this.cbClasse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbClasse.DisplayMember = "1";
            this.cbClasse.DropDownHeight = 136;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClasse.ForeColor = System.Drawing.Color.White;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.IntegralHeight = false;
            this.cbClasse.Location = new System.Drawing.Point(94, 33);
            this.cbClasse.MaxDropDownItems = 10;
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(237, 23);
            this.cbClasse.TabIndex = 35;
            this.cbClasse.Tag = "A";
            // 
            // opReceita
            // 
            this.opReceita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.opReceita.AutoSize = true;
            this.opReceita.ForeColor = System.Drawing.Color.White;
            this.opReceita.Location = new System.Drawing.Point(94, 8);
            this.opReceita.Name = "opReceita";
            this.opReceita.Size = new System.Drawing.Size(74, 19);
            this.opReceita.TabIndex = 40;
            this.opReceita.TabStop = true;
            this.opReceita.Text = "Receita";
            this.opReceita.UseVisualStyleBackColor = true;
            this.opReceita.CheckedChanged += new System.EventHandler(this.opReceita_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Data";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(94, 120);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 23);
            this.txtValor.TabIndex = 38;
            this.txtValor.Tag = "D";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Valor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Classe";
            // 
            // cbConta
            // 
            this.cbConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbConta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbConta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbConta.DropDownHeight = 136;
            this.cbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConta.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbConta.ForeColor = System.Drawing.Color.White;
            this.cbConta.FormattingEnabled = true;
            this.cbConta.IntegralHeight = false;
            this.cbConta.Location = new System.Drawing.Point(94, 62);
            this.cbConta.MaxDropDownItems = 10;
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(237, 23);
            this.cbConta.TabIndex = 36;
            this.cbConta.Tag = "B";
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(94, 91);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(110, 23);
            this.txtData.TabIndex = 37;
            this.txtData.Tag = "C";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Conta";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(94, 149);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(237, 23);
            this.txtDescricao.TabIndex = 39;
            // 
            // opDespesa
            // 
            this.opDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.opDespesa.AutoSize = true;
            this.opDespesa.Checked = true;
            this.opDespesa.ForeColor = System.Drawing.Color.White;
            this.opDespesa.Location = new System.Drawing.Point(174, 8);
            this.opDespesa.Name = "opDespesa";
            this.opDespesa.Size = new System.Drawing.Size(74, 19);
            this.opDespesa.TabIndex = 41;
            this.opDespesa.TabStop = true;
            this.opDespesa.Text = "Despesa";
            this.opDespesa.UseVisualStyleBackColor = true;
            this.opDespesa.CheckedChanged += new System.EventHandler(this.opDespesa_CheckedChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(348, 4);
            this.label8.TabIndex = 24;
            // 
            // stSalvar
            // 
            this.stSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.stSalvar.GripMargin = new System.Windows.Forms.Padding(0);
            this.stSalvar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.limpar,
            this.cadastro});
            this.stSalvar.Location = new System.Drawing.Point(0, 0);
            this.stSalvar.Name = "stSalvar";
            this.stSalvar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stSalvar.Size = new System.Drawing.Size(348, 24);
            this.stSalvar.TabIndex = 31;
            this.stSalvar.Text = "menuStrip2";
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.Transparent;
            this.salvar.ForeColor = System.Drawing.Color.White;
            this.salvar.Image = ((System.Drawing.Image)(resources.GetObject("salvar.Image")));
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(66, 20);
            this.salvar.Text = "Salvar";
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.Transparent;
            this.limpar.ForeColor = System.Drawing.Color.White;
            this.limpar.Image = ((System.Drawing.Image)(resources.GetObject("limpar.Image")));
            this.limpar.Name = "limpar";
            this.limpar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.limpar.Size = new System.Drawing.Size(72, 20);
            this.limpar.Text = "Limpar";
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // cadastro
            // 
            this.cadastro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cadastro.ForeColor = System.Drawing.Color.White;
            this.cadastro.Image = ((System.Drawing.Image)(resources.GetObject("cadastro.Image")));
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(121, 20);
            this.cadastro.Text = "Classes • Contas";
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(1, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1104, 4);
            this.label7.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(5, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1095, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 21;
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(23, 17);
            this.statusLabel.Text = ">>";
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.White;
            this.lblLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLeft.Location = new System.Drawing.Point(0, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(1, 457);
            this.lblLeft.TabIndex = 22;
            // 
            // lblRight
            // 
            this.lblRight.BackColor = System.Drawing.Color.White;
            this.lblRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRight.Location = new System.Drawing.Point(1104, 0);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(1, 453);
            this.lblRight.TabIndex = 22;
            // 
            // pnListaClasse
            // 
            this.pnListaClasse.Controls.Add(this.lista_Gastos_Classe);
            this.pnListaClasse.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnListaClasse.Location = new System.Drawing.Point(357, 26);
            this.pnListaClasse.Name = "pnListaClasse";
            this.pnListaClasse.Size = new System.Drawing.Size(352, 401);
            this.pnListaClasse.TabIndex = 23;
            // 
            // lnLeft
            // 
            this.lnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnLeft.Location = new System.Drawing.Point(709, 26);
            this.lnLeft.Name = "lnLeft";
            this.lnLeft.Size = new System.Drawing.Size(4, 401);
            this.lnLeft.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(5, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1095, 4);
            this.label1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(4, 453);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(353, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(4, 401);
            this.label10.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(5, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1095, 2);
            this.label12.TabIndex = 24;
            // 
            // lnRight
            // 
            this.lnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnRight.Location = new System.Drawing.Point(1100, 0);
            this.lnRight.Name = "lnRight";
            this.lnRight.Size = new System.Drawing.Size(4, 453);
            this.lnRight.TabIndex = 25;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1105, 457);
            this.Controls.Add(this.lnLeft);
            this.Controls.Add(this.pnListaClasse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnSalvar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lnRight);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLeft);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(734, 496);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmMenu_Activated);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSaldo_Contas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Gastos_Classe)).EndInit();
            this.pnSalvar.ResumeLayout(false);
            this.pnSalvar.PerformLayout();
            this.pnSalvarIn.ResumeLayout(false);
            this.pnSalvarIn.PerformLayout();
            this.stSalvar.ResumeLayout(false);
            this.stSalvar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnListaClasse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoLancamento;
        private ToolStripMenuItem receitaDespesa;
        private ToolStripMenuItem relatorios;
        private ToolStripMenuItem comprasCredito;
        private ToolStripMenuItem transferencia;
        private ToolStripMenuItem cadastros;
        private ToolStripMenuItem classesDeCustoAdd;
        private ToolStripMenuItem contasAdd;
        private ToolStripMenuItem cartaoDeCreditoAdd;
        private ToolStripMenuItem exportar;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripMenuItem previsaoDeCustos;
        private ToolStripMenuItem query;
        private ToolStripMenuItem anotacoes;
        private ToolStripMenuItem sair;
        private ErrorProvider errorProvider1;
        private Controles.dgView listaSaldo_Contas;
        public Controles.dgView lista_Gastos_Classe;
        private MenuStrip stSalvar;
        private ToolStripMenuItem salvar;
        private ToolStripMenuItem limpar;
        private Controles.cbCombo cbConta;
        private Controles.Data txtData;
        private Controles.Decimal txtValor;
        private Controles.Txt txtDescricao;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private RadioButton opReceita;
        private Controles.cbCombo cbClasse;
        private RadioButton opDespesa;
        private ToolStripMenuItem configuracoes;
        private ToolStripMenuItem usuarioAdd;
        private ToolStripMenuItem connBD;
        private Controles.Cabecalho menu;
        private Controles.Cabecalho ToolRelatorio;
        private Controles.Cabecalho ToolVisaoGeral;
        private Controles.Cabecalho ToolLancamento;
        private Controles.Cabecalho ToolCalculadora;
        private Controles.Cabecalho ToolPrevisao;
        private Controles.Cabecalho compraCredito;
        private Controles.Cabecalho transf;
        private Label label7;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private Label lblRight;
        private Label lblLeft;
        private Panel pnSalvar;
        private DataGridViewTextBoxColumn CLASSE_ID;
        private DataGridViewTextBoxColumn CLASSE;
        private DataGridViewTextBoxColumn VALOR;
        private ToolStripMenuItem cadastro;
        private DataGridViewTextBoxColumn CONTA_ID;
        private DataGridViewTextBoxColumn CONTA;
        private DataGridViewTextBoxColumn SALDO;
        private Panel pnListaClasse;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label1;
        private Label lnLeft;
        private Label label11;
        private Label label12;
        private Panel pnSalvarIn;
        private Label lnRight;
    }
}