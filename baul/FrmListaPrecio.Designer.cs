namespace PresentationLayer
{
    partial class FrmListaPrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaPrecio));
            this.GbListaPrecio = new System.Windows.Forms.GroupBox();
            this.ChkEstado = new System.Windows.Forms.CheckBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.LbFechaFin = new System.Windows.Forms.Label();
            this.DtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.LbFechaInicio = new System.Windows.Forms.Label();
            this.RTxtInformacion = new System.Windows.Forms.RichTextBox();
            this.LbInformacion = new System.Windows.Forms.Label();
            this.DgListaPrecio = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbListaPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // GbListaPrecio
            // 
            this.GbListaPrecio.BackColor = System.Drawing.Color.Transparent;
            this.GbListaPrecio.Controls.Add(this.ChkEstado);
            this.GbListaPrecio.Controls.Add(this.BtnVolver);
            this.GbListaPrecio.Controls.Add(this.BtnGuardar);
            this.GbListaPrecio.Controls.Add(this.DtFechaFin);
            this.GbListaPrecio.Controls.Add(this.LbFechaFin);
            this.GbListaPrecio.Controls.Add(this.DtFechaInicio);
            this.GbListaPrecio.Controls.Add(this.LbFechaInicio);
            this.GbListaPrecio.Controls.Add(this.RTxtInformacion);
            this.GbListaPrecio.Controls.Add(this.LbInformacion);
            this.GbListaPrecio.Controls.Add(this.DgListaPrecio);
            this.GbListaPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbListaPrecio.Location = new System.Drawing.Point(12, 12);
            this.GbListaPrecio.Name = "GbListaPrecio";
            this.GbListaPrecio.Size = new System.Drawing.Size(776, 612);
            this.GbListaPrecio.TabIndex = 0;
            this.GbListaPrecio.TabStop = false;
            this.GbListaPrecio.Text = "Datos";
            // 
            // ChkEstado
            // 
            this.ChkEstado.AutoSize = true;
            this.ChkEstado.Location = new System.Drawing.Point(438, 224);
            this.ChkEstado.Name = "ChkEstado";
            this.ChkEstado.Size = new System.Drawing.Size(91, 25);
            this.ChkEstado.TabIndex = 28;
            this.ChkEstado.Text = "Habilitar";
            this.ChkEstado.UseVisualStyleBackColor = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(577, 528);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(151, 57);
            this.BtnVolver.TabIndex = 27;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolver.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Image = global::PresentationLayer.Properties.Resources.guardar1;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(329, 283);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnGuardar.Size = new System.Drawing.Size(151, 57);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DtFechaFin
            // 
            this.DtFechaFin.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFechaFin.Location = new System.Drawing.Point(438, 165);
            this.DtFechaFin.Name = "DtFechaFin";
            this.DtFechaFin.Size = new System.Drawing.Size(290, 29);
            this.DtFechaFin.TabIndex = 7;
            // 
            // LbFechaFin
            // 
            this.LbFechaFin.AutoSize = true;
            this.LbFechaFin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbFechaFin.ForeColor = System.Drawing.Color.Black;
            this.LbFechaFin.Location = new System.Drawing.Point(438, 137);
            this.LbFechaFin.Name = "LbFechaFin";
            this.LbFechaFin.Size = new System.Drawing.Size(93, 25);
            this.LbFechaFin.TabIndex = 6;
            this.LbFechaFin.Text = "Fecha Fin";
            // 
            // DtFechaInicio
            // 
            this.DtFechaInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFechaInicio.Location = new System.Drawing.Point(438, 85);
            this.DtFechaInicio.Name = "DtFechaInicio";
            this.DtFechaInicio.Size = new System.Drawing.Size(290, 29);
            this.DtFechaInicio.TabIndex = 5;
            // 
            // LbFechaInicio
            // 
            this.LbFechaInicio.AutoSize = true;
            this.LbFechaInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.LbFechaInicio.Location = new System.Drawing.Point(438, 57);
            this.LbFechaInicio.Name = "LbFechaInicio";
            this.LbFechaInicio.Size = new System.Drawing.Size(114, 25);
            this.LbFechaInicio.TabIndex = 4;
            this.LbFechaInicio.Text = "Fecha Inicio";
            // 
            // RTxtInformacion
            // 
            this.RTxtInformacion.Location = new System.Drawing.Point(41, 85);
            this.RTxtInformacion.Name = "RTxtInformacion";
            this.RTxtInformacion.Size = new System.Drawing.Size(358, 164);
            this.RTxtInformacion.TabIndex = 3;
            this.RTxtInformacion.Text = "";
            // 
            // LbInformacion
            // 
            this.LbInformacion.AutoSize = true;
            this.LbInformacion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbInformacion.ForeColor = System.Drawing.Color.Black;
            this.LbInformacion.Location = new System.Drawing.Point(41, 57);
            this.LbInformacion.Name = "LbInformacion";
            this.LbInformacion.Size = new System.Drawing.Size(117, 25);
            this.LbInformacion.TabIndex = 2;
            this.LbInformacion.Text = "Información";
            // 
            // DgListaPrecio
            // 
            this.DgListaPrecio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgListaPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion});
            this.DgListaPrecio.Location = new System.Drawing.Point(41, 358);
            this.DgListaPrecio.Name = "DgListaPrecio";
            this.DgListaPrecio.RowTemplate.Height = 25;
            this.DgListaPrecio.Size = new System.Drawing.Size(687, 150);
            this.DgListaPrecio.TabIndex = 0;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Text = "Asignar producto";
            this.Accion.UseColumnTextForButtonValue = true;
            this.Accion.Width = 66;
            // 
            // FrmListaPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.GbListaPrecio);
            this.DoubleBuffered = true;
            this.Name = "FrmListaPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Precio";
            this.Load += new System.EventHandler(this.FrmListaPrecio_Load);
            this.GbListaPrecio.ResumeLayout(false);
            this.GbListaPrecio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbListaPrecio;
        private DataGridView DgListaPrecio;
        private DateTimePicker DtFechaInicio;
        private Label LbFechaInicio;
        private RichTextBox RTxtInformacion;
        private Label LbInformacion;
        private DateTimePicker DtFechaFin;
        private Label LbFechaFin;
        private Button BtnGuardar;
        private Button BtnVolver;
        private CheckBox ChkEstado;
        private DataGridViewButtonColumn Accion;
    }
}