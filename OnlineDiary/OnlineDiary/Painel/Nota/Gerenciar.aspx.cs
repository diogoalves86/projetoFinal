using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineDiary.Classes;

namespace OnlineDiary.Classes.Painel.NotaTela
{
    public partial class Gerenciar : System.Web.UI.Page
    {
        private NotaContext nota_context = new NotaContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            Listar_Notas();
        }

        private void Listar_Notas()
        {
            List<Nota> notas = nota_context.Listar_Notas().ToList();
            Preenche_Notas(notas);
        }

        private void Preenche_Notas(List<Nota> notas)
        {
            TableRow tRow = new TableRow();
            foreach (var nota in notas)
            {
                TableCell tCell = new TableCell();
                tCell.Text = nota.primeira_certificação.ToString();
                tRow.Cells.Add(tCell);

                TableCell tCell2 = new TableCell();
                tCell2.Text = nota.segunda_certificação.ToString();
                tRow.Cells.Add(tCell2);

                TableCell tCell3 = new TableCell();
                tCell3.Text = nota.terceira_certificação.ToString();
                tRow.Cells.Add(tCell3);

                TableCell tCell4 = new TableCell();
                tCell4.Text = nota.primeira_recuperacao.ToString();
                tRow.Cells.Add(tCell4);

                TableCell tCell5 = new TableCell();
                tCell5.Text = nota.segunda_recuperacao.ToString();
                tRow.Cells.Add(tCell5);

                TableCell tCell6 = new TableCell();
                tCell6.Text = nota.terceira_certificação.ToString();
                tRow.Cells.Add(tCell6);

                tbl_notas.Rows.Add(tRow);
            }
        }
    }
}