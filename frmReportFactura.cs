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
    public partial class frmReportFactura : Form
    {
        public int numeroFact;
        public frmReportFactura()
        {
            InitializeComponent();
        }
        private void frmReportFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteFactura.sp_obtenerDetalle' Puede moverla o quitarla según sea necesario.
            this.sp_obtenerDetalleTableAdapter.Fill(this.ReporteFactura.sp_obtenerDetalle,numeroFact);
            // TODO: esta línea de código carga datos en la tabla 'ReporteFactura.sp_obtenerEncabezado' Puede moverla o quitarla según sea necesario.
            this.sp_obtenerEncabezadoTableAdapter.Fill(this.ReporteFactura.sp_obtenerEncabezado,numeroFact);
          
            this.rptFactura.RefreshReport();
        }
    }
}
