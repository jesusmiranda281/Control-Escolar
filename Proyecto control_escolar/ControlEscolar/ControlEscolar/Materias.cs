using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolar;
using Entidades.ControlEscolar;

namespace ControlEscolar
{
    public partial class Materias : Form
    {
        private MateriasManejador _materiasManejador;
        private Entidades.ControlEscolar.Materias _materias;
        public Materias()
        {
            InitializeComponent();
            _materiasManejador = new MateriasManejador();
            _materias = new Entidades.ControlEscolar.Materias();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            BuscarMaterias();
            controlcombos();
        }
        private void controlcombos()
        {
            _materiasManejador.Combomaterias(cmbMateriaantes);
            _materiasManejador.Combomaterias(cmbMateriadespues);
        }
        private void cmbMateriaantes_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            txtClave.Enabled = activar;
            txtNombre.Enabled = activar;
            txtTeoria.Enabled = activar;
            txtPractica.Enabled = activar;
            txtSemestre.Enabled = activar;
            txtBuscar.Enabled = activar;
            cmbMateriaantes.Enabled = activar;
            cmbMateriadespues.Enabled = activar;
        }
        private void limpiar()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtTeoria.Text = "";
            txtPractica.Text = "";
            txtSemestre.Text = "";
            txtBuscar.Text = "";
            cmbMateriaantes.Text = "";
            cmbMateriadespues.Text = "";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlbotones(false, true, true, true);
            controlcajas(true);
            txtClave.Focus();
        }
        private void BuscarMaterias()
        {
            dtgMaterias.DataSource = _materiasManejador.GetMaterias();
            dtgMaterias.AutoResizeColumns();
        }
        private void guardarmaterias()
        {
            _materiasManejador.Guardar(new Entidades.ControlEscolar.Materias
            {
                Id = Convert.ToInt32(lblId.Text),
                Idmateria = txtClave.Text,
                Nombre = txtNombre.Text,
                Horasteoria = int.Parse(txtTeoria.Text),
                Horaspractica = int.Parse(txtPractica.Text),
                Fkrelantes = cmbMateriaantes.Text,
                Fkreldespues = cmbMateriadespues.Text,
                Semestre = txtSemestre.Text
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlbotones(true, false, false, true);
            controlcajas(false);
            try
            {
                guardarmaterias();
                BuscarMaterias();
                limpiar();
                    //para guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            controlcombos();
        }
        private void eliminar()
        {
            var Idmateria = dtgMaterias.CurrentRow.Cells["Id"].Value;
            _materiasManejador.Eliminar(Convert.ToInt32(Idmateria));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminar();
                    BuscarMaterias();
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
            lblId.Text = dtgMaterias.CurrentRow.Cells["Id"].Value.ToString();
            txtClave.Text = dtgMaterias.CurrentRow.Cells["Idmateria"].Value.ToString();
            txtNombre.Text = dtgMaterias.CurrentRow.Cells["nombre"].Value.ToString();
            txtTeoria.Text = dtgMaterias.CurrentRow.Cells["Horasteoria"].Value.ToString();
            txtPractica.Text = dtgMaterias.CurrentRow.Cells["Horaspractica"].Value.ToString();
            cmbMateriaantes.Text = dtgMaterias.CurrentRow.Cells["Fkrelantes"].Value.ToString();
            cmbMateriadespues.Text = dtgMaterias.CurrentRow.Cells["Fkreldespues"].Value.ToString();
            txtSemestre.Text = dtgMaterias.CurrentRow.Cells["Semestre"].Value.ToString();
        }

        private void dtgMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificar();
                BuscarMaterias();
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcell(dtgMaterias);
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
    }
}
