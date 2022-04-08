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
    public partial class FrmAsignarPrecio : Form
    {
        Producto producto = new Producto();
        Validacion validacion = new Validacion();
        public FrmAsignarPrecio()
        {
            InitializeComponent();
        }

        private void FrmAsignarPrecio_Load(object sender, EventArgs e)
        {
            CargarProducto();
        }

        private void CargarProducto()
        {
            try
            {
                producto.ConsultarListaProducto(DgProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void TxtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validacion validacion = new Validacion();
                validacion.ValidarLetraYnumero(e);
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (TxtBuscarProducto.Text != "")
                    {
                        BuscarProducto();
                    }
                    else
                    {
                        CargarProducto();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void BuscarProducto()
        {
            try
            {
                if (TxtBuscarProducto.Text != "")
                {
                    producto.BuscarProducto(DgProductos, TxtBuscarProducto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (validacion.ValidarTextbox(GbDatos, ErrorNumeric))
            {
                //validacion.ValidarProducto(GbDatos,  TxtPrecioUnitario, TxtValor, TxtValorVenta, TxtDescuento, TxtValorDescuento, ErrorNumeric);
                validacion.LimpiarCampos(this, GbDatos);
            }
        }

        private void TxtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }

        private void TxtValorVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TxtValorVenta.Text == "" || TxtValorDescuento.Text == "")
                {
                    TxtValorVenta.Text = "0";
                    TxtValorDescuento.Text = "0";
                }
                else
                {
                    TxtValorDescuento.Text = TxtValorVenta.Text;
                }
                TxtValorDescuento.Text = Convert.ToString(validacion.CalcularDescuento(TxtValorVenta, TxtDescuento));
            }
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TxtValorVenta.Text == "" || TxtValorDescuento.Text == "")
                {
                    TxtValorVenta.Text = "0";
                    TxtValorDescuento.Text = "0";
                }else if (Convert.ToInt32(TxtDescuento.Text) > 100)
                {
                    MessageBox.Show("El descuento no puede ser mayor de 100", "validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TxtValorDescuento.Text = TxtValorVenta.Text;
                }
                TxtValorDescuento.Text = Convert.ToString(validacion.CalcularDescuento(TxtValorVenta, TxtDescuento));
            }
        }

        private void TxtValorVenta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (TxtDescuento.Text == "")
            {
                TxtDescuento.Text = "0";
            }
        }
    }
}
