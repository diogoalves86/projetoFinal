using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineDiary.Classes;

namespace OnlineDiary.Painel.UsuarioTela
{
    public partial class Adicionar : System.Web.UI.Page
    {
        private UsuarioContext usuario_context = new UsuarioContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Cadastra_Usuario()
        {
            try
            {
                Usuario usuario = new Usuario { Nome = txt_nome.Text };
                usuario_context.InsertOrUpdate(usuario);
                lbl_feedback.ForeColor = Color.Green;
                lbl_feedback.Text = "Disciplina cadastrada com sucesso!";
            }
            catch (Exception ex)
            {
                lbl_feedback.ForeColor = Color.Red;
                lbl_feedback.Text = ex.Message;
            }
        }
    }
}