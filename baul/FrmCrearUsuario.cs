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
    public partial class FrmCrearUsuario : Form
    {
        Actions action = new Actions();
        Validacion validacion = new Validacion();
        Usuario usuario = new Usuario();
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            try
            {
                action.CargarTipoUsuario(CmbTipoUsuario);
                CmbTipoUsuario.SelectedIndex = -1;
                action.CargarEstadoUsuario(CmbEstadoUsuario);
                CmbEstadoUsuario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacion.ValidarTextbox(GbCrearUsuario, ErrorNumeric) && validacion.ValidarCombo(GbCrearUsuario, ErrorNumeric))
                {
                    if (validacion.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (usuario.GuardarUsuario(TxtNumeroDocumento, TxtNombre, TxtApellido, TxtTelefono, TxtEmail,CmbTipoUsuario,CmbEstadoUsuario))
                        {
                            MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            validacion.LimpiarCampos(this, GbCrearUsuario);
                            ErrorNumeric.Clear();
                        }
                        else if (usuario._CodigoError == -2146232060)
                        {
                            MessageBox.Show(usuario._Mensaje, "El cliente ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //ahora desencriptamos
            //txtcadenafinal.Text = validacion.DesEncriptar(txtcadenaencriptada.Text);
            //Vereis que despues de estas instrucciones txtcadenainial y txtcadenafinal contienen lo mismo.
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmListaUsuario frm = new FrmListaUsuario();
            frm.Show();
            this.Close();
        }
    }
}
