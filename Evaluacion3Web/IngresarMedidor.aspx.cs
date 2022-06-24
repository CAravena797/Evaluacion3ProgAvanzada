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
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = MedidoresDAL.GetInstancia();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarMedidorBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) 
            {
                this.medidorRepetidoMsj.Text = "";
                this.ingresarMedidorMsj.Text = "";
                List<Medidor> listaMedidores = medidoresDAL.ObtenerMedidores();
                int id = Convert.ToInt32(this.numSerieTxt.Text.Trim());
                string tipo = this.tipoMedidorDdl.SelectedValue;
                bool idValida = true;
                foreach (Medidor medidor in listaMedidores)
                {
                    if(medidor.Id == id){
                        this.ingresarMedidorMsj.Text = "";
                        this.medidorRepetidoMsj.Text = "Ese numero de serie ya existe";
                        idValida = false;
                        break;
                    }
                }
                if (idValida)
                {
                    Medidor medidorNuevo = new Medidor()
                    {
                        Id = id,
                        Tipo = tipo
                    };

                    medidoresDAL.AgregarMedidores(medidorNuevo);

                    this.ingresarMedidorMsj.Text = "Medidor Ingresado";
                    Response.Redirect("verMedidores.aspx");
                }
            }
                
            

        }

        protected void numSerieTxtCus_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                Convert.ToInt32(args.Value.Trim());
                args.IsValid = true;
            }
            catch (Exception)
            {
                args.IsValid = false;
            }
        }
    }
}