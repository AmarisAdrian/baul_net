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
    public partial class FrmEstadoProducto : Form
    {
        Producto producto = new Producto();
        public FrmEstadoProducto()
        {
            InitializeComponent();
        }

        private void FrmEstadoProducto_Load(object sender, EventArgs e)
        {
            CargarProducto();
        }
        private void CargarProducto()
        {
            try
            {
                producto.ConsultarListaProducto(DgListaProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void DgListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                bool estado = (bool)DgListaProducto.Rows[e.RowIndex].Cells[9].Value;
                string codigo = DgListaProducto.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (estado)
                {
                    DialogResult result = MessageBox.Show("¿Desea deshabilitar?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        CambiarEstado(false, codigo);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Desea habilitar?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        CambiarEstado(true, codigo);
                    }
                }
            }
        }
        private void CambiarEstado(bool estado, string codigo)
        {
            try
            {
                if(producto.CambiarEstado(estado, codigo))
                {
                    MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProducto();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el estado", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }
        private void BuscarProducto()
        {
            try
            {
                if (TxtBuscarProducto.Text != "")
                {
                    producto.BuscarProducto(DgListaProducto, TxtBuscarProducto);
                }
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
