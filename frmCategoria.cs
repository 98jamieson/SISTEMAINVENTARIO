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
    public partial class frmCategoria : Form
    {
        Controlador.CategoriaController objCategoriaControl = new Controlador.CategoriaController();
        int caputuraRegistro = 0;
        public frmCategoria()
        {
            InitializeComponent();
        }
        #region"Evnetos"
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            Modelo.UtilidadesVistas objUtilidades = new Modelo.UtilidadesVistas();
            dgvCategoria.DataSource = objCategoriaControl.ObtenerCategoria();
            lstOpcion.DataSource = objUtilidades.opciones();
            dgvCategoria.AutoGenerateColumns = true;
            bloqueo();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstOpcion.SelectedIndex == 0)
            {
                if (objCategoriaControl.IngresarCategoria(txtCategoria.Text, txtDescripcion.Text))
                {
                    MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    dgvCategoria.DataSource = objCategoriaControl.ObtenerCategoria();
                }
            }
            if (lstOpcion.SelectedIndex == 1)
            {
                if (objCategoriaControl.ModificarCategoria(txtCategoria.Text, txtDescripcion.Text,caputuraRegistro))
                {
                    MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    dgvCategoria.DataSource = objCategoriaControl.ObtenerCategoria();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar los registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            if (lstOpcion.SelectedIndex == 2)
            {
                if (objCategoriaControl.EliminarCategoria(caputuraRegistro))
                {
                    MessageBox.Show("Se guardo informacion correctamente.!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    dgvCategoria.DataSource = objCategoriaControl.ObtenerCategoria();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar los registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewCell cell = dgvCategoria.CurrentCell;
                    caputuraRegistro = Convert.ToInt32(cell.Value);
                    var CategoriaEncontrado = objCategoriaControl.CategoriaEncontrado(caputuraRegistro);
                    txtCategoria.Text = CategoriaEncontrado[0].nom_categoria;
                    txtDescripcion.Text = CategoriaEncontrado[0].des_categoria;
                    if (lstOpcion.SelectedIndex == 2)
                    {
                        bloqueo();
                        btnAgregar.Enabled = true;
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
        #endregion
        #region"Metodos"
        public void Limpiar()
        {
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            btnAgregar.Enabled = false;
        }
        public void bloqueo()
        {
            txtCategoria.Enabled = false;
            txtDescripcion.Enabled = false;
        }
        public void habilitar()
        {
            txtCategoria.Enabled = true;
            txtDescripcion.Enabled = true;
            btnAgregar.Enabled = true;
        }
        #endregion
    }
}
