using System.Windows.Forms;
using System.Drawing;
using System;

namespace Setup.Controles
{
    public class atv : Label
    {
        protected override void OnCreateControl()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = Color.White;
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.AutoSize = false;
            //this.TextAlign = ContentAlignment.MiddleRight;
            this.Cursor = Cursors.Hand;
            //this.Image = ((Image)Properties.Resources.ligado);

            base.OnCreateControl();
        }

        protected override void OnClick(EventArgs e)
        {
            if(this.TabIndex == 1)
            {
                this.TabIndex = 0;
            }
            else if(this.TabIndex == 0)
            {
                this.TabIndex = 1;
            }

            try
            {
                COD.Configurar_Ativacoes(this.Name, this.TabIndex.ToString());
            }
            catch 
            {

            }

            base.OnClick(e);
        }

        protected override void OnTabIndexChanged(EventArgs e)
        {
            if (this.TabIndex == 1)
            {
                this.Image = ((Image)Properties.Resources.ligado);
            }
            else if (this.TabIndex == 0)
            {
                this.Image = ((Image)Properties.Resources.desligado);
            }

            base.OnTabIndexChanged(e);
        }
    }
}