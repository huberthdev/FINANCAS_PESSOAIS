using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
                
                if(controle != NaoLimpar)
                {
                    if (controle is TextBox)
                    {
                        ((TextBox)controle).Clear();
                    }
                    else if (controle is ComboBox)
                    {
                        ((ComboBox)controle).Text = "";
                    }

                }
            }

            if (Foco != null)
                Foco.Focus();
                     
        }

    }
}
