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
    public partial class FrmListaProducto : Form
    {
        Producto producto = new Producto();
        public FrmListaProducto()
        {
            InitializeComponent();
        }

        private void FrmListaProducto_Load(object sender, EventArgs e)
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
                    producto.BuscarProducto(DgListaProducto, TxtBuscarProducto);
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

        private void DgListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id = DgListaProducto.Rows[e.RowIndex].Cells[1].Value.ToString();
                FrmEditarProducto frm = new FrmEditarProducto();
                frm._id = id;
                frm.Show();
                this.Hide();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
