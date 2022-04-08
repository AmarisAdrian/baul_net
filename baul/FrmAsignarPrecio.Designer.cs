namespace PresentationLayer
{
    partial class FrmAsignarPrecio
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
            this.TxtBuscarProducto = new System.Windows.Forms.TextBox();
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtValorDescuento = new System.Windows.Forms.TextBox();
            this.LblValorDescuento = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.TxtValorVenta = new System.Windows.Forms.TextBox();
            this.LblValorVenta = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.LblPrecioUnitario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DgProductos = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBuscarUsuario = new System.Windows.Forms.Button();
            this.ErrorNumeric = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscarProducto
            // 
            this.TxtBuscarProducto.Location = new System.Drawing.Point(27, 40);
            this.TxtBuscarProducto.Name = "TxtBuscarProducto";
            this.TxtBuscarProducto.Size = new System.Drawing.Size(576, 29);
            this.TxtBuscarProducto.TabIndex = 3;
            this.TxtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarProducto_KeyPress);
            // 
            // GbDatos
            // 
            this.GbDatos.BackColor = System.Drawing.Color.Transparent;
            this.GbDatos.Controls.Add(this.BtnAgregar);
            this.GbDatos.Controls.Add(this.TxtValorDescuento);
            this.GbDatos.Controls.Add(this.LblValorDescuento);
            this.GbDatos.Controls.Add(this.TxtDescuento);
            this.GbDatos.Controls.Add(this.LblDescuento);
            this.GbDatos.Controls.Add(this.TxtValorVenta);
            this.GbDatos.Controls.Add(this.LblValorVenta);
            this.GbDatos.Controls.Add(this.TxtValor);
            this.GbDatos.Controls.Add(this.LblValor);
            this.GbDatos.Controls.Add(this.TxtPrecioUnitario);
            this.GbDatos.Controls.Add(this.LblPrecioUnitario);
            this.GbDatos.Controls.Add(this.dataGridView1);
            this.GbDatos.Controls.Add(this.DgProductos);
            this.GbDatos.Controls.Add(this.BtnBuscarUsuario);
            this.GbDatos.Controls.Add(this.TxtBuscarProducto);
            this.GbDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbDatos.Location = new System.Drawing.Point(12, 12);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(776, 652);
            this.GbDatos.TabIndex = 4;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Image = global::PresentationLayer.Properties.Resources.agregar;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(576, 375);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(151, 57);
            this.BtnAgregar.TabIndex = 26;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtValorDescuento
            // 
            this.TxtValorDescuento.Enabled = false;
            this.TxtValorDescuento.Location = new System.Drawing.Point(306, 403);
            this.TxtValorDescuento.MaxLength = 300;
            this.TxtValorDescuento.Name = "TxtValorDescuento";
            this.TxtValorDescuento.Size = new System.Drawing.Size(162, 29);
            this.TxtValorDescuento.TabIndex = 24;
            this.TxtValorDescuento.Text = "0";
            // 
            // LblValorDescuento
            // 
            this.LblValorDescuento.AutoSize = true;
            this.LblValorDescuento.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblValorDescuento.ForeColor = System.Drawing.Color.Black;
            this.LblValorDescuento.Location = new System.Drawing.Point(306, 375);
            this.LblValorDescuento.Name = "LblValorDescuento";
            this.LblValorDescuento.Size = new System.Drawing.Size(191, 25);
            this.LblValorDescuento.TabIndex = 25;
            this.LblValorDescuento.Text = "Valor Con Descuento";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(27, 403);
            this.TxtDescuento.MaxLength = 3;
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(162, 29);
            this.TxtDescuento.TabIndex = 22;
            this.TxtDescuento.Text = "0";
            this.TxtDescuento.TextChanged += new System.EventHandler(this.TxtDescuento_TextChanged);
            this.TxtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescuento_KeyPress);
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDescuento.ForeColor = System.Drawing.Color.Black;
            this.LblDescuento.Location = new System.Drawing.Point(27, 375);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(103, 25);
            this.LblDescuento.TabIndex = 23;
            this.LblDescuento.Text = "Descuento";
            // 
            // TxtValorVenta
            // 
            this.TxtValorVenta.Location = new System.Drawing.Point(576, 315);
            this.TxtValorVenta.MaxLength = 300;
            this.TxtValorVenta.Name = "TxtValorVenta";
            this.TxtValorVenta.Size = new System.Drawing.Size(162, 29);
            this.TxtValorVenta.TabIndex = 20;
            this.TxtValorVenta.Text = "0";
            this.TxtValorVenta.TextChanged += new System.EventHandler(this.TxtValorVenta_TextChanged);
            this.TxtValorVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorVenta_KeyPress);
            // 
            // LblValorVenta
            // 
            this.LblValorVenta.AutoSize = true;
            this.LblValorVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblValorVenta.ForeColor = System.Drawing.Color.Black;
            this.LblValorVenta.Location = new System.Drawing.Point(576, 287);
            this.LblValorVenta.Name = "LblValorVenta";
            this.LblValorVenta.Size = new System.Drawing.Size(110, 25);
            this.LblValorVenta.TabIndex = 21;
            this.LblValorVenta.Text = "Valor Venta";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(306, 315);
            this.TxtValor.MaxLength = 300;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(162, 29);
            this.TxtValor.TabIndex = 18;
            this.TxtValor.Text = "0";
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblValor.ForeColor = System.Drawing.Color.Black;
            this.LblValor.Location = new System.Drawing.Point(306, 287);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(56, 25);
            this.LblValor.TabIndex = 19;
            this.LblValor.Text = "Valor";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(27, 315);
            this.TxtPrecioUnitario.MaxLength = 300;
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(162, 29);
            this.TxtPrecioUnitario.TabIndex = 16;
            this.TxtPrecioUnitario.Text = "0";
            this.TxtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioUnitario_KeyPress);
            // 
            // LblPrecioUnitario
            // 
            this.LblPrecioUnitario.AutoSize = true;
            this.LblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPrecioUnitario.ForeColor = System.Drawing.Color.Black;
            this.LblPrecioUnitario.Location = new System.Drawing.Point(27, 287);
            this.LblPrecioUnitario.Name = "LblPrecioUnitario";
            this.LblPrecioUnitario.Size = new System.Drawing.Size(139, 25);
            this.LblPrecioUnitario.TabIndex = 17;
            this.LblPrecioUnitario.Text = "Precio Unitario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 477);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(713, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // DgProductos
            // 
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion});
            this.DgProductos.Location = new System.Drawing.Point(27, 113);
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.RowTemplate.Height = 25;
            this.DgProductos.Size = new System.Drawing.Size(713, 150);
            this.DgProductos.TabIndex = 5;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Text = "Agregar";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // BtnBuscarUsuario
            // 
            this.BtnBuscarUsuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarUsuario.Image = global::PresentationLayer.Properties.Resources.buscar;
            this.BtnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarUsuario.Location = new System.Drawing.Point(625, 27);
            this.BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            this.BtnBuscarUsuario.Size = new System.Drawing.Size(115, 53);
            this.BtnBuscarUsuario.TabIndex = 4;
            this.BtnBuscarUsuario.Text = "Buscar";
            this.BtnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarUsuario.UseVisualStyleBackColor = false;
            this.BtnBuscarUsuario.Click += new System.EventHandler(this.BtnBuscarUsuario_Click);
            // 
            // ErrorNumeric
            // 
            this.ErrorNumeric.ContainerControl = this;
            // 
            // FrmAsignarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 669);
            this.Controls.Add(this.GbDatos);
            this.DoubleBuffered = true;
            this.Name = "FrmAsignarPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Precio";
            this.Load += new System.EventHandler(this.FrmAsignarPrecio_Load);
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TxtBuscarProducto;
        private GroupBox GbDatos;
        private Button BtnBuscarUsuario;
        private DataGridView DgProductos;
        private DataGridViewButtonColumn Accion;
        private DataGridView dataGridView1;
        private TextBox TxtDescuento;
        private Label LblDescuento;
        private TextBox TxtValorVenta;
        private Label LblValorVenta;
        private TextBox TxtValor;
        private Label LblValor;
        private TextBox TxtPrecioUnitario;
        private Label LblPrecioUnitario;
        private TextBox TxtValorDescuento;
        private Label LblValorDescuento;
        private Button BtnAgregar;
        private ErrorProvider ErrorNumeric;
    }
}