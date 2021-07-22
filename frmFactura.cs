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
using Newtonsoft.Json;

namespace SISTEMAINVENTARIO
{
    public partial class frmFactura : Form
    {
        Controlador.ClienteController objClienteControl = new Controlador.ClienteController();
        Controlador.ProductosController objProductoControl = new Controlador.ProductosController();
        Controlador.FacturacionController objFacturacionControl = new Controlador.FacturacionController();
        DataTable detalle = new DataTable();
        public frmFactura()
        {
            InitializeComponent();
        }
        #region"Eventos"
        private void frmFactura_Load(object sender, EventArgs e)
        {
            try
            {
                cboCliente.Items.Add("Escoger Cliente");
                cboCliente.SelectedIndex = 0;
                cboCliente.DisplayMember = "Descripcion";
                cboCliente.ValueMember = "Valor";
                cboProducto.Items.Add("Escoger producto");
                cboProducto.SelectedIndex = 0;
                cboProducto.DisplayMember = "Descripcion";
                cboProducto.ValueMember = "Valor";
                detalle.Columns.Add("Codigo");
                detalle.Columns.Add("Producto");
                detalle.Columns.Add("Cantidad");
                detalle.Columns.Add("Precio Unitario");
                detalle.Columns.Add("Subtotal");
                List<Cliente> listcliente = new List<Cliente>();

                foreach (Cliente datos in objClienteControl.ObtenerCliente())
                {
                    string nombre = datos.primer_nombre + " " + datos.segundo_nombre + " " + datos.primer_apellido + " " + datos.segundo_apellido;
                    cboCliente.Items.Add(new { Valor = datos.id_Cliente, Descripcion = datos.primer_nombre + " " + datos.segundo_nombre + " " + datos.primer_apellido + " " + datos.segundo_apellido });
                }
                foreach (Producto datos in objProductoControl.ObtenerProductos())
                {
                    cboProducto.Items.Add(new { Valor = datos.id_product, Descripcion = datos.nombre_product });
                }
                bloqueo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != 0)
            {
                var items = cboCliente.SelectedItem.GetType().GetProperty("Valor").GetValue(cboCliente.SelectedItem, null);
                var ClienteEncontrado = objClienteControl.ClienteEncontrado(Convert.ToInt32(items));
                txtDireccion.Text = ClienteEncontrado[0].direccion;
                txtNit.Text = ClienteEncontrado[0].Nit;
            }
        }
        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex != 0)
            {
                var items = cboProducto.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProducto.SelectedItem, null);
                var ProductoEncontrado = objProductoControl.ProductosEncontrado(Convert.ToInt32(items));
                txtPrecio.Text = ProductoEncontrado[0].precio_venta.ToString();
            }
        }
        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmCliente open = new frmCliente();
            open.Show();
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            var IdCliente = cboCliente.SelectedItem.GetType().GetProperty("Valor").GetValue(cboCliente.SelectedItem, null);
            int numeFact = 0;
            //var IdProducto = cboProducto.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProducto.SelectedItem, null);
            numeFact = objFacturacionControl.IngresarFacturacion(Convert.ToInt32(IdCliente), Convert.ToDecimal(txtTotal.Text), DateTime.Now);
            foreach (DataRow fila in detalle.Rows)
            {
                string Producto = fila["Codigo"].ToString();
                string Cantidad = fila["Cantidad"].ToString();
                string Subtotal = fila["Subtotal"].ToString();
                objFacturacionControl.IngresarDetalleFacturacion(Convert.ToInt32(Producto), Convert.ToInt32(Cantidad), Convert.ToDecimal(Subtotal));
                objFacturacionControl.InvetariarProducto(Convert.ToInt32(Producto));
            }
            MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarPantalla();
            frmReportFactura open = new frmReportFactura();
            open.numeroFact = numeFact;
            open.Show();
            this.Close();
        }
        private void btnGuardaDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                var ProductoEncontrado = objProductoControl.ProductosEncontrado(Convert.ToInt32(cboProducto.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProducto.SelectedItem, null)));
                if (ProductoEncontrado[0].stock > 0)
                {
                    DataRow row = detalle.NewRow();
                    row["Codigo"] = cboProducto.SelectedItem.GetType().GetProperty("Valor").GetValue(cboProducto.SelectedItem, null);
                    row["Producto"] = cboProducto.Text;
                    row["Cantidad"] = txtCantidad.Text;
                    row["Precio Unitario"] = txtPrecio.Text;
                    row["Subtotal"] = txtSubtotal.Text;
                    detalle.Rows.Add(row);
                    dgvDetalleFactura.DataSource = detalle;
                    dgvDetalleFactura.AutoGenerateColumns = true;
                    dgvDetalleFactura.AutoSize = true;
                    decimal total = 0;
                    foreach (DataGridViewRow Registro in dgvDetalleFactura.Rows)
                    {
                        total = total + Convert.ToDecimal(Registro.Cells["Subtotal"].Value);
                    }
                    txtTotal.Text = total.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Verifique el stock de los productos y vuelva a intentar a realizar la facturacion.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnCancelar__Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region"Metodos"
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
            cboCliente.SelectedIndex = 0;
            txtDireccion.Text = "";
            txtNit.Text = "";
            txtTelefono.Text = "";
            txtTotal.Text = "";
            dgvDetalleFactura.DataSource = null;
        }
        public void bloqueo()
        {
            txtPrecio.Enabled = false;
            txtSubtotal.Enabled = false;
            txtDireccion.Enabled = false;
            txtNit.Enabled = false;
            txtTelefono.Enabled = false;
        }
        #endregion
    }
}
