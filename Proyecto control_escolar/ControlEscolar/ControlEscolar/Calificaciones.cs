using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Office.Interop.Excel;
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
    public partial class Calificaciones : Form
    {
        int IndiceColumna = 0, IndiceFila = 0;
        private calificacionesManejador _calificacionManejador;
        private Entidades.ControlEscolar.Calificaciones _calificaciones;
        private Entidades.ControlEscolar.v_calificaciones _calificacion;
        public Calificaciones()
        {
            InitializeComponent();
            _calificacionManejador = new calificacionesManejador();
            _calificaciones = new Entidades.ControlEscolar.Calificaciones();
            _calificacion = new Entidades.ControlEscolar.v_calificaciones();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            Buscarcalificaciones();
            gpbCalificaciones.Visible = false;
            _calificacionManejador.GetGrupo(cmbGrupo);
            txtNocontrol.Visible = false;
        }
        private void controlbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            //btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            //btnCancelar.Enabled = cancelar;
            //btnEliminar.Enabled = eliminar;
        }
        private void controlcajas(bool activar)
        {

        }
        private void limpiar()
        {
            txtuno.Text = "";
            txtdos.Text = "";
            txttres.Text = "";
            txtcuatro.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlbotones(false, true, true, true);
            controlcajas(true);
        }
        private void Buscarcalificaciones()
        {
           dtgAlumnoss.DataSource = _calificacionManejador.Getcalificaciones(txtNocontrol.Text);
           dtgAlumnoss.AutoResizeColumns();
        }
        private void guardarcalificacion()
        {
            _calificacionManejador.Guardar(new Entidades.ControlEscolar.v_calificaciones
            {
                Idcalificacion = Convert.ToInt32(lbIds.Text),
                Numerocontrol = txtNocontrol.Text,
                Materia = cmbMaterias.Text,
                Primero = Convert.ToDouble(txtuno.Text),
                Segundo = Convert.ToDouble(txtdos.Text),
                Tercero = Convert.ToDouble(txttres.Text),
                Cuarto = Convert.ToDouble(txtcuatro.Text)
                //Numerocontrol = txtNocontrol.Text,
                //Primero = Convert.ToDouble(txtuno.Text),
                //Segundo = Convert.ToDouble(txtdos.Text),
                //Tercero = Convert.ToDouble(txttres.Text),
                //Cuarto = Convert.ToDouble(txtcuatro.Text)

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
                guardarcalificacion();
                Buscarcalificaciones();
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
            var Idcalificacion = dtgAlumnoss.CurrentRow.Cells["Idcalificacion"].Value;
            _calificacionManejador.Eliminar(Convert.ToInt32(Idcalificacion));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminar();
                    Buscarcalificaciones();
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
            lblId.Text = dtgcalificaciones.CurrentRow.Cells["Idalumnos"].Value.ToString();
            cmbGrupo.Text = dtgcalificaciones.CurrentRow.Cells["grupo"].Value.ToString();
            txtNocontrol.Text = dtgcalificaciones.CurrentRow.Cells["Numerocontrol"].Value.ToString();
            lblNumerocontrol.Text = dtgcalificaciones.CurrentRow.Cells["Numerocontrol"].Value.ToString();
            lblNombre.Text = dtgcalificaciones.CurrentRow.Cells["Nombre"].Value.ToString();
            lblPaterno.Text = dtgcalificaciones.CurrentRow.Cells["Apellidopaterno"].Value.ToString();
            lblMaterno.Text = dtgcalificaciones.CurrentRow.Cells["Apellidomaterno"].Value.ToString();
            //txtuno.Text = dtgcalificaciones.CurrentRow.Cells["primero"].Value.ToString();
            //txtdos.Text = dtgcalificaciones.CurrentRow.Cells["segundo"].Value.ToString();
            //txttres.Text = dtgcalificaciones.CurrentRow.Cells["tercero"].Value.ToString();
            //txtcuatro.Text = dtgcalificaciones.CurrentRow.Cells["cuarto"].Value.ToString();
            //cmbGrupo.Text = dtgAsignacion.CurrentRow.Cells["grupo"].Value.ToString();

        }
        private void Modificarcalificacion()
        {
            controlcajas(true);
            controlbotones(false, true, true, false);
            lbIds.Text = dtgAlumnoss.CurrentRow.Cells["Idcalificacion"].Value.ToString();
            cmbMaterias.Text = dtgAlumnoss.CurrentRow.Cells["Materia"].Value.ToString();
            //txtNocontrol.Text = dtgAlumnoss.CurrentRow.Cells["Numerocontrol"].Value.ToString();
            txtuno.Text = dtgAlumnoss.CurrentRow.Cells["primero"].Value.ToString();
            txtdos.Text = dtgAlumnoss.CurrentRow.Cells["segundo"].Value.ToString();
            txttres.Text = dtgAlumnoss.CurrentRow.Cells["tercero"].Value.ToString();
            txtcuatro.Text = dtgAlumnoss.CurrentRow.Cells["cuarto"].Value.ToString();
            //cmbGrupo.Text = dtgAlumnoss.CurrentRow.Cells["grupo"].Value.ToString();

        }

        private void dtgcalificaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                Modificar();
                Buscarcalificaciones();
                gpbCalificaciones.Visible = true;
                _calificacionManejador.GetAlumno(txtNocontrol.Text, cmbMaterias);
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
            gpbCalificaciones.Visible = false;
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgcalificaciones.DataSource = _calificacionManejador.Getalumnos(cmbGrupo.Text);
            dtgcalificaciones.AutoResizeColumns();
        }

        private void dtgcalificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //gpbCalificaciones.Visible = false;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(dtgAlumnoss);
        }
        private void ExportarExcell(DataGridView dtg)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Workbook libros_trabajo;
                    Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    for (int i = 0; i < dtg.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtg.Rows.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = dtg.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Reporte terminado", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo la creacion del archivo, intenta de nuevo con otro nombre", "Error de creacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void exportaraexcel(DataGridView tabla)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Workbook libros_trabajo;
                    Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Application.Workbooks.Add(true);
                    /*for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        for (int j = 0; j < tabla.Rows.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = tabla.Rows[i].Cells[j].Value.ToString();
                        }
                    }*/
                    foreach (DataGridViewColumn col in tabla.Columns) // Columnas
                    {
                        IndiceColumna++;
                        aplicacion.Cells[1, IndiceColumna] = col.Name;
                    }
                    foreach (DataGridViewRow row in tabla.Rows) // Filas
                    {
                        IndiceFila++;
                        IndiceColumna = 0;
                        foreach (DataGridViewColumn col in tabla.Columns)
                        {
                            IndiceColumna++;
                            aplicacion.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    
                    //aplicacion.Visible = true;
                    MessageBox.Show("Reporte terminado", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo la creacion del archivo, intenta de nuevo con otro nombre", "Error de creacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgAlumnoss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificarcalificacion();
        }
    }
}
