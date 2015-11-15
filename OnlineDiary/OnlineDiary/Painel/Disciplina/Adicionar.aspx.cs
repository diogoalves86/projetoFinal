using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineDiary.Classes
{
    public partial class Adicionar : System.Web.UI.Page
    {
        private DisciplinaContext disciplina_context = new DisciplinaContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina { Nome = txt_nome.Text };
            disciplina_context.InsertOrUpdate(disciplina);

            //string nome_disciplina = txt_nome.Text;
            ////this.disciplina = new Disciplina(0, nome_disciplina);
            ////string feedback_cadastro = disciplina.Cadastrar_Disciplina(nome_disciplina);
            //if (feedback_cadastro == "OK")
            //{
            //    lbl_feedback.ForeColor = Color.Green;
            //    lbl_feedback.Visible = true;
            //    lbl_feedback.Text = "Disciplina cadastrada com sucesso!";
            //}
            //else
            //{
            //    lbl_feedback.ForeColor = Color.Red;
            //    lbl_feedback.Visible = true;
            //    lbl_feedback.Text = feedback_cadastro;
            //}
        }
    }
}