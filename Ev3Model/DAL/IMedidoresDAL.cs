using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev3Model.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidor> ObtenerMedidores();
        void AgregarMedidores(Medidor medidor);
    }
}
