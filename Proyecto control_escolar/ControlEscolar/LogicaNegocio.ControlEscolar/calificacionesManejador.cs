using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio.ControlEscolar
{
    public class calificacionesManejador
    {
        private calificacionesAccesoDatos _calificacionesAccesoaDatos = new calificacionesAccesoDatos();
        public void Guardar(v_calificaciones c)
        {
            _calificacionesAccesoaDatos.Guardar(c);
        }
        public void Eliminar(int Idmateria)
        {
            //eliminar
            _calificacionesAccesoaDatos.Eliminar(Idmateria);
        }
        public List<v_alumnos> Getalumnos(string filtro)
        {
            var listalumnos = _calificacionesAccesoaDatos.GetAlumnos(filtro);
            //lenar lista
            return listalumnos;
        }
        public List<Grupos> GetGrupo(ComboBox filtro)
        {
            var listgrupo = _calificacionesAccesoaDatos.GetGrupos(filtro);
            //lenar lista
            return listgrupo;
        }
        public List<v_materias> GetAlumno(string filtro, ComboBox cmbmaterias)
        {
            var listestudio = _calificacionesAccesoaDatos.GetAlumno(filtro, cmbmaterias);
            //lenar lista
            return listestudio;
        }
        public List<v_calificaciones> Getcalificaciones(string filtro)
        {
            var listcalificaciones = _calificacionesAccesoaDatos.GetCalificaciones(filtro);
            //lenar lista
            return listcalificaciones;
        }
    }
}
