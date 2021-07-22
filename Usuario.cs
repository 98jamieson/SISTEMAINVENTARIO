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
    public partial class frmUsuarios : Form
    {
        Controlador.UsuarioController objUserControl = new Controlador.UsuarioController();
        int caputuraRegistro = 0;
        #region "EVENTOS"
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void Usuario_Load(object sender, EventArgs e)
        {
            Modelo.UtilidadesVistas objUtilidades = new Modelo.UtilidadesVistas();
            dgvUsuarios.DataSource = objUserControl.ObtenerUsuarios();
            dgvUsuarios.AutoGenerateColumns = true;
            lstOpcion.DataSource = objUtilidades.opciones();
            bloqueo();
            ConfiguracionGridView();
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
                    if (objUserControl.IngresarUsuario(txtUsuario.Text, txtPassword.Text))
                    {
                        MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        BorrarError();
                        dgvUsuarios.DataSource = objUserControl.ObtenerUsuarios();
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
                    if (objUserControl.ModificarUsuario(txtUsuario.Text, txtPassword.Text, caputuraRegistro))
                    {
                        MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        BorrarError();
                        dgvUsuarios.DataSource = objUserControl.ObtenerUsuarios();
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
                if (objUserControl.EliminarrUsuario( caputuraRegistro))
                {
                    MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    dgvUsuarios.DataSource = objUserControl.ObtenerUsuarios();
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
            if (txtUsuario.Text == "")
            {
                ok = false;
                ErroUser.SetError(txtUsuario, "ingrese el nombre");
            }
            if (txtPassword.Text == "")
            {
                ok = false;
                ErrorPass.SetError(txtPassword, "ingrese el nombre");
            }
            return ok;
        }
        public void BorrarError()
        {
            ErroUser.SetError(txtUsuario, "");
            ErrorPass.SetError(txtPassword, "");            
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewCell cell = dgvUsuarios.CurrentCell;
                    caputuraRegistro = Convert.ToInt32(cell.Value);
                    var UsuarioEncontrado = objUserControl.UsuarioEncontrado(caputuraRegistro);
                    txtUsuario.Text =  UsuarioEncontrado[0].user;
                    txtPassword.Text = UsuarioEncontrado[0].pass;
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
        #region "METODOS"
        public void ConfiguracionGridView()
        {
            dgvUsuarios.Columns[0].HeaderText = "Correlativo";
            dgvUsuarios.Columns[1].HeaderText = "Usuarios";
            dgvUsuarios.Columns[2].HeaderText = "Contraseña";
            dgvUsuarios.Columns[3].HeaderText = "fecha creacion";
            dgvUsuarios.Columns[4].HeaderText = "fecha modificacion";
            dgvUsuarios.ReadOnly = true;
            for (int i = 0; i <= dgvUsuarios.Columns.Count - 1; i++)
            {
                dgvUsuarios.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void bloqueo()
        {
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
        }
        public void habilitar()
        {
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            btnGuardar.Enabled = true;
        }
        public void Limpiar()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
            btnGuardar.Enabled = false;
            caputuraRegistro = 0;
        }
        #endregion
    }
}
