namespace FarmaciaMataSanos
{
    partial class FrmAgregarMed
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombreMed = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombreMed = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.picImagenMed = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.errValidar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(223, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "AGREGAR MEDICAMENTO";
            // 
            // txtNombreMed
            // 
            this.txtNombreMed.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMed.Location = new System.Drawing.Point(310, 56);
            this.txtNombreMed.MaxLength = 100;
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.Size = new System.Drawing.Size(209, 29);
            this.txtNombreMed.TabIndex = 2;
            this.txtNombreMed.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreMed_Validating);
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(310, 284);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(209, 29);
            this.txtCant.TabIndex = 3;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            this.txtCant.Validating += new System.ComponentModel.CancelEventHandler(this.txtCant_Validating);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(310, 323);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(209, 29);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            // 
            // lblNombreMed
            // 
            this.lblNombreMed.AutoSize = true;
            this.lblNombreMed.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMed.Location = new System.Drawing.Point(93, 59);
            this.lblNombreMed.Name = "lblNombreMed";
            this.lblNombreMed.Size = new System.Drawing.Size(211, 21);
            this.lblNombreMed.TabIndex = 6;
            this.lblNombreMed.Text = "Nombre del Medicamento";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(225, 284);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 21);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(246, 323);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 21);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(364, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 31);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // picImagenMed
            // 
            this.picImagenMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagenMed.Location = new System.Drawing.Point(310, 97);
            this.picImagenMed.Name = "picImagenMed";
            this.picImagenMed.Size = new System.Drawing.Size(209, 130);
            this.picImagenMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagenMed.TabIndex = 10;
            this.picImagenMed.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagen.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(319, 233);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(186, 34);
            this.btnImagen.TabIndex = 11;
            this.btnImagen.Text = "Seleccionar Imagen";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(98, 97);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(206, 21);
            this.lblImagen.TabIndex = 12;
            this.lblImagen.Text = "Imagen del Medicamento";
            // 
            // errValidar
            // 
            this.errValidar.ContainerControl = this;
            // 
            // FrmAgregarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.picImagenMed);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreMed);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtNombreMed);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAgregarMed";
            this.Text = "FrmAgregarMed";
            ((System.ComponentModel.ISupportInitialize)(this.picImagenMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errValidar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombreMed;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNombreMed;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox picImagenMed;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.ErrorProvider errValidar;
    }
}