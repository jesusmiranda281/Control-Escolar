using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades.ControlEscolar;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos.ControlEscolar
{
    public class calificacionesAccesoDatos
    {
        coneccionAccesoDatos conexion;
        public calificacionesAccesoDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public void Guardar(v_calificaciones calificaciones)
        {
            //insertar
            if (calificaciones.Idcalificacion == 0)
            {
                string consulta = string.Format("insert into calificaciones values(null,'{0}', '{1}', '{2}','{3}','{4}','{5}')",
                calificaciones.Numerocontrol, calificaciones.Materia, calificaciones.Primero, calificaciones.Segundo, calificaciones.Tercero, calificaciones.Cuarto);
                conexion.Ejecutarconsulta(consulta);
            }
            else
            {
                string consulta = string.Format("Update calificaciones set alumno = '{0}', primero = '{1}', segundo = '{2}', tercero = '{3}', cuarto = '{4}' where Idcalificacion = {5}",
                calificaciones.Materia, calificaciones.Primero, calificaciones.Segundo, calificaciones.Tercero, calificaciones.Cuarto, calificaciones.Idcalificacion);
                conexion.Ejecutarconsulta(consulta);
            }
        }
        public void Eliminar(int id)
        {
            //eliminar
            string consulta = string.Format("delete from calificaciones where Idcalificacion = '{0}'", id);
            conexion.Ejecutarconsulta(consulta);
        }
        public List<v_calificaciones> GetCalificaciones(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listcalificaciones = new List<v_calificaciones>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from v_calificaciones where numerocontrolalumno like '%"+filtro+"%'";
            ds = conexion.Obtenerdatos(consulta, "v_calificaciones");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var calificaciones = new v_calificaciones
                {
                    Idcalificacion = Convert.ToInt32(row["Idcalificacion"]),
                    Numerocontrol = row["numerocontrolalumno"].ToString(),
                    Materia = row["alumno"].ToString(),
                    Primero = Convert.ToDouble(row["Primero"]),
                    Segundo = Convert.ToDouble(row["segundo"]),
                    Tercero = Convert.ToDouble(row["tercero"]),
                    Cuarto = Convert.ToDouble(row["cuarto"]),
                    Promedio = Convert.ToDouble(row["Promedio"])
                    /* Primero = Convert.ToDouble(row["primero"]),
                     Segundo = Convert.ToDouble(row["apellidopaterno"]),
                     Tercero = Convert.ToDouble(row["apellidomaterno"]),
                     Cuarto = Convert.ToDouble(row["materia"]),
                     Promedio = Convert.ToDouble(row["promedio"])*/
                };
                listcalificaciones.Add(calificaciones);
            }
            //HardCodear
            //lenar lista
            return listcalificaciones;
        }
        public List<v_alumnos> GetAlumnos(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listalumnos = new List<v_alumnos>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from v_alumnos where grupo like '%" + filtro + "%'";
            ds = conexion.Obtenerdatos(consulta, "v_alumnos");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var alumno = new v_alumnos
                {
                    Idalumnos = Convert.ToInt32(row["Idalumnos"]),
                    Grupo = row["grupo"].ToString(),
                    Numerocontrol = row["numerocontrol"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Apellidopaterno = row["apellidopaterno"].ToString(),
                    Apellidomaterno = row["apellidomaterno"].ToString()
                   /* Primero = Convert.ToDouble(row["primero"]),
                    Segundo = Convert.ToDouble(row["apellidopaterno"]),
                    Tercero = Convert.ToDouble(row["apellidomaterno"]),
                    Cuarto = Convert.ToDouble(row["materia"]),
                    Promedio = Convert.ToDouble(row["promedio"])*/
                };
                listalumnos.Add(alumno);
            }
            //HardCodear
            //lenar lista
            return listalumnos;
        }
        public List<v_materias> GetMateria(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listmaterias = new List<v_materias>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from materialumno where numerocontrol = '" + filtro + "'";
            ds = conexion.Obtenerdatos(consulta, "materialumno");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var estudios = new v_materias
                {
                    Idmateria = Convert.ToInt32(row["Idmateralu"]),
                    Numerocontrol = row["numerocontrol"].ToString(),
                    Materia = row["materias"].ToString()
                    //Fkprofesor = row["fkprofesor"].ToString()
                };
                listmaterias.Add(estudios);
            }
            //HardCodear
            //lenar lista
            return listmaterias;
        }
        /* public List<vista_asignacion> GetAsignaciones(string filtro)
         {
             //List<Usuario> listusuario = new List<Usuario>();
             var listasignacion = new List<vista_asignacion>(); //la variable var es generica
             var ds = new DataSet();
             string consulta = "Select * from v_asignacion where nombre like '%" + filtro + "%'";
             ds = conexion.Obtenerdatos(consulta, "v_asignacion");
             var dt = new DataTable();
             dt = ds.Tables[0];
             foreach (DataRow row in dt.Rows)
             {
                 var asignacion = new vista_asignacion
                 {
                     Idasignacion = Convert.ToInt32(row["asignacion"]),
                     Numerocontrol = row["numerocontrol"].ToString(),
                     Profesor = row["nombre"].ToString(),
                     Apellidopaterno = row["apellidopaterno"].ToString(),
                     Apellidomaterno = row["apellidomaterno"].ToString(),
                     Materia = row["materia"].ToString(),
                     Grupo = row["grupo"].ToString()
                 };
                 listasignacion.Add(asignacion);
             }
         }*/
        public List<Grupos> GetGrupos(ComboBox combo)
        {
            var listgrupos = new List<Grupos>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from grupos";
            ds = conexion.Obtenerdatos(consulta, "grupos");
            combo.DataSource = ds.Tables[0];
            combo.DisplayMember = "grupo";
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                //string datos = string.Format("{0}", row.ItemArray[0]);
                //combo.Items.Add(datos);
                var grupos = new Grupos
                {
                    Idgrupo = Convert.ToInt32(row["Idgrupo"]),
                    Grupo = row["grupo"].ToString(),
                };
                listgrupos.Add(grupos);
            }
            //lenar lista
            return listgrupos;
        }
        public List<v_materias> GetAlumno(string filtro, ComboBox cmbmaterias)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listmaterias = new List<v_materias>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from materialumno where numerocontrol = '" + filtro + "'";
            ds = conexion.Obtenerdatos(consulta, "materialumno");
            cmbmaterias.DataSource = ds.Tables[0];
            cmbmaterias.DisplayMember = "materias";
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var estudios = new v_materias
                {
                    Idmateria = Convert.ToInt32(row["Idmateralu"]),
                    Numerocontrol = row["numerocontrol"].ToString(),
                    Materia = row["materias"].ToString()
                    //Fkprofesor = row["fkprofesor"].ToString()
                };
                listmaterias.Add(estudios);
            }
            //HardCodear
            //lenar lista
            return listmaterias;
        }
    }
}
