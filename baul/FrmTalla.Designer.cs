namespace PresentationLayer
{
    partial class FrmTalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalla));
            this.GbTalla = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgListaTalla = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.GbTalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaTalla)).BeginInit();
            this.SuspendLayout();
            // 
            // GbTalla
            // 
            this.GbTalla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbTalla.BackColor = System.Drawing.Color.Transparent;
            this.GbTalla.Controls.Add(this.BtnSalir);
            this.GbTalla.Controls.Add(this.BtnVolver);
            this.GbTalla.Controls.Add(this.BtnGuardar);
            this.GbTalla.Controls.Add(this.DgListaTalla);
            this.GbTalla.Controls.Add(this.TxtNombre);
            this.GbTalla.Controls.Add(this.LbNombre);
            this.GbTalla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbTalla.Location = new System.Drawing.Point(49, 36);
            this.GbTalla.Name = "GbTalla";
            this.GbTalla.Size = new System.Drawing.Size(406, 492);
            this.GbTalla.TabIndex = 1;
            this.GbTalla.TabStop = false;
            this.GbTalla.Text = "Datos";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(210, 395);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(150, 57);
            this.BtnSalir.TabIndex = 27;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVolver.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(271, 575);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(150, 57);
            this.BtnVolver.TabIndex = 26;
            this.BtnVolver.Text = "Salir";
            this.BtnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolver.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Image = global::PresentationLayer.Properties.Resources.guardar1;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(210, 129);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGuardar.Size = new System.Drawing.Size(150, 57);
            this.BtnGuardar.TabIndex = 25;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DgListaTalla
            // 
            this.DgListaTalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaTalla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion});
            this.DgListaTalla.Location = new System.Drawing.Point(32, 217);
            this.DgListaTalla.Name = "DgListaTalla";
            this.DgListaTalla.RowTemplate.Height = 25;
            this.DgListaTalla.Size = new System.Drawing.Size(328, 150);
            this.DgListaTalla.TabIndex = 3;
            this.DgListaTalla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListaTalla_CellContentClick);
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Text = "Editar";
            this.Accion.ToolTipText = "Editar";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(32, 79);
            this.TxtNombre.MaxLength = 300;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(328, 29);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNombre.ForeColor = System.Drawing.Color.Black;
            this.LbNombre.Location = new System.Drawing.Point(32, 51);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(83, 25);
            this.LbNombre.TabIndex = 2;
            this.LbNombre.Text = "Nombre";
            // 
            // FrmTalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 565);
            this.Controls.Add(this.GbTalla);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talla";
            this.Load += new System.EventHandler(this.FrmTalla_Load);
            this.GbTalla.ResumeLayout(false);
            this.GbTalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaTalla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbTalla;
        private Button BtnVolver;
        private Button BtnGuardar;
        private DataGridView DgListaTalla;
        private DataGridViewButtonColumn Accion;
        private TextBox TxtNombre;
        private Label LbNombre;
        private Button BtnSalir;
    }
}