using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class v_alumnos
    {
        private int _idalumnos;
        private string _grupo;
        private string _numerocontrol;
        private string _nombre;
        private string _apellidopaterno;
        private string _apellidomaterno;

        public int Idalumnos { get => _idalumnos; set => _idalumnos = value; }
        public string Grupo { get => _grupo; set => _grupo = value; }
        public string Numerocontrol { get => _numerocontrol; set => _numerocontrol = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidopaterno { get => _apellidopaterno; set => _apellidopaterno = value; }
        public string Apellidomaterno { get => _apellidomaterno; set => _apellidomaterno = value; }
    }
}
