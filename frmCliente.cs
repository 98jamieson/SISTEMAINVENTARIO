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
    public partial class frmCliente : Form
    {
        Controlador.ClienteController objClienteControl = new Controlador.ClienteController();
        int caputuraRegistro = 0;

        public object ErrorProvider1 { get; private set; }

        public frmCliente()
        {
            InitializeComponent();
        }
        #region"Eventos"
        private void frmCliente_Load(object sender, EventArgs e)
        {
            Modelo.UtilidadesVistas objUtilidades = new Modelo.UtilidadesVistas();
            dgvCliente.DataSource = objClienteControl.ObtenerCliente();
            lstOpcion.DataSource = objUtilidades.opciones();
            dgvCliente.AutoGenerateColumns = true;
            bloqueo();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lstOpcion.SelectedIndex == 0)
            {

                if (ValidarCampos()==false)
                {
                    MessageBox.Show("Llene los campos Faltantes.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    if (objClienteControl.IngresarCliente(txtPrim_nom.Text, txtSeg_nom.Text, txtPrimeApellido.Text, txtSegApellido.Text, txtDireccion.Text, txtNit.Text, DateTime.Now))
                    {

                        MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        BorrarError();
                        dgvCliente.DataSource = objClienteControl.ObtenerCliente();
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
                    if (objClienteControl.ModificarCliente(txtPrim_nom.Text, txtSeg_nom.Text, txtPrimeApellido.Text, txtSegApellido.Text, txtDireccion.Text, txtNit.Text, DateTime.Now, caputuraRegistro))
                    {
                        MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        BorrarError();
                        dgvCliente.DataSource = objClienteControl.ObtenerCliente();
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
                if (objClienteControl.EliminarProductos(caputuraRegistro))
                {
                    MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    dgvCliente.DataSource = objClienteControl.ObtenerCliente();
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
            if ( txtPrim_nom.Text == "")
            {
                ok = false;
               ErrorAp.SetError(txtPrim_nom, "ingrese el nombre");
            }
            if (txtSeg_nom.Text == "")
            {
                ok = false;
                ErrorSn.SetError(txtSeg_nom, "ingrese el nombre");
            }
            if (txtNit.Text == "")
            {
                ok = false;
                NitError.SetError(txtNit, "El NIT es Obligatorio");
            }
            return ok;
        }
        public void BorrarError()
        {
            ErrorAp.SetError(txtPrim_nom, "");
            ErrorSn.SetError(txtSeg_nom, "");
            NitError.SetError(txtNit, "");
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
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewCell cell = dgvCliente.CurrentCell;
                    caputuraRegistro = Convert.ToInt32(cell.Value);
                    var ClienteEncontrado = objClienteControl.ClienteEncontrado(caputuraRegistro);
                    txtPrim_nom.Text = ClienteEncontrado[0].primer_nombre;
                    txtSeg_nom.Text = ClienteEncontrado[0].segundo_nombre;
                    txtPrimeApellido.Text = ClienteEncontrado[0].primer_apellido;
                    txtSegApellido.Text = ClienteEncontrado[0].segundo_apellido;
                    txtDireccion.Text = ClienteEncontrado[0].direccion;
                    txtNit.Text = ClienteEncontrado[0].Nit;

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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region"Metodos"
        public void Limpiar()
        {
            txtDireccion.Text = "";
            txtNit.Text = "";
            txtPrimeApellido.Text = "";
            txtSegApellido.Text = "";
            txtPrim_nom.Text = "";
            txtSeg_nom.Text = "";
            btnGuardar.Enabled = false;
            caputuraRegistro = 0;
        }
        public void bloqueo()
        {
            txtDireccion.Enabled = false;
            txtPrimeApellido.Enabled = false;
            txtSegApellido.Enabled = false;
            txtSeg_nom.Enabled = false;
            txtPrim_nom.Enabled = false;
            txtNit.Enabled = false;
        }
        public void habilitar()
        {
            txtDireccion.Enabled = true;
            txtPrimeApellido.Enabled = true;
            txtSegApellido.Enabled = true;
            txtPrim_nom.Enabled = true;
            txtSeg_nom.Enabled = true;
            txtNit.Enabled = true;
            btnGuardar.Enabled = true;
        }


        #endregion

        
    }
}
