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
    public partial class FrmTalla : Form
    {
        Configuracion configuracion = new Configuracion();
        Validacion validacion = new Validacion();
        public FrmTalla()
        {
            InitializeComponent();
        }

        private void FrmTalla_Load(object sender, EventArgs e)
        {
            CargarTalla();
            DgListaTalla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void CargarTalla()
        {
            try
            {
                configuracion.ConsultarListaTalla(DgListaTalla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNombre.Text != "")
                {
                    if (configuracion.GuardarTalla(TxtNombre))
                    {
                        MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNombre.Clear();
                        CargarTalla();
                    }
                    else
                    {
                        MessageBox.Show(configuracion._Mensaje, "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El campo Nombre no puede estar vacio", "validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void DgListaTalla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id = DgListaTalla.Rows[e.RowIndex].Cells[1].Value.ToString();
                FrmEditarMotivo frm = new FrmEditarMotivo();
                frm._id = id;
                frm.Show();
                this.Hide();
            }
            else if (e.ColumnIndex == 3)
            {
                bool estado = (bool)DgListaTalla.Rows[e.RowIndex].Cells[3].Value;
                string id = DgListaTalla.Rows[e.RowIndex].Cells[1].Value.ToString();

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
                if (configuracion.CambiarEstadoTalla(estado, id))
                {
                    MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTalla();
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

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.ValidarLetraYnumero(e);
        }
    }
}
