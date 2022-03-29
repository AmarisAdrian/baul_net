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
namespace PresentationLayer
{
    public partial class FrmContainer : Form
    {
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void listadoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaProducto listaproducto = new FrmListaProducto();
            listaproducto.MdiParent = this;
            listaproducto.Show();
        }

        private void crearProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearProducto crearproducto = new FrmCrearProducto();
            crearproducto.MdiParent = this;
            crearproducto.Show();
        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaCliente listacliente = new FrmListaCliente();
            listacliente.MdiParent = this;
            listacliente.Show();
        }

        private void crearClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearCliente crearcliente = new FrmCrearCliente();
            crearcliente.MdiParent = this;
            crearcliente.Show();
        }

        private void listaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaUsuario listausuario = new FrmListaUsuario();
            listausuario.MdiParent = this;
            listausuario.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario crearusuario = new FrmCrearUsuario();
            crearusuario.MdiParent= this;
            crearusuario.Show();
        }

        private void FrmContainer_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.LightSteelBlue;
        }
    }
}
