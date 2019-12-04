using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class v_calificaciones
    {
        private int _idcalificacion;
        private string _numerocontrol;
        private string _materia;
        private double _primero;
        private double _segundo;
        private double _tercero;
        private double _cuarto;
        private double _promedio;

        public int Idcalificacion { get => _idcalificacion; set => _idcalificacion = value; }
        public string Numerocontrol { get => _numerocontrol; set => _numerocontrol = value; }
        public string Materia { get => _materia; set => _materia = value; }
        public double Primero { get => _primero; set => _primero = value; }
        public double Segundo { get => _segundo; set => _segundo = value; }
        public double Tercero { get => _tercero; set => _tercero = value; }
        public double Cuarto { get => _cuarto; set => _cuarto = value; }
        public double Promedio { get => _promedio; set => _promedio = value; }
        
    }
}
