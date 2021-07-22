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
    public partial class frmReporteCompra : Form
    {
        public int CompraNum;
        public frmReporteCompra()
        {
            InitializeComponent();
        }

        private void frmReporteCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteCompra.sp_obtenerEncabezadoCompras' Puede moverla o quitarla según sea necesario.
            this.sp_obtenerEncabezadoComprasTableAdapter.Fill(this.ReporteCompra.sp_obtenerEncabezadoCompras, CompraNum);
            // TODO: esta línea de código carga datos en la tabla 'ReporteCompra.sp_obtenerDetalleCompra' Puede moverla o quitarla según sea necesario.
            this.sp_obtenerDetalleCompraTableAdapter.Fill(this.ReporteCompra.sp_obtenerDetalleCompra, CompraNum);

            this.rptReporteCompra.RefreshReport();
        }
    }
}
