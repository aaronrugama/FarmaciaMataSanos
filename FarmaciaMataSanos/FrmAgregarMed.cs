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
    public partial class FrmAgregarMed : Form
    {
        private byte[] imagenBytes = null;
        public FrmAgregarMed()
        {
            InitializeComponent();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*webp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                picImagenMed.Image = img;

                // Convertir imagen a byte[]
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    imagenBytes = ms.ToArray();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMed.Text.Trim();
            int cantidad = int.Parse(txtCant.Text.Trim());
            decimal precio = decimal.Parse(txtPrecio.Text.Trim());

            MedicamentoDAO dao = new MedicamentoDAO();

            try
            {
                bool ok = dao.InsertarMedicamento(nombre, imagenBytes, cantidad, precio);

                if (ok)
                {
                    MessageBox.Show("Medicamento agregado correctamente",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar el medicamento.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCant_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtCant.Text, out int _))
            {
                errValidar.SetError(txtCant, "Solo números enteros.");
                e.Cancel = true;
            }
            else
            {
                errValidar.SetError(txtCant, "");
            }
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(txtPrecio.Text, out decimal valor))
            {
                // máximo 2 decimales
                if (decimal.Round(valor, 2) != valor)
                {
                    errValidar.SetError(txtPrecio, "Solo se permiten 2 decimales.");
                    e.Cancel = true;
                    return;
                }

                errValidar.SetError(txtPrecio, "");
            }
            else
            {
                errValidar.SetError(txtPrecio, "Precio inválido.");
                e.Cancel = true;
            }
        }

        private void txtNombreMed_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombreMed.Text.Length > 100)
            {
                errValidar.SetError(txtNombreMed, "Máximo 100 caracteres.");
                e.Cancel = true;
            }
            else if (string.IsNullOrWhiteSpace(txtNombreMed.Text))
            {
                errValidar.SetError(txtNombreMed, "El nombre es obligatorio.");
                e.Cancel = true;
            }
            else
            {
                errValidar.SetError(txtNombreMed, "");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // solo un punto
            if (e.KeyChar == '.' && txtPrecio.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
