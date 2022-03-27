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
    public partial class FrmEditarProducto : Form
    {
        Producto producto = new Producto();
        Validacion validacion = new Validacion();
        Actions Cargar = new Actions();
        public string _id { get; set; }
        public FrmEditarProducto()
        {
            InitializeComponent();
        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            Consultar();
        }
        private void CargarCombos()
        {
            try
            {
                Cargar.CargarTalla(CmbTalla);
                CmbTalla.SelectedIndex = -1;
                Cargar.CargarMotivo(CmbMotivo);
                CmbMotivo.SelectedIndex = -1;
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
                    if (producto.BuscarProducto(Convert.ToInt32(_id)))
                    {
                        TxtCodigo.Text = producto._Codigo;
                        TxtReferencia.Text = producto._Referencia;
                        RTxtDescripcion.Text = producto._Descripcion;
                        RTxtDetalleProducto.Text = producto._DetalleProducto;
                        CmbTalla.SelectedValue = producto._IdTalla;
                        TxtCantidad.Text = producto._Cantidad;
                        CmbMotivo.SelectedValue = producto._IdMotivo;
                        TxtPieza.Text = producto._Pieza;
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
                if (producto.BuscarTalla(TxtReferencia, CmbTalla) || Convert.ToString(producto._IdTalla) == Convert.ToString(CmbTalla.SelectedValue))
                {
                    if (producto.BuscarMotivo(TxtReferencia))
                    {
                        EditarProducto();
                    }
                    else
                    {
                        if (Convert.ToString(producto._Pieza) == Convert.ToString(TxtPieza.Text) && Convert.ToString(producto._IdMotivo) == Convert.ToString(CmbMotivo.SelectedValue))
                        {
                            EditarProducto();
                        }
                        else
                        {
                            MessageBox.Show("El motivo y la talla no se pueden modificar","Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("Ya existe un producto con esa talla" , "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmListaProducto frm = new FrmListaProducto();
            frm.Show();
            this.Close();
        }
        private void EditarProducto()
        {
            if (producto.EditarProducto(TxtCodigo, TxtReferencia, RTxtDescripcion, RTxtDetalleProducto, CmbTalla, TxtCantidad, CmbMotivo, TxtPieza))
            {
                MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (producto._CodigoError == -2146232060)
            {
                MessageBox.Show(producto._Mensaje, "El producto ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPieza_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }
    }
}
