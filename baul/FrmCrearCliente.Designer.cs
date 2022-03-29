namespace baul
{
    partial class FrmCrearCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearCliente));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GbCrearCliente = new System.Windows.Forms.GroupBox();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.LbNumeroDocumento = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LbDireccion = new System.Windows.Forms.Label();
            this.LbTelefono = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbApellido = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.ErrorNumeric = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbCrearCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Image = global::PresentationLayer.Properties.Resources.guardar1;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(661, 280);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGuardar.Size = new System.Drawing.Size(151, 57);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GbCrearCliente
            // 
            this.GbCrearCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbCrearCliente.BackColor = System.Drawing.Color.Transparent;
            this.GbCrearCliente.Controls.Add(this.TxtNumeroDocumento);
            this.GbCrearCliente.Controls.Add(this.LbNumeroDocumento);
            this.GbCrearCliente.Controls.Add(this.BtnCancelar);
            this.GbCrearCliente.Controls.Add(this.TxtApellido);
            this.GbCrearCliente.Controls.Add(this.TxtDireccion);
            this.GbCrearCliente.Controls.Add(this.TxtEmail);
            this.GbCrearCliente.Controls.Add(this.TxtTelefono);
            this.GbCrearCliente.Controls.Add(this.TxtNombre);
            this.GbCrearCliente.Controls.Add(this.LbDireccion);
            this.GbCrearCliente.Controls.Add(this.LbTelefono);
            this.GbCrearCliente.Controls.Add(this.LbEmail);
            this.GbCrearCliente.Controls.Add(this.LbApellido);
            this.GbCrearCliente.Controls.Add(this.LbNombre);
            this.GbCrearCliente.Controls.Add(this.BtnGuardar);
            this.GbCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbCrearCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbCrearCliente.ForeColor = System.Drawing.Color.Black;
            this.GbCrearCliente.Location = new System.Drawing.Point(34, 26);
            this.GbCrearCliente.Name = "GbCrearCliente";
            this.GbCrearCliente.Size = new System.Drawing.Size(887, 368);
            this.GbCrearCliente.TabIndex = 1;
            this.GbCrearCliente.TabStop = false;
            this.GbCrearCliente.Text = "Datos";
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(46, 144);
            this.TxtNumeroDocumento.MaxLength = 20;
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(375, 29);
            this.TxtNumeroDocumento.TabIndex = 8;
            this.TxtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDocumento_KeyPress);
            // 
            // LbNumeroDocumento
            // 
            this.LbNumeroDocumento.AutoSize = true;
            this.LbNumeroDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNumeroDocumento.ForeColor = System.Drawing.Color.Black;
            this.LbNumeroDocumento.Location = new System.Drawing.Point(46, 116);
            this.LbNumeroDocumento.Name = "LbNumeroDocumento";
            this.LbNumeroDocumento.Size = new System.Drawing.Size(212, 25);
            this.LbNumeroDocumento.TabIndex = 12;
            this.LbNumeroDocumento.Text = "Número de documento";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(479, 280);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(151, 57);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Volver";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(479, 73);
            this.TxtApellido.MaxLength = 300;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(375, 29);
            this.TxtApellido.TabIndex = 7;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(46, 218);
            this.TxtDireccion.MaxLength = 300;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(375, 29);
            this.TxtDireccion.TabIndex = 10;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(479, 218);
            this.TxtEmail.MaxLength = 254;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(376, 29);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(479, 144);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(375, 29);
            this.TxtTelefono.TabIndex = 9;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(46, 73);
            this.TxtNombre.MaxLength = 300;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(375, 29);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LbDireccion
            // 
            this.LbDireccion.AutoSize = true;
            this.LbDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbDireccion.ForeColor = System.Drawing.Color.Black;
            this.LbDireccion.Location = new System.Drawing.Point(46, 190);
            this.LbDireccion.Name = "LbDireccion";
            this.LbDireccion.Size = new System.Drawing.Size(93, 25);
            this.LbDireccion.TabIndex = 5;
            this.LbDireccion.Text = "Direccion";
            // 
            // LbTelefono
            // 
            this.LbTelefono.AutoSize = true;
            this.LbTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbTelefono.ForeColor = System.Drawing.Color.Black;
            this.LbTelefono.Location = new System.Drawing.Point(479, 116);
            this.LbTelefono.Name = "LbTelefono";
            this.LbTelefono.Size = new System.Drawing.Size(85, 25);
            this.LbTelefono.TabIndex = 4;
            this.LbTelefono.Text = "Telefono";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.ForeColor = System.Drawing.Color.Black;
            this.LbEmail.Location = new System.Drawing.Point(479, 190);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(59, 25);
            this.LbEmail.TabIndex = 3;
            this.LbEmail.Text = "Email";
            // 
            // LbApellido
            // 
            this.LbApellido.AutoSize = true;
            this.LbApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbApellido.ForeColor = System.Drawing.Color.Black;
            this.LbApellido.Location = new System.Drawing.Point(479, 45);
            this.LbApellido.Name = "LbApellido";
            this.LbApellido.Size = new System.Drawing.Size(91, 25);
            this.LbApellido.TabIndex = 2;
            this.LbApellido.Text = "Apellidos";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNombre.ForeColor = System.Drawing.Color.Black;
            this.LbNombre.Location = new System.Drawing.Point(46, 45);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(91, 25);
            this.LbNombre.TabIndex = 1;
            this.LbNombre.Text = "Nombres";
            // 
            // ErrorNumeric
            // 
            this.ErrorNumeric.ContainerControl = this;
            // 
            // FrmCrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 434);
            this.Controls.Add(this.GbCrearCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmCrearCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear cliente";
            this.GbCrearCliente.ResumeLayout(false);
            this.GbCrearCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnGuardar;
        private GroupBox GbCrearCliente;
        private Label LbNombre;
        private Label LbDireccion;
        private Label LbTelefono;
        private Label LbEmail;
        private Label LbApellido;
        private TextBox TxtApellido;
        private TextBox TxtDireccion;
        private TextBox TxtEmail;
        private TextBox TxtTelefono;
        private TextBox TxtNombre;
        private Button BtnCancelar;
        private TextBox TxtNumeroDocumento;
        private Label LbNumeroDocumento;
        private ErrorProvider ErrorNumeric;
    }
}