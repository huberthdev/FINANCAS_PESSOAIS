using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Financas
{
    partial class frmMenu
    {
        public delegate void MouseEventHandler(object sender, MouseEventArgs e);
        
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
            this.lista_Gastos_Classe.Columns[1].CellTemplate.Style.ForeColor = Color.Tomato;
            this.lista_Gastos_Classe.BorderStyle = BorderStyle.None;
            this.lista_Gastos_Classe.GridColor = Color.FromArgb(37, 37, 38);
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            this.lista_Gastos_Classe.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.lista_Gastos_Classe.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.listaSaldo_Contas.BorderStyle = BorderStyle.None;
            this.listaSaldo_Contas.GridColor = Color.FromArgb(37, 37, 38);
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            this.listaSaldo_Contas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.listaSaldo_Contas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.listaCompromissos.BorderStyle = BorderStyle.None;
            this.listaCompromissos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.listaCompromissos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.listaCompromissos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.listaCompromissos.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            this.listaCompromissos.Enabled = false;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new Setup.Controles.Cabecalho();
            this.novoLancamento = new System.Windows.Forms.ToolStripMenuItem();
            this.receitaDespesa = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.transferencia = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.cads = new System.Windows.Forms.ToolStripMenuItem();
            this.cartaoDeCreditoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.previsaoDeCustos = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.connBD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.definicoes = new System.Windows.Forms.ToolStripMenuItem();
            this.query = new System.Windows.Forms.ToolStripMenuItem();
            this.anotacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
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
            this.CLASSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSalvar = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
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
            this.stSalvar = new System.Windows.Forms.MenuStrip();
            this.salvar = new Setup.Controles.Cabecalho();
            this.limpar = new Setup.Controles.Cabecalho();
            this.cadastro = new Setup.Controles.Cabecalho();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnListaClasse = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.gReceitas = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.gCredito = new System.Windows.Forms.Label();
            this.gDespesas = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.gTransferencias = new System.Windows.Forms.Label();
            this.gPeriodo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mesAnterior = new System.Windows.Forms.ToolStripMenuItem();
            this.mesProximo = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lnRight = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listaCompromissos = new Setup.Controles.dgView();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPROMISSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnDefinicoes = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.AtivarNotifVencimentos = new Setup.Controles.atv();
            this.AtivarNotifLogin = new Setup.Controles.atv();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fechar_ = new Setup.Controles.Cabecalho();
            this.pnCompromissos = new System.Windows.Forms.Panel();
            this.lblVencimentos = new System.Windows.Forms.Label();
            this.lnLeft = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSaldo_Contas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Gastos_Classe)).BeginInit();
            this.pnSalvar.SuspendLayout();
            this.pnSalvarIn.SuspendLayout();
            this.stSalvar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.pnListaClasse.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompromissos)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.pnDefinicoes.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.pnCompromissos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.compraCredito,
            this.transf,
            this.ToolRelatorio,
            this.ToolVisaoGeral,
            this.ToolPrevisao,
            this.ToolCalculadora});
            this.menuStrip1.Location = new System.Drawing.Point(277, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1033, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoLancamento,
            this.relatorios,
            this.cadastros,
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
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // novoLancamento
            // 
            this.novoLancamento.BackColor = System.Drawing.SystemColors.Control;
            this.novoLancamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receitaDespesa,
            this.comprasCredito,
            this.transferencia});
            this.novoLancamento.ForeColor = System.Drawing.Color.Black;
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
            this.receitaDespesa.Click += new System.EventHandler(this.receitaDespesa_Click);
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
            this.transferencia.Click += new System.EventHandler(this.transferencia_Click);
            // 
            // relatorios
            // 
            this.relatorios.ForeColor = System.Drawing.Color.Black;
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
            this.cads,
            this.cartaoDeCreditoAdd});
            this.cadastros.ForeColor = System.Drawing.Color.Black;
            this.cadastros.Image = ((System.Drawing.Image)(resources.GetObject("cadastros.Image")));
            this.cadastros.Name = "cadastros";
            this.cadastros.Size = new System.Drawing.Size(246, 22);
            this.cadastros.Text = "Cadastros";
            // 
            // cads
            // 
            this.cads.Image = ((System.Drawing.Image)(resources.GetObject("cads.Image")));
            this.cads.Name = "cads";
            this.cads.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.cads.Size = new System.Drawing.Size(203, 22);
            this.cads.Text = "Classes • Contas";
            this.cads.Click += new System.EventHandler(this.cads_Click);
            // 
            // cartaoDeCreditoAdd
            // 
            this.cartaoDeCreditoAdd.Image = ((System.Drawing.Image)(resources.GetObject("cartaoDeCreditoAdd.Image")));
            this.cartaoDeCreditoAdd.Name = "cartaoDeCreditoAdd";
            this.cartaoDeCreditoAdd.Size = new System.Drawing.Size(203, 22);
            this.cartaoDeCreditoAdd.Text = "Cartão de Crédito";
            this.cartaoDeCreditoAdd.Click += new System.EventHandler(this.cartaoDeCreditoAdd_Click);
            // 
            // previsaoDeCustos
            // 
            this.previsaoDeCustos.ForeColor = System.Drawing.Color.Black;
            this.previsaoDeCustos.Image = ((System.Drawing.Image)(resources.GetObject("previsaoDeCustos.Image")));
            this.previsaoDeCustos.Name = "previsaoDeCustos";
            this.previsaoDeCustos.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.previsaoDeCustos.Size = new System.Drawing.Size(246, 22);
            this.previsaoDeCustos.Text = "Previsão de Custos";
            this.previsaoDeCustos.Click += new System.EventHandler(this.previsaoDeCustos_Click);
            // 
            // configuracoes
            // 
            this.configuracoes.BackColor = System.Drawing.SystemColors.Control;
            this.configuracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioAdd,
            this.connBD,
            this.toolStripSeparator1,
            this.definicoes});
            this.configuracoes.ForeColor = System.Drawing.Color.Black;
            this.configuracoes.Image = ((System.Drawing.Image)(resources.GetObject("configuracoes.Image")));
            this.configuracoes.Name = "configuracoes";
            this.configuracoes.Size = new System.Drawing.Size(246, 22);
            this.configuracoes.Text = "Configurações";
            // 
            // usuarioAdd
            // 
            this.usuarioAdd.BackColor = System.Drawing.SystemColors.Control;
            this.usuarioAdd.ForeColor = System.Drawing.Color.Black;
            this.usuarioAdd.Image = ((System.Drawing.Image)(resources.GetObject("usuarioAdd.Image")));
            this.usuarioAdd.Name = "usuarioAdd";
            this.usuarioAdd.Size = new System.Drawing.Size(209, 22);
            this.usuarioAdd.Text = "Usuários";
            this.usuarioAdd.Click += new System.EventHandler(this.usuarioAdd_Click);
            // 
            // connBD
            // 
            this.connBD.BackColor = System.Drawing.SystemColors.Control;
            this.connBD.ForeColor = System.Drawing.Color.Black;
            this.connBD.Image = ((System.Drawing.Image)(resources.GetObject("connBD.Image")));
            this.connBD.Name = "connBD";
            this.connBD.Size = new System.Drawing.Size(209, 22);
            this.connBD.Text = "Conexão Banco de Dados";
            this.connBD.Click += new System.EventHandler(this.connBD_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // definicoes
            // 
            this.definicoes.Image = ((System.Drawing.Image)(resources.GetObject("definicoes.Image")));
            this.definicoes.Name = "definicoes";
            this.definicoes.Size = new System.Drawing.Size(209, 22);
            this.definicoes.Text = "Definições do sistema";
            this.definicoes.Click += new System.EventHandler(this.definicoes_Click);
            // 
            // query
            // 
            this.query.ForeColor = System.Drawing.Color.Black;
            this.query.Image = ((System.Drawing.Image)(resources.GetObject("query.Image")));
            this.query.Name = "query";
            this.query.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.query.Size = new System.Drawing.Size(246, 22);
            this.query.Text = "SQL";
            this.query.Click += new System.EventHandler(this.queryDesenvolvedorToolStripMenuItem_Click);
            // 
            // anotacoes
            // 
            this.anotacoes.ForeColor = System.Drawing.Color.Black;
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
            // compraCredito
            // 
            this.compraCredito.AutoToolTip = true;
            this.compraCredito.ForeColor = System.Drawing.Color.White;
            this.compraCredito.Image = ((System.Drawing.Image)(resources.GetObject("compraCredito.Image")));
            this.compraCredito.Name = "compraCredito";
            this.compraCredito.Size = new System.Drawing.Size(142, 20);
            this.compraCredito.Text = "Compras no Crédito";
            this.compraCredito.ToolTipText = "Lançamentos de Compras no Crédito";
            this.compraCredito.Click += new System.EventHandler(this.compraCredito_Click);
            // 
            // transf
            // 
            this.transf.AutoToolTip = true;
            this.transf.ForeColor = System.Drawing.Color.White;
            this.transf.Image = ((System.Drawing.Image)(resources.GetObject("transf.Image")));
            this.transf.Name = "transf";
            this.transf.Size = new System.Drawing.Size(109, 20);
            this.transf.Text = "Transferências";
            this.transf.ToolTipText = "Transferências entre contas";
            this.transf.Click += new System.EventHandler(this.transf_Click);
            // 
            // ToolRelatorio
            // 
            this.ToolRelatorio.AutoToolTip = true;
            this.ToolRelatorio.ForeColor = System.Drawing.Color.White;
            this.ToolRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("ToolRelatorio.Image")));
            this.ToolRelatorio.Name = "ToolRelatorio";
            this.ToolRelatorio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ToolRelatorio.Size = new System.Drawing.Size(82, 20);
            this.ToolRelatorio.Text = "Relatório";
            this.ToolRelatorio.ToolTipText = "Relatório Geral";
            this.ToolRelatorio.Click += new System.EventHandler(this.ToolRelatorio_Click);
            // 
            // ToolVisaoGeral
            // 
            this.ToolVisaoGeral.AutoToolTip = true;
            this.ToolVisaoGeral.ForeColor = System.Drawing.Color.White;
            this.ToolVisaoGeral.Image = ((System.Drawing.Image)(resources.GetObject("ToolVisaoGeral.Image")));
            this.ToolVisaoGeral.Name = "ToolVisaoGeral";
            this.ToolVisaoGeral.Size = new System.Drawing.Size(97, 20);
            this.ToolVisaoGeral.Text = "Visão Anual";
            this.ToolVisaoGeral.ToolTipText = "Visão Anual [Receitas x Despesas]";
            this.ToolVisaoGeral.Click += new System.EventHandler(this.ToolVisaoGeral_Click);
            // 
            // ToolPrevisao
            // 
            this.ToolPrevisao.AutoToolTip = true;
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
            this.ToolCalculadora.AutoToolTip = true;
            this.ToolCalculadora.ForeColor = System.Drawing.Color.White;
            this.ToolCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("ToolCalculadora.Image")));
            this.ToolCalculadora.Name = "ToolCalculadora";
            this.ToolCalculadora.Size = new System.Drawing.Size(98, 20);
            this.ToolCalculadora.Text = "Calculadora";
            this.ToolCalculadora.ToolTipText = "Calculadora do Windows";
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
            this.listaSaldo_Contas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaSaldo_Contas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaSaldo_Contas.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.listaSaldo_Contas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaSaldo_Contas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaSaldo_Contas.EnableHeadersVisualStyles = false;
            this.listaSaldo_Contas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.listaSaldo_Contas.Location = new System.Drawing.Point(0, 216);
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
            this.listaSaldo_Contas.Size = new System.Drawing.Size(335, 294);
            this.listaSaldo_Contas.TabIndex = 1;
            this.listaSaldo_Contas.TabStop = false;
            this.listaSaldo_Contas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.listaSaldo_Contas_DataBindingComplete);
            // 
            // CONTA_ID
            // 
            this.CONTA_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CONTA_ID.DataPropertyName = "CONTA_ID";
            this.CONTA_ID.HeaderText = "ID";
            this.CONTA_ID.Name = "CONTA_ID";
            this.CONTA_ID.ReadOnly = true;
            this.CONTA_ID.Visible = false;
            this.CONTA_ID.Width = 5;
            // 
            // CONTA
            // 
            this.CONTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CONTA.DataPropertyName = "CONTA";
            this.CONTA.HeaderText = "CONTA";
            this.CONTA.MinimumWidth = 140;
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CONTA.Width = 140;
            // 
            // SALDO
            // 
            this.SALDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SALDO.DataPropertyName = "SALDO";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0,00";
            this.SALDO.DefaultCellStyle = dataGridViewCellStyle3;
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.MinimumWidth = 150;
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            this.SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SALDO.Width = 150;
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
            this.lista_Gastos_Classe.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.lista_Gastos_Classe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista_Gastos_Classe.Location = new System.Drawing.Point(4, 28);
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
            this.lista_Gastos_Classe.Size = new System.Drawing.Size(385, 287);
            this.lista_Gastos_Classe.TabIndex = 1;
            this.lista_Gastos_Classe.TabStop = false;
            this.lista_Gastos_Classe.DoubleClick += new System.EventHandler(this.lista_Gastos_Classe_DoubleClick);
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
            this.pnSalvar.Controls.Add(this.listaSaldo_Contas);
            this.pnSalvar.Controls.Add(this.label8);
            this.pnSalvar.Controls.Add(this.pnSalvarIn);
            this.pnSalvar.Controls.Add(this.stSalvar);
            this.pnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSalvar.Location = new System.Drawing.Point(277, 26);
            this.pnSalvar.MinimumSize = new System.Drawing.Size(335, 510);
            this.pnSalvar.Name = "pnSalvar";
            this.pnSalvar.Size = new System.Drawing.Size(335, 510);
            this.pnSalvar.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 4);
            this.label8.TabIndex = 24;
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
            this.pnSalvarIn.Location = new System.Drawing.Point(0, 24);
            this.pnSalvarIn.Name = "pnSalvarIn";
            this.pnSalvarIn.Size = new System.Drawing.Size(335, 188);
            this.pnSalvarIn.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 4);
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
            this.cbClasse.Location = new System.Drawing.Point(87, 33);
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
            this.opReceita.Location = new System.Drawing.Point(87, 8);
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
            this.label4.Location = new System.Drawing.Point(46, 97);
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
            this.txtValor.Location = new System.Drawing.Point(87, 120);
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
            this.label5.Location = new System.Drawing.Point(39, 130);
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
            this.label2.Location = new System.Drawing.Point(32, 41);
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
            this.cbConta.Location = new System.Drawing.Point(87, 62);
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
            this.txtData.Location = new System.Drawing.Point(87, 91);
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
            this.label6.Location = new System.Drawing.Point(11, 157);
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
            this.label3.Location = new System.Drawing.Point(39, 70);
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
            this.txtDescricao.Location = new System.Drawing.Point(87, 149);
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
            this.opDespesa.Location = new System.Drawing.Point(167, 8);
            this.opDespesa.Name = "opDespesa";
            this.opDespesa.Size = new System.Drawing.Size(74, 19);
            this.opDespesa.TabIndex = 41;
            this.opDespesa.TabStop = true;
            this.opDespesa.Text = "Despesa";
            this.opDespesa.UseVisualStyleBackColor = true;
            this.opDespesa.CheckedChanged += new System.EventHandler(this.opDespesa_CheckedChanged);
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
            this.stSalvar.Size = new System.Drawing.Size(335, 24);
            this.stSalvar.TabIndex = 31;
            this.stSalvar.Text = "menuStrip2";
            // 
            // salvar
            // 
            this.salvar.AutoToolTip = true;
            this.salvar.BackColor = System.Drawing.Color.Transparent;
            this.salvar.ForeColor = System.Drawing.Color.White;
            this.salvar.Image = ((System.Drawing.Image)(resources.GetObject("salvar.Image")));
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(66, 20);
            this.salvar.Text = "Salvar";
            this.salvar.ToolTipText = "Salvar Receita/Despesa";
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
            this.cadastro.AutoToolTip = true;
            this.cadastro.ForeColor = System.Drawing.Color.White;
            this.cadastro.Image = ((System.Drawing.Image)(resources.GetObject("cadastro.Image")));
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(121, 20);
            this.cadastro.Text = "Classes • Contas";
            this.cadastro.ToolTipText = "Cadastrar Classes e contas";
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario});
            this.statusStrip.Location = new System.Drawing.Point(277, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 21;
            // 
            // usuario
            // 
            this.usuario.ForeColor = System.Drawing.Color.White;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(16, 17);
            this.usuario.Text = "...";
            // 
            // pnListaClasse
            // 
            this.pnListaClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
            this.pnListaClasse.Controls.Add(this.lista_Gastos_Classe);
            this.pnListaClasse.Controls.Add(this.panel1);
            this.pnListaClasse.Controls.Add(this.gPeriodo);
            this.pnListaClasse.Controls.Add(this.label7);
            this.pnListaClasse.Controls.Add(this.menuStrip2);
            this.pnListaClasse.Controls.Add(this.label10);
            this.pnListaClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListaClasse.Location = new System.Drawing.Point(612, 26);
            this.pnListaClasse.MinimumSize = new System.Drawing.Size(375, 510);
            this.pnListaClasse.Name = "pnListaClasse";
            this.pnListaClasse.Size = new System.Drawing.Size(389, 510);
            this.pnListaClasse.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.gReceitas);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.gCredito);
            this.panel1.Controls.Add(this.gDespesas);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.gTransferencias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 195);
            this.panel1.TabIndex = 50;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Image = ((System.Drawing.Image)(resources.GetObject("lbl1.Image")));
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.Location = new System.Drawing.Point(20, 10);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 43);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "      Receitas";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gReceitas
            // 
            this.gReceitas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gReceitas.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gReceitas.ForeColor = System.Drawing.Color.White;
            this.gReceitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gReceitas.Location = new System.Drawing.Point(209, 10);
            this.gReceitas.Name = "gReceitas";
            this.gReceitas.Size = new System.Drawing.Size(156, 43);
            this.gReceitas.TabIndex = 2;
            this.gReceitas.Text = "R$ 0,00";
            this.gReceitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Image = ((System.Drawing.Image)(resources.GetObject("lbl2.Image")));
            this.lbl2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl2.Location = new System.Drawing.Point(20, 53);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(184, 43);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "      Despesas no débito";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gCredito
            // 
            this.gCredito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gCredito.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gCredito.ForeColor = System.Drawing.Color.White;
            this.gCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gCredito.Location = new System.Drawing.Point(209, 142);
            this.gCredito.Name = "gCredito";
            this.gCredito.Size = new System.Drawing.Size(156, 43);
            this.gCredito.TabIndex = 2;
            this.gCredito.Text = "R$ 0,00";
            this.gCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gDespesas
            // 
            this.gDespesas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gDespesas.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gDespesas.ForeColor = System.Drawing.Color.White;
            this.gDespesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gDespesas.Location = new System.Drawing.Point(209, 54);
            this.gDespesas.Name = "gDespesas";
            this.gDespesas.Size = new System.Drawing.Size(156, 43);
            this.gDespesas.TabIndex = 2;
            this.gDespesas.Text = "R$ 0,00";
            this.gDespesas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Image = ((System.Drawing.Image)(resources.GetObject("lbl4.Image")));
            this.lbl4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl4.Location = new System.Drawing.Point(20, 142);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(184, 43);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = "      Despesas no crédito";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Image = ((System.Drawing.Image)(resources.GetObject("lbl3.Image")));
            this.lbl3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl3.Location = new System.Drawing.Point(20, 96);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(184, 43);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "      Transferências";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gTransferencias
            // 
            this.gTransferencias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTransferencias.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gTransferencias.ForeColor = System.Drawing.Color.White;
            this.gTransferencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gTransferencias.Location = new System.Drawing.Point(209, 98);
            this.gTransferencias.Name = "gTransferencias";
            this.gTransferencias.Size = new System.Drawing.Size(156, 43);
            this.gTransferencias.TabIndex = 2;
            this.gTransferencias.Text = "R$ 0,00";
            this.gTransferencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gPeriodo
            // 
            this.gPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPeriodo.ForeColor = System.Drawing.Color.White;
            this.gPeriodo.Location = new System.Drawing.Point(100, 3);
            this.gPeriodo.Name = "gPeriodo";
            this.gPeriodo.Size = new System.Drawing.Size(193, 17);
            this.gPeriodo.TabIndex = 47;
            this.gPeriodo.Text = "janeiro.2022";
            this.gPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(4, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 4);
            this.label7.TabIndex = 48;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesAnterior,
            this.mesProximo});
            this.menuStrip2.Location = new System.Drawing.Point(4, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(385, 24);
            this.menuStrip2.TabIndex = 3;
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
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(4, 510);
            this.label10.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1314, 4);
            this.label1.TabIndex = 24;
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lblLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLeft.Location = new System.Drawing.Point(273, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(4, 562);
            this.lblLeft.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(277, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1033, 2);
            this.label12.TabIndex = 24;
            // 
            // lnRight
            // 
            this.lnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnRight.Location = new System.Drawing.Point(1310, 0);
            this.lnRight.Name = "lnRight";
            this.lnRight.Size = new System.Drawing.Size(4, 562);
            this.lnRight.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Location = new System.Drawing.Point(277, 536);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1033, 4);
            this.label13.TabIndex = 26;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "menos.png");
            this.imageList1.Images.SetKeyName(2, "transferencia.png");
            this.imageList1.Images.SetKeyName(3, "cartao.png");
            // 
            // listaCompromissos
            // 
            this.listaCompromissos.AllowUserToAddRows = false;
            this.listaCompromissos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.listaCompromissos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.listaCompromissos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaCompromissos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaCompromissos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCompromissos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listaCompromissos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCompromissos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.listaCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCompromissos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.COMPROMISSO,
            this.DIA,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaCompromissos.DefaultCellStyle = dataGridViewCellStyle16;
            this.listaCompromissos.Dock = System.Windows.Forms.DockStyle.Top;
            this.listaCompromissos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaCompromissos.EnableHeadersVisualStyles = false;
            this.listaCompromissos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.listaCompromissos.Location = new System.Drawing.Point(4, 28);
            this.listaCompromissos.MultiSelect = false;
            this.listaCompromissos.Name = "listaCompromissos";
            this.listaCompromissos.ReadOnly = true;
            this.listaCompromissos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCompromissos.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.listaCompromissos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.listaCompromissos.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.listaCompromissos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listaCompromissos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.listaCompromissos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.listaCompromissos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaCompromissos.RowTemplate.Height = 25;
            this.listaCompromissos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCompromissos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.listaCompromissos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCompromissos.ShowEditingIcon = false;
            this.listaCompromissos.Size = new System.Drawing.Size(305, 480);
            this.listaCompromissos.TabIndex = 1;
            this.listaCompromissos.TabStop = false;
            this.toolTip1.SetToolTip(this.listaCompromissos, "Próximos vencimentos [Cartão de crédito, empréstimos e despesas fixas]");
            this.listaCompromissos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.listaCompromissos_DataBindingComplete);
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // COMPROMISSO
            // 
            this.COMPROMISSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.COMPROMISSO.DataPropertyName = "COMPROMISSO";
            this.COMPROMISSO.HeaderText = "COMPROMISSO";
            this.COMPROMISSO.MinimumWidth = 180;
            this.COMPROMISSO.Name = "COMPROMISSO";
            this.COMPROMISSO.ReadOnly = true;
            this.COMPROMISSO.Width = 180;
            // 
            // DIA
            // 
            this.DIA.DataPropertyName = "DIA";
            this.DIA.HeaderText = "DIA";
            this.DIA.Name = "DIA";
            this.DIA.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VALOR";
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0,00";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn2.HeaderText = "VALOR";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechar});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(94, 26);
            // 
            // fechar
            // 
            this.fechar.Image = ((System.Drawing.Image)(resources.GetObject("fechar.Image")));
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(93, 22);
            this.fechar.Text = "Sair";
            this.fechar.Click += new System.EventHandler(this.fechar_Click_1);
            // 
            // pnDefinicoes
            // 
            this.pnDefinicoes.Controls.Add(this.label9);
            this.pnDefinicoes.Controls.Add(this.AtivarNotifVencimentos);
            this.pnDefinicoes.Controls.Add(this.AtivarNotifLogin);
            this.pnDefinicoes.Controls.Add(this.menuStrip3);
            this.pnDefinicoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDefinicoes.Location = new System.Drawing.Point(0, 0);
            this.pnDefinicoes.Name = "pnDefinicoes";
            this.pnDefinicoes.Size = new System.Drawing.Size(273, 562);
            this.pnDefinicoes.TabIndex = 0;
            this.pnDefinicoes.Visible = false;
            this.pnDefinicoes.DoubleClick += new System.EventHandler(this.pnDefinicoes_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Definições";
            // 
            // AtivarNotifVencimentos
            // 
            this.AtivarNotifVencimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtivarNotifVencimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtivarNotifVencimentos.ForeColor = System.Drawing.Color.White;
            this.AtivarNotifVencimentos.Image = ((System.Drawing.Image)(resources.GetObject("AtivarNotifVencimentos.Image")));
            this.AtivarNotifVencimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtivarNotifVencimentos.Location = new System.Drawing.Point(3, 62);
            this.AtivarNotifVencimentos.Name = "AtivarNotifVencimentos";
            this.AtivarNotifVencimentos.Size = new System.Drawing.Size(231, 33);
            this.AtivarNotifVencimentos.TabIndex = 0;
            this.AtivarNotifVencimentos.Text = "Notificação de vencimentos";
            this.AtivarNotifVencimentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AtivarNotifLogin
            // 
            this.AtivarNotifLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtivarNotifLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtivarNotifLogin.ForeColor = System.Drawing.Color.White;
            this.AtivarNotifLogin.Image = ((System.Drawing.Image)(resources.GetObject("AtivarNotifLogin.Image")));
            this.AtivarNotifLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtivarNotifLogin.Location = new System.Drawing.Point(3, 29);
            this.AtivarNotifLogin.Name = "AtivarNotifLogin";
            this.AtivarNotifLogin.Size = new System.Drawing.Size(189, 33);
            this.AtivarNotifLogin.TabIndex = 0;
            this.AtivarNotifLogin.Text = "Notificação de login";
            this.AtivarNotifLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechar_});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(273, 24);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fechar_
            // 
            this.fechar_.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fechar_.ForeColor = System.Drawing.Color.White;
            this.fechar_.Image = ((System.Drawing.Image)(resources.GetObject("fechar_.Image")));
            this.fechar_.Name = "fechar_";
            this.fechar_.Size = new System.Drawing.Size(70, 20);
            this.fechar_.Text = "Fechar";
            this.fechar_.Click += new System.EventHandler(this.fechar__Click);
            // 
            // pnCompromissos
            // 
            this.pnCompromissos.Controls.Add(this.listaCompromissos);
            this.pnCompromissos.Controls.Add(this.lblVencimentos);
            this.pnCompromissos.Controls.Add(this.lnLeft);
            this.pnCompromissos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCompromissos.Location = new System.Drawing.Point(1001, 26);
            this.pnCompromissos.Name = "pnCompromissos";
            this.pnCompromissos.Size = new System.Drawing.Size(309, 510);
            this.pnCompromissos.TabIndex = 33;
            // 
            // lblVencimentos
            // 
            this.lblVencimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVencimentos.ForeColor = System.Drawing.Color.White;
            this.lblVencimentos.Location = new System.Drawing.Point(4, 0);
            this.lblVencimentos.Name = "lblVencimentos";
            this.lblVencimentos.Size = new System.Drawing.Size(305, 28);
            this.lblVencimentos.TabIndex = 49;
            this.lblVencimentos.Text = "Vencimentos";
            this.lblVencimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnLeft
            // 
            this.lnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnLeft.Location = new System.Drawing.Point(0, 0);
            this.lnLeft.Name = "lnLeft";
            this.lnLeft.Size = new System.Drawing.Size(4, 510);
            this.lnLeft.TabIndex = 50;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1314, 566);
            this.Controls.Add(this.pnListaClasse);
            this.Controls.Add(this.pnCompromissos);
            this.Controls.Add(this.pnSalvar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lnRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.pnDefinicoes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
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
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompromissos)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.pnDefinicoes.ResumeLayout(false);
            this.pnDefinicoes.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.pnCompromissos.ResumeLayout(false);
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
        private ToolStripMenuItem cads;
        private ToolStripMenuItem cartaoDeCreditoAdd;
        private ToolStripMenuItem previsaoDeCustos;
        private ToolStripMenuItem query;
        private ToolStripMenuItem anotacoes;
        private ToolStripMenuItem sair;
        private ErrorProvider errorProvider1;
        private Controles.dgView listaSaldo_Contas;
        public Controles.dgView lista_Gastos_Classe;
        private MenuStrip stSalvar;
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
        private Controles.Cabecalho ToolCalculadora;
        private Controles.Cabecalho ToolPrevisao;
        private Controles.Cabecalho compraCredito;
        private Controles.Cabecalho transf;
        private StatusStrip statusStrip;
        private Panel pnSalvar;
        private Panel pnListaClasse;
        private Label lblLeft;
        private Label label8;
        private Label label1;
        private Label label11;
        private Label label12;
        private Panel pnSalvarIn;
        private Label lnRight;
        private Label label13;
        private DataGridViewTextBoxColumn CLASSE;
        private DataGridViewTextBoxColumn VALOR;
        private ImageList imageList1;
        private Label lbl1;
        private Label lbl2;
        private Label lbl4;
        private Label lbl3;
        private Label gCredito;
        private Label gTransferencias;
        private Label gDespesas;
        private Label gReceitas;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem mesAnterior;
        private ToolStripMenuItem mesProximo;
        private Label gPeriodo;
        private Label label7;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem definicoes;
        private Controles.Cabecalho salvar;
        private Controles.Cabecalho limpar;
        private Controles.Cabecalho cadastro;
        private ToolStripStatusLabel usuario;
        private ToolTip toolTip1;
        public NotifyIcon notifyIcon1;
        public ContextMenuStrip contextMenu;
        private ToolStripMenuItem fechar;
        private Panel pnDefinicoes;
        private MenuStrip menuStrip3;
        private Controles.Cabecalho fechar_;
        private Controles.atv AtivarNotifLogin;
        private Controles.atv AtivarNotifVencimentos;
        private Label label10;
        private Panel pnCompromissos;
        private Label lnLeft;
        public Controles.dgView listaCompromissos;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn COMPROMISSO;
        private DataGridViewTextBoxColumn DIA;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label lblVencimentos;
        private Panel panel1;
        private Label label9;
        private DataGridViewTextBoxColumn CONTA_ID;
        private DataGridViewTextBoxColumn CONTA;
        private DataGridViewTextBoxColumn SALDO;
    }
}