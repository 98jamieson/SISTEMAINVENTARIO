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
    public partial class frmProveedor : Form
    {
        Controlador.ProveedorController objProveedorControl = new Controlador.ProveedorController();
        int caputuraRegistro = 0;
        #region "Eventos"
        public frmProveedor()
        {
            InitializeComponent();
        }
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            Modelo.UtilidadesVistas objUtilidades = new Modelo.UtilidadesVistas();
            dgvProveedor.DataSource = objProveedorControl.ObtenerProveedores();
            lstOpcion.DataSource = objUtilidades.opciones();
            dgvProveedor.AutoGenerateColumns = true;
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
                    if (objProveedorControl.IngresarProveedor(txtProveedor.Text, txtContacto.Text, txtTelefono.Text, txtNit.Text, txtDireccion.Text))
                    {
                        MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        BorrarError();
                        dgvProveedor.DataSource = objProveedorControl.ObtenerProveedores();
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
                    if (objProveedorControl.ModificarProveedor(txtProveedor.Text, txtContacto.Text, txtTelefono.Text, txtNit.Text, txtDireccion.Text, caputuraRegistro))
                    {
                        MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        BorrarError();
                        dgvProveedor.DataSource = objProveedorControl.ObtenerProveedores();
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
                if (objProveedorControl.EliminarProveedor(caputuraRegistro))
                {
                    MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    dgvProveedor.DataSource = objProveedorControl.ObtenerProveedores();
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
            if (txtProveedor.Text == "")
            {
                ok = false;
                ErroNom.SetError(txtProveedor, "ingrese el nombre");

            }

            if (txtDireccion.Text == "")
            {
                ok = false;
                ErrorDire.SetError(txtDireccion, "ingrese Direccion");

            }

            if (txtNit.Text == "")
            {
                ok = false;
               ErrorNit.SetError(txtNit, "El NIT es Obligatorio");

            }

            return ok;
        }

        public void BorrarError()
        {
            ErroNom.SetError(txtProveedor, "");
            ErrorDire.SetError(txtDireccion, "");
            ErrorNit.SetError(txtNit, "");
        }











        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewCell cell = dgvProveedor.CurrentCell;
                    caputuraRegistro = Convert.ToInt32(cell.Value);
                    var ProveedorEncontrado = objProveedorControl.ProveedorEncontrado(caputuraRegistro);
                    txtProveedor.Text = ProveedorEncontrado[0].prov_empresa;
                    txtContacto.Text = ProveedorEncontrado[0].prov_contacto;
                    txtTelefono.Text = ProveedorEncontrado[0].prov_telefono;
                    txtDireccion.Text = ProveedorEncontrado[0].prov_direccion;
                    txtNit.Text = ProveedorEncontrado[0].prov_nit;
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
            }
            else if (lstOpcion.SelectedIndex == 2)
            {
                Limpiar();
                MessageBox.Show("Seleccione usuario a modificar en el listado.");
                bloqueo();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Metodos"
        public void Limpiar()
        {
            txtProveedor.Text = "";
            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtNit.Text = "";
            btnGuardar.Enabled = false;
            caputuraRegistro = 0;
        }
        public void bloqueo()
        {
            txtProveedor.Enabled = false;
            txtTelefono.Enabled = false;
            txtNit.Enabled = false;
            txtDireccion.Enabled = false;
            txtContacto.Enabled = false;
        }
        public void habilitar()
        {
            txtProveedor.Enabled = true;
            txtTelefono.Enabled = true;
            txtNit.Enabled = true;
            txtDireccion.Enabled = true;
            txtContacto.Enabled = true;
            btnGuardar.Enabled = true;
        }

        #endregion
    }
}
