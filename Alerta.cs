using System.Drawing;
using System.Windows.Forms;

namespace Setup
{
    public partial class Alerta : UserControl
    {
        private string _mensagem;

        public string Mensagem
        {
            get { return _mensagem; }

            set
            {
                _mensagem = value;
                lblMsg.Text = value;
            }
        }

        public Alerta()
        {
            InitializeComponent();
        }
    }
}
