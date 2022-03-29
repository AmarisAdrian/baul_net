namespace PresentationLayer
{
    partial class FrmListaProducto
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
            this.GbListaProducto = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.TxtBuscarProducto = new System.Windows.Forms.TextBox();
            this.DgListaProducto = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCrearProducto = new System.Windows.Forms.Button();
            this.GbListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // GbListaProducto
            // 
            this.GbListaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListaProducto.BackColor = System.Drawing.Color.Transparent;
            this.GbListaProducto.Controls.Add(this.BtnSalir);
            this.GbListaProducto.Controls.Add(this.BtnBuscarProducto);
            this.GbListaProducto.Controls.Add(this.TxtBuscarProducto);
            this.GbListaProducto.Controls.Add(this.DgListaProducto);
            this.GbListaProducto.Controls.Add(this.BtnCrearProducto);
            this.GbListaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbListaProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbListaProducto.Location = new System.Drawing.Point(30, 25);
            this.GbListaProducto.Name = "GbListaProducto";
            this.GbListaProducto.Size = new System.Drawing.Size(1108, 497);
            this.GbListaProducto.TabIndex = 1;
            this.GbListaProducto.TabStop = false;
            this.GbListaProducto.Text = "Lista Producto";
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
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarProducto.Image = global::PresentationLayer.Properties.Resources.buscar;
            this.BtnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(687, 56);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(115, 53);
            this.BtnBuscarProducto.TabIndex = 3;
            this.BtnBuscarProducto.Text = "Buscar";
            this.BtnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // TxtBuscarProducto
            // 
            this.TxtBuscarProducto.Location = new System.Drawing.Point(68, 69);
            this.TxtBuscarProducto.Name = "TxtBuscarProducto";
            this.TxtBuscarProducto.Size = new System.Drawing.Size(597, 29);
            this.TxtBuscarProducto.TabIndex = 2;
            this.TxtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarProducto_KeyPress);
            // 
            // DgListaProducto
            // 
            this.DgListaProducto.AllowUserToAddRows = false;
            this.DgListaProducto.AllowUserToDeleteRows = false;
            this.DgListaProducto.AllowUserToOrderColumns = true;
            this.DgListaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgListaProducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgListaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgListaProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgListaProducto.Location = new System.Drawing.Point(68, 115);
            this.DgListaProducto.Name = "DgListaProducto";
            this.DgListaProducto.ReadOnly = true;
            this.DgListaProducto.RowHeadersVisible = false;
            this.DgListaProducto.RowTemplate.Height = 25;
            this.DgListaProducto.Size = new System.Drawing.Size(964, 338);
            this.DgListaProducto.TabIndex = 1;
            this.DgListaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListaProducto_CellContentClick);
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
            // BtnCrearProducto
            // 
            this.BtnCrearProducto.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCrearProducto.Image = global::PresentationLayer.Properties.Resources.crear;
            this.BtnCrearProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearProducto.Location = new System.Drawing.Point(808, 56);
            this.BtnCrearProducto.Name = "BtnCrearProducto";
            this.BtnCrearProducto.Size = new System.Drawing.Size(109, 53);
            this.BtnCrearProducto.TabIndex = 0;
            this.BtnCrearProducto.Text = "Crear";
            this.BtnCrearProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearProducto.UseVisualStyleBackColor = false;
            // 
            // FrmListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 563);
            this.Controls.Add(this.GbListaProducto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmListaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Producto";
            this.Load += new System.EventHandler(this.FrmListaProducto_Load);
            this.GbListaProducto.ResumeLayout(false);
            this.GbListaProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbListaProducto;
        private Button BtnSalir;
        private Button BtnBuscarProducto;
        private TextBox TxtBuscarProducto;
        private DataGridView DgListaProducto;
        private DataGridViewButtonColumn Accion;
        private Button BtnCrearProducto;
    }
}