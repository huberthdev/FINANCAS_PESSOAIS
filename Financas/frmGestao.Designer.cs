using System.Drawing;
using System.Windows.Forms;

namespace Setup.Financas
{
    partial class frmGestao
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
            this.lista.MultiSelect = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.next = new System.Windows.Forms.ToolStripMenuItem();
            this.back = new System.Windows.Forms.ToolStripMenuItem();
            this.ano = new System.Windows.Forms.ToolStripComboBox();
            this.lista = new Setup.Controles.dgView();
            this.MES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MES_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESPESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESVIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optDtParc = new System.Windows.Forms.RadioButton();
            this.optDtCompra = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.next,
            this.back,
            this.ano});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 27);
            this.menuStrip1.TabIndex = 1;
            // 
            // next
            // 
            this.next.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.next.ForeColor = System.Drawing.Color.White;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(28, 23);
            this.next.ToolTipText = "Próximo ano";
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
            this.back.ToolTipText = "Ano anterior";
            this.back.Click += new System.EventHandler(this.back_Click);
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
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.MES,
            this.MES_NOME,
            this.RECEITA,
            this.DESPESA,
            this.DESVIO});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle6;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista.Location = new System.Drawing.Point(5, 30);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(458, 348);
            this.lista.TabIndex = 1;
            this.lista.TabStop = false;
            this.lista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.lista_DataBindingComplete);
            // 
            // MES
            // 
            this.MES.DataPropertyName = "MES";
            this.MES.HeaderText = "MÊS";
            this.MES.Name = "MES";
            this.MES.ReadOnly = true;
            this.MES.Visible = false;
            // 
            // MES_NOME
            // 
            this.MES_NOME.DataPropertyName = "MES_NOME";
            this.MES_NOME.HeaderText = "MÊS";
            this.MES_NOME.Name = "MES_NOME";
            this.MES_NOME.ReadOnly = true;
            // 
            // RECEITA
            // 
            this.RECEITA.DataPropertyName = "RECEITA";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.Format = "N2";
            this.RECEITA.DefaultCellStyle = dataGridViewCellStyle3;
            this.RECEITA.HeaderText = "RECEITA R$";
            this.RECEITA.Name = "RECEITA";
            this.RECEITA.ReadOnly = true;
            // 
            // DESPESA
            // 
            this.DESPESA.DataPropertyName = "DESPESA";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.Format = "N2";
            this.DESPESA.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESPESA.HeaderText = "DESPESA R$";
            this.DESPESA.Name = "DESPESA";
            this.DESPESA.ReadOnly = true;
            this.DESPESA.ToolTipText = "Soma de débito e crédito";
            // 
            // DESVIO
            // 
            this.DESVIO.DataPropertyName = "DESVIO";
            dataGridViewCellStyle5.Format = "N2";
            this.DESVIO.DefaultCellStyle = dataGridViewCellStyle5;
            this.DESVIO.HeaderText = "DESVIO R$";
            this.DESVIO.Name = "DESVIO";
            this.DESVIO.ReadOnly = true;
            // 
            // optDtParc
            // 
            this.optDtParc.AutoSize = true;
            this.optDtParc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.optDtParc.Checked = true;
            this.optDtParc.ForeColor = System.Drawing.Color.White;
            this.optDtParc.Location = new System.Drawing.Point(5, 5);
            this.optDtParc.Name = "optDtParc";
            this.optDtParc.Size = new System.Drawing.Size(106, 19);
            this.optDtParc.TabIndex = 2;
            this.optDtParc.TabStop = true;
            this.optDtParc.Text = "Data da parcela";
            this.optDtParc.UseVisualStyleBackColor = false;
            this.optDtParc.CheckedChanged += new System.EventHandler(this.optDtParc_CheckedChanged);
            this.optDtParc.Click += new System.EventHandler(this.optDtParc_Click);
            // 
            // optDtCompra
            // 
            this.optDtCompra.AutoSize = true;
            this.optDtCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.optDtCompra.ForeColor = System.Drawing.Color.White;
            this.optDtCompra.Location = new System.Drawing.Point(117, 5);
            this.optDtCompra.Name = "optDtCompra";
            this.optDtCompra.Size = new System.Drawing.Size(109, 19);
            this.optDtCompra.TabIndex = 3;
            this.optDtCompra.Text = "Data da compra";
            this.optDtCompra.UseVisualStyleBackColor = false;
            this.optDtCompra.Click += new System.EventHandler(this.optDtCompra_Click);
            // 
            // frmGestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(467, 382);
            this.Controls.Add(this.optDtCompra);
            this.Controls.Add(this.optDtParc);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGestao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem next;
        private System.Windows.Forms.ToolStripMenuItem back;
        public System.Windows.Forms.ToolStripComboBox ano;
        public Controles.dgView lista;
        private DataGridViewTextBoxColumn MES;
        private DataGridViewTextBoxColumn MES_NOME;
        private DataGridViewTextBoxColumn RECEITA;
        private DataGridViewTextBoxColumn DESPESA;
        private DataGridViewTextBoxColumn DESVIO;
        private RadioButton optDtParc;
        private RadioButton optDtCompra;
    }
}