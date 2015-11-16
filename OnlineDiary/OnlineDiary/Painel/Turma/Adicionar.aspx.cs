using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineDiary.Classes;


namespace OnlineDiary.Classes.Painel.TurmaTela
{
    public partial class Adicionar : System.Web.UI.Page
    {
        private TurmaContext turma_context = new TurmaContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Cadastra_Turma()
        {
            //try
            //{
            //    Turma turma = new Turma { Nome = txt_nome.Text };
            //    turma_context.InsertOrUpdate(turma);
            //    lbl_feedback.ForeColor = Color.Green;
            //    lbl_feedback.Text = "Disciplina cadastrada com sucesso!";
            //}
            //catch (Exception ex)
            //{
            //    lbl_feedback.ForeColor = Color.Red;
            //    lbl_feedback.Text = ex.Message;
            //}
        }
    }
}