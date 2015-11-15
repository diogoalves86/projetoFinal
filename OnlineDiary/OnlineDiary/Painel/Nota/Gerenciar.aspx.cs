using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineDiary.Classes
{
    public partial class Gerenciar : System.Web.UI.Page
    {
        private NotaContext nota_context = new NotaContext();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private List<Nota> Listar_Notas()
        {
            List<Nota> notas = nota_context.Listar_Notas().ToList();
            return notas;
        }
    }
}