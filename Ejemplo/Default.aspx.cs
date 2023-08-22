using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Ejemplo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaPersona"] == null)
            {
                PersonaNegocio negocio = new PersonaNegocio();
                Session.Add("listaPersona", negocio.listar());
            }

            dgvPersonas.DataSource = Session["listaPersona"];
            dgvPersonas.DataBind();
        }

        protected void dgvPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var algo = dgvPersonas.SelectedRow.Cells[0].Text;
            Response.Redirect("PersonaForms.aspx?Id=0" + algo);
        }
    }
}