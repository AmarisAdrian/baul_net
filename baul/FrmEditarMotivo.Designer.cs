namespace PresentationLayer
{
    partial class FrmEditarMotivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarMotivo));
            this.DbEditarMotivo = new System.Windows.Forms.GroupBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.DbEditarMotivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // DbEditarMotivo
            // 
            this.DbEditarMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbEditarMotivo.BackColor = System.Drawing.Color.Transparent;
            this.DbEditarMotivo.Controls.Add(this.BtnVolver);
            this.DbEditarMotivo.Controls.Add(this.BtnEditar);
            this.DbEditarMotivo.Controls.Add(this.TxtNombre);
            this.DbEditarMotivo.Controls.Add(this.LbNombre);
            this.DbEditarMotivo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DbEditarMotivo.Location = new System.Drawing.Point(25, 22);
            this.DbEditarMotivo.Name = "DbEditarMotivo";
            this.DbEditarMotivo.Size = new System.Drawing.Size(439, 236);
            this.DbEditarMotivo.TabIndex = 0;
            this.DbEditarMotivo.TabStop = false;
            this.DbEditarMotivo.Text = "Datos";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVolver.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(79, 126);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(150, 57);
            this.BtnVolver.TabIndex = 28;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Image = global::PresentationLayer.Properties.Resources.guardar1;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(260, 126);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEditar.Size = new System.Drawing.Size(150, 57);
            this.BtnEditar.TabIndex = 27;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(26, 66);
            this.TxtNombre.MaxLength = 300;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(384, 29);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNombre.ForeColor = System.Drawing.Color.Black;
            this.LbNombre.Location = new System.Drawing.Point(26, 38);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(83, 25);
            this.LbNombre.TabIndex = 4;
            this.LbNombre.Text = "Nombre";
            // 
            // FrmEditarMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 285);
            this.Controls.Add(this.DbEditarMotivo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarMotivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Motivo";
            this.Load += new System.EventHandler(this.FrmEditarMotivo_Load);
            this.DbEditarMotivo.ResumeLayout(false);
            this.DbEditarMotivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox DbEditarMotivo;
        private TextBox TxtNombre;
        private Label LbNombre;
        private Button BtnVolver;
        private Button BtnEditar;
    }
}