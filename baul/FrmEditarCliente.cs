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
    public partial class FrmEditarCliente : Form
    {
        public string _id;

        Cliente cliente = new Cliente();
        Validacion validacion = new Validacion();

        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            Consultar();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacion.ValidarTextbox(GbEditarCliente, ErrorNumeric))
                {
                    if (validacion.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (cliente.EditarCliente(Convert.ToInt32(_id),TxtNumeroDocumento, TxtNombre, TxtApellido, TxtDireccion, TxtTelefono, TxtEmail))
                        {
                            MessageBox.Show("Sus datos han sido actualizado correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ErrorNumeric.Clear();
                            FrmListaCliente frm = new FrmListaCliente();
                            frm.Show();
                            this.Close();
                        }
                        else if (cliente._CodigoError == -2146232060)
                        {
                            MessageBox.Show("El cliente ya existe", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(cliente._Mensaje, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de email incorrecto", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacíos", "validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if (cliente.BuscarCliente(Convert.ToInt32(_id)))
                    {
                        TxtNumeroDocumento.Text = cliente._Documento;
                        TxtNombre.Text = cliente._Nombre;
                        TxtApellido.Text = cliente._Apellido;
                        TxtDireccion.Text = cliente._Direccion; 
                        TxtTelefono.Text = cliente._Telefono;
                        TxtEmail.Text = cliente._Email;

                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelarEditar_Click(object sender, EventArgs e)
        {
            FrmListaCliente frm = new FrmListaCliente();
            frm.Show();
            this.Close();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetra(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetra(e);
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.ValidarLetraYnumero(e);
        }
    }
}
