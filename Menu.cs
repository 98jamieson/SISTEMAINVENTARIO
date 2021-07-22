using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAINVENTARIO
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void logueoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UserControl1 open = new UserControl1();
            //open.Dock = DockStyle.Fill;
            //this.Controls.Add(open);
            //usuariosToolStripMenuItem.Enabled = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin ope = new frmLogin();
            ope.Close();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios open = new frmUsuarios();
            open.Show();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
        }

        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor open = new frmProveedor();
            open.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos open = new frmProductos();
            open.Show();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente open = new frmCliente();
            open.Show();
        }

        private void verFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura open = new frmFactura();
            open.Show();
        }

        private void verCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras open = new frmCompras();
            open.Show();
        }

        private void reporteFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas open = new frmVentas();
            open.Show();

        }

        private void reporteCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCompras open = new frmReporteCompras();
            open.Show();
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformacion open = new frmInformacion();
            open.Show();
        }

        private void verKardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKardex open = new frmKardex();
            open.Show();
        }
    }
}
