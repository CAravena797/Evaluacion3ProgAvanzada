using Ev3Model;
using Ev3Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion3Web
{
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = MedidoresDAL.GetInstancia();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Medidor> listaMedidores = medidoresDAL.ObtenerMedidores();
            this.mostrarLecturaDdl.DataSource = listaMedidores;
            this.mostrarLecturaDdl.DataTextField = "Id";
            this.mostrarLecturaDdl.DataValueField = "Id";
            this.mostrarLecturaDdl.DataBind();
        }

        protected void mostrarLecturaDdl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}