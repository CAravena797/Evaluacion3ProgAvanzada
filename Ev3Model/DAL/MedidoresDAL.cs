using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev3Model.DAL
{
    public class MedidoresDAL : IMedidoresDAL
    {
        private static List<Medidor> listaMedidores = new List<Medidor>()
           {
                new Medidor() { Id = 1 , Tipo = "tipo1"},
                new Medidor() { Id = 2 , Tipo = "tipo2"},
                new Medidor() { Id = 3 , Tipo = "tipo3"},
                new Medidor() { Id = 4 , Tipo = "tipo2"},
                new Medidor() { Id = 5 , Tipo = "tipo1"}
           };

        private MedidoresDAL()
        {

        }

        private static MedidoresDAL instancia;

        public static IMedidoresDAL GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new MedidoresDAL();
            }
            return instancia;
        }
        public List<Medidor> ObtenerMedidores()
        {
            return listaMedidores;
        }

        public void AgregarMedidores(Medidor medidor)
        {
            listaMedidores.Add(medidor);
        }
    }
}


