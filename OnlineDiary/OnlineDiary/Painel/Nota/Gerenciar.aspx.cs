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
            nota_context.Pega_Nota_Aluno("489e7340-4015-4e0e-ad04-7632ed72f5ab");
        }

        private void Listar_Notas()
        {
            List<Nota> notas = nota_context.Listar_Notas().ToList();
            Preenche_Notas(notas);
        }

        private void Preenche_Notas(List<Nota> notas)
        {
            foreach (var nota in notas)
            {
                TableRow tRow = new TableRow();
                tbl_notas.Rows.Add(tRow);
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

                TableCell tCell7 = new TableCell();
                tCell7.Controls.Add(btn_apaga_nota);
                tRow.Cells.Add(tCell7);

                Button btn = new Button();
                btn.Text = "Apagar";
                tCell7.Controls.Add(btn);
            }
        }

        protected void btn_apaga_nota_Click(object sender, EventArgs e)
        {

        }
    }
}