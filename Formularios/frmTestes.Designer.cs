
namespace Setup.Formularios
{
    partial class frmTestes
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
            this.label1 = new System.Windows.Forms.Label();
            this.decimal1 = new Setup.Controles.Decimal();
            this.moeda1 = new Setup.Controles.Moeda();
            this.inteiro1 = new Setup.Controles.Inteiro();
            this.cbCombo1 = new Setup.Controles.cbCombo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decimal1
            // 
            this.decimal1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decimal1.Location = new System.Drawing.Point(210, 149);
            this.decimal1.Name = "decimal1";
            this.decimal1.Size = new System.Drawing.Size(100, 23);
            this.decimal1.TabIndex = 7;
            this.decimal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moeda1
            // 
            this.moeda1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moeda1.Location = new System.Drawing.Point(210, 178);
            this.moeda1.Name = "moeda1";
            this.moeda1.Size = new System.Drawing.Size(100, 23);
            this.moeda1.TabIndex = 8;
            this.moeda1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inteiro1
            // 
            this.inteiro1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inteiro1.Location = new System.Drawing.Point(210, 207);
            this.inteiro1.Name = "inteiro1";
            this.inteiro1.Size = new System.Drawing.Size(100, 23);
            this.inteiro1.TabIndex = 9;
            this.inteiro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbCombo1
            // 
            this.cbCombo1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCombo1.FormattingEnabled = true;
            this.cbCombo1.Location = new System.Drawing.Point(316, 207);
            this.cbCombo1.Name = "cbCombo1";
            this.cbCombo1.Size = new System.Drawing.Size(121, 23);
            this.cbCombo1.TabIndex = 10;
            // 
            // frmTestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 308);
            this.Controls.Add(this.cbCombo1);
            this.Controls.Add(this.inteiro1);
            this.Controls.Add(this.moeda1);
            this.Controls.Add(this.decimal1);
            this.Controls.Add(this.label1);
            this.Name = "frmTestes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTesteCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controles.Decimal decimal1;
        private Controles.Moeda moeda1;
        private Controles.Inteiro inteiro1;
        private Controles.cbCombo cbCombo1;
    }
}