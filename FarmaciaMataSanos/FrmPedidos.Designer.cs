namespace FarmaciaMataSanos
{
    partial class FrmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblPedidos = new System.Windows.Forms.Label();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.picDoc = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPedidos.Location = new System.Drawing.Point(22, 30);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(501, 54);
            this.lblPedidos.TabIndex = 0;
            this.lblPedidos.Text = "PEDIDOS REALIZADOS";
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(31, 87);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.RowHeadersWidth = 62;
            this.dtgPedidos.RowTemplate.Height = 28;
            this.dtgPedidos.Size = new System.Drawing.Size(956, 379);
            this.dtgPedidos.TabIndex = 1;
            // 
            // picDoc
            // 
            this.picDoc.Image = global::FarmaciaMataSanos.Properties.Resources.pedidosParcero;
            this.picDoc.Location = new System.Drawing.Point(877, 207);
            this.picDoc.Name = "picDoc";
            this.picDoc.Size = new System.Drawing.Size(473, 430);
            this.picDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoc.TabIndex = 6;
            this.picDoc.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FarmaciaMataSanos.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(951, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1301, 543);
            this.Controls.Add(this.dtgPedidos);
            this.Controls.Add(this.picDoc);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPedidos";
            this.Text = "Pedidos realizados";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.PictureBox picDoc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}