
namespace SISTEMAINVENTARIO
{
    partial class frmCliente
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblSegApellido = new System.Windows.Forms.Label();
            this.txtSegApellido = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtPrimeApellido = new System.Windows.Forms.TextBox();
            this.txtSeg_nom = new System.Windows.Forms.TextBox();
            this.lblSeg_nom = new System.Windows.Forms.Label();
            this.txtPrim_nom = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPrim_nom = new System.Windows.Forms.Label();
            this.lstOpcion = new System.Windows.Forms.ListBox();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.ErrorSn = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorAp = new System.Windows.Forms.ErrorProvider(this.components);
            this.NitError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gpbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NitError)).BeginInit();
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
            this.splitContainer1.Panel1.BackgroundImage = global::SISTEMAINVENTARIO.Properties.Resources._35152;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.dgvCliente);
            this.splitContainer1.Panel1.Controls.Add(this.lblCliente);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::SISTEMAINVENTARIO.Properties.Resources._35152;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel2.Controls.Add(this.gpbCliente);
            this.splitContainer1.Panel2.Controls.Add(this.lstOpcion);
            this.splitContainer1.Panel2.Controls.Add(this.lblOpciones);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 4;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(13, 37);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(773, 129);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(301, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(192, 26);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "LISTADO CLIENTES";
            // 
            // gpbCliente
            // 
            this.gpbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gpbCliente.Controls.Add(this.lblDireccion);
            this.gpbCliente.Controls.Add(this.txtDireccion);
            this.gpbCliente.Controls.Add(this.lblNit);
            this.gpbCliente.Controls.Add(this.txtNit);
            this.gpbCliente.Controls.Add(this.lblSegApellido);
            this.gpbCliente.Controls.Add(this.txtSegApellido);
            this.gpbCliente.Controls.Add(this.lblPrimerApellido);
            this.gpbCliente.Controls.Add(this.txtPrimeApellido);
            this.gpbCliente.Controls.Add(this.txtSeg_nom);
            this.gpbCliente.Controls.Add(this.lblSeg_nom);
            this.gpbCliente.Controls.Add(this.txtPrim_nom);
            this.gpbCliente.Controls.Add(this.btnCancelar);
            this.gpbCliente.Controls.Add(this.btnGuardar);
            this.gpbCliente.Controls.Add(this.lblPrim_nom);
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.ForeColor = System.Drawing.Color.White;
            this.gpbCliente.Location = new System.Drawing.Point(158, 12);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(617, 233);
            this.gpbCliente.TabIndex = 2;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "CREACION/EDICION CLIENTE";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 119);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 16);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(10, 135);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(211, 92);
            this.txtDireccion.TabIndex = 15;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(236, 119);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(27, 16);
            this.lblNit.TabIndex = 14;
            this.lblNit.Text = "Nit";
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(239, 135);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(211, 22);
            this.txtNit.TabIndex = 13;
            // 
            // lblSegApellido
            // 
            this.lblSegApellido.AutoSize = true;
            this.lblSegApellido.Location = new System.Drawing.Point(236, 73);
            this.lblSegApellido.Name = "lblSegApellido";
            this.lblSegApellido.Size = new System.Drawing.Size(131, 16);
            this.lblSegApellido.TabIndex = 12;
            this.lblSegApellido.Text = "Segundo apellido";
            // 
            // txtSegApellido
            // 
            this.txtSegApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegApellido.Location = new System.Drawing.Point(239, 89);
            this.txtSegApellido.Name = "txtSegApellido";
            this.txtSegApellido.Size = new System.Drawing.Size(211, 22);
            this.txtSegApellido.TabIndex = 11;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(7, 73);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(114, 16);
            this.lblPrimerApellido.TabIndex = 10;
            this.lblPrimerApellido.Text = "Primer apellido";
            // 
            // txtPrimeApellido
            // 
            this.txtPrimeApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeApellido.Location = new System.Drawing.Point(10, 89);
            this.txtPrimeApellido.Name = "txtPrimeApellido";
            this.txtPrimeApellido.Size = new System.Drawing.Size(211, 22);
            this.txtPrimeApellido.TabIndex = 9;
            // 
            // txtSeg_nom
            // 
            this.txtSeg_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeg_nom.Location = new System.Drawing.Point(239, 36);
            this.txtSeg_nom.Name = "txtSeg_nom";
            this.txtSeg_nom.Size = new System.Drawing.Size(211, 22);
            this.txtSeg_nom.TabIndex = 8;
            // 
            // lblSeg_nom
            // 
            this.lblSeg_nom.AutoSize = true;
            this.lblSeg_nom.Location = new System.Drawing.Point(236, 20);
            this.lblSeg_nom.Name = "lblSeg_nom";
            this.lblSeg_nom.Size = new System.Drawing.Size(126, 16);
            this.lblSeg_nom.TabIndex = 7;
            this.lblSeg_nom.Text = "Segundo nombre";
            // 
            // txtPrim_nom
            // 
            this.txtPrim_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrim_nom.Location = new System.Drawing.Point(10, 36);
            this.txtPrim_nom.Name = "txtPrim_nom";
            this.txtPrim_nom.Size = new System.Drawing.Size(211, 22);
            this.txtPrim_nom.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(532, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Location = new System.Drawing.Point(451, 192);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 35);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPrim_nom
            // 
            this.lblPrim_nom.AutoSize = true;
            this.lblPrim_nom.Location = new System.Drawing.Point(7, 20);
            this.lblPrim_nom.Name = "lblPrim_nom";
            this.lblPrim_nom.Size = new System.Drawing.Size(109, 16);
            this.lblPrim_nom.TabIndex = 0;
            this.lblPrim_nom.Text = "Primer nombre";
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
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.Color.White;
            this.lblOpciones.Location = new System.Drawing.Point(13, 14);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(142, 16);
            this.lblOpciones.TabIndex = 0;
            this.lblOpciones.Text = "ESCOGER OPCION";
            // 
            // ErrorSn
            // 
            this.ErrorSn.ContainerControl = this;
            // 
            // ErrorAp
            // 
            this.ErrorAp.ContainerControl = this;
            // 
            // NitError
            // 
            this.NitError.ContainerControl = this;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NitError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.TextBox txtPrim_nom;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPrim_nom;
        private System.Windows.Forms.ListBox lstOpcion;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimeApellido;
        private System.Windows.Forms.TextBox txtSeg_nom;
        private System.Windows.Forms.Label lblSeg_nom;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblSegApellido;
        private System.Windows.Forms.TextBox txtSegApellido;
        private System.Windows.Forms.ErrorProvider ErrorSn;
        private System.Windows.Forms.ErrorProvider ErrorAp;
        private System.Windows.Forms.ErrorProvider NitError;
    }
}