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
    public partial class frmProductos : Form
    {
        Controlador.ProductosController objProductoControl = new Controlador.ProductosController();
        Controlador.CategoriaController objCategoriaControl = new Controlador.CategoriaController();
        int caputuraRegistro = 0;
        public frmProductos()
        {
            InitializeComponent();
        }
        #region "Eventos"
        private void frmProductos_Load(object sender, EventArgs e)
        {
            Modelo.UtilidadesVistas objUtilidades = new Modelo.UtilidadesVistas();
            dgvProducto.DataSource = objProductoControl.ObtenerProductos();
            lstOpcion.DataSource = objUtilidades.opciones();
            dgvProducto.AutoGenerateColumns = true;
            cboCategoria.Items.Add("Escoger categoria");
            cboCategoria.SelectedIndex = 0;
            foreach (Categoria datos in objCategoriaControl.ObtenerCategoria())
            {
                if (!cboCategoria.Items.Cast<string>().Contains(datos.nom_categoria))
                {
                    cboCategoria.Items.Add(datos.nom_categoria);
                }
            }
            bloqueo();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lstOpcion.SelectedIndex == 0)
            {
                if (ValidarCampos() == false)
                {
                    MessageBox.Show("Llene los campos Faltantes.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (objProductoControl.IngresarProductos(txtProducto.Text, txtDescripcion.Text, cboCategoria.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToDecimal(txtPrecio_Vent.Text)))
                    {

                        MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        BorrarError();
                        dgvProducto.DataSource = objProductoControl.ObtenerProductos();
                    }
                }
            }

            if (lstOpcion.SelectedIndex == 1)
            {
                if (ValidarCampos() == false)
                {
                    MessageBox.Show("Llene los campos Faltantes.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (objProductoControl.ModificarProductos(txtProducto.Text, txtDescripcion.Text, cboCategoria.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToDecimal(txtPrecio_Vent.Text), caputuraRegistro))
                    {
                        MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        BorrarError();
                        dgvProducto.DataSource = objProductoControl.ObtenerProductos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al guardar los registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }

                }
            }
            if (lstOpcion.SelectedIndex == 2)
            {
                if (objProductoControl.EliminarProductos(caputuraRegistro))
                {
                    MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    dgvProducto.DataSource = objProductoControl.ObtenerProductos();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar los registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
        }
        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtProducto.Text == "")
            {
                ok = false;
                ErrorName.SetError(txtProducto, "Ingrese el Nombre");

            }

            if (txtPrecio.Text == "")
            {
                ok = false;
               ErrorPrecio.SetError(txtPrecio, "Ingrese el Precio");

            }

         return ok;
        }
        public void BorrarError()
        {
            ErrorName.SetError(txtProducto, "");
            ErrorPrecio.SetError(txtPrecio, "");
            
        }
        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewCell cell = dgvProducto.CurrentCell;
                    caputuraRegistro = Convert.ToInt32(cell.Value);
                    var ProductoEncontrado = objProductoControl.ProductosEncontrado(caputuraRegistro);
                    txtProducto.Text = ProductoEncontrado[0].nombre_product;
                    txtDescripcion.Text = ProductoEncontrado[0].descripcion_product;
                    txtPrecio.Text = ProductoEncontrado[0].precio.ToString();
                    txtPrecio_Vent.Text = ProductoEncontrado[0].precio_venta.ToString();
                    txtCantidad.Text = ProductoEncontrado[0].stock.ToString();
                    var categoria = objCategoriaControl.CategoriaEncontrado(ProductoEncontrado[0].id_categoria);
                    cboCategoria.SelectedItem = categoria[0].nom_categoria;

                    if (lstOpcion.SelectedIndex == 2)
                    {
                        bloqueo();
                        btnGuardar.Enabled = true;
                    }
                    else if (lstOpcion.SelectedIndex == 0)
                    {
                        Limpiar();
                        habilitar();
                    }
                    else
                    {
                        habilitar();
                    }
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
            }
        }
        private void lstOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOpcion.SelectedIndex == 0)
            {
                Limpiar();
                bloqueo();
                habilitar();
            }
            else if (lstOpcion.SelectedIndex == 1)
            {
                Limpiar();
                MessageBox.Show("Seleccione usuario a modificar en el listado.");
                bloqueo();
                cboCategoria.SelectedIndex = 0;
            }
            else if (lstOpcion.SelectedIndex == 2)
            {
                Limpiar();
                MessageBox.Show("Seleccione usuario a modificar en el listado.");
                bloqueo();
                cboCategoria.SelectedIndex = 0;
                
            }
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria open = new frmCategoria();
            open.Show();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region"Metodos"
        public void  Limpiar()
        {
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtPrecio_Vent.Text = "";
            btnGuardar.Enabled = false;
            caputuraRegistro = 0;
        }
        public void bloqueo()
        {
            txtProducto.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtPrecio_Vent.Enabled = false;
            cboCategoria.Enabled = false;
        }
        public void habilitar()
        {
            txtProducto.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtPrecio_Vent.Enabled = true;
            btnGuardar.Enabled = true;
            cboCategoria.Enabled = true;
        }
        #endregion
    }
}
