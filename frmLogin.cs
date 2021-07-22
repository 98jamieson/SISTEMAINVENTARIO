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
    public partial class frmLogin : Form
    {
        Controlador.UsuarioController objUserControl = new Controlador.UsuarioController();
        public frmLogin()
        {
            InitializeComponent();

        }
        #region "Eventos"
        private void frmLogin_Load(object sender, EventArgs e)
        {



        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (objUserControl.ValidarUsuario(txtUsuario.Text, txtPassword.Text))
            {
                this.Hide();
                FrmMenu openMenu = new FrmMenu();
                openMenu.Show();
            }
            else
            {
                MessageBox.Show("Verifique usuario o contraseña y vuelva a intentar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





    }

   





        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Metodos"

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                }
            }
            else {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
