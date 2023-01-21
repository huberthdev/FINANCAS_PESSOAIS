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
        public static bool Alerta_Compromissos;
        public static bool Alerta_Login;

        public static void ShowNotification(string titulo, string mensagem, ToolTipIcon icon, int tempo = 10)
        {
            try
            {
                Financas.frmMenu menu = new Financas.frmMenu();
                menu.notifyIcon1.ShowBalloonTip(tempo, titulo, mensagem, icon);
            }
            catch
            {

            }
        }

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

        public static string RemoveSpecialCharacters(string text, bool allowSpace = false)
        {
            string ret;

            if (allowSpace)
                ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\s]+?", string.Empty);
            else
                ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ]+?", string.Empty);

            return ret;
        }

        public static string RemoverAcentos(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 255)
                    sb.Append(text[i]);
                else
                    sb.Append(s_Diacritics[text[i]]);
            }

            return sb.ToString();
        }

        private static readonly char[] s_Diacritics = GetDiacritics();

        private static char[] GetDiacritics()
        {
            char[] accents = new char[256];

            for (int i = 0; i < 256; i++)
                accents[i] = (char)i;

            accents[(byte)'á'] = accents[(byte)'à'] = accents[(byte)'ã'] = accents[(byte)'â'] = accents[(byte)'ä'] = 'a';
            accents[(byte)'Á'] = accents[(byte)'À'] = accents[(byte)'Ã'] = accents[(byte)'Â'] = accents[(byte)'Ä'] = 'A';

            accents[(byte)'é'] = accents[(byte)'è'] = accents[(byte)'ê'] = accents[(byte)'ë'] = 'e';
            accents[(byte)'É'] = accents[(byte)'È'] = accents[(byte)'Ê'] = accents[(byte)'Ë'] = 'E';

            accents[(byte)'í'] = accents[(byte)'ì'] = accents[(byte)'î'] = accents[(byte)'ï'] = 'i';
            accents[(byte)'Í'] = accents[(byte)'Ì'] = accents[(byte)'Î'] = accents[(byte)'Ï'] = 'I';

            accents[(byte)'ó'] = accents[(byte)'ò'] = accents[(byte)'ô'] = accents[(byte)'õ'] = accents[(byte)'ö'] = 'o';
            accents[(byte)'Ó'] = accents[(byte)'Ò'] = accents[(byte)'Ô'] = accents[(byte)'Õ'] = accents[(byte)'Ö'] = 'O';

            accents[(byte)'ú'] = accents[(byte)'ù'] = accents[(byte)'û'] = accents[(byte)'ü'] = 'u';
            accents[(byte)'Ú'] = accents[(byte)'Ù'] = accents[(byte)'Û'] = accents[(byte)'Ü'] = 'U';

            accents[(byte)'ç'] = 'c';
            accents[(byte)'Ç'] = 'C';

            accents[(byte)'ñ'] = 'n';
            accents[(byte)'Ñ'] = 'N';

            accents[(byte)'ÿ'] = accents[(byte)'ý'] = 'y';
            accents[(byte)'Ý'] = 'Y';

            return accents;
        }

        public static void MsgAlerta(Form frm, string msg = "")
        {
            
        }
    }
}
