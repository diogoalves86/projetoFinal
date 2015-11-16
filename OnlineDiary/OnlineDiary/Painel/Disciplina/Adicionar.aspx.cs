using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineDiary.Classes;

namespace OnlineDiary.Classes.Painel.DisciplinaTela
{
    public partial class Adicionar : System.Web.UI.Page
    {
        private DisciplinaContext disciplina_context = new DisciplinaContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastra_Disciplina();
        }

        private void Cadastra_Disciplina()
        {
            try
            {
                Disciplina disciplina = new Disciplina { Nome = txt_nome.Text };
                disciplina_context.InsertOrUpdate(disciplina);
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