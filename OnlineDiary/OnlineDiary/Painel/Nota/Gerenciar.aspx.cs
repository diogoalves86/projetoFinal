using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineDiary.Classes;

namespace OnlineDiary.Classes
{
    public partial class Gerenciar : System.Web.UI.Page
    {
        private NotaContext nota_context = new NotaContext();
        

        private List<Nota> Listar_Notas()
        {
            List<Nota> notas = nota_context.Listar_Notas().ToList();
            return notas;
        }
    }
}