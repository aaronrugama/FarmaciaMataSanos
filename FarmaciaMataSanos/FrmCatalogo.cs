using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using static FarmaciaMataSanos.Catalogo;

namespace FarmaciaMataSanos
{
    public partial class FrmCatalogo : Form
    {
        private ConexionBD conexion = new ConexionBD();
        private List<Medicamento> inventario = new List<Medicamento>();
        private List<PedidoItem> carrito = new List<PedidoItem>();
        private bool seleccionadoManualmente = false;
        private string codCliente;

        public FrmCatalogo(string codigoCliente)
        {
            InitializeComponent();
            codCliente = codigoCliente;
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            conexion.leerXML();
            conexion.conectar();
            configurarColumnas();
            configurarSeleccion();
            cargarInventario();
            dgvCatalogo.ClearSelection();
            seleccionadoManualmente = false;
            numCantidad.Value = 1;
            numCantidad.Minimum = 1;
        }

        private void configurarSeleccion()
        {
            dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatalogo.MultiSelect = false;
        }

        private void configurarColumnas()
        {
            dgvCatalogo.Columns.Clear();
            dgvCatalogo.Columns.Add("CodMed", "Código");
            dgvCatalogo.Columns.Add("Nombre", "Medicamento");
            dgvCatalogo.Columns.Add("Cantidad", "Stock");
            dgvCatalogo.Columns.Add("Precio", "Precio");
        }

        private void cargarInventario()
        {
            inventario = MedicamentoC.obtenerMedicamentos(conexion.getMiConexion());
            dgvCatalogo.Rows.Clear();

            foreach (var m in inventario)
            {
                dgvCatalogo.Rows.Add(m.CodMed, m.Nombre, m.Cantidad, m.Precio);
            }
        }

        private void dgvCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string cod = dgvCatalogo.Rows[e.RowIndex].Cells[0].Value.ToString();
            var med = inventario.Find(x => x.CodMed == cod);

            if (med != null)
            {
                picImagen.SizeMode = PictureBoxSizeMode.Zoom;
                picImagen.Image = ImagenHelper.ByteArrayToImage(med.Imagen);

                txtNombre.Text = med.Nombre;
                txtStock.Text = med.Cantidad.ToString();
                txtPrecio.Text = med.Precio.ToString("0.00");

                numCantidad.Maximum = med.Cantidad;
                numCantidad.Value = 1;
                seleccionadoManualmente = true;
            }
            else
            {
                picImagen.Image = null;
                txtNombre.Text = "";
                txtStock.Text = "";
                txtPrecio.Text = "";
                numCantidad.Value = 1;
                seleccionadoManualmente = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvCatalogo.SelectedRows.Count == 0 || !seleccionadoManualmente)
            {
                MessageBox.Show("Seleccione un medicamento del inventario (clic en la fila).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cod = dgvCatalogo.SelectedRows[0].Cells[0].Value.ToString();
            var med = inventario.Find(x => x.CodMed == cod);
            if (med == null)
            {
                MessageBox.Show("No se pudo encontrar el medicamento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad = Convert.ToInt32(numCantidad.Value);

            if (cantidad <= 0 || cantidad > med.Cantidad)
            {
                MessageBox.Show($"Cantidad inválida o mayor al stock disponible ({med.Cantidad}).", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existente = carrito.Find(p => p.Medicamento.CodMed == med.CodMed);
            if (existente != null)
            {
                if (existente.Cantidad + cantidad > med.Cantidad)
                {
                    MessageBox.Show($"No puede agregar {cantidad}. Ya hay {existente.Cantidad} en el carrito y el stock es {med.Cantidad}.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existente.Cantidad += cantidad;
                existente.Subtotal = existente.Cantidad * med.Precio;
            }
            else
            {
                carrito.Add(new PedidoItem
                {
                    Medicamento = med,
                    Cantidad = cantidad,
                    Subtotal = med.Precio * cantidad
                });
            }

            actualizarCarrito();
            numCantidad.Value = 1;
            dgvCatalogo.ClearSelection();
            seleccionadoManualmente = false;
        }

        private void actualizarCarrito()
        {
            lstCarrito.Items.Clear();
            decimal total = 0;

            foreach (var item in carrito)
            {
                lstCarrito.Items.Add($"{item.Medicamento.Nombre} x{item.Cantidad} = {item.Subtotal:0.00}");
                total += item.Subtotal;
            }

            txtTotal.Text = total.ToString("0.00");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            carrito.Clear();
            lstCarrito.Items.Clear();
            txtTotal.Text = "0.00";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            numCantidad.Value = 1;

            MessageBox.Show("Carrito borrado correctamente.");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            decimal total = decimal.Parse(txtTotal.Text);
            string codOrden = PedidoDAO.insertarOrden(conexion.getMiConexion(), total, codCliente);

            foreach (var item in carrito)
            {
                PedidoDAO.insertarDetalle(conexion.getMiConexion(), codOrden, item);
            }

            MessageBox.Show("Pedido realizado con éxito. Código: " + codOrden);

            carrito.Clear();
            actualizarCarrito();
            cargarInventario();
        }

        private void lstCarrito_DoubleClick(object sender, EventArgs e)
        {
            if (lstCarrito.SelectedIndex == -1)
                return;

            var respuesta = MessageBox.Show(
                "¿Eliminar este producto del carrito?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
                return;

            int index = lstCarrito.SelectedIndex;
            carrito.RemoveAt(index);
            actualizarCarrito();
        }
    }
}
