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
    public partial class frmReporteCompras : Form
    {
        Controlador.ReportesController objReportesControl = new Controlador.ReportesController();
        Controlador.ProveedorController objProveedorControl = new Controlador.ProveedorController();
        public frmReporteCompras()
        {
            InitializeComponent();
        }
        #region"Metodos"
        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            cboFiltro.DisplayMember = "Descripcion";
            cboFiltro.ValueMember = "Valor";
            cboFiltro.Items.Add("Escoger Filtro");
            cboFiltro.SelectedIndex = 0;
            cboFiltro.DisplayMember = "Descripcion";
            cboFiltro.ValueMember = "Valor";
            cboProveedor.DisplayMember = "Descripcion";
            cboProveedor.ValueMember = "Valor";
            cboProveedor.Items.Add("Escoger Proveedor");
            cboProveedor.SelectedIndex = 0;
            cboFiltro.Items.Add(new { Valor = "1", Descripcion = "Filtrar por proveedor" });
            cboFiltro.Items.Add(new { Valor = "2", Descripcion = "Filtrar por producto" });
            foreach (Proveedor datos in objProveedorControl.ObtenerProveedores())
            {
                cboProveedor.Items.Add(new { Valor = datos.prov_id, Descripcion = datos.prov_empresa });
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cboFiltro.SelectedItem.ToString() != "Escoger Filtro")
            {
                var Filtro = cboFiltro.SelectedItem.GetType().GetProperty("Valor").GetValue(cboFiltro.SelectedItem, null);
                if (Convert.ToInt32(Filtro) == 1)
                {
                    dgvCompras.DataSource = objReportesControl.obtenerReporte(Convert.ToDateTime(txtDateInicial.Text), Convert.ToDateTime(txtDateFinal.Text), 1, 0);
                }
                else if (Convert.ToInt32(Filtro) == 2)
                {
                    if (cboProveedor.SelectedItem.ToString() != "Escoger Proveedor")
                    {
                        var IdProveedor = cboProveedor.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProveedor.SelectedItem, null);
                        dgvCompras.DataSource = objReportesControl.obtenerReporte(Convert.ToDateTime(txtDateInicial.Text), Convert.ToDateTime(txtDateFinal.Text), 2, Convert.ToInt32(IdProveedor));
                        dgvCompras.DataSource = objReportesControl.obtenerReporte(Convert.ToDateTime(txtDateInicial.Text), Convert.ToDateTime(txtDateFinal.Text), 2, Convert.ToInt32(IdProveedor));
                    }
                    else
                    {
                        MessageBox.Show("Debe escoger un proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe escoger un tipo de filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion
    }
}
