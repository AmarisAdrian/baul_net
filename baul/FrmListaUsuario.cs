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
    public partial class FrmListaUsuario : Form
    {
        Usuario usuario = new Usuario();
        public FrmListaUsuario()
        {
            InitializeComponent();
        }

        private void FrmListaUsuario_Load(object sender, EventArgs e)
        {
            DgListaUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CargarUsuario();
        }

        private void CargarUsuario()
        {
            try
            {
                usuario.ConsultarListaUsuario(DgListaUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario Frm = new FrmCrearUsuario();
            Frm.Show();
            this.Hide();
        }

        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtBuscarUsuario.Text != "")
                {
                    BuscarUsuario();
                }
                else
                {
                    CargarUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void BuscarUsuario()
        {
            try
            {
                if (TxtBuscarUsuario.Text != "")
                {
                    usuario.BuscarUsuario(DgListaUsuario, TxtBuscarUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);

            }
        }

        private void DgListaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id = DgListaUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                FrmEditarUsuario frm = new FrmEditarUsuario();
                frm._id = id;
                frm.Show();
                this.Hide();
            }
        }

        private void TxtBuscarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validacion validacion = new Validacion();
                validacion.ValidarLetraYnumero(e);
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (TxtBuscarUsuario.Text != "")
                    {
                        BuscarUsuario();
                    }
                    else
                    {
                        CargarUsuario();
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
