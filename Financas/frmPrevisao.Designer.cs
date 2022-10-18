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
            this.menuStrip1 = new MenuStrip();
            this.novo = new ToolStripMenuItem();
            this.excluir = new ToolStripMenuItem();
            this.replicar = new ToolStripMenuItem();
            this.atualizar = new ToolStripMenuItem();
            this.definicoes = new ToolStripMenuItem();
            this.ano = new ToolStripComboBox();
            this.mes = new ToolStripComboBox();
            this.panel = new Panel();
            this.status = new StatusStrip();
            this.imagens = new ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.novo,
            this.excluir,
            this.replicar,
            this.atualizar,
            this.definicoes,
            this.ano,
            this.mes});
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
            this.ano.Alignment = ToolStripItemAlignment.Right;
            this.ano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ano.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ano.ForeColor = System.Drawing.Color.White;
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(121, 23);
            // 
            // mes
            // 
            this.mes.Alignment = ToolStripItemAlignment.Right;
            this.mes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.mes.DropDownStyle = ComboBoxStyle.DropDownList;
            this.mes.ForeColor = System.Drawing.Color.White;
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(121, 23);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = BorderStyle.FixedSingle;
            this.panel.Dock = DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1050, 479);
            this.panel.TabIndex = 1;
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Location = new System.Drawing.Point(0, 484);
            this.status.Name = "status";
            this.status.RenderMode = ToolStripRenderMode.Professional;
            this.status.Size = new System.Drawing.Size(1050, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 7;
            // 
            // imagens
            // 
            this.imagens.ColorDepth = ColorDepth.Depth8Bit;
            this.imagens.ImageStream = ((ImageListStreamer)(resources.GetObject("imagens.ImageStream")));
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
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1050, 506);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrevisao";
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrevisao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem novo;
        private ToolStripMenuItem excluir;
        private ToolStripMenuItem replicar;
        private ToolStripComboBox ano;
        private ToolStripComboBox mes;
        private StatusStrip status;
        private ImageList imagens;
        public Panel panel;
        private ToolStripMenuItem atualizar;
        private ToolStripMenuItem definicoes;
    }
}