using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Setup.Formularios
{
    public partial class frmImagem : Form
    {
        public frmImagem()
        {
            InitializeComponent();
        }

        private void frmImagem_KeyDown(object sender, KeyEventArgs e)
        {
            Image img = null;

            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                if (Clipboard.ContainsImage())
                {
                    img = Clipboard.GetImage();

                    imagem.Image = img;
                    imagem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
