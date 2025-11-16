using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaMataSanos
{
    public partial class FrmVisualizarInv : Form
    {
        private VisualizarInventario infoMedicamentos;
        public FrmVisualizarInv()
        {
            InitializeComponent();
            infoMedicamentos = new VisualizarInventario();
        }

        private void FrmVisualizarInv_Load(object sender, EventArgs e)
        {
            CargarMedicamentos();
            ConfigurarDataGridView();
        }

        private void CargarMedicamentos()
        {
            DataTable datos = infoMedicamentos.ObtenerMedicamentos();
            dtgInventario.DataSource = datos;

            foreach (DataGridViewRow fila in dtgInventario.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["imagen_med"].Value != DBNull.Value)
                {
                    byte[] bytes = (byte[])fila.Cells["imagen_med"].Value;

                    if (bytes.Length > 4 &&
                       ((bytes[0] == 0x89 && bytes[1] == 0x50) ||
                        (bytes[0] == 0xFF && bytes[1] == 0xD8)))
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                fila.Cells["imagen_med"].Value = Image.FromStream(ms);
                            }
                        }
                        catch
                        {
                            fila.Cells["imagen_med"].Value = null;
                        }
                    }
                    else
                    {
                        fila.Cells["imagen_med"].Value = null;
                    }
                }
            }
        }


        private void ConfigurarDataGridView()
        {
            dtgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             dtgInventario.RowTemplate.Height = 60;

            if (dtgInventario.Columns.Contains("imagen_med"))
            {
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dtgInventario.Columns["imagen_med"];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.Width = 80;
                imgCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dtgInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
