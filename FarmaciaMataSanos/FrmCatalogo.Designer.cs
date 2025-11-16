namespace FarmaciaMataSanos
{
    partial class FrmCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstCarrito = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.Location = new System.Drawing.Point(148, 2);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(193, 34);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Inventario";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Location = new System.Drawing.Point(576, 2);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(143, 34);
            this.lblCarrito.TabIndex = 1;
            this.lblCarrito.Text = "Carrito";
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Location = new System.Drawing.Point(12, 39);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(452, 170);
            this.dgvCatalogo.TabIndex = 2;
            this.dgvCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogo_CellClick);
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(3, 210);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(94, 70);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 3;
            this.picImagen.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 280);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(9, 303);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(9, 328);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 16);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(9, 357);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 16);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 276);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(103, 302);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(103, 328);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 10;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(103, 357);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 11;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 383);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 31);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstCarrito
            // 
            this.lstCarrito.FormattingEnabled = true;
            this.lstCarrito.Location = new System.Drawing.Point(532, 47);
            this.lstCarrito.Name = "lstCarrito";
            this.lstCarrito.Size = new System.Drawing.Size(233, 199);
            this.lstCarrito.TabIndex = 13;
            this.lstCarrito.DoubleClick += new System.EventHandler(this.lstCarrito_DoubleClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(529, 264);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 16);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(582, 259);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPedido.Location = new System.Drawing.Point(532, 302);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(150, 27);
            this.btnConfirmarPedido.TabIndex = 16;
            this.btnConfirmarPedido.Text = "Confirmar pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            this.btnConfirmarPedido.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(696, 302);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Borrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDivisor.Location = new System.Drawing.Point(485, 0);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(10, 502);
            this.pnlDivisor.TabIndex = 18;
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarPedido);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstCarrito);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.lblInventario);
            this.Name = "FrmCatalogo";
            this.Text = "FrmCatalogo";
            this.Load += new System.EventHandler(this.FrmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstCarrito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.Button btnCancelar;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.Panel pnlDivisor;
    }
}