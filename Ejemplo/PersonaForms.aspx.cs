using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Ejemplo
{
    public partial class PersonaForms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Id"] != null)
            {
                int id = int.Parse(Request.QueryString["Id"].ToString());
                List<Persona> temporal = (List<Persona>)Session["listaPersona"];
                Persona seleccionado = temporal.Find(x => x.Id == id);
                txtId.Text = seleccionado.Id.ToString();
                txtId.ReadOnly = true;
                txtNombre.Text = seleccionado.Nombre;
                txtEdad.Text = seleccionado.Edad.ToString();
                calFechaNac.Text = seleccionado.FechaNacimiento.ToString();
                chkCasado.Checked = seleccionado.Casado;


            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona a = new Persona();
            a.Id = int.Parse(txtId.Text);
            a.Nombre = txtNombre.Text;
            a.Edad = int.Parse(txtEdad.Text);
            a.FechaNacimiento = DateTime.Parse(calFechaNac.Text);
            a.Casado = chkCasado.Checked;

            if (rdbSiArgentino.Checked)
                a.Argentino = true;
            else if (rdbNoArgentino.Checked)
                a.Argentino = false;

            //a la base de datos segun el metodo...
            //recuperar los datos para agregar la persona a la lista
            //forma corta:
            //((List<Persona>)Session["listaPersona"]).Add(a);

            //forma larga:
            List<Persona> temporal = (List<Persona>)Session["listaPersona"];
            temporal.Add(a);

            Response.Redirect("Default.aspx");
        }
    }
}