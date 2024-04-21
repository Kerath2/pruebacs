using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftProgRRHHModel
{
    public class Persona
    {
        private int idPersona;
        private int dni;
        private string nombre;
        private string apellidoPaterno;
        private char genero;
        private DateTime fechanacimiento;

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
    }
}
