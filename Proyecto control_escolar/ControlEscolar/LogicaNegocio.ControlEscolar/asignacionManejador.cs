using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio.ControlEscolar
{
    public class asignacionManejador
    {
        private asignacionAccesoaDatos _asignacionAccesoaDatos = new asignacionAccesoaDatos();
        public void Guardar(vista_asignacion asignacion)
        {
            _asignacionAccesoaDatos.Guardar(asignacion);
        }
        public void Eliminar(int Idmateria)
        {
            //eliminar
            _asignacionAccesoaDatos.Eliminar(Idmateria);
        }
        public List<vista_asignacion> GetAsignacion()
        {
            var listasignacion = _asignacionAccesoaDatos.GetAsignacion();
            //lenar lista
            return listasignacion;
        }
        public List<vista_asignacion> GetAsignaciones(string filtro)
        {
            var listasignacion = _asignacionAccesoaDatos.GetAsignaciones(filtro);
            //lenar lista
            return listasignacion;
        }
        public List<profesores> GetProfesores(ComboBox filtro)
        {
            var listprofesores = _asignacionAccesoaDatos.GetProfesores(filtro);
            //lenar lista
            return listprofesores;
        }
        public List<Materias> GetMaterias(ComboBox filtro)
        {
            var listmaterias = _asignacionAccesoaDatos.Combomaterias(filtro);
            //lenar lista
            return listmaterias;
        }
        public List<Grupos> GetGrupo(ComboBox filtro)
        {
            var listgrupo = _asignacionAccesoaDatos.GetGrupos(filtro);
            //lenar lista
            return listgrupo;
        }
    }
}
