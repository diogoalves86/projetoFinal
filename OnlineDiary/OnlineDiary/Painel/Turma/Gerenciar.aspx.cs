using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineDiary.Classes;

namespace OnlineDiary.Classes.Painel.TurmaTela
{
    public partial class Gerenciar : System.Web.UI.Page
    {
        private TurmaContext turma_context = new TurmaContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private List<Turma> Lista_Turma()
        {
            List<Turma> turmas = turma_context.Lista_Turmas().ToList();
            return turmas;
        }
    }
}