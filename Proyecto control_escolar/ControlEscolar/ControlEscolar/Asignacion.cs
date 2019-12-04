using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using LogicaNegocio.ControlEscolar;
using Entidades.ControlEscolar;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class Asignacion : Form
    {
        private asignacionManejador _asignacionManejador;
        private vista_asignacion _asignacion;
        public Asignacion()
        {
            InitializeComponent();
            _asignacion = new vista_asignacion();
            _asignacionManejador = new asignacionManejador();
        }

        private void Asignacion_Load(object sender, EventArgs e)
        {
            Buscarasignacion();
            controlcajas(false);
            controlbotones(true,false,false,true);
            //_asignacionManejador.GetMaterias(cmbMateria);
            //_asignacionManejador.GetProfesores(cmbProfesor);
            //_asignacionManejador.GetGrupo(cmbGrupo);
        }
        private void controlbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            //btnCancelar.Enabled = cancelar;
            //btnEliminar.Enabled = eliminar;
        }
        private void controlcajas(bool activar)
        {
            
        }
        private void limpiar()
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlbotones(false, true, true, true);
            controlcajas(true);
            
            Profesores p = new Profesores();
            p.ShowDialog();
        }
        private void Buscarasignacion()
        {
            dtgAsignacion.DataSource = _asignacionManejador.GetAsignacion();
            dtgAsignacion.AutoResizeColumns();
        }
        private void guardarasignacion()
        {
            _asignacionManejador.Guardar(new vista_asignacion
            {
              /*  Idasignacion = Convert.ToInt32(lblId.Text),
                Profesor = cmbProfesor.Text,
                Materia = cmbMateria.Text,
                Grupo = cmbGrupo.Text*/
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true);
            controlcajas(false);
            try
            {
                guardarasignacion();
                Buscarasignacion();
                limpiar();
                //para guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void eliminar()
        {
            var Idasignacion = dtgAsignacion.CurrentRow.Cells["Idasignacion"].Value;
            _asignacionManejador.Eliminar(Convert.ToInt32(Idasignacion));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminar();
                    Buscarasignacion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Modificar()
        {
            controlcajas(true);
            controlbotones(false, true, true, false);
           // lblId.Text = dtgAsignacion.CurrentRow.Cells["Idasignacion"].Value.ToString();
            //cmbProfesor.Text = dtgAsignacion.CurrentRow.Cells["profesor"].Value.ToString();
            //cmbMateria.Text = dtgAsignacion.CurrentRow.Cells["materia"].Value.ToString();
            //cmbGrupo.Text = dtgAsignacion.CurrentRow.Cells["grupo"].Value.ToString();
            
        }

        private void dtgAsignacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void dtgAsignacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificar();
                Buscarasignacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true);
            controlcajas(false);
            limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAsignacion(txtBuscar.Text);
        }
        private void BuscarAsignacion(string filtro)
        {
            dtgAsignacion.DataSource = _asignacionManejador.GetAsignaciones(filtro);
            dtgAsignacion.AutoResizeColumns();
        }
    }
}
