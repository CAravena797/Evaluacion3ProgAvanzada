using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev3Model.DAL
{
    public class LecturasDAL : ILecturasDAL
    {
        private static List<Lectura> listalecturas = new List<Lectura>()
           {
                new Lectura() { MedidorId = 1 , Fecha = new DateTime (2022,04,25,14,36,00), Valor = 467},
                new Lectura() { MedidorId = 1 , Fecha = new DateTime (2022,06,16,03,36,00), Valor = 300},
                new Lectura() { MedidorId = 1 , Fecha = new DateTime (2022,05,10,03,50,00), Valor = 223},
                new Lectura() { MedidorId = 1 , Fecha = new DateTime (2022,04,12,13,40,00), Valor = 580},
                new Lectura() { MedidorId = 1 , Fecha = new DateTime (2022,09,07,19,00,00), Valor = 122}
           };

        private LecturasDAL()
        {

        }

        private static LecturasDAL instancia;

        public static ILecturasDAL GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new LecturasDAL();
            }
            return instancia;
        }

        public void IngresarLectura(Lectura lectura)
        {
            listalecturas.Add(lectura);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return listalecturas;
        }
    }
}
