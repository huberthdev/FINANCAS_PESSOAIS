
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.limpar = new System.Windows.Forms.ToolStripMenuItem();
            this.cartoes = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCartao = new Setup.Controles.cbCombo();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClasse = new Setup.Controles.cbCombo();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new Setup.Controles.Data();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new Setup.Controles.Decimal();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdeParc = new Setup.Controles.Inteiro();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new Setup.Controles.Txt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lista = new Setup.Controles.dgView();
            this.CHAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARCELA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_PGMTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvar,
            this.limpar,
            this.cartoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvar
            // 
            this.salvar.Image = ((System.Drawing.Image)(resources.GetObject("salvar.Image")));
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(66, 20);
            this.salvar.Text = "Salvar";
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // limpar
            // 
            this.limpar.Image = ((System.Drawing.Image)(resources.GetObject("limpar.Image")));
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(72, 20);
            this.limpar.Text = "Limpar";
            // 
            // cartoes
            // 
            this.cartoes.Image = ((System.Drawing.Image)(resources.GetObject("cartoes.Image")));
            this.cartoes.Name = "cartoes";
            this.cartoes.Size = new System.Drawing.Size(75, 20);
            this.cartoes.Text = "Cartões";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cartão";
            // 
            // cbCartao
            // 
            this.cbCartao.BackColor = System.Drawing.Color.Black;
            this.cbCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCartao.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCartao.ForeColor = System.Drawing.Color.White;
            this.cbCartao.FormattingEnabled = true;
            this.cbCartao.Location = new System.Drawing.Point(60, 31);
            this.cbCartao.Name = "cbCartao";
            this.cbCartao.Size = new System.Drawing.Size(309, 23);
            this.cbCartao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Classe";
            // 
            // cbClasse
            // 
            this.cbClasse.BackColor = System.Drawing.Color.Black;
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClasse.ForeColor = System.Drawing.Color.White;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(421, 31);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(309, 23);
            this.cbClasse.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.Black;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(60, 63);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(110, 23);
            this.txtData.TabIndex = 3;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Black;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(215, 63);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 23);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Qtd. Parcelas";
            // 
            // txtQtdeParc
            // 
            this.txtQtdeParc.BackColor = System.Drawing.Color.Black;
            this.txtQtdeParc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeParc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdeParc.ForeColor = System.Drawing.Color.White;
            this.txtQtdeParc.Location = new System.Drawing.Point(413, 63);
            this.txtQtdeParc.MaxLength = 3;
            this.txtQtdeParc.Name = "txtQtdeParc";
            this.txtQtdeParc.Size = new System.Drawing.Size(48, 23);
            this.txtQtdeParc.TabIndex = 5;
            this.txtQtdeParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Black;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(531, 63);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(260, 23);
            this.txtDesc.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 298);
            this.panel1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lista);
            this.splitContainer1.Size = new System.Drawing.Size(779, 298);
            this.splitContainer1.SplitterDistance = 506;
            this.splitContainer1.TabIndex = 2;
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
            this.CHAVE,
            this.ID,
            this.DATA,
            this.CLASSE,
            this.VALOR,
            this.PARCELA,
            this.DATA_PGMTO,
            this.DESCRICAO});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle3;
            this.lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.DimGray;
            this.lista.Location = new System.Drawing.Point(0, 0);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(506, 298);
            this.lista.TabIndex = 1;
            // 
            // CHAVE
            // 
            this.CHAVE.HeaderText = "CHAVE";
            this.CHAVE.Name = "CHAVE";
            this.CHAVE.ReadOnly = true;
            this.CHAVE.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DATA
            // 
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            // 
            // CLASSE
            // 
            this.CLASSE.HeaderText = "CLASSE";
            this.CLASSE.Name = "CLASSE";
            this.CLASSE.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // PARCELA
            // 
            this.PARCELA.HeaderText = "PARCELA";
            this.PARCELA.Name = "PARCELA";
            this.PARCELA.ReadOnly = true;
            // 
            // DATA_PGMTO
            // 
            this.DATA_PGMTO.HeaderText = "DATA PGMTO";
            this.DATA_PGMTO.Name = "DATA_PGMTO";
            this.DATA_PGMTO.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtQtdeParc);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbCartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCredito";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvar;
        private System.Windows.Forms.ToolStripMenuItem limpar;
        private System.Windows.Forms.ToolStripMenuItem cartoes;
        private System.Windows.Forms.Label label1;
        private Controles.cbCombo cbCartao;
        private System.Windows.Forms.Label label2;
        private Controles.cbCombo cbClasse;
        private System.Windows.Forms.Label label3;
        private Controles.Data txtData;
        private System.Windows.Forms.Label label4;
        private Controles.Decimal txtValor;
        private System.Windows.Forms.Label label5;
        private Controles.Inteiro txtQtdeParc;
        private System.Windows.Forms.Label label6;
        private Controles.Txt txtDesc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Controles.dgView lista;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARCELA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_PGMTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
    }
}