using BusinessLayer;
namespace baul
{
    public partial class FrmCrearCliente : Form
    {
        Cliente cliente = new Cliente();
        Validacion validacion = new Validacion();
        public FrmCrearCliente()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacion.ValidarTextbox(GbCrearCliente, ErrorNumeric))
                {
                    if (validacion.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (cliente.GuardarCliente(TxtNumeroDocumento, TxtNombre, TxtApellido, TxtDireccion, TxtTelefono, TxtEmail))
                        {
                            MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            validacion.LimpiarCampos(this, GbCrearCliente);
                            ErrorNumeric.Clear();
                        }
                        else if (cliente._CodigoError == -2146232060)
                        {
                            MessageBox.Show(cliente._Mensaje, "El cliente ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}