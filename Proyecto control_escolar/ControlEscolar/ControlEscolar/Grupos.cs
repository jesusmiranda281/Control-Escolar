using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.ControlEscolar;
using Entidades.ControlEscolar;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class Grupos : Form
    {
        private grupoManejador _gruposManejador;
        private Entidades.ControlEscolar.Grupos _grupos;
        public Grupos()
        {
            InitializeComponent();
            _gruposManejador = new grupoManejador();
            _grupos = new Entidades.ControlEscolar.Grupos();
        }
        private void Grupos_Load(object sender, EventArgs e)
        {
            BuscarGrupo();
            controlcajas(false);
        }
        private void controlbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
        }
        private void controlcajas(bool activar)
        {
            txtGrupo.Enabled = activar;
        }
        private void limpiar()
        {
            txtGrupo.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlbotones(false, true, true, true);
            controlcajas(true);
            txtGrupo.Focus();
        }
        private void BuscarGrupo()
        {
            dtgGrupos.DataSource = _gruposManejador.GetGrupos();
            dtgGrupos.AutoResizeColumns();
        }
        private void guardargrupos()
        {
            _gruposManejador.Guardar(new Entidades.ControlEscolar.Grupos
            {
                Idgrupo = Convert.ToInt32(lblId.Text),
                Grupo = txtGrupo.Text
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true);
            controlcajas(false);
            try
            {
                guardargrupos();
                BuscarGrupo();
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
            var Idgrupo = dtgGrupos.CurrentRow.Cells["Idgrupo"].Value;
            _gruposManejador.Eliminar(Convert.ToInt32(Idgrupo));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminar();
                    BuscarGrupo();
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
            lblId.Text = dtgGrupos.CurrentRow.Cells["Idgrupo"].Value.ToString();
            txtGrupo.Text = dtgGrupos.CurrentRow.Cells["grupo"].Value.ToString();
            veralumnos();
        }

        private void dtgGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificar();
                BuscarGrupo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void veralumnos()
        {
            dtgAlumnos.DataSource = _gruposManejador.GetAlumnos(txtGrupo.Text);
            dtgAlumnos.AutoResizeColumns();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true);
            controlcajas(false);
            limpiar();
        }
    }
}
