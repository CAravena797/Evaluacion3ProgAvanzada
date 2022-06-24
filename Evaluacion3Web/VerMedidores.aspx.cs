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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = MedidoresDAL.GetInstancia();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                actualizarGrid();
            }
        }

        private void actualizarGrid()
        {
            List<Medidor> listaMedidores = medidoresDAL.ObtenerMedidores();
            List<Medidor> listaMedidoresFiltrada = new List<Medidor>();
            string filtro = this.verMedidorDdl.SelectedValue;
            if (filtro != "no")
            {
                foreach (Medidor medidor in listaMedidores)
                {
                    if (medidor.Tipo == filtro)
                    {
                        listaMedidoresFiltrada.Add(medidor);
                    }
                }
                this.medidoresGrid.DataSource = listaMedidoresFiltrada;
                this.medidoresGrid.DataBind();
            }
            else
            {
                this.medidoresGrid.DataSource = listaMedidores;
                this.medidoresGrid.DataBind();
            }
            
        }

        protected void verMedidorDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
}