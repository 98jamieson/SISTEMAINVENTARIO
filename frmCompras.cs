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
    public partial class frmCompras : Form
    {
        Controlador.ProductosController objProductoControl = new Controlador.ProductosController();
        Controlador.ProveedorController objProveedorControl = new Controlador.ProveedorController();
        Controlador.ComprasController objCompraControl = new Controlador.ComprasController();
        DataTable detalle = new DataTable();
        public frmCompras()
        {
            InitializeComponent();
        }
        #region"Eventos"
        private void frmCompras_Load(object sender, EventArgs e)
        {
            cboProveedor.Items.Add("Escoger Proveedor");
            cboProveedor.SelectedIndex = 0;
            cboProveedor.DisplayMember = "Descripcion";
            cboProveedor.ValueMember = "Valor";
            cboProducto.Items.Add("Escoger producto");
            cboProducto.SelectedIndex = 0;
            cboProducto.DisplayMember = "Descripcion";
            cboProducto.ValueMember = "Valor";
            detalle.Columns.Add("Codigo");
            detalle.Columns.Add("Producto");
            detalle.Columns.Add("Cantidad");
            detalle.Columns.Add("Precio Unitario");
            detalle.Columns.Add("Subtotal");
            foreach (Proveedor datos in objProveedorControl.ObtenerProveedores())
            {
                cboProveedor.Items.Add(new { Valor = datos.prov_id, Descripcion = datos.prov_empresa });
            }
            foreach (Producto datos in objProductoControl.ObtenerProductos())
            {
                cboProducto.Items.Add(new { Valor = datos.id_product, Descripcion = datos.nombre_product });
            }
            bloqueo();
        }
        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor open = new frmProveedor();
            open.Show();
        }
        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProveedor.SelectedIndex != 0)
            {
                var items = cboProveedor.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProveedor.SelectedItem, null);
                var ProveedorEncontrado = objProveedorControl.ProveedorEncontrado(Convert.ToInt32(items));
                txtDireccion.Text = ProveedorEncontrado[0].prov_direccion;
                txtNit.Text = ProveedorEncontrado[0].prov_nit;
            }
        }
        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex != 0)
            {
                var items = cboProducto.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProducto.SelectedItem, null);
                var ProductoEncontrado = objProductoControl.ProductosEncontrado(Convert.ToInt32(items));
                txtPrecio.Text = ProductoEncontrado[0].precio.ToString();
            }
        }
        private void btnGuardaDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = detalle.NewRow();
                row["Codigo"] = cboProducto.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProducto.SelectedItem, null); ;
                row["Producto"] = cboProducto.Text;
                row["Cantidad"] = txtCantidad.Text;
                row["Precio Unitario"] = txtPrecio.Text;
                row["Subtotal"] = txtSubtotal.Text;
                detalle.Rows.Add(row);
                dgvDetalleCompra.DataSource = detalle;
                dgvDetalleCompra.AutoGenerateColumns = true;
                dgvDetalleCompra.AutoSize = true;
                decimal total = 0;
                foreach (DataGridViewRow Registro in dgvDetalleCompra.Rows)
                {
                    total = total + Convert.ToDecimal(Registro.Cells["Subtotal"].Value);
                }
                txtTotal.Text = total.ToString();
                Limpiar();

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "0")
            {
                if (txtCantidad.Text != "")
                {
                    if (cboProducto.SelectedIndex != 0)
                    {
                        txtSubtotal.Text = Convert.ToString(Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text));
                    }

                }

            }
        }
        private void btnCompra_Click(object sender, EventArgs e)
        {
            var IdProveedor = cboProveedor.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProveedor.SelectedItem, null);
            //var IdProducto = cboProducto.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProducto.SelectedItem, null);
            int num = 0;
             num  = objCompraControl.IngresarCompra(Convert.ToInt32(IdProveedor), Convert.ToDecimal(txtTotal.Text), DateTime.Now);
            foreach (DataRow fila in detalle.Rows)
            {
                string Producto = fila["Codigo"].ToString();
                string Cantidad = fila["Cantidad"].ToString();
                string Subtotal = fila["Subtotal"].ToString();
                objCompraControl.IngresarDetalleCompra(Convert.ToInt32(Producto), Convert.ToInt32(Cantidad), Convert.ToDecimal(Subtotal));
                objCompraControl.InvetariarProducto(Convert.ToInt32(Producto));
            }
            MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarPantalla();
            frmReporteCompra open = new frmReporteCompra();
            open.CompraNum = num;
            open.Show();
            this.Close();
        }
        private void btnCancelar__Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region"Metodos"
        public void bloqueo()
        {
            txtPrecio.Enabled = false;
            txtSubtotal.Enabled = false;
            txtDireccion.Enabled = false;
            txtNit.Enabled = false;
            txtTelefono.Enabled = false;
        }
        public void Limpiar()
        {
            cboProducto.SelectedIndex = 0;
            txtPrecio.Text = "";
            txtSubtotal.Text = "";
            txtCantidad.Text = "0";
        }
        public void LimpiarPantalla()
        {
            cboProducto.SelectedIndex = 0;
            txtPrecio.Text = "";
            txtSubtotal.Text = "";
            txtCantidad.Text = "";
            cboProveedor.SelectedIndex = 0;
            txtDireccion.Text = "";
            txtNit.Text = "";
            txtTelefono.Text = "";
            txtTotal.Text = "";
            dgvDetalleCompra.DataSource = null;
        }
        #endregion
    }
}
