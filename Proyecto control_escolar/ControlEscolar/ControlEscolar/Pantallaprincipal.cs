using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class Pantallaprincipal : Form
    {
        public Pantallaprincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios u = new FrmUsuarios();
            u.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos a = new Alumnos();
            a.ShowDialog();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores p = new Profesores();
            p.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias m = new Materias();
            m.ShowDialog();
        }

        private void escuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escuela es = new Escuela();
            es.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos gr = new Grupos();
            gr.ShowDialog();
        }

        private void asignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignacion a = new Asignacion();
            a.ShowDialog();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificaciones c = new Calificaciones();
            c.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
