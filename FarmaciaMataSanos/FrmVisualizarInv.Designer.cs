namespace FarmaciaMataSanos
{
    partial class FrmVisualizarInv
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
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picMedi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInventario.Location = new System.Drawing.Point(204, 34);
            this.lblInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(794, 59);
            this.lblInventario.TabIndex = 2;
            this.lblInventario.Text = "INVENTARIO DE MEDICAMENTOS";
            // 
            // dtgInventario
            // 
            this.dtgInventario.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventario.Location = new System.Drawing.Point(124, 108);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.RowHeadersWidth = 62;
            this.dtgInventario.RowTemplate.Height = 28;
            this.dtgInventario.Size = new System.Drawing.Size(939, 507);
            this.dtgInventario.TabIndex = 3;
            this.dtgInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInventario_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FarmaciaMataSanos.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(-50, 277);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 259);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FarmaciaMataSanos.Properties.Resources._5;
            this.pictureBox2.Location = new System.Drawing.Point(-63, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 259);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // picMedi
            // 
            this.picMedi.Image = global::FarmaciaMataSanos.Properties.Resources.Yellow_And_Red_Modern_10_10_Mega_Sale_Instagram_Post;
            this.picMedi.Location = new System.Drawing.Point(976, 120);
            this.picMedi.Name = "picMedi";
            this.picMedi.Size = new System.Drawing.Size(294, 288);
            this.picMedi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedi.TabIndex = 4;
            this.picMedi.TabStop = false;
            // 
            // FrmVisualizarInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dtgInventario);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picMedi);
            this.Controls.Add(this.lblInventario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVisualizarInv";
            this.Text = "FrmVisualizarInv";
            this.Load += new System.EventHandler(this.FrmVisualizarInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.DataGridView dtgInventario;
        private System.Windows.Forms.PictureBox picMedi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}