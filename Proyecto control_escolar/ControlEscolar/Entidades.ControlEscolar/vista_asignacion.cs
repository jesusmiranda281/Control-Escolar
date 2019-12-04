using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class vista_asignacion
    {
        private int _Idasignacion;
        private string _numerocontrol;
        private string _profesor;
        private string _apellidopaterno;
        private string _apellidomaterno;
        private string _materia;
        private string _grupo;

        public int Idasignacion { get => _Idasignacion; set => _Idasignacion = value; }
        public string Numerocontrol { get => _numerocontrol; set => _numerocontrol = value; }
        public string Profesor { get => _profesor; set => _profesor = value; }
        public string Apellidopaterno { get => _apellidopaterno; set => _apellidopaterno = value; }
        public string Apellidomaterno { get => _apellidomaterno; set => _apellidomaterno = value; }
        public string Materia { get => _materia; set => _materia = value; }
        public string Grupo { get => _grupo; set => _grupo = value; }


        // public string Apellidopaterno { get => _apellidopaterno; set => _apellidopaterno = value; }
        //public string Apellidomaterno { get => _apellidomaterno; set => _apellidomaterno = value; }
        //public string Clave { get => _clave; set => _clave = value; }
        //public string Numerocontrol { get => _numerocontrol; set => _numerocontrol = value; }
    }
}
