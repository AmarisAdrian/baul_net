namespace PresentationLayer
{
    partial class FrmEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProducto));
            this.GbEditarProducto = new System.Windows.Forms.GroupBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardarProducto = new System.Windows.Forms.Button();
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
            this.GbEditarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbEditarProducto
            // 
            this.GbEditarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbEditarProducto.BackColor = System.Drawing.Color.Transparent;
            this.GbEditarProducto.Controls.Add(this.BtnVolver);
            this.GbEditarProducto.Controls.Add(this.BtnEditar);
            this.GbEditarProducto.Controls.Add(this.BtnSalir);
            this.GbEditarProducto.Controls.Add(this.BtnGuardarProducto);
            this.GbEditarProducto.Controls.Add(this.TxtPieza);
            this.GbEditarProducto.Controls.Add(this.LblPieza);
            this.GbEditarProducto.Controls.Add(this.CmbMotivo);
            this.GbEditarProducto.Controls.Add(this.LblMotivo);
            this.GbEditarProducto.Controls.Add(this.TxtCantidad);
            this.GbEditarProducto.Controls.Add(this.LblCantidad);
            this.GbEditarProducto.Controls.Add(this.TxtReferencia);
            this.GbEditarProducto.Controls.Add(this.LblReferencia);
            this.GbEditarProducto.Controls.Add(this.LblTalla);
            this.GbEditarProducto.Controls.Add(this.RTxtDetalleProducto);
            this.GbEditarProducto.Controls.Add(this.LblDetalleProducto);
            this.GbEditarProducto.Controls.Add(this.RTxtDescripcion);
            this.GbEditarProducto.Controls.Add(this.CmbTalla);
            this.GbEditarProducto.Controls.Add(this.TxtCodigo);
            this.GbEditarProducto.Controls.Add(this.LbDescripcion);
            this.GbEditarProducto.Controls.Add(this.LbCodigo);
            this.GbEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbEditarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbEditarProducto.ForeColor = System.Drawing.Color.Black;
            this.GbEditarProducto.Location = new System.Drawing.Point(30, 33);
            this.GbEditarProducto.Name = "GbEditarProducto";
            this.GbEditarProducto.Size = new System.Drawing.Size(876, 594);
            this.GbEditarProducto.TabIndex = 3;
            this.GbEditarProducto.TabStop = false;
            this.GbEditarProducto.Text = "Datos";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolver.Image = global::PresentationLayer.Properties.Resources.exit;
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(539, 493);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(140, 57);
            this.BtnVolver.TabIndex = 11;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Image = global::PresentationLayer.Properties.Resources.guardar1;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(714, 493);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(140, 57);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(520, 1304);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(816, 57);
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
            this.BtnGuardarProducto.Location = new System.Drawing.Point(702, 1304);
            this.BtnGuardarProducto.Name = "BtnGuardarProducto";
            this.BtnGuardarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGuardarProducto.Size = new System.Drawing.Size(816, 57);
            this.BtnGuardarProducto.TabIndex = 23;
            this.BtnGuardarProducto.Text = "Guardar";
            this.BtnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // TxtPieza
            // 
            this.TxtPieza.Location = new System.Drawing.Point(692, 424);
            this.TxtPieza.MaxLength = 300;
            this.TxtPieza.Name = "TxtPieza";
            this.TxtPieza.Size = new System.Drawing.Size(162, 29);
            this.TxtPieza.TabIndex = 10;
            this.TxtPieza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPieza_KeyPress);
            // 
            // LblPieza
            // 
            this.LblPieza.AutoSize = true;
            this.LblPieza.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPieza.ForeColor = System.Drawing.Color.Black;
            this.LblPieza.Location = new System.Drawing.Point(692, 396);
            this.LblPieza.Name = "LblPieza";
            this.LblPieza.Size = new System.Drawing.Size(57, 25);
            this.LblPieza.TabIndex = 19;
            this.LblPieza.Text = "Pieza";
            // 
            // CmbMotivo
            // 
            this.CmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMotivo.FormattingEnabled = true;
            this.CmbMotivo.Location = new System.Drawing.Point(492, 424);
            this.CmbMotivo.Name = "CmbMotivo";
            this.CmbMotivo.Size = new System.Drawing.Size(156, 29);
            this.CmbMotivo.TabIndex = 9;
            // 
            // LblMotivo
            // 
            this.LblMotivo.AutoSize = true;
            this.LblMotivo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMotivo.ForeColor = System.Drawing.Color.Black;
            this.LblMotivo.Location = new System.Drawing.Point(492, 396);
            this.LblMotivo.Name = "LblMotivo";
            this.LblMotivo.Size = new System.Drawing.Size(74, 25);
            this.LblMotivo.TabIndex = 17;
            this.LblMotivo.Text = "Motivo";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Enabled = false;
            this.TxtCantidad.Location = new System.Drawing.Point(267, 424);
            this.TxtCantidad.MaxLength = 300;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(162, 29);
            this.TxtCantidad.TabIndex = 8;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCantidad.ForeColor = System.Drawing.Color.Black;
            this.LblCantidad.Location = new System.Drawing.Point(267, 396);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(89, 25);
            this.LblCantidad.TabIndex = 15;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Enabled = false;
            this.TxtReferencia.Location = new System.Drawing.Point(471, 73);
            this.TxtReferencia.MaxLength = 300;
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(383, 29);
            this.TxtReferencia.TabIndex = 3;
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
            this.RTxtDescripcion.TabIndex = 5;
            this.RTxtDescripcion.Text = "";
            // 
            // CmbTalla
            // 
            this.CmbTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTalla.FormattingEnabled = true;
            this.CmbTalla.Location = new System.Drawing.Point(46, 424);
            this.CmbTalla.Name = "CmbTalla";
            this.CmbTalla.Size = new System.Drawing.Size(156, 29);
            this.CmbTalla.TabIndex = 7;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(46, 73);
            this.TxtCodigo.MaxLength = 300;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(383, 29);
            this.TxtCodigo.TabIndex = 2;
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
            // FrmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 660);
            this.Controls.Add(this.GbEditarProducto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.FrmEditarProducto_Load);
            this.GbEditarProducto.ResumeLayout(false);
            this.GbEditarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbEditarProducto;
        private Button BtnSalir;
        private Button BtnGuardarProducto;
        private TextBox TxtPieza;
        private Label LblPieza;
        private ComboBox CmbMotivo;
        private Label LblMotivo;
        private TextBox TxtCantidad;
        private Label LblCantidad;
        private TextBox TxtReferencia;
        private Label LblReferencia;
        private Label LblTalla;
        private RichTextBox RTxtDetalleProducto;
        private Label LblDetalleProducto;
        private RichTextBox RTxtDescripcion;
        private ComboBox CmbTalla;
        private TextBox TxtCodigo;
        private Label LbDescripcion;
        private Label LbCodigo;
        private Button BtnEditar;
        private Button BtnVolver;
    }
}