using System.Windows.Forms;
using System.Drawing;

namespace Setup.Formularios
{
    partial class frmQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSQL = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.executar = new System.Windows.Forms.ToolStripMenuItem();
            this.novo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLimite = new System.Windows.Forms.ToolStripTextBox();
            this.treeTabelas = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lista = new Setup.Controles.dgView();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnRight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSQL
            // 
            this.txtSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSQL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSQL.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(1);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtSQL.ShowSelectionMargin = true;
            this.txtSQL.Size = new System.Drawing.Size(615, 79);
            this.txtSQL.TabIndex = 0;
            this.txtSQL.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFromToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // selectFromToolStripMenuItem
            // 
            this.selectFromToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectFromToolStripMenuItem.Image")));
            this.selectFromToolStripMenuItem.Name = "selectFromToolStripMenuItem";
            this.selectFromToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.selectFromToolStripMenuItem.Text = "Select from ...";
            this.selectFromToolStripMenuItem.Click += new System.EventHandler(this.selectFromToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atualizarToolStripMenuItem.Image")));
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executar,
            this.novo,
            this.toolLimite});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // executar
            // 
            this.executar.BackColor = System.Drawing.Color.Transparent;
            this.executar.ForeColor = System.Drawing.Color.White;
            this.executar.Image = ((System.Drawing.Image)(resources.GetObject("executar.Image")));
            this.executar.Name = "executar";
            this.executar.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.executar.Size = new System.Drawing.Size(103, 25);
            this.executar.Text = "Executar {F4}";
            this.executar.Click += new System.EventHandler(this.executarToolStripMenuItem_Click);
            // 
            // novo
            // 
            this.novo.BackColor = System.Drawing.Color.Transparent;
            this.novo.ForeColor = System.Drawing.Color.White;
            this.novo.Image = ((System.Drawing.Image)(resources.GetObject("novo.Image")));
            this.novo.Name = "novo";
            this.novo.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.novo.Size = new System.Drawing.Size(87, 25);
            this.novo.Text = "Novo {F5}";
            this.novo.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // toolLimite
            // 
            this.toolLimite.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.toolLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolLimite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolLimite.ForeColor = System.Drawing.Color.White;
            this.toolLimite.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolLimite.Name = "toolLimite";
            this.toolLimite.Size = new System.Drawing.Size(100, 25);
            this.toolLimite.Text = "1000";
            this.toolLimite.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treeTabelas
            // 
            this.treeTabelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.treeTabelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeTabelas.ContextMenuStrip = this.contextMenuStrip1;
            this.treeTabelas.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeTabelas.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeTabelas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeTabelas.ForeColor = System.Drawing.Color.White;
            this.treeTabelas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeTabelas.Location = new System.Drawing.Point(4, 29);
            this.treeTabelas.Name = "treeTabelas";
            this.treeTabelas.Size = new System.Drawing.Size(174, 324);
            this.treeTabelas.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtSQL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(178, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 324);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 4);
            this.label2.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.lista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 245);
            this.panel2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(0, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(615, 4);
            this.label9.TabIndex = 47;
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 223);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(615, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 46;
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(23, 17);
            this.statusLabel.Text = ">>";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.lista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.lista.RowTemplate.Height = 25;
            this.lista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.ShowEditingIcon = false;
            this.lista.Size = new System.Drawing.Size(615, 245);
            this.lista.TabIndex = 1;
            this.lista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.lista_DataBindingComplete);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Location = new System.Drawing.Point(0, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(793, 4);
            this.label13.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 324);
            this.label1.TabIndex = 50;
            // 
            // lnRight
            // 
            this.lnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.lnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnRight.Location = new System.Drawing.Point(793, 0);
            this.lnRight.Name = "lnRight";
            this.lnRight.Size = new System.Drawing.Size(4, 357);
            this.lnRight.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(178, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(4, 324);
            this.label10.TabIndex = 52;
            // 
            // frmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(797, 357);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeTabelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lnRight);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(655, 313);
            this.Name = "frmQuery";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmQuery_Activated);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txtSQL;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem executar;
        private ToolStripMenuItem novo;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem selectFromToolStripMenuItem;
        private TreeView treeTabelas;
        private Panel panel1;
        private Panel panel2;
        private ToolStripTextBox toolLimite;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private Controles.dgView lista;
        private Label label9;
        private StatusStrip status;
        private ToolStripStatusLabel statusLabel;
        private Label label13;
        private Label label1;
        private Label lnRight;
        private Label label10;
        private Label label2;
    }
}