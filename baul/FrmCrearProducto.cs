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
    public partial class FrmCrearProducto : Form
    {
        Actions Cargar = new Actions();
        Validacion validacion = new Validacion();
        Producto producto = new Producto();
        public FrmCrearProducto()
        {
            InitializeComponent();
        }

        private void FrmCrearProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
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

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }

        private void TxtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }

        private void TxtPieza_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumero(e);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(validacion.ValidarCombo(GbCrearProducto, ErrorNumeric) && validacion.ValidarTextbox(GbCrearProducto, ErrorNumeric))
            {
                validacion.ValidarProducto(DgCrearProducto,TxtCodigo, TxtReferencia, RTxtDescripcion, RTxtDetalleProducto,CmbTalla, TxtCantidad, CmbMotivo, TxtPieza, ErrorNumeric);
                validacion.LimpiarCampos(this, GbCrearProducto);
            }
        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                validacion.EliminarFilasVacias(DgCrearProducto);
                if (DgCrearProducto[0, 0].Value == null)
                {
                    MessageBox.Show("No se ha agregado ningun producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (producto.GuardarProducto(DgCrearProducto))
                    {
                        MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validacion.LimpiarCampos(this, GbCrearProducto);
                        DgCrearProducto.Rows.Clear();
                        ErrorNumeric.Clear();
                    }
                    else if (producto._CodigoError == -2146232060)
                    {
                        MessageBox.Show(producto._Mensaje, "El producto ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DgCrearProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && DgCrearProducto[0, 0].Value != null)
            {
                DgCrearProducto.Rows.Remove(DgCrearProducto.Rows[e.RowIndex]);
            }
        }


    }
}
