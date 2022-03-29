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
    public partial class FrmEditarUsuario : Form
    {
        public string _id;
        Actions action = new Actions();
        Validacion validacion = new Validacion();
        Usuario usuario = new Usuario();
        public FrmEditarUsuario()
        {
            InitializeComponent();
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            CargarCombos();
            Consultar();
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
                    if (usuario.BuscarUsuario(Convert.ToInt32(_id)))
                    {
                        TxtNumeroDocumento.Text = usuario._Documento;
                        TxtNombre.Text = usuario._Nombre;
                        TxtApellido.Text = usuario._Apellido;
                        TxtTelefono.Text = usuario._Telefono;
                        TxtEmail.Text = usuario._Email;
                        CmbTipoUsuario.SelectedValue = usuario._IdTipoUsuario;
                        CmbEstadoUsuario.SelectedValue = usuario._IdEstadoUsuario;
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmListaUsuario frm = new FrmListaUsuario();
            frm.Show();
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacion.ValidarTextbox(GbEditarUsuario, ErrorNumeric) && validacion.ValidarCombo(GbEditarUsuario, ErrorNumeric))
                {
                    if (validacion.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (usuario.EditarUsuario(Convert.ToInt32(_id), TxtNumeroDocumento, TxtNombre, TxtApellido, TxtTelefono, TxtEmail,CmbTipoUsuario,CmbEstadoUsuario))
                        {
                            MessageBox.Show("Sus datos han sido actualizado correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ErrorNumeric.Clear();
                            FrmListaUsuario frm = new FrmListaUsuario();
                            frm.Show();
                            this.Close();
                        }
                        else if (usuario._CodigoError == -2146232060)
                        {
                            MessageBox.Show("El usuario ya existe", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(usuario._Mensaje, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
