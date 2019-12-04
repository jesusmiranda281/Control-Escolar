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
    public class asignacionAccesoaDatos
    {
        coneccionAccesoDatos conexion;
        public asignacionAccesoaDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public void Guardar(vista_asignacion asignacion)
        {
            //insertar
            if (asignacion.Idasignacion == 0)
            {
                string consulta = string.Format("insert into asignacion values(null,'{0}', '{1}', '{2}')",
                asignacion.Profesor, asignacion.Materia, asignacion.Grupo);
                conexion.Ejecutarconsulta(consulta);
            }
            else
            {
                string consulta = string.Format("Update asignacion set profesor = '{0}', materia = '{1}', grupo = '{2}' where Idasignacion = {3}",
                asignacion.Profesor , asignacion.Materia, asignacion.Grupo, asignacion.Idasignacion);
                conexion.Ejecutarconsulta(consulta);
            }
        }
        public void Eliminar(int id)
        {
            //eliminar
            string consulta = string.Format("delete from asignacion where Idasignacion = '{0}'", id);
            conexion.Ejecutarconsulta(consulta);
        }
        public List<vista_asignacion> GetAsignacion()
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listasignacion = new List<vista_asignacion>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from v_asignacion";
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
            //HardCodear
            //lenar lista
            return listasignacion;
        }
        public List<vista_asignacion> GetAsignaciones(string filtro)
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
            //HardCodear
            //lenar lista
            return listasignacion;
        }
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
        public List<profesores> GetProfesores(ComboBox combo)
        {
            var listprofesores = new List<profesores>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from profesores";
            ds = conexion.Obtenerdatos(consulta, "profesores");
            combo.DataSource = ds.Tables[0];
            combo.DisplayMember = "nombre";
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                //string datos = string.Format("{0}", row.ItemArray[0]);
                //combo.Items.Add(datos);
                var profesores = new profesores
                {
                    //Idgrupo = Convert.ToInt32(row["Idgrupo"]),
                    //Grupo = row["grupo"].ToString(),
                };
                listprofesores.Add(profesores);
            }
            //lenar lista
            return listprofesores;
        }
        public List<Materias> Combomaterias(ComboBox combo)
        {
            var listmaterias = new List<Materias>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from materias";
            ds = conexion.Obtenerdatos(consulta, "materias");
            combo.DataSource = ds.Tables[0];
            combo.DisplayMember = "nombre";
            //combo.ValueMember = "Idestudio";
            //combo.DataSource = dt;
            var dt = new DataTable();
            dt = ds.Tables[0];
            //combo.DataSource = dt;
            foreach (DataRow row in dt.Rows)
            {
                //string datos = string.Format("{0}", row.ItemArray[0]);
                //combo.Items.Add(datos);
                var materias = new Materias
                {
                    //Nombre = row["nombre"].ToString(),
                };
                listmaterias.Add(materias);
            }
            //lenar lista
            return listmaterias;
        }
    }
}
