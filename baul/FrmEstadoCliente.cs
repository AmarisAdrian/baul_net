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
    public partial class FrmEstadoCliente : Form
    {
        Cliente cliente = new Cliente(); 
        public FrmEstadoCliente()
        {
            InitializeComponent();
        }

        private void FrmEstadoCliente_Load(object sender, EventArgs e)
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
                MessageBox.Show("Error: ", ex.Message);
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
                    cliente.BuscarCliente(DgListaCliente, TxtBuscarCliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);

            }
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
            if (e.ColumnIndex == 8)
            {
                bool estado = (bool)DgListaCliente.Rows[e.RowIndex].Cells[8].Value;
                string id = DgListaCliente.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (estado)
                {
                    DialogResult result = MessageBox.Show("¿Desea deshabilitar?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        CambiarEstado(false, id);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Desea habilitar?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        CambiarEstado(true, id);
                    }
                }
            }
        }
        private void CambiarEstado(bool estado, string id)
        {
            try
            {
                if (cliente.CambiarEstado(estado, id))
                {
                    MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCliente();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
