namespace PresentationLayer
{
    partial class FrmListaUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbListaUsuario = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnBuscarUsuario = new System.Windows.Forms.Button();
            this.TxtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.DgListaUsuario = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCrearUsuario = new System.Windows.Forms.Button();
            this.GbListaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // GbListaUsuario
            // 
            this.GbListaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.GbListaUsuario.Controls.Add(this.BtnSalir);
            this.GbListaUsuario.Controls.Add(this.BtnBuscarUsuario);
            this.GbListaUsuario.Controls.Add(this.TxtBuscarUsuario);
            this.GbListaUsuario.Controls.Add(this.DgListaUsuario);
            this.GbListaUsuario.Controls.Add(this.BtnCrearUsuario);
            this.GbListaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbListaUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbListaUsuario.Location = new System.Drawing.Point(30, 33);
            this.GbListaUsuario.Name = "GbListaUsuario";
            this.GbListaUsuario.Size = new System.Drawing.Size(1108, 497);
            this.GbListaUsuario.TabIndex = 1;
            this.GbListaUsuario.TabStop = false;
            this.GbListaUsuario.Text = "Lista Usuario";
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
            // 
            // BtnBuscarUsuario
            // 
            this.BtnBuscarUsuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarUsuario.Image = global::PresentationLayer.Properties.Resources.buscar;
            this.BtnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarUsuario.Location = new System.Drawing.Point(687, 56);
            this.BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            this.BtnBuscarUsuario.Size = new System.Drawing.Size(115, 53);
            this.BtnBuscarUsuario.TabIndex = 3;
            this.BtnBuscarUsuario.Text = "Buscar";
            this.BtnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarUsuario.UseVisualStyleBackColor = false;
            this.BtnBuscarUsuario.Click += new System.EventHandler(this.BtnBuscarUsuario_Click);
            // 
            // TxtBuscarUsuario
            // 
            this.TxtBuscarUsuario.Location = new System.Drawing.Point(68, 69);
            this.TxtBuscarUsuario.Name = "TxtBuscarUsuario";
            this.TxtBuscarUsuario.Size = new System.Drawing.Size(597, 29);
            this.TxtBuscarUsuario.TabIndex = 2;
            // 
            // DgListaUsuario
            // 
            this.DgListaUsuario.AllowUserToAddRows = false;
            this.DgListaUsuario.AllowUserToDeleteRows = false;
            this.DgListaUsuario.AllowUserToOrderColumns = true;
            this.DgListaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgListaUsuario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgListaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgListaUsuario.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgListaUsuario.Location = new System.Drawing.Point(68, 115);
            this.DgListaUsuario.Name = "DgListaUsuario";
            this.DgListaUsuario.ReadOnly = true;
            this.DgListaUsuario.RowHeadersVisible = false;
            this.DgListaUsuario.RowTemplate.Height = 25;
            this.DgListaUsuario.Size = new System.Drawing.Size(964, 338);
            this.DgListaUsuario.TabIndex = 1;
            // 
            // Accion
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Accion.DefaultCellStyle = dataGridViewCellStyle5;
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Text = "Editar";
            this.Accion.ToolTipText = "Editar cliente";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // BtnCrearUsuario
            // 
            this.BtnCrearUsuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCrearUsuario.Image = global::PresentationLayer.Properties.Resources.crear;
            this.BtnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearUsuario.Location = new System.Drawing.Point(808, 56);
            this.BtnCrearUsuario.Name = "BtnCrearUsuario";
            this.BtnCrearUsuario.Size = new System.Drawing.Size(109, 53);
            this.BtnCrearUsuario.TabIndex = 0;
            this.BtnCrearUsuario.Text = "Crear";
            this.BtnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearUsuario.UseVisualStyleBackColor = false;
            this.BtnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            // 
            // FrmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 563);
            this.Controls.Add(this.GbListaUsuario);
            this.Name = "FrmListaUsuario";
            this.Text = "Lista Usuario";
            this.Load += new System.EventHandler(this.FrmListaUsuario_Load);
            this.GbListaUsuario.ResumeLayout(false);
            this.GbListaUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GbListaUsuario;
        private Button BtnSalir;
        private Button BtnBuscarUsuario;
        private TextBox TxtBuscarUsuario;
        private DataGridView DgListaUsuario;
        private DataGridViewButtonColumn Accion;
        private Button BtnCrearUsuario;
    }
}