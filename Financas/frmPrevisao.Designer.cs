using System.Windows.Forms;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrevisao));
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
            this.status = new System.Windows.Forms.StatusStrip();
            this.imagens = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
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
            // 
            // atualizar
            // 
            this.atualizar.ForeColor = System.Drawing.Color.White;
            this.atualizar.Image = ((System.Drawing.Image)(resources.GetObject("atualizar.Image")));
            this.atualizar.Name = "atualizar";
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
            this.ano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ano.CausesValidation = false;
            this.ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ano.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.ano.ForeColor = System.Drawing.Color.White;
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(121, 23);
            this.ano.SelectedIndexChanged += new System.EventHandler(this.ano_SelectedIndexChanged);
            // 
            // mes
            // 
            this.mes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.mes.CausesValidation = false;
            this.mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mes.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
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
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1050, 479);
            this.panel.TabIndex = 1;
            this.panel.CausesValidationChanged += new System.EventHandler(this.panel_CausesValidationChanged);
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Location = new System.Drawing.Point(0, 484);
            this.status.Name = "status";
            this.status.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.status.Size = new System.Drawing.Size(1050, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 7;
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
            // frmPrevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1050, 506);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(712, 88);
            this.Name = "frmPrevisao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrevisao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}