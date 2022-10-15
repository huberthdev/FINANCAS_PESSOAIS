
using System;
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
            this.lista_Gastos_Classe.Columns[2].CellTemplate.Style.ForeColor = Color.Red;
            base.OnCreateControl();
        }

        protected override void OnActivated(EventArgs e)
        {
            this.CarregarListaSaldoContas();
            this.CarregarListaGastoClasseMesAtual();
            base.OnActivated(e);
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolLancamento = new System.Windows.Forms.ToolStripMenuItem();
            this.compraCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.transf = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVisaoGeral = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPrevisao = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaMenu = new System.Windows.Forms.TabControl();
            this.tabReceita_Despesa = new System.Windows.Forms.TabPage();
            this.pnLancamento = new System.Windows.Forms.Panel();
            this.cbClasse = new Setup.Controles.cbCombo();
            this.cbConta = new Setup.Controles.cbCombo();
            this.txtData = new Setup.Controles.Data();
            this.txtValor = new Setup.Controles.Decimal();
            this.txtDescricao = new Setup.Controles.Txt();
            this.opReceita = new System.Windows.Forms.RadioButton();
            this.opDespesa = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.listaSaldo_Contas = new Setup.Controles.dgView();
            this.lista_Gastos_Classe = new Setup.Controles.dgView();
            this.CLASSE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.limpar = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCad_Classes = new System.Windows.Forms.TabPage();
            this.gpConta = new System.Windows.Forms.GroupBox();
            this.listaConta = new Setup.Controles.dgView();
            this.ID_CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ckAtivoConta = new System.Windows.Forms.CheckBox();
            this.btnExcluirConta = new System.Windows.Forms.Button();
            this.txtConta = new Setup.Controles.Txt();
            this.btnSalvarConta = new System.Windows.Forms.Button();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CONTA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabelaMenu.SuspendLayout();
            this.tabReceita_Despesa.SuspendLayout();
            this.pnLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSaldo_Contas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Gastos_Classe)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabCad_Classes.SuspendLayout();
            this.gpConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaConta)).BeginInit();
            this.gpClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.ToolLancamento,
            this.compraCredito,
            this.transf,
            this.ToolRelatorio,
            this.ToolVisaoGeral,
            this.ToolPrevisao,
            this.ToolCalculadora});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
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
            this.sairToolStripMenuItem});
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
            this.receitaDespesa.Click += new System.EventHandler(this.receitaDespesaToolStripMenuItem_Click);
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
            this.classesDeCustoAdd.Click += new System.EventHandler(this.classesDeCustoToolStripMenuItem_Click);
            // 
            // contasAdd
            // 
            this.contasAdd.Image = ((System.Drawing.Image)(resources.GetObject("contasAdd.Image")));
            this.contasAdd.Name = "contasAdd";
            this.contasAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.contasAdd.Size = new System.Drawing.Size(205, 22);
            this.contasAdd.Text = "Contas";
            this.contasAdd.Click += new System.EventHandler(this.contasToolStripMenuItem_Click);
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
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ToolLancamento
            // 
            this.ToolLancamento.ForeColor = System.Drawing.Color.White;
            this.ToolLancamento.Image = ((System.Drawing.Image)(resources.GetObject("ToolLancamento.Image")));
            this.ToolLancamento.Name = "ToolLancamento";
            this.ToolLancamento.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.ToolLancamento.Size = new System.Drawing.Size(137, 20);
            this.ToolLancamento.Text = "Receitas • Despesas";
            this.ToolLancamento.Click += new System.EventHandler(this.novoLançamentoToolStripMenuItem1_Click);
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
            // tabelaMenu
            // 
            this.tabelaMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabelaMenu.Controls.Add(this.tabReceita_Despesa);
            this.tabelaMenu.Controls.Add(this.tabCad_Classes);
            this.tabelaMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaMenu.Location = new System.Drawing.Point(0, 0);
            this.tabelaMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabelaMenu.Name = "tabelaMenu";
            this.tabelaMenu.Padding = new System.Drawing.Point(0, 0);
            this.tabelaMenu.SelectedIndex = 0;
            this.tabelaMenu.Size = new System.Drawing.Size(899, 370);
            this.tabelaMenu.TabIndex = 0;
            // 
            // tabReceita_Despesa
            // 
            this.tabReceita_Despesa.BackColor = System.Drawing.Color.Black;
            this.tabReceita_Despesa.Controls.Add(this.pnLancamento);
            this.tabReceita_Despesa.Controls.Add(this.statusStrip);
            this.tabReceita_Despesa.Controls.Add(this.label7);
            this.tabReceita_Despesa.Controls.Add(this.listaSaldo_Contas);
            this.tabReceita_Despesa.Controls.Add(this.lista_Gastos_Classe);
            this.tabReceita_Despesa.Controls.Add(this.label1);
            this.tabReceita_Despesa.Controls.Add(this.menuStrip2);
            this.tabReceita_Despesa.Location = new System.Drawing.Point(4, 27);
            this.tabReceita_Despesa.Name = "tabReceita_Despesa";
            this.tabReceita_Despesa.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceita_Despesa.Size = new System.Drawing.Size(891, 339);
            this.tabReceita_Despesa.TabIndex = 0;
            this.tabReceita_Despesa.Tag = "Lancamento";
            this.tabReceita_Despesa.Text = "Receitas • Despesas";
            this.tabReceita_Despesa.UseVisualStyleBackColor = true;
            // 
            // pnLancamento
            // 
            this.pnLancamento.Controls.Add(this.cbClasse);
            this.pnLancamento.Controls.Add(this.cbConta);
            this.pnLancamento.Controls.Add(this.txtData);
            this.pnLancamento.Controls.Add(this.txtValor);
            this.pnLancamento.Controls.Add(this.txtDescricao);
            this.pnLancamento.Controls.Add(this.opReceita);
            this.pnLancamento.Controls.Add(this.opDespesa);
            this.pnLancamento.Controls.Add(this.label3);
            this.pnLancamento.Controls.Add(this.label6);
            this.pnLancamento.Controls.Add(this.label5);
            this.pnLancamento.Controls.Add(this.label4);
            this.pnLancamento.Controls.Add(this.label2);
            this.pnLancamento.Controls.Add(this.pictureBox1);
            this.pnLancamento.Location = new System.Drawing.Point(7, 31);
            this.pnLancamento.Name = "pnLancamento";
            this.pnLancamento.Size = new System.Drawing.Size(876, 62);
            this.pnLancamento.TabIndex = 34;
            // 
            // cbClasse
            // 
            this.cbClasse.AllowDrop = true;
            this.cbClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClasse.BackColor = System.Drawing.Color.Black;
            this.cbClasse.DisplayMember = "1";
            this.cbClasse.DropDownHeight = 136;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClasse.ForeColor = System.Drawing.Color.White;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.IntegralHeight = false;
            this.cbClasse.Location = new System.Drawing.Point(215, 3);
            this.cbClasse.MaxDropDownItems = 10;
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(288, 23);
            this.cbClasse.TabIndex = 35;
            this.cbClasse.Tag = "A";
            // 
            // cbConta
            // 
            this.cbConta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbConta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbConta.BackColor = System.Drawing.Color.Black;
            this.cbConta.DropDownHeight = 136;
            this.cbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConta.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbConta.ForeColor = System.Drawing.Color.White;
            this.cbConta.FormattingEnabled = true;
            this.cbConta.IntegralHeight = false;
            this.cbConta.Location = new System.Drawing.Point(576, 3);
            this.cbConta.MaxDropDownItems = 10;
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(288, 23);
            this.cbConta.TabIndex = 36;
            this.cbConta.Tag = "B";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.Black;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(215, 32);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(110, 23);
            this.txtData.TabIndex = 37;
            this.txtData.Tag = "C";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Black;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(393, 33);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 23);
            this.txtValor.TabIndex = 38;
            this.txtValor.Tag = "D";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Black;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(604, 32);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(260, 23);
            this.txtDescricao.TabIndex = 39;
            // 
            // opReceita
            // 
            this.opReceita.AutoSize = true;
            this.opReceita.ForeColor = System.Drawing.Color.White;
            this.opReceita.Location = new System.Drawing.Point(77, 7);
            this.opReceita.Name = "opReceita";
            this.opReceita.Size = new System.Drawing.Size(74, 19);
            this.opReceita.TabIndex = 40;
            this.opReceita.TabStop = true;
            this.opReceita.Text = "Receita";
            this.opReceita.UseVisualStyleBackColor = true;
            this.opReceita.CheckedChanged += new System.EventHandler(this.opReceita_CheckedChanged);
            // 
            // opDespesa
            // 
            this.opDespesa.AutoSize = true;
            this.opDespesa.Checked = true;
            this.opDespesa.ForeColor = System.Drawing.Color.White;
            this.opDespesa.Location = new System.Drawing.Point(77, 36);
            this.opDespesa.Name = "opDespesa";
            this.opDespesa.Size = new System.Drawing.Size(74, 19);
            this.opDespesa.TabIndex = 41;
            this.opDespesa.TabStop = true;
            this.opDespesa.Text = "Despesa";
            this.opDespesa.UseVisualStyleBackColor = true;
            this.opDespesa.CheckedChanged += new System.EventHandler(this.opDespesa_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(528, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Conta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(528, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(345, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(174, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Classe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Black;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(3, 313);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(885, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 20;
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
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(3, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(885, 1);
            this.label7.TabIndex = 33;
            // 
            // listaSaldo_Contas
            // 
            this.listaSaldo_Contas.AllowUserToAddRows = false;
            this.listaSaldo_Contas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.listaSaldo_Contas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listaSaldo_Contas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaSaldo_Contas.BackgroundColor = System.Drawing.Color.Black;
            this.listaSaldo_Contas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaSaldo_Contas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listaSaldo_Contas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaSaldo_Contas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listaSaldo_Contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSaldo_Contas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONTA_ID,
            this.CONTA,
            this.SALDO});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaSaldo_Contas.DefaultCellStyle = dataGridViewCellStyle4;
            this.listaSaldo_Contas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaSaldo_Contas.EnableHeadersVisualStyles = false;
            this.listaSaldo_Contas.GridColor = System.Drawing.Color.DimGray;
            this.listaSaldo_Contas.Location = new System.Drawing.Point(7, 99);
            this.listaSaldo_Contas.MultiSelect = false;
            this.listaSaldo_Contas.Name = "listaSaldo_Contas";
            this.listaSaldo_Contas.ReadOnly = true;
            this.listaSaldo_Contas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaSaldo_Contas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listaSaldo_Contas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.listaSaldo_Contas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.listaSaldo_Contas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.listaSaldo_Contas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.listaSaldo_Contas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.listaSaldo_Contas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaSaldo_Contas.RowTemplate.Height = 25;
            this.listaSaldo_Contas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaSaldo_Contas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaSaldo_Contas.ShowEditingIcon = false;
            this.listaSaldo_Contas.Size = new System.Drawing.Size(436, 206);
            this.listaSaldo_Contas.TabIndex = 1;
            // 
            // lista_Gastos_Classe
            // 
            this.lista_Gastos_Classe.AllowUserToAddRows = false;
            this.lista_Gastos_Classe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.lista_Gastos_Classe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.lista_Gastos_Classe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista_Gastos_Classe.BackgroundColor = System.Drawing.Color.Black;
            this.lista_Gastos_Classe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista_Gastos_Classe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.lista_Gastos_Classe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_Gastos_Classe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.lista_Gastos_Classe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_Gastos_Classe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLASSE_ID,
            this.CLASSE,
            this.VALOR});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_Gastos_Classe.DefaultCellStyle = dataGridViewCellStyle10;
            this.lista_Gastos_Classe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista_Gastos_Classe.EnableHeadersVisualStyles = false;
            this.lista_Gastos_Classe.GridColor = System.Drawing.Color.DimGray;
            this.lista_Gastos_Classe.Location = new System.Drawing.Point(448, 99);
            this.lista_Gastos_Classe.MultiSelect = false;
            this.lista_Gastos_Classe.Name = "lista_Gastos_Classe";
            this.lista_Gastos_Classe.ReadOnly = true;
            this.lista_Gastos_Classe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_Gastos_Classe.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.lista_Gastos_Classe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.lista_Gastos_Classe.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.lista_Gastos_Classe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.lista_Gastos_Classe.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista_Gastos_Classe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.lista_Gastos_Classe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista_Gastos_Classe.RowTemplate.Height = 25;
            this.lista_Gastos_Classe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_Gastos_Classe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_Gastos_Classe.ShowEditingIcon = false;
            this.lista_Gastos_Classe.Size = new System.Drawing.Size(436, 206);
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
            this.CLASSE.DataPropertyName = "CLASSE";
            this.CLASSE.HeaderText = "CLASSE";
            this.CLASSE.Name = "CLASSE";
            this.CLASSE.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0,00";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle9;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 1);
            this.label1.TabIndex = 32;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.limpar});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(885, 24);
            this.menuStrip2.TabIndex = 31;
            this.menuStrip2.Text = "menuStrip2";
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
            // tabCad_Classes
            // 
            this.tabCad_Classes.BackColor = System.Drawing.Color.Black;
            this.tabCad_Classes.Controls.Add(this.gpConta);
            this.tabCad_Classes.Controls.Add(this.gpClasse);
            this.tabCad_Classes.Location = new System.Drawing.Point(4, 27);
            this.tabCad_Classes.Name = "tabCad_Classes";
            this.tabCad_Classes.Padding = new System.Windows.Forms.Padding(3);
            this.tabCad_Classes.Size = new System.Drawing.Size(891, 339);
            this.tabCad_Classes.TabIndex = 2;
            this.tabCad_Classes.Tag = "Cadastro";
            this.tabCad_Classes.Text = "ADD";
            this.tabCad_Classes.UseVisualStyleBackColor = true;
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
            this.gpConta.Location = new System.Drawing.Point(449, 1);
            this.gpConta.Name = "gpConta";
            this.gpConta.Size = new System.Drawing.Size(431, 330);
            this.gpConta.TabIndex = 11;
            this.gpConta.TabStop = false;
            this.gpConta.Text = "Cadastrar Conta";
            // 
            // listaConta
            // 
            this.listaConta.AllowUserToAddRows = false;
            this.listaConta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.listaConta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.listaConta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaConta.BackgroundColor = System.Drawing.Color.Black;
            this.listaConta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaConta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listaConta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaConta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.listaConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONTA,
            this.CONT,
            this.CREDITO});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaConta.DefaultCellStyle = dataGridViewCellStyle16;
            this.listaConta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaConta.EnableHeadersVisualStyles = false;
            this.listaConta.GridColor = System.Drawing.Color.DimGray;
            this.listaConta.Location = new System.Drawing.Point(6, 74);
            this.listaConta.MultiSelect = false;
            this.listaConta.Name = "listaConta";
            this.listaConta.ReadOnly = true;
            this.listaConta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaConta.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.listaConta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.listaConta.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.listaConta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.listaConta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.listaConta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.listaConta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaConta.RowTemplate.Height = 25;
            this.listaConta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaConta.ShowEditingIcon = false;
            this.listaConta.Size = new System.Drawing.Size(419, 246);
            this.listaConta.TabIndex = 1;
            this.listaConta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaConta_CellContentClick);
            this.listaConta.MouseEnter += new System.EventHandler(this.listaConta_MouseEnter);
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = false;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CREDITO.DefaultCellStyle = dataGridViewCellStyle15;
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
            this.ckAtivoConta.Location = new System.Drawing.Point(364, 48);
            this.ckAtivoConta.Name = "ckAtivoConta";
            this.ckAtivoConta.Size = new System.Drawing.Size(61, 19);
            this.ckAtivoConta.TabIndex = 18;
            this.ckAtivoConta.TabStop = false;
            this.ckAtivoConta.Text = "Ativo";
            this.ckAtivoConta.UseVisualStyleBackColor = true;
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirConta.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirConta.Image")));
            this.btnExcluirConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirConta.Location = new System.Drawing.Point(344, 19);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(81, 23);
            this.btnExcluirConta.TabIndex = 2;
            this.btnExcluirConta.Text = "Excluir";
            this.btnExcluirConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirConta.UseVisualStyleBackColor = true;
            this.btnExcluirConta.Click += new System.EventHandler(this.btnExcluirConta_Click);
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.Color.Black;
            this.txtConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConta.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConta.ForeColor = System.Drawing.Color.White;
            this.txtConta.Location = new System.Drawing.Point(5, 19);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(229, 23);
            this.txtConta.TabIndex = 0;
            this.txtConta.Tag = "\'Conta\'";
            this.txtConta.TextChanged += new System.EventHandler(this.txtConta_TextChanged);
            // 
            // btnSalvarConta
            // 
            this.btnSalvarConta.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarConta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarConta.Image")));
            this.btnSalvarConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarConta.Location = new System.Drawing.Point(257, 19);
            this.btnSalvarConta.Name = "btnSalvarConta";
            this.btnSalvarConta.Size = new System.Drawing.Size(81, 23);
            this.btnSalvarConta.TabIndex = 1;
            this.btnSalvarConta.Text = "Salvar";
            this.btnSalvarConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarConta.UseVisualStyleBackColor = true;
            this.btnSalvarConta.Click += new System.EventHandler(this.btnSalvarConta_Click);
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
            this.gpClasse.Location = new System.Drawing.Point(10, 1);
            this.gpClasse.Name = "gpClasse";
            this.gpClasse.Size = new System.Drawing.Size(430, 330);
            this.gpClasse.TabIndex = 10;
            this.gpClasse.TabStop = false;
            this.gpClasse.Text = "Cadastrar Classe";
            // 
            // listaClasse
            // 
            this.listaClasse.AllowUserToAddRows = false;
            this.listaClasse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            this.listaClasse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.listaClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaClasse.BackgroundColor = System.Drawing.Color.Black;
            this.listaClasse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaClasse.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listaClasse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClasse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.listaClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.CLASS});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaClasse.DefaultCellStyle = dataGridViewCellStyle21;
            this.listaClasse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listaClasse.EnableHeadersVisualStyles = false;
            this.listaClasse.GridColor = System.Drawing.Color.DimGray;
            this.listaClasse.Location = new System.Drawing.Point(6, 74);
            this.listaClasse.MultiSelect = false;
            this.listaClasse.Name = "listaClasse";
            this.listaClasse.ReadOnly = true;
            this.listaClasse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClasse.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.listaClasse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.listaClasse.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.listaClasse.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.listaClasse.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.listaClasse.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.listaClasse.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listaClasse.RowTemplate.Height = 25;
            this.listaClasse.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaClasse.ShowEditingIcon = false;
            this.listaClasse.Size = new System.Drawing.Size(418, 246);
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
            this.ckAtivoClasse.Location = new System.Drawing.Point(363, 50);
            this.ckAtivoClasse.Name = "ckAtivoClasse";
            this.ckAtivoClasse.Size = new System.Drawing.Size(61, 19);
            this.ckAtivoClasse.TabIndex = 18;
            this.ckAtivoClasse.TabStop = false;
            this.ckAtivoClasse.Text = "Ativo";
            this.ckAtivoClasse.UseVisualStyleBackColor = true;
            // 
            // btnExcluirClasse
            // 
            this.btnExcluirClasse.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirClasse.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirClasse.Image")));
            this.btnExcluirClasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirClasse.Location = new System.Drawing.Point(343, 19);
            this.btnExcluirClasse.Name = "btnExcluirClasse";
            this.btnExcluirClasse.Size = new System.Drawing.Size(81, 23);
            this.btnExcluirClasse.TabIndex = 2;
            this.btnExcluirClasse.Text = "Excluir";
            this.btnExcluirClasse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirClasse.UseVisualStyleBackColor = true;
            this.btnExcluirClasse.Click += new System.EventHandler(this.btnExcluirClasse_Click);
            // 
            // btnSalvarClasse
            // 
            this.btnSalvarClasse.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarClasse.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarClasse.Image")));
            this.btnSalvarClasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarClasse.Location = new System.Drawing.Point(256, 19);
            this.btnSalvarClasse.Name = "btnSalvarClasse";
            this.btnSalvarClasse.Size = new System.Drawing.Size(81, 23);
            this.btnSalvarClasse.TabIndex = 1;
            this.btnSalvarClasse.Text = "Salvar";
            this.btnSalvarClasse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarClasse.UseVisualStyleBackColor = true;
            this.btnSalvarClasse.Click += new System.EventHandler(this.btnSalvarClasse_Click);
            // 
            // optDespesa
            // 
            this.optDespesa.AutoSize = true;
            this.optDespesa.Location = new System.Drawing.Point(263, 49);
            this.optDespesa.Name = "optDespesa";
            this.optDespesa.Size = new System.Drawing.Size(74, 19);
            this.optDespesa.TabIndex = 17;
            this.optDespesa.Text = "Despesa";
            this.optDespesa.UseVisualStyleBackColor = true;
            this.optDespesa.CheckedChanged += new System.EventHandler(this.optDespesa_CheckedChanged);
            // 
            // optReceita
            // 
            this.optReceita.AutoSize = true;
            this.optReceita.Checked = true;
            this.optReceita.Location = new System.Drawing.Point(183, 49);
            this.optReceita.Name = "optReceita";
            this.optReceita.Size = new System.Drawing.Size(74, 19);
            this.optReceita.TabIndex = 16;
            this.optReceita.TabStop = true;
            this.optReceita.Text = "Receita";
            this.optReceita.UseVisualStyleBackColor = true;
            this.optReceita.CheckedChanged += new System.EventHandler(this.optReceita_CheckedChanged);
            // 
            // txtClasse
            // 
            this.txtClasse.BackColor = System.Drawing.Color.Black;
            this.txtClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClasse.ForeColor = System.Drawing.Color.White;
            this.txtClasse.Location = new System.Drawing.Point(4, 19);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(229, 23);
            this.txtClasse.TabIndex = 0;
            this.txtClasse.Tag = "\'Classe\'";
            this.txtClasse.TextChanged += new System.EventHandler(this.txtClasse_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.CONTA.DataPropertyName = "CONTA";
            this.CONTA.HeaderText = "CONTA";
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(899, 370);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabelaMenu);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabelaMenu.ResumeLayout(false);
            this.tabReceita_Despesa.ResumeLayout(false);
            this.tabReceita_Despesa.PerformLayout();
            this.pnLancamento.ResumeLayout(false);
            this.pnLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSaldo_Contas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Gastos_Classe)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabCad_Classes.ResumeLayout(false);
            this.gpConta.ResumeLayout(false);
            this.gpConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaConta)).EndInit();
            this.gpClasse.ResumeLayout(false);
            this.gpClasse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu;
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
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem ToolRelatorio;
        private ToolStripMenuItem ToolVisaoGeral;
        private ToolStripMenuItem ToolLancamento;
        private ToolStripMenuItem ToolCalculadora;
        private ToolStripMenuItem ToolPrevisao;
        private TabControl tabelaMenu;
        private ErrorProvider errorProvider1;
        private TabPage tabReceita_Despesa;
        private TabPage tabCad_Classes;
        private GroupBox gpConta;
        private CheckBox ckAtivoConta;
        private Button btnExcluirConta;
        private Controles.Txt txtConta;
        private Button btnSalvarConta;
        private GroupBox gpClasse;
        private CheckBox ckAtivoClasse;
        private Button btnExcluirClasse;
        private Button btnSalvarClasse;
        private RadioButton optDespesa;
        private RadioButton optReceita;
        private Controles.Txt txtClasse;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private Label label7;
        private Controles.dgView listaSaldo_Contas;
        public Controles.dgView lista_Gastos_Classe;
        private Label label1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem salvar;
        private ToolStripMenuItem limpar;
        private Controles.dgView listaClasse;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn CLASS;
        private Controles.dgView listaConta;
        private Panel pnLancamento;
        private PictureBox pictureBox1;
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
        private ToolStripMenuItem compraCredito;
        private ToolStripMenuItem transf;
        private DataGridViewTextBoxColumn ID_CONTA;
        private DataGridViewTextBoxColumn CONT;
        private DataGridViewCheckBoxColumn CREDITO;
        private DataGridViewTextBoxColumn CLASSE_ID;
        private DataGridViewTextBoxColumn CLASSE;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn CONTA_ID;
        private DataGridViewTextBoxColumn CONTA;
        private DataGridViewTextBoxColumn SALDO;
    }
}