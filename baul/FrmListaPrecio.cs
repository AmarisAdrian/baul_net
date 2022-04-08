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
    public partial class FrmListaPrecio : Form
    {
        ListaPrecio listaprecio = new ListaPrecio();
        Validacion validacion = new Validacion();
        public FrmListaPrecio()
        {
            InitializeComponent();
        }
        private void FrmListaPrecio_Load(object sender, EventArgs e)
        {
            DgListaPrecio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ConsultarListaPrecio();
        }
        private void ConsultarListaPrecio()
        {
            try
            {
                listaprecio.ConsultarListaPrecio(DgListaPrecio);
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
                if (RTxtInformacion.Text != "")
                {
                    if (DtFechaFin.Value <= DtFechaInicio.Value)
                    {
                        MessageBox.Show("La fecha final no puede ser menor que la fecha inicial", "validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (listaprecio.GuardarListaPrecio(RTxtInformacion,DtFechaInicio,DtFechaFin,ChkEstado))
                        {
                            MessageBox.Show("Sus datos han sido guardados correctamente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            validacion.LimpiarCampos(this, GbListaPrecio);
                            DtFechaInicio.Value = DateTime.Now;
                            DtFechaFin.Value = DateTime.Now;
                            ChkEstado.Checked = false;
                            ConsultarListaPrecio();
                        }
                        else if (listaprecio._CodigoError == -2146232060)
                        {
                            MessageBox.Show(listaprecio._Mensaje, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        }

    }
}
