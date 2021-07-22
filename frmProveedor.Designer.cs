
namespace SISTEMAINVENTARIO
{
    partial class frmProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.gpbProveedor = new System.Windows.Forms.GroupBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lstOpcion = new System.Windows.Forms.ListBox();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.ErroNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorNit = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorDire = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.gpbProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErroNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDire)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.dgvProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.lblProveedores);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.gpbProveedor);
            this.splitContainer1.Panel2.Controls.Add(this.lstOpcion);
            this.splitContainer1.Panel2.Controls.Add(this.lblOpciones);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(13, 37);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(773, 129);
            this.dgvProveedor.TabIndex = 2;
            this.dgvProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellClick);
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedores.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.ForeColor = System.Drawing.Color.White;
            this.lblProveedores.Location = new System.Drawing.Point(301, 8);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(223, 26);
            this.lblProveedores.TabIndex = 1;
            this.lblProveedores.Text = "LISTADO PROVEEDOR";
            // 
            // gpbProveedor
            // 
            this.gpbProveedor.BackColor = System.Drawing.Color.Transparent;
            this.gpbProveedor.Controls.Add(this.txtNit);
            this.gpbProveedor.Controls.Add(this.lblNit);
            this.gpbProveedor.Controls.Add(this.txtDireccion);
            this.gpbProveedor.Controls.Add(this.lbl_direccion);
            this.gpbProveedor.Controls.Add(this.txtTelefono);
            this.gpbProveedor.Controls.Add(this.lblTelefono);
            this.gpbProveedor.Controls.Add(this.btnCancelar);
            this.gpbProveedor.Controls.Add(this.btnGuardar);
            this.gpbProveedor.Controls.Add(this.txtContacto);
            this.gpbProveedor.Controls.Add(this.lblPassword);
            this.gpbProveedor.Controls.Add(this.txtProveedor);
            this.gpbProveedor.Controls.Add(this.lblProveedor);
            this.gpbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProveedor.Location = new System.Drawing.Point(158, 12);
            this.gpbProveedor.Name = "gpbProveedor";
            this.gpbProveedor.Size = new System.Drawing.Size(617, 233);
            this.gpbProveedor.TabIndex = 2;
            this.gpbProveedor.TabStop = false;
            this.gpbProveedor.Text = "CREACION/EDICION PROVEEDOR";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(220, 97);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(169, 22);
            this.txtNit.TabIndex = 9;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(217, 80);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(24, 16);
            this.lblNit.TabIndex = 8;
            this.lblNit.Text = "Nit";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(10, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 22);
            this.txtDireccion.TabIndex = 7;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(7, 80);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(65, 16);
            this.lbl_direccion.TabIndex = 6;
            this.lbl_direccion.Text = "Direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(434, 36);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(431, 19);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 16);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(528, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(439, 194);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 33);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(220, 37);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(169, 22);
            this.txtContacto.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(217, 20);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contacto";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(10, 37);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(169, 22);
            this.txtProveedor.TabIndex = 1;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(7, 20);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(133, 16);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Nombre de empresa";
            // 
            // lstOpcion
            // 
            this.lstOpcion.FormattingEnabled = true;
            this.lstOpcion.Location = new System.Drawing.Point(16, 31);
            this.lstOpcion.Name = "lstOpcion";
            this.lstOpcion.Size = new System.Drawing.Size(136, 212);
            this.lstOpcion.TabIndex = 1;
            this.lstOpcion.SelectedIndexChanged += new System.EventHandler(this.lstOpcion_SelectedIndexChanged);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.BackColor = System.Drawing.Color.Transparent;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(13, 14);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(128, 16);
            this.lblOpciones.TabIndex = 0;
            this.lblOpciones.Text = "ESCOGER OPCION";
            // 
            // ErroNom
            // 
            this.ErroNom.ContainerControl = this;
            // 
            // ErrorNit
            // 
            this.ErrorNit.ContainerControl = this;
            // 
            // ErrorDire
            // 
            this.ErrorDire.ContainerControl = this;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.gpbProveedor.ResumeLayout(false);
            this.gpbProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErroNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.GroupBox gpbProveedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ListBox lstOpcion;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.ErrorProvider ErroNom;
        private System.Windows.Forms.ErrorProvider ErrorNit;
        private System.Windows.Forms.ErrorProvider ErrorDire;
    }
}