namespace FarmaciaMataSanos
{
    partial class FrmInicio
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mEDICAMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reabastecerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEDICAMENTOSToolStripMenuItem,
            this.iNVENTARIOToolStripMenuItem,
            this.iToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mEDICAMENTOSToolStripMenuItem
            // 
            this.mEDICAMENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMedicamentoToolStripMenuItem,
            this.modificarOEliminarToolStripMenuItem});
            this.mEDICAMENTOSToolStripMenuItem.Name = "mEDICAMENTOSToolStripMenuItem";
            this.mEDICAMENTOSToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.mEDICAMENTOSToolStripMenuItem.Text = "MEDICAMENTOS";
            // 
            // agregarMedicamentoToolStripMenuItem
            // 
            this.agregarMedicamentoToolStripMenuItem.Name = "agregarMedicamentoToolStripMenuItem";
            this.agregarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.agregarMedicamentoToolStripMenuItem.Text = "Agregar ";
            this.agregarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.agregarMedicamentoToolStripMenuItem_Click);
            // 
            // modificarOEliminarToolStripMenuItem
            // 
            this.modificarOEliminarToolStripMenuItem.Name = "modificarOEliminarToolStripMenuItem";
            this.modificarOEliminarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.modificarOEliminarToolStripMenuItem.Text = "Modificar o Eliminar ";
            this.modificarOEliminarToolStripMenuItem.Click += new System.EventHandler(this.modificarOEliminarToolStripMenuItem_Click);
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            this.iNVENTARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reabastecerToolStripMenuItem,
            this.visualizarToolStripMenuItem});
            this.iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            this.iNVENTARIOToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.iNVENTARIOToolStripMenuItem.Text = "INVENTARIO";
            // 
            // reabastecerToolStripMenuItem
            // 
            this.reabastecerToolStripMenuItem.Name = "reabastecerToolStripMenuItem";
            this.reabastecerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reabastecerToolStripMenuItem.Text = "Reabastecer";
            this.reabastecerToolStripMenuItem.Click += new System.EventHandler(this.reabastecerToolStripMenuItem_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.iToolStripMenuItem.Text = "CATALOGO";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mEDICAMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reabastecerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
    }
}