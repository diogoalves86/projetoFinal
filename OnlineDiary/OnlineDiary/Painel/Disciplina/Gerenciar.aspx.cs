﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineDiary.Classes
{
    public partial class Gerenciar : System.Web.UI.Page
    {
        private DisciplinaContext disciplina_context = new DisciplinaContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista_Disciplinas();
        }

        private List<Disciplina> Lista_Disciplinas()
        {
            List<Disciplina> disciplinas = disciplina_context.Lista_Disciplinas().ToList();
            return disciplinas;
        }
    }
}