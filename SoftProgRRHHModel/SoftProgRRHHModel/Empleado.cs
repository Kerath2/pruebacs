using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgRRHHModel
{
    public class Empleado : Persona
    {
        private Area area;
        private string cargo;
        private bool activo;

        public Area Area { get => area; set => area = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
