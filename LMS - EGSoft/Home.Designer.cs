namespace LMS___EGSoft
{
    partial class Home
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
            this.homeclosebtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAlquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquileresAEntregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aEsperaDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibirLibroRegularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibirConAtrazoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeAlquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosPorLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeclosebtn
            // 
            this.homeclosebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.homeclosebtn.Location = new System.Drawing.Point(1287, 1);
            this.homeclosebtn.Name = "homeclosebtn";
            this.homeclosebtn.Size = new System.Drawing.Size(75, 23);
            this.homeclosebtn.TabIndex = 0;
            this.homeclosebtn.Text = "Cerrar";
            this.homeclosebtn.UseVisualStyleBackColor = true;
            this.homeclosebtn.Click += new System.EventHandler(this.homeclosebtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.alquilerToolStripMenuItem,
            this.recepcionToolStripMenuItem,
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLibroToolStripMenuItem,
            this.agregarClienteToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarLibroToolStripMenuItem
            // 
            this.agregarLibroToolStripMenuItem.Name = "agregarLibroToolStripMenuItem";
            this.agregarLibroToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarLibroToolStripMenuItem.Text = "Agregar Libro";
            this.agregarLibroToolStripMenuItem.Click += new System.EventHandler(this.agregarLibroToolStripMenuItem_Click);
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem1});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editarClienteToolStripMenuItem.Text = "Editar Libro";
            // 
            // editarClienteToolStripMenuItem1
            // 
            this.editarClienteToolStripMenuItem1.Name = "editarClienteToolStripMenuItem1";
            this.editarClienteToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.editarClienteToolStripMenuItem1.Text = "Editar Cliente";
            // 
            // alquilerToolStripMenuItem
            // 
            this.alquilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAlquileresToolStripMenuItem,
            this.alquilarLibroToolStripMenuItem,
            this.alquileresAEntregarToolStripMenuItem,
            this.aEsperaDeEntregaToolStripMenuItem});
            this.alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            this.alquilerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.alquilerToolStripMenuItem.Text = "Alquiler";
            // 
            // verAlquileresToolStripMenuItem
            // 
            this.verAlquileresToolStripMenuItem.Name = "verAlquileresToolStripMenuItem";
            this.verAlquileresToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.verAlquileresToolStripMenuItem.Text = "Ver alquileres";
            // 
            // alquilarLibroToolStripMenuItem
            // 
            this.alquilarLibroToolStripMenuItem.Name = "alquilarLibroToolStripMenuItem";
            this.alquilarLibroToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.alquilarLibroToolStripMenuItem.Text = "Alquilar Libro";
            // 
            // alquileresAEntregarToolStripMenuItem
            // 
            this.alquileresAEntregarToolStripMenuItem.Name = "alquileresAEntregarToolStripMenuItem";
            this.alquileresAEntregarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.alquileresAEntregarToolStripMenuItem.Text = "Alquileres a entregar";
            // 
            // aEsperaDeEntregaToolStripMenuItem
            // 
            this.aEsperaDeEntregaToolStripMenuItem.Name = "aEsperaDeEntregaToolStripMenuItem";
            this.aEsperaDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aEsperaDeEntregaToolStripMenuItem.Text = "A espera de entrega";
            // 
            // recepcionToolStripMenuItem
            // 
            this.recepcionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibirLibroRegularToolStripMenuItem,
            this.recibirConAtrazoToolStripMenuItem});
            this.recepcionToolStripMenuItem.Name = "recepcionToolStripMenuItem";
            this.recepcionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.recepcionToolStripMenuItem.Text = "Recepcion";
            // 
            // recibirLibroRegularToolStripMenuItem
            // 
            this.recibirLibroRegularToolStripMenuItem.Name = "recibirLibroRegularToolStripMenuItem";
            this.recibirLibroRegularToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.recibirLibroRegularToolStripMenuItem.Text = "Recibir libro regular";
            // 
            // recibirConAtrazoToolStripMenuItem
            // 
            this.recibirConAtrazoToolStripMenuItem.Name = "recibirConAtrazoToolStripMenuItem";
            this.recibirConAtrazoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.recibirConAtrazoToolStripMenuItem.Text = "Recibir con atrazo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosDeAlquileresToolStripMenuItem,
            this.registroPorClienteToolStripMenuItem,
            this.registrosPorLibroToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrosDeAlquileresToolStripMenuItem
            // 
            this.registrosDeAlquileresToolStripMenuItem.Name = "registrosDeAlquileresToolStripMenuItem";
            this.registrosDeAlquileresToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registrosDeAlquileresToolStripMenuItem.Text = "Registros de Alquileres";
            // 
            // registroPorClienteToolStripMenuItem
            // 
            this.registroPorClienteToolStripMenuItem.Name = "registroPorClienteToolStripMenuItem";
            this.registroPorClienteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registroPorClienteToolStripMenuItem.Text = "Registro por cliente";
            // 
            // registrosPorLibroToolStripMenuItem
            // 
            this.registrosPorLibroToolStripMenuItem.Name = "registrosPorLibroToolStripMenuItem";
            this.registrosPorLibroToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registrosPorLibroToolStripMenuItem.Text = "Registros por libro";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.homeclosebtn;
            this.ClientSize = new System.Drawing.Size(1362, 345);
            this.ControlBox = false;
            this.Controls.Add(this.homeclosebtn);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Inicio - LMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeclosebtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAlquileresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquileresAEntregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aEsperaDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibirLibroRegularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibirConAtrazoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeAlquileresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosPorLibroToolStripMenuItem;

    }
}