namespace PresentationLayer
{
    partial class FrmContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoProductosToolStripMenuItem,
            this.crearProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // listadoProductosToolStripMenuItem
            // 
            this.listadoProductosToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.pencil_table;
            this.listadoProductosToolStripMenuItem.Name = "listadoProductosToolStripMenuItem";
            this.listadoProductosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listadoProductosToolStripMenuItem.Text = "&Lista productos";
            this.listadoProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoProductosToolStripMenuItem_Click);
            // 
            // crearProductosToolStripMenuItem
            // 
            this.crearProductosToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.agregar_producto;
            this.crearProductosToolStripMenuItem.Name = "crearProductosToolStripMenuItem";
            this.crearProductosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.crearProductosToolStripMenuItem.Text = "&Crear productos";
            this.crearProductosToolStripMenuItem.Click += new System.EventHandler(this.crearProductosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientesToolStripMenuItem,
            this.crearClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listaClientesToolStripMenuItem
            // 
            this.listaClientesToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.client_list;
            this.listaClientesToolStripMenuItem.Name = "listaClientesToolStripMenuItem";
            this.listaClientesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listaClientesToolStripMenuItem.Text = "&Lista Clientes";
            this.listaClientesToolStripMenuItem.Click += new System.EventHandler(this.listaClientesToolStripMenuItem_Click);
            // 
            // crearClientesToolStripMenuItem
            // 
            this.crearClientesToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.add_user_client;
            this.crearClientesToolStripMenuItem.Name = "crearClientesToolStripMenuItem";
            this.crearClientesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.crearClientesToolStripMenuItem.Text = "&Crear Clientes";
            this.crearClientesToolStripMenuItem.Click += new System.EventHandler(this.crearClientesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaUsuarioToolStripMenuItem,
            this.crearUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listaUsuarioToolStripMenuItem
            // 
            this.listaUsuarioToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.user_list;
            this.listaUsuarioToolStripMenuItem.Name = "listaUsuarioToolStripMenuItem";
            this.listaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.listaUsuarioToolStripMenuItem.Text = "&Lista Usuarios";
            this.listaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.listaUsuarioToolStripMenuItem_Click);
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.add_user_client;
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.crearUsuarioToolStripMenuItem.Text = "&Crear Usuarios";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motivoToolStripMenuItem,
            this.tallaToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // motivoToolStripMenuItem
            // 
            this.motivoToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.motivo;
            this.motivoToolStripMenuItem.Name = "motivoToolStripMenuItem";
            this.motivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motivoToolStripMenuItem.Text = "&Motivo";
            this.motivoToolStripMenuItem.Click += new System.EventHandler(this.motivoToolStripMenuItem_Click);
            // 
            // tallaToolStripMenuItem
            // 
            this.tallaToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.talla;
            this.tallaToolStripMenuItem.Name = "tallaToolStripMenuItem";
            this.tallaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tallaToolStripMenuItem.Text = "&Talla";
            this.tallaToolStripMenuItem.Click += new System.EventHandler(this.tallaToolStripMenuItem_Click);
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmContainer";
            this.Text = "Container";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmContainer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem listadoProductosToolStripMenuItem;
        private ToolStripMenuItem crearProductosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem listaClientesToolStripMenuItem;
        private ToolStripMenuItem crearClientesToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem listaUsuarioToolStripMenuItem;
        private ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem motivoToolStripMenuItem;
        private ToolStripMenuItem tallaToolStripMenuItem;
    }
}