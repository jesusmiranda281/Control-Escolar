using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.ControlEscolar;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace AccesoDatos.ControlEscolar
{
    public class grupoAccesoaDatos
    {
        coneccionAccesoDatos conexion;
        public grupoAccesoaDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public void Guardar(Grupos grupos)
        {
            //insertar
            if (grupos.Idgrupo == 0)
            {
                string consulta = string.Format("insert into grupos values(null,'{0}')",
                grupos.Grupo);
                conexion.Ejecutarconsulta(consulta);
            }
            else
            {
                string consulta = string.Format("Update grupos set grupo = '{0}' where Idgrupo = {1}",
                grupos.Grupo, grupos.Idgrupo);
                conexion.Ejecutarconsulta(consulta);
            }
        }
        public void Eliminar(int id)
        {
            //eliminar
            string consulta = string.Format("delete from grupos where Idgrupo = '{0}'", id);
            conexion.Ejecutarconsulta(consulta);
        }
        public List<Grupos> GetGrupos()
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listgrupos = new List<Grupos>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from grupos";
            ds = conexion.Obtenerdatos(consulta, "grupos");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var grupos = new Grupos
                {
                    Idgrupo = Convert.ToInt32(row["Idgrupo"]),
                    Grupo = row["grupo"].ToString()
                };
                listgrupos.Add(grupos);
            }
            //HardCodear
            //lenar lista
            return listgrupos;
        }
        public List<Alumnos> GetAlumnos(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listalumnos = new List<Alumnos>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from alumnos where grupo like '%" + filtro + "%'";
            ds = conexion.Obtenerdatos(consulta, "v_alumnos");
            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var alumnos = new Alumnos
                {
                    Idalumnos = Convert.ToInt32(row["Idalumnos"]),
                    Numerocontrol = row["numerocontrol"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Apellidopaterno = row["apellidopaterno"].ToString(),
                    Apellidomaterno = row["apellidomaterno"].ToString(),
                    Fechanacimiento = row["fechanacimiento"].ToString(),
                    Domicilio = row["domicilio"].ToString(),
                    Email = row["email"].ToString(),
                    Sexo = row["sexo"].ToString(),
                    Estado = row["estado"].ToString(),
                    Ciudad = row["ciudad"].ToString(),
                    Grupo = row["grupo"].ToString()
                };
                listalumnos.Add(alumnos);
            }
            //HardCodear
            //lenar lista
            return listalumnos;
        }
    }
}
