using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baul;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class FrmListaCliente : Form
    {
        Cliente cliente = new Cliente();
        public FrmListaCliente()
        {
            InitializeComponent();
        }

        private void FrmListaCliente_Load(object sender, EventArgs e)
        {
            CargarCliente();
        }

        private void CargarCliente()
        {
            try
            {
                cliente.ConsultarListaCliente(DgListaCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ",ex.Message);
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtBuscarCliente.Text != "")
                {
                    BuscarCliente();
                }
                else
                {
                    CargarCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void BuscarCliente()
        {
            try
            {
                if (TxtBuscarCliente.Text != "")
                {
                    cliente.BuscarCliente(DgListaCliente,TxtBuscarCliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);

            }
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            FrmCrearCliente Frm = new FrmCrearCliente();
            Frm.Show();
            this.Hide();
        }

        private void TxtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion validacion = new Validacion();
            validacion.ValidarLetraYnumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TxtBuscarCliente.Text == "")
                {
                    CargarCliente();
                }
                else
                {
                    BuscarCliente();
                }

            }
        }

        private void DgListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id = DgListaCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                FrmEditarCliente frm = new FrmEditarCliente();
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
