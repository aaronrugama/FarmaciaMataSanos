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
    public partial class FrmPedidos : Form
    {
        private ConsultarPedidos infoPedidos;
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            infoPedidos = new ConsultarPedidos();
            CargarPedidos();

        }
        private void CargarPedidos()
        {
            DataTable datos = infoPedidos.ObtenerPedidos();
            dtgPedidos.DataSource = datos;

            if (dtgPedidos.Columns.Contains("cod_orden"))
                dtgPedidos.Columns["cod_orden"].HeaderText = "#";
            if (dtgPedidos.Columns.Contains("cliente"))
                dtgPedidos.Columns["cliente"].HeaderText = "CLIENTE";
            if (dtgPedidos.Columns.Contains("medicamento"))
                dtgPedidos.Columns["medicamento"].HeaderText = "MEDICAMENTO";
            if (dtgPedidos.Columns.Contains("cantidad"))
                dtgPedidos.Columns["cantidad"].HeaderText = "CANTIDAD";
            if (dtgPedidos.Columns.Contains("total_orden"))
                dtgPedidos.Columns["total_orden"].HeaderText = "TOTAL";
            if (dtgPedidos.Columns.Contains("fecha_orden"))
                dtgPedidos.Columns["fecha_orden"].HeaderText = "FECHA PEDIDO";
        }

    }
}
