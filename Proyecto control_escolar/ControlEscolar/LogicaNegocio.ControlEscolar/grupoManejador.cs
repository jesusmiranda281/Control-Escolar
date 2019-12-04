using System;
using System.Collections.Generic;
using System.Linq;
using AccesoDatos.ControlEscolar;
using Entidades.ControlEscolar;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ControlEscolar
{
    public class grupoManejador
    {
        private grupoAccesoaDatos _gruposAccesoaDatos = new grupoAccesoaDatos();
        public void Guardar(Grupos grupos)
        {
            _gruposAccesoaDatos.Guardar(grupos);
        }
        public void Eliminar(int Idmateria)
        {
            //eliminar
            _gruposAccesoaDatos.Eliminar(Idmateria);
        }
        public List<Grupos> GetGrupos()
        {
            var listgrupos = _gruposAccesoaDatos.GetGrupos();
            //lenar lista
            return listgrupos;
        }
        public List<Alumnos> GetAlumnos(string filtro)
        {
            var listalumnos = _gruposAccesoaDatos.GetAlumnos(filtro);
            //lenar lista
            return listalumnos;
        }
    }
}
