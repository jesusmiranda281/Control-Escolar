using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.ControlEscolar
{
    public class AlumnoAccesoDatos
    {
        coneccionAccesoDatos conexion;
        public AlumnoAccesoDatos()
        {
            conexion = new coneccionAccesoDatos("localhost", "root", "", "empresa", 3306);
        }
        public void Guardar(Alumnos alumnos)
        {
            if (alumnos.Idalumnos == 0)
            {
                //insertar
                string consulta = string.Format("insert into alumnos values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                alumnos.Numerocontrol, alumnos.Nombre, alumnos.Apellidopaterno, alumnos.Apellidomaterno, alumnos.Fechanacimiento, alumnos.Domicilio,
                alumnos.Email, alumnos.Sexo, alumnos.Estado, alumnos.Ciudad, alumnos.Grupo);
                conexion.Ejecutarconsulta(consulta);
            }
            else
            {
                //update o que lo modifique
                string consulta = string.Format("Update alumnos set numerocontrol = '{0}', nombre = '{1}', apellidopaterno = '{2}', apellidomaterno = '{3}', fechanacimiento = '{4}', domicilio = '{5}', email = '{6}', sexo = '{7}', estado = '{8}', ciudad = '{9}', grupo = '{10}' where Idalumnos = {11}",
                alumnos.Numerocontrol, alumnos.Nombre, alumnos.Apellidopaterno, alumnos.Apellidomaterno, alumnos.Fechanacimiento,
                alumnos.Domicilio, alumnos.Email, alumnos.Sexo, alumnos.Estado, alumnos.Ciudad, alumnos.Grupo, alumnos.Idalumnos);
                conexion.Ejecutarconsulta(consulta);
            }
        }
        public void Eliminar(int Idalumnos)
        {
            //eliminar
            string consulta = string.Format("delete from alumnos where Idalumnos = {0}", Idalumnos);
            conexion.Ejecutarconsulta(consulta);
        }
        public List<Alumnos> GetAlumnos(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listalumnos = new List<Alumnos>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from alumnos where nombre like '%" + filtro + "%'";
            ds = conexion.Obtenerdatos(consulta, "alumnos");
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
        public void Guardarmaterias(v_materias materias)
        {
            if (materias.Idmateria == 0)
            {
                //insertar
                string consulta = string.Format("insert into materialumno values(null,'{0}','{1}')",
                materias.Numerocontrol, materias.Materia);
                conexion.Ejecutarconsulta(consulta);
            }
            else
            {
                //update o que lo modifique
                string consulta = string.Format("Update materialumno set numerocontrol = '{0}', materias = '{1}' where Idmateralu = {2}",
                materias.Numerocontrol, materias.Materia, materias.Idmateria);
                conexion.Ejecutarconsulta(consulta);
            }
        }
        public List<v_materias> GetMateria(string filtro)
        {
            //List<Usuario> listusuario = new List<Usuario>();
            var listmaterias = new List<v_materias>(); //la variable var es generica
            var ds = new DataSet();
            string consulta = "Select * from materialumno where numerocontrol = '"+filtro+"'";
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
    }
}
