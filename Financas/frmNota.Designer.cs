
namespace Setup.Financas
{
    partial class frmNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNota));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.DataGridView();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota";
            // 
            // txtTexto
            // 
            this.txtTexto.AcceptsTab = true;
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTexto.Location = new System.Drawing.Point(12, 68);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(291, 297);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.Text = "";
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // lblCor
            // 
            this.lblCor.BackColor = System.Drawing.Color.Aqua;
            this.lblCor.Location = new System.Drawing.Point(281, 27);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(22, 23);
            this.lblCor.TabIndex = 3;
            this.lblCor.Click += new System.EventHandler(this.lblCor_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(12, 27);
            this.txtTitulo.MaxLength = 36;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(236, 23);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.Tag = "0";
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.Color.White;
            this.lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle3;
            this.lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lista.GridColor = System.Drawing.Color.White;
            this.lista.Location = new System.Drawing.Point(3, 3);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(511, 353);
            this.lista.TabIndex = 7;
            this.lista.TabStop = false;
            this.lista.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.lista_UserDeletingRow);
            this.lista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseClick);
            this.lista.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lista_MouseMove);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AccessibleName = "Salvar";
            this.lblSalvar.BackColor = System.Drawing.Color.Transparent;
            this.lblSalvar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalvar.Image = ((System.Drawing.Image)(resources.GetObject("lblSalvar.Image")));
            this.lblSalvar.Location = new System.Drawing.Point(254, 27);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(22, 23);
            this.lblSalvar.TabIndex = 3;
            this.lblSalvar.Click += new System.EventHandler(this.lblSalvar_Click);
            // 
            // lblFaixa
            // 
            this.lblFaixa.BackColor = System.Drawing.Color.Aqua;
            this.lblFaixa.Location = new System.Drawing.Point(12, 56);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(291, 12);
            this.lblFaixa.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lista);
            this.panel1.Location = new System.Drawing.Point(309, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 365);
            this.panel1.TabIndex = 9;
            // 
            // frmNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(837, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmNota";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNota_FormClosing);
            this.Load += new System.EventHandler(this.frmNota_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmNota_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.Panel panel1;
    }
}