using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Setup
{
    public class COD
    {
        public static int NumTentativasLogin;
        public static bool Resposta;

        //Função para abrir o formulário de ERRO mudando o texto de acordo com a chamada
        public static void Erro(string Msg)
        {
            Formularios.frmErro erro = new Formularios.frmErro();
            erro.lblMsg.Text = Msg;
            erro.ShowDialog();
        }

        //Função para abrir o formulário de OK mudando o texto de acordo com a chamada
        public static void OK(string Msg)
        {
            Formularios.frmOK ok = new Formularios.frmOK();
            ok.lblMsg.Text = Msg;
            ok.ShowDialog();
        }

        //Função para abrir o formulário de PERGUNTA mudando o texto de acordo com a chamada
        public static void Pergunta(string Msg)
        {
            Formularios.frmPergunta pergunta = new Formularios.frmPergunta();
            pergunta.lblMsg.Text = Msg;
            pergunta.ShowDialog();
        }

        //Função para limpar todos os campos de texto de um formulário
        public static void LimparCampos(Control Formulario, Control NaoLimpar = null, Control Foco = null)
        {
            foreach (var controle in Formulario.Controls)
            {

                if (controle != NaoLimpar)
                {
                    if (controle is TextBox)
                    {
                        ((TextBox)controle).Clear();
                    }
                    else if (controle is ComboBox)
                    {
                        ((ComboBox)controle).SelectedIndex = -1;
                    }
                    else if (controle is RichTextBox)
                    {
                        ((RichTextBox)controle).Clear();
                    }

                }
            }

            if (Foco != null)
                Foco.Focus();

        }

        //Função para validar todos os campos vazios obrigatórios de um formulário
        public static bool ValidarCampos(Control Formulario, ErrorProvider erro = null)
        {

            if (erro != null)
                erro.Clear();

            foreach (Control controle in Formulario.Controls)
            {

                if (controle is TextBox || controle is ComboBox)
                {
                    if (controle.Tag != null)
                    {
                        if (controle.Text == "")
                        {
                            controle.Focus();

                            if (erro != null)
                                erro.SetError(controle, "Este campo é obrigatório!");

                            return false;
                        }
                    }
                }

            }

            return true;

        }

        public static string CriptografiaMd5(string texto)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(texto));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
