using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaMataSanos
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void agregarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarMed agregar = new FrmAgregarMed();
            agregar.MdiParent = this;
            agregar.WindowState = FormWindowState.Maximized;
            agregar.Show();
        }

        private void modificarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModEliminarMed modDelete = new FrmModEliminarMed();
            modDelete.MdiParent = this;
            modDelete.WindowState = FormWindowState.Maximized;
            modDelete.Show();
        }

        private void reabastecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReabastecerInv reabastecer = new FrmReabastecerInv();
            reabastecer.MdiParent = this;
            reabastecer.WindowState = FormWindowState.Maximized;
            reabastecer.Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisualizarInv visualizar = new FrmVisualizarInv();
            visualizar.MdiParent = this;
            visualizar.WindowState = FormWindowState.Maximized;
            visualizar.Show();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatalogo catalogo = new FrmCatalogo();
            catalogo.MdiParent = this;
            catalogo.WindowState = FormWindowState.Maximized;
            catalogo.Show();
        }
    }
}
