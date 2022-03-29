namespace PresentationLayer
{
    partial class FrmListaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbListaCliente = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.TxtBuscarCliente = new System.Windows.Forms.TextBox();
            this.DgListaCliente = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCrearCliente = new System.Windows.Forms.Button();
            this.GbListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GbListaCliente
            // 
            this.GbListaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListaCliente.BackColor = System.Drawing.Color.Transparent;
            this.GbListaCliente.Controls.Add(this.BtnSalir);
            this.GbListaCliente.Controls.Add(this.BtnBuscarCliente);
            this.GbListaCliente.Controls.Add(this.TxtBuscarCliente);
            this.GbListaCliente.Controls.Add(this.DgListaCliente);
            this.GbListaCliente.Controls.Add(this.BtnCrearCliente);
            this.GbListaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbListaCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbListaCliente.Location = new System.Drawing.Point(36, 25);
            this.GbListaCliente.Name = "GbListaCliente";
            this.GbListaCliente.Size = new System.Drawing.Size(1108, 497);
            this.GbListaCliente.TabIndex = 0;
            this.GbListaCliente.TabStop = false;
            this.GbListaCliente.Text = "Lista Cliente";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Image = global::PresentationLayer.Properties.Resources.exit;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(923, 56);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(109, 53);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarCliente.Image = global::PresentationLayer.Properties.Resources.buscar;
            this.BtnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(687, 56);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(115, 53);
            this.BtnBuscarCliente.TabIndex = 3;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Location = new System.Drawing.Point(68, 69);
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.Size = new System.Drawing.Size(597, 29);
            this.TxtBuscarCliente.TabIndex = 2;
            this.TxtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarCliente_KeyPress);
            // 
            // DgListaCliente
            // 
            this.DgListaCliente.AllowUserToAddRows = false;
            this.DgListaCliente.AllowUserToDeleteRows = false;
            this.DgListaCliente.AllowUserToOrderColumns = true;
            this.DgListaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgListaCliente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgListaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgListaCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgListaCliente.Location = new System.Drawing.Point(68, 115);
            this.DgListaCliente.Name = "DgListaCliente";
            this.DgListaCliente.ReadOnly = true;
            this.DgListaCliente.RowHeadersVisible = false;
            this.DgListaCliente.RowTemplate.Height = 25;
            this.DgListaCliente.Size = new System.Drawing.Size(964, 338);
            this.DgListaCliente.TabIndex = 1;
            this.DgListaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListaCliente_CellContentClick);
            // 
            // Accion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Accion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Text = "Editar";
            this.Accion.ToolTipText = "Editar cliente";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCrearCliente.Image = global::PresentationLayer.Properties.Resources.crear;
            this.BtnCrearCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearCliente.Location = new System.Drawing.Point(808, 56);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(109, 53);
            this.BtnCrearCliente.TabIndex = 0;
            this.BtnCrearCliente.Text = "Crear";
            this.BtnCrearCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearCliente.UseVisualStyleBackColor = false;
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // FrmListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 563);
            this.Controls.Add(this.GbListaCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmListaCliente";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Cliente";
            this.Load += new System.EventHandler(this.FrmListaCliente_Load);
            this.GbListaCliente.ResumeLayout(false);
            this.GbListaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbListaCliente;
        private DataGridView DgListaCliente;
        private Button BtnCrearCliente;
        private DataGridViewButtonColumn Accion;
        private Button BtnBuscarCliente;
        private TextBox TxtBuscarCliente;
        private Button BtnSalir;
    }
}