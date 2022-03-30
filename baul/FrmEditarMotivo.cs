using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class FrmEditarMotivo : Form
    {
        Configuracion configuracion = new Configuracion();
        Validacion validacion = new Validacion();
        public string _id { get; set; }
        public FrmEditarMotivo()
        {
            InitializeComponent();
        }

        private void FrmEditarMotivo_Load(object sender, EventArgs e)
        {
            Consultar();
        }
        private void Consultar()
        {
            try
            {
                if (_id == "")
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (configuracion.BuscarMotivo(Convert.ToInt32(_id)))
                    {
                        TxtNombre.Text = configuracion._Nombre;
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNombre.Text != "")
                {
                   
                    if (configuracion.EditarMotivo(Convert.ToInt32(_id), TxtNombre))
                    {
                        MessageBox.Show("Sus datos han sido actualizado correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmMotivo frm = new FrmMotivo();
                        frm.Show();
                        this.Close();
                    }
                    else if (configuracion._CodigoError == -2146232060)
                    {
                        MessageBox.Show("El cliente ya existe", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre no puede ser vacio", "validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMotivo frm = new FrmMotivo();
            frm.Show();
            this.Close();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetra(e);
        }
    }
}
