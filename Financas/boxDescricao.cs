﻿using System;
using System.Windows.Forms;

namespace Setup.Financas
{
    public partial class boxDescricao : Form
    {
        public boxDescricao()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lnU_MouseDown(object sender, MouseEventArgs e)
        {
            COD.ReleaseCapture();
            COD.SendMessage(this.Handle, COD.WM_NCLBUTTONDOWN, COD.HT_CAPTION, 0);
        }
    }
}
