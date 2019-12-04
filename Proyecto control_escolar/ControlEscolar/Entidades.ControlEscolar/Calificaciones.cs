using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Calificaciones
    {
        private int _idcalificacion;
        private string _grupo;
        private string _nombre;
        private string _apellidopaterno;
        private string _apellidomaterno;
        private double _primero;
        private double _segundo;
        private double _tercero;
        private double _cuarto;
        private double _promedio;

        public int Idcalificacion { get => _idcalificacion; set => _idcalificacion = value; }
        public string Grupo { get => _grupo; set => _grupo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidopaterno { get => _apellidopaterno; set => _apellidopaterno = value; }
        public string Apellidomaterno { get => _apellidomaterno; set => _apellidomaterno = value; }
        public double Primero { get => _primero; set => _primero = value; }
        public double Segundo { get => _segundo; set => _segundo = value; }
        public double Tercero { get => _tercero; set => _tercero = value; }
        public double Cuarto { get => _cuarto; set => _cuarto = value; }
        public double Promedio { get => _promedio; set => _promedio = value; }
    }
}
