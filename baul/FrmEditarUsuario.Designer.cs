namespace PresentationLayer
{
    partial class FrmEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarUsuario));
            this.GbEditarUsuario = new System.Windows.Forms.GroupBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.CmbEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.LblEstadoUsuario = new System.Windows.Forms.Label();
            this.CmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.LbNumeroDocumento = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LbTelefono = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbApellido = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.ErrorNumeric = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbEditarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // GbEditarUsuario
            // 
            this.GbEditarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbEditarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.GbEditarUsuario.Controls.Add(this.BtnVolver);
            this.GbEditarUsuario.Controls.Add(this.BtnEditar);
            this.GbEditarUsuario.Controls.Add(this.CmbEstadoUsuario);
            this.GbEditarUsuario.Controls.Add(this.LblEstadoUsuario);
            this.GbEditarUsuario.Controls.Add(this.CmbTipoUsuario);
            this.GbEditarUsuario.Controls.Add(this.LblTipoUsuario);
            this.GbEditarUsuario.Controls.Add(this.TxtNumeroDocumento);
            this.GbEditarUsuario.Controls.Add(this.LbNumeroDocumento);
            this.GbEditarUsuario.Controls.Add(this.TxtApellido);
            this.GbEditarUsuario.Controls.Add(this.TxtEmail);
            this.GbEditarUsuario.Controls.Add(this.TxtTelefono);
            this.GbEditarUsuario.Controls.Add(this.TxtNombre);
            this.GbEditarUsuario.Controls.Add(this.LbTelefono);
            this.GbEditarUsuario.Controls.Add(this.LbEmail);
            this.GbEditarUsuario.Controls.Add(this.LbApellido);
            this.GbEditarUsuario.Controls.Add(this.LbNombre);
            this.GbEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbEditarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbEditarUsuario.ForeColor = System.Drawing.Color.Black;
            this.GbEditarUsuario.Location = new System.Drawing.Point(31, 33);
            this.GbEditarUsuario.Name = "GbEditarUsuario";
            this.GbEditarUsuario.Size = new System.Drawing.Size(887, 376);
            this.GbEditarUsuario.TabIndex = 3;
            this.GbEditarUsuario.TabStop = false;
            this.GbEditarUsuario.Text = "Datos";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(479, 279);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(151, 57);
            this.BtnVolver.TabIndex = 26;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Image = global::PresentationLayer.Properties.Resources.guardar1;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(661, 279);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEditar.Size = new System.Drawing.Size(151, 57);
            this.BtnEditar.TabIndex = 25;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // CmbEstadoUsuario
            // 
            this.CmbEstadoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoUsuario.FormattingEnabled = true;
            this.CmbEstadoUsuario.Location = new System.Drawing.Point(46, 294);
            this.CmbEstadoUsuario.Name = "CmbEstadoUsuario";
            this.CmbEstadoUsuario.Size = new System.Drawing.Size(375, 29);
            this.CmbEstadoUsuario.TabIndex = 22;
            // 
            // LblEstadoUsuario
            // 
            this.LblEstadoUsuario.AutoSize = true;
            this.LblEstadoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEstadoUsuario.ForeColor = System.Drawing.Color.Black;
            this.LblEstadoUsuario.Location = new System.Drawing.Point(46, 266);
            this.LblEstadoUsuario.Name = "LblEstadoUsuario";
            this.LblEstadoUsuario.Size = new System.Drawing.Size(139, 25);
            this.LblEstadoUsuario.TabIndex = 21;
            this.LblEstadoUsuario.Text = "Estado Usuario";
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.Location = new System.Drawing.Point(479, 219);
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(375, 29);
            this.CmbTipoUsuario.TabIndex = 20;
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTipoUsuario.ForeColor = System.Drawing.Color.Black;
            this.LblTipoUsuario.Location = new System.Drawing.Point(479, 191);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(119, 25);
            this.LblTipoUsuario.TabIndex = 19;
            this.LblTipoUsuario.Text = "Tipo Usuario";
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(46, 144);
            this.TxtNumeroDocumento.MaxLength = 20;
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(375, 29);
            this.TxtNumeroDocumento.TabIndex = 8;
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
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(479, 73);
            this.TxtApellido.MaxLength = 300;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(375, 29);
            this.TxtApellido.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(46, 219);
            this.TxtEmail.MaxLength = 254;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(378, 29);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(479, 144);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(375, 29);
            this.TxtTelefono.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(46, 73);
            this.TxtNombre.MaxLength = 300;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(375, 29);
            this.TxtNombre.TabIndex = 6;
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
            this.LbEmail.Location = new System.Drawing.Point(46, 191);
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
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 442);
            this.Controls.Add(this.GbEditarUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuario";
            this.Load += new System.EventHandler(this.FrmEditarUsuario_Load);
            this.GbEditarUsuario.ResumeLayout(false);
            this.GbEditarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbEditarUsuario;
        private ComboBox CmbEstadoUsuario;
        private Label LblEstadoUsuario;
        private ComboBox CmbTipoUsuario;
        private Label LblTipoUsuario;
        private TextBox TxtNumeroDocumento;
        private Label LbNumeroDocumento;
        private TextBox TxtApellido;
        private TextBox TxtEmail;
        private TextBox TxtTelefono;
        private TextBox TxtNombre;
        private Label LbTelefono;
        private Label LbEmail;
        private Label LbApellido;
        private Label LbNombre;
        private Button BtnVolver;
        private Button BtnEditar;
        private ErrorProvider ErrorNumeric;
    }
}