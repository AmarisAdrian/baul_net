namespace PresentationLayer
{
    partial class FrmCrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearProducto));
            this.GbCrearProducto = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardarProducto = new System.Windows.Forms.Button();
            this.DgCrearProducto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtPieza = new System.Windows.Forms.TextBox();
            this.LblPieza = new System.Windows.Forms.Label();
            this.CmbMotivo = new System.Windows.Forms.ComboBox();
            this.LblMotivo = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.LblReferencia = new System.Windows.Forms.Label();
            this.LblTalla = new System.Windows.Forms.Label();
            this.RTxtDetalleProducto = new System.Windows.Forms.RichTextBox();
            this.LblDetalleProducto = new System.Windows.Forms.Label();
            this.RTxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.CmbTalla = new System.Windows.Forms.ComboBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LbDescripcion = new System.Windows.Forms.Label();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorNumeric = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbCrearProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCrearProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // GbCrearProducto
            // 
            this.GbCrearProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbCrearProducto.BackColor = System.Drawing.Color.Transparent;
            this.GbCrearProducto.Controls.Add(this.BtnSalir);
            this.GbCrearProducto.Controls.Add(this.BtnGuardarProducto);
            this.GbCrearProducto.Controls.Add(this.DgCrearProducto);
            this.GbCrearProducto.Controls.Add(this.BtnAgregar);
            this.GbCrearProducto.Controls.Add(this.TxtPieza);
            this.GbCrearProducto.Controls.Add(this.LblPieza);
            this.GbCrearProducto.Controls.Add(this.CmbMotivo);
            this.GbCrearProducto.Controls.Add(this.LblMotivo);
            this.GbCrearProducto.Controls.Add(this.TxtCantidad);
            this.GbCrearProducto.Controls.Add(this.LblCantidad);
            this.GbCrearProducto.Controls.Add(this.TxtReferencia);
            this.GbCrearProducto.Controls.Add(this.LblReferencia);
            this.GbCrearProducto.Controls.Add(this.LblTalla);
            this.GbCrearProducto.Controls.Add(this.RTxtDetalleProducto);
            this.GbCrearProducto.Controls.Add(this.LblDetalleProducto);
            this.GbCrearProducto.Controls.Add(this.RTxtDescripcion);
            this.GbCrearProducto.Controls.Add(this.CmbTalla);
            this.GbCrearProducto.Controls.Add(this.TxtCodigo);
            this.GbCrearProducto.Controls.Add(this.LbDescripcion);
            this.GbCrearProducto.Controls.Add(this.LbCodigo);
            this.GbCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbCrearProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbCrearProducto.ForeColor = System.Drawing.Color.Black;
            this.GbCrearProducto.Location = new System.Drawing.Point(31, 33);
            this.GbCrearProducto.Name = "GbCrearProducto";
            this.GbCrearProducto.Size = new System.Drawing.Size(876, 888);
            this.GbCrearProducto.TabIndex = 2;
            this.GbCrearProducto.TabStop = false;
            this.GbCrearProducto.Text = "Datos";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(520, 810);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(140, 57);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.Text = "Volver";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarProducto
            // 
            this.BtnGuardarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarProducto.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarProducto.Image = global::PresentationLayer.Properties.Resources.guardar1;
            this.BtnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarProducto.Location = new System.Drawing.Point(702, 810);
            this.BtnGuardarProducto.Name = "BtnGuardarProducto";
            this.BtnGuardarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGuardarProducto.Size = new System.Drawing.Size(140, 57);
            this.BtnGuardarProducto.TabIndex = 23;
            this.BtnGuardarProducto.Text = "Guardar";
            this.BtnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarProducto.UseVisualStyleBackColor = false;
            this.BtnGuardarProducto.Click += new System.EventHandler(this.BtnGuardarProducto_Click);
            // 
            // DgCrearProducto
            // 
            this.DgCrearProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCrearProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.Detalles,
            this.Talla,
            this.Cantidad,
            this.Motivo,
            this.Pieza,
            this.Accion});
            this.DgCrearProducto.Location = new System.Drawing.Point(46, 576);
            this.DgCrearProducto.Name = "DgCrearProducto";
            this.DgCrearProducto.ReadOnly = true;
            this.DgCrearProducto.RowTemplate.Height = 25;
            this.DgCrearProducto.Size = new System.Drawing.Size(808, 205);
            this.DgCrearProducto.TabIndex = 22;
            this.DgCrearProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCrearProducto_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Referencia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Width = 105;
            // 
            // Talla
            // 
            this.Talla.HeaderText = "Talla";
            this.Talla.Name = "Talla";
            this.Talla.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 80;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // Pieza
            // 
            this.Pieza.HeaderText = "Pieza";
            this.Pieza.Name = "Pieza";
            this.Pieza.ReadOnly = true;
            this.Pieza.Width = 70;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Accion.Text = "Eliminar";
            this.Accion.ToolTipText = "Eliminar producto";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Image = global::PresentationLayer.Properties.Resources.agregar;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(377, 485);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(151, 57);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtPieza
            // 
            this.TxtPieza.Location = new System.Drawing.Point(676, 424);
            this.TxtPieza.MaxLength = 300;
            this.TxtPieza.Name = "TxtPieza";
            this.TxtPieza.Size = new System.Drawing.Size(162, 29);
            this.TxtPieza.TabIndex = 20;
            this.TxtPieza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPieza_KeyPress);
            // 
            // LblPieza
            // 
            this.LblPieza.AutoSize = true;
            this.LblPieza.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPieza.ForeColor = System.Drawing.Color.Black;
            this.LblPieza.Location = new System.Drawing.Point(676, 396);
            this.LblPieza.Name = "LblPieza";
            this.LblPieza.Size = new System.Drawing.Size(57, 25);
            this.LblPieza.TabIndex = 19;
            this.LblPieza.Text = "Pieza";
            // 
            // CmbMotivo
            // 
            this.CmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMotivo.FormattingEnabled = true;
            this.CmbMotivo.Location = new System.Drawing.Point(468, 424);
            this.CmbMotivo.Name = "CmbMotivo";
            this.CmbMotivo.Size = new System.Drawing.Size(156, 29);
            this.CmbMotivo.TabIndex = 18;
            // 
            // LblMotivo
            // 
            this.LblMotivo.AutoSize = true;
            this.LblMotivo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMotivo.ForeColor = System.Drawing.Color.Black;
            this.LblMotivo.Location = new System.Drawing.Point(468, 396);
            this.LblMotivo.Name = "LblMotivo";
            this.LblMotivo.Size = new System.Drawing.Size(74, 25);
            this.LblMotivo.TabIndex = 17;
            this.LblMotivo.Text = "Motivo";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(254, 424);
            this.TxtCantidad.MaxLength = 300;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(162, 29);
            this.TxtCantidad.TabIndex = 16;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCantidad.ForeColor = System.Drawing.Color.Black;
            this.LblCantidad.Location = new System.Drawing.Point(254, 396);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(89, 25);
            this.LblCantidad.TabIndex = 15;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Location = new System.Drawing.Point(471, 73);
            this.TxtReferencia.MaxLength = 300;
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(383, 29);
            this.TxtReferencia.TabIndex = 14;
            this.TxtReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReferencia_KeyPress);
            // 
            // LblReferencia
            // 
            this.LblReferencia.AutoSize = true;
            this.LblReferencia.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblReferencia.ForeColor = System.Drawing.Color.Black;
            this.LblReferencia.Location = new System.Drawing.Point(471, 45);
            this.LblReferencia.Name = "LblReferencia";
            this.LblReferencia.Size = new System.Drawing.Size(102, 25);
            this.LblReferencia.TabIndex = 13;
            this.LblReferencia.Text = "Referencia";
            // 
            // LblTalla
            // 
            this.LblTalla.AutoSize = true;
            this.LblTalla.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTalla.ForeColor = System.Drawing.Color.Black;
            this.LblTalla.Location = new System.Drawing.Point(46, 396);
            this.LblTalla.Name = "LblTalla";
            this.LblTalla.Size = new System.Drawing.Size(50, 25);
            this.LblTalla.TabIndex = 7;
            this.LblTalla.Text = "Talla";
            // 
            // RTxtDetalleProducto
            // 
            this.RTxtDetalleProducto.Location = new System.Drawing.Point(46, 287);
            this.RTxtDetalleProducto.Name = "RTxtDetalleProducto";
            this.RTxtDetalleProducto.Size = new System.Drawing.Size(808, 96);
            this.RTxtDetalleProducto.TabIndex = 6;
            this.RTxtDetalleProducto.Text = "";
            // 
            // LblDetalleProducto
            // 
            this.LblDetalleProducto.AutoSize = true;
            this.LblDetalleProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDetalleProducto.ForeColor = System.Drawing.Color.Black;
            this.LblDetalleProducto.Location = new System.Drawing.Point(46, 259);
            this.LblDetalleProducto.Name = "LblDetalleProducto";
            this.LblDetalleProducto.Size = new System.Drawing.Size(156, 25);
            this.LblDetalleProducto.TabIndex = 5;
            this.LblDetalleProducto.Text = "Detalle producto";
            // 
            // RTxtDescripcion
            // 
            this.RTxtDescripcion.Location = new System.Drawing.Point(46, 145);
            this.RTxtDescripcion.Name = "RTxtDescripcion";
            this.RTxtDescripcion.Size = new System.Drawing.Size(808, 96);
            this.RTxtDescripcion.TabIndex = 4;
            this.RTxtDescripcion.Text = "";
            // 
            // CmbTalla
            // 
            this.CmbTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTalla.FormattingEnabled = true;
            this.CmbTalla.Location = new System.Drawing.Point(46, 424);
            this.CmbTalla.Name = "CmbTalla";
            this.CmbTalla.Size = new System.Drawing.Size(156, 29);
            this.CmbTalla.TabIndex = 8;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(46, 73);
            this.TxtCodigo.MaxLength = 300;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(383, 29);
            this.TxtCodigo.TabIndex = 2;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // LbDescripcion
            // 
            this.LbDescripcion.AutoSize = true;
            this.LbDescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbDescripcion.ForeColor = System.Drawing.Color.Black;
            this.LbDescripcion.Location = new System.Drawing.Point(46, 117);
            this.LbDescripcion.Name = "LbDescripcion";
            this.LbDescripcion.Size = new System.Drawing.Size(112, 25);
            this.LbDescripcion.TabIndex = 3;
            this.LbDescripcion.Text = "Descripcion";
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbCodigo.ForeColor = System.Drawing.Color.Black;
            this.LbCodigo.Location = new System.Drawing.Point(46, 45);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(73, 25);
            this.LbCodigo.TabIndex = 1;
            this.LbCodigo.Text = "Codigo";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Referencia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ErrorNumeric
            // 
            this.ErrorNumeric.ContainerControl = this;
            // 
            // FrmCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 954);
            this.Controls.Add(this.GbCrearProducto);
            this.Name = "FrmCrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.FrmCrearProducto_Load);
            this.GbCrearProducto.ResumeLayout(false);
            this.GbCrearProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCrearProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbCrearProducto;
        private Button BtnCancelar;
        private TextBox TxtCodigo;
        private Label LbDescripcion;
        private Label LbCodigo;
        private Button BtnGuardar;
        private RichTextBox RTxtDescripcion;
        private ComboBox CmbTalla;
        private Label LblTalla;
        private RichTextBox RTxtDetalleProducto;
        private Label LblDetalleProducto;
        private DataGridView DgCrearProducto;
        private Button BtnAgregar;
        private TextBox TxtPieza;
        private Label LblPieza;
        private ComboBox CmbMotivo;
        private Label LblMotivo;
        private TextBox TxtCantidad;
        private Label LblCantidad;
        private TextBox TxtReferencia;
        private Label LblReferencia;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Referencia;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button BtnSalir;
        private Button BtnGuardarProducto;
        private ErrorProvider ErrorNumeric;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Detalles;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn Pieza;
        private DataGridViewButtonColumn Accion;
    }
}