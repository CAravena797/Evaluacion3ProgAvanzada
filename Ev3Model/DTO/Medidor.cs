using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev3Model
{
    public class Medidor
    {
        private int id;
        private string tipo;

        public int Id { get => id; set => id=value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
