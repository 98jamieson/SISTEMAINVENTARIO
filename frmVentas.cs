using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace SISTEMAINVENTARIO
{
    public partial class frmVentas : Form
    {
        Controlador.ReportesController objReportesControl = new Controlador.ReportesController();
        Controlador.ProductosController objProductoControl = new Controlador.ProductosController();
        public frmVentas()
        {
            InitializeComponent();
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            cboFiltro.DisplayMember = "Descripcion";
            cboFiltro.ValueMember = "Valor";
            cboFiltro.Items.Add("Escoger Filtro");
            cboFiltro.SelectedIndex = 0;
            cboFiltro.DisplayMember = "Descripcion";
            cboFiltro.ValueMember = "Valor";
            cboFiltro.Items.Add(new { Valor = "1", Descripcion = "Filtrar por cliente" });
            cboFiltro.Items.Add(new { Valor = "2", Descripcion = "Filtrar por producto" });
            cboProducto.DisplayMember = "Descripcion";
            cboProducto.ValueMember = "Valor";
            cboProducto.Items.Add("Escoger producto vendido");
            cboProducto.SelectedIndex = 0;
            foreach (Producto datos in objProductoControl.ObtenerProductos())
            {
                cboProducto.Items.Add(new { Valor = datos.id_product, Descripcion = datos.nombre_product});
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cboFiltro.SelectedItem.ToString() != "Escoger Filtro")
            {
                var Filtro = cboFiltro.SelectedItem.GetType().GetProperty("Valor").GetValue(cboFiltro.SelectedItem, null);
                if (Convert.ToInt32(Filtro) == 1)
                {
                    dgvCliente.DataSource = objReportesControl.obtenerReporteVenta(Convert.ToDateTime(txtDateInicial.Text), Convert.ToDateTime(txtDateFinal.Text), 1, 0);
                }
                else if (Convert.ToInt32(Filtro) == 2)
                {
                    if (cboProducto.SelectedItem.ToString() != "Escoger producto vendido")
                    {
                        var Idproducto = cboProducto.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProducto.SelectedItem, null);
                        dgvCliente.DataSource = objReportesControl.obtenerReporteVenta(Convert.ToDateTime(txtDateInicial.Text), Convert.ToDateTime(txtDateFinal.Text), 2, Convert.ToInt32(Idproducto));
                    }
                    else
                    {
                        MessageBox.Show("Debe escoger un producto vendido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe escoger un tipo de filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
