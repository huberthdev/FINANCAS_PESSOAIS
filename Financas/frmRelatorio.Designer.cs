
namespace Setup.Financas
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.alterar = new System.Windows.Forms.ToolStripMenuItem();
            this.limparFiltro = new System.Windows.Forms.ToolStripMenuItem();
            this.exportar = new System.Windows.Forms.ToolStripMenuItem();
            this.excel = new System.Windows.Forms.ToolStripMenuItem();
            this.pdf = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataInicio = new Setup.Controles.Data();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataFim = new Setup.Controles.Data();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClasse = new Setup.Controles.cbCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.cbConta = new Setup.Controles.cbCombo();
            this.ckReceita = new System.Windows.Forms.CheckBox();
            this.ckDespesa = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new Setup.Controles.Txt();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor1 = new Setup.Controles.Decimal();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor2 = new Setup.Controles.Decimal();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lista = new Setup.Controles.dgView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizar,
            this.excluir,
            this.alterar,
            this.limparFiltro,
            this.exportar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atualizar
            // 
            this.atualizar.Image = ((System.Drawing.Image)(resources.GetObject("atualizar.Image")));
            this.atualizar.Name = "atualizar";
            this.atualizar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.atualizar.Size = new System.Drawing.Size(104, 20);
            this.atualizar.Text = "Atualizar {F5}";
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.Name = "excluir";
            this.excluir.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluir.Size = new System.Drawing.Size(101, 20);
            this.excluir.Text = "Excluir {DEL}";
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // alterar
            // 
            this.alterar.Image = ((System.Drawing.Image)(resources.GetObject("alterar.Image")));
            this.alterar.Name = "alterar";
            this.alterar.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.alterar.Size = new System.Drawing.Size(93, 20);
            this.alterar.Text = "Alterar {F2}";
            // 
            // limparFiltro
            // 
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
            this.exportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excel,
            this.pdf});
            this.exportar.Image = ((System.Drawing.Image)(resources.GetObject("exportar.Image")));
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(79, 20);
            this.exportar.Text = "Exportar";
            // 
            // excel
            // 
            this.excel.Image = ((System.Drawing.Image)(resources.GetObject("excel.Image")));
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(101, 22);
            this.excel.Text = "Excel";
            // 
            // pdf
            // 
            this.pdf.Image = ((System.Drawing.Image)(resources.GetObject("pdf.Image")));
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(101, 22);
            this.pdf.Text = "PDF";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 1);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "De:";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.BackColor = System.Drawing.Color.Black;
            this.txtDataInicio.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataInicio.ForeColor = System.Drawing.Color.White;
            this.txtDataInicio.Location = new System.Drawing.Point(42, 32);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(110, 23);
            this.txtDataInicio.TabIndex = 1;
            this.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "De:";
            // 
            // txtDataFim
            // 
            this.txtDataFim.BackColor = System.Drawing.Color.Black;
            this.txtDataFim.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataFim.ForeColor = System.Drawing.Color.White;
            this.txtDataFim.Location = new System.Drawing.Point(188, 32);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(110, 23);
            this.txtDataFim.TabIndex = 2;
            this.txtDataFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(304, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Classe:";
            // 
            // cbClasse
            // 
            this.cbClasse.BackColor = System.Drawing.Color.Black;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClasse.ForeColor = System.Drawing.Color.White;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(353, 32);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(209, 23);
            this.cbClasse.TabIndex = 3;
            this.cbClasse.SelectedValueChanged += new System.EventHandler(this.cbClasse_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(568, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Conta:";
            // 
            // cbConta
            // 
            this.cbConta.BackColor = System.Drawing.Color.Black;
            this.cbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConta.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbConta.ForeColor = System.Drawing.Color.White;
            this.cbConta.FormattingEnabled = true;
            this.cbConta.Location = new System.Drawing.Point(616, 32);
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(209, 23);
            this.cbConta.TabIndex = 4;
            this.cbConta.SelectedValueChanged += new System.EventHandler(this.cbConta_SelectedValueChanged);
            // 
            // ckReceita
            // 
            this.ckReceita.AutoSize = true;
            this.ckReceita.ForeColor = System.Drawing.Color.White;
            this.ckReceita.Location = new System.Drawing.Point(693, 65);
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
            this.ckDespesa.AutoSize = true;
            this.ckDespesa.ForeColor = System.Drawing.Color.White;
            this.ckDespesa.Location = new System.Drawing.Point(762, 65);
            this.ckDespesa.Name = "ckDespesa";
            this.ckDespesa.Size = new System.Drawing.Size(69, 19);
            this.ckDespesa.TabIndex = 9;
            this.ckDespesa.Text = "Despesa";
            this.ckDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckDespesa.UseVisualStyleBackColor = true;
            this.ckDespesa.CheckedChanged += new System.EventHandler(this.ckDespesa_CheckedChanged);
            this.ckDespesa.Click += new System.EventHandler(this.ckDespesa_Click);
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 343);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(842, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(23, 17);
            this.statusLabel.Text = ">>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Black;
            this.txtDescricao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(79, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(297, 23);
            this.txtDescricao.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(382, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valor Entre:";
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.Color.Black;
            this.txtValor1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor1.ForeColor = System.Drawing.Color.White;
            this.txtValor1.Location = new System.Drawing.Point(454, 63);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 23);
            this.txtValor1.TabIndex = 6;
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(560, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "e";
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.Color.Black;
            this.txtValor2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor2.ForeColor = System.Drawing.Color.White;
            this.txtValor2.Location = new System.Drawing.Point(579, 63);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 23);
            this.txtValor2.TabIndex = 7;
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(850, 1);
            this.label9.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(0, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(842, 1);
            this.label10.TabIndex = 10;
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.Color.Black;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.lista.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TIPO,
            this.DATA,
            this.CLASSE,
            this.VALOR,
            this.DESC});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle9;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.DimGray;
            this.lista.Location = new System.Drawing.Point(2, 101);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(837, 238);
            this.lista.TabIndex = 1;
            this.lista.SelectionChanged += new System.EventHandler(this.lista_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "-";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle5;
            this.DATA.FillWeight = 29.37201F;
            this.DATA.HeaderText = "DATA";
            this.DATA.MinimumWidth = 80;
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 80;
            // 
            // CLASSE
            // 
            this.CLASSE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.CLASSE.DataPropertyName = "CLASSE";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            this.CLASSE.DefaultCellStyle = dataGridViewCellStyle6;
            this.CLASSE.FillWeight = 397.6419F;
            this.CLASSE.HeaderText = "CLASSE";
            this.CLASSE.MinimumWidth = 200;
            this.CLASSE.Name = "CLASSE";
            this.CLASSE.ReadOnly = true;
            this.CLASSE.Width = 200;
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0,00";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle7;
            this.VALOR.FillWeight = 2.176008F;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.MinimumWidth = 80;
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 80;
            // 
            // DESC
            // 
            this.DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DESC.DataPropertyName = "DESC";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            this.DESC.DefaultCellStyle = dataGridViewCellStyle8;
            this.DESC.FillWeight = 1.224657F;
            this.DESC.HeaderText = "DESCRIÇÃO";
            this.DESC.MinimumWidth = 200;
            this.DESC.Name = "DESC";
            this.DESC.ReadOnly = true;
            this.DESC.Width = 400;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(842, 365);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbConta);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.ckReceita);
            this.Controls.Add(this.ckDespesa);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRelatorio_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atualizar;
        private System.Windows.Forms.ToolStripMenuItem excluir;
        private System.Windows.Forms.ToolStripMenuItem alterar;
        private System.Windows.Forms.ToolStripMenuItem limparFiltro;
        private System.Windows.Forms.ToolStripMenuItem exportar;
        private System.Windows.Forms.ToolStripMenuItem excel;
        private System.Windows.Forms.ToolStripMenuItem pdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controles.Data txtDataInicio;
        private System.Windows.Forms.Label label3;
        private Controles.Data txtDataFim;
        private System.Windows.Forms.Label label4;
        private Controles.cbCombo cbClasse;
        private System.Windows.Forms.Label label5;
        private Controles.cbCombo cbConta;
        private System.Windows.Forms.CheckBox ckReceita;
        private System.Windows.Forms.CheckBox ckDespesa;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label6;
        private Controles.Txt txtDescricao;
        private System.Windows.Forms.Label label7;
        private Controles.Decimal txtValor1;
        private System.Windows.Forms.Label label8;
        private Controles.Decimal txtValor2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Controles.dgView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC;
    }
}