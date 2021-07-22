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
    public partial class frmKardex : Form
    {
        Controlador.KardexController objKardexControl = new Controlador.KardexController();
        public frmKardex()
        {
            InitializeComponent();
        }
        #region"Evento"
        private void frmKardex_Load(object sender, EventArgs e)
        {
            dgvKardex.DataSource = null;
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvKardex.DataSource = objKardexControl.ObtenerKardex(Convert.ToDateTime(txtDateInicial.Text), Convert.ToDateTime(txtDateFinal.Text));
        }
        #endregion
        #region"Metodo"
        #endregion

    }
}
