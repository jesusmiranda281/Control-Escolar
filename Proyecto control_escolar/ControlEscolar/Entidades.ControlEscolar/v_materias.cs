using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class v_materias
    {
        private int _idmateria;
        private string _numerocontrol;
        private string _materia;

        public int Idmateria { get => _idmateria; set => _idmateria = value; }
        public string Numerocontrol { get => _numerocontrol; set => _numerocontrol = value; }
        public string Materia { get => _materia; set => _materia = value; }
    }
}
