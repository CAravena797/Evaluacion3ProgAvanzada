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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = LecturasDAL.GetInstancia();
        private IMedidoresDAL medidoresDAL = MedidoresDAL.GetInstancia();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> listaMedidores = medidoresDAL.ObtenerMedidores();
                this.medidorDdl.DataSource = listaMedidores;
                this.medidorDdl.DataTextField = "Id";
                this.medidorDdl.DataValueField = "Id";
                this.medidorDdl.DataBind();
            }
        }

        protected void ingresarLecturaBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int medidorId = Convert.ToInt32(this.medidorDdl.SelectedValue);
                string diaMesAño = this.calendarioLectura.SelectedDate.ToShortDateString();
                string[] arr = diaMesAño.Split('-');
                string hora = this.horaTxt.Text.Trim();
                string minuto = this.minutosTxt.Text.Trim();
                DateTime fecha = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]), Convert.ToInt32(hora), Convert.ToInt32(minuto), 0);
                double valor = Convert.ToDouble(this.valorTxt.Text.Trim());

                Lectura lectura = new Lectura()
                {
                    MedidorId = medidorId,
                    Fecha = fecha,
                    Valor = valor
                };
                lecturasDAL.IngresarLectura(lectura);
                this.ingresarLecturaMsj.Text = "Lectura ingresada";
                Response.Redirect("MostrarLecturas.aspx");
            }
        }
    }
}