
namespace SISTEMAINVENTARIO
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.lblProductos = new System.Windows.Forms.Label();
            this.gpbProductos = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecio_Vent = new System.Windows.Forms.TextBox();
            this.lblPrecio_vent = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lstOpcion = new System.Windows.Forms.ListBox();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.ErrorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.gpbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCantidad)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvProducto);
            this.splitContainer1.Panel1.Controls.Add(this.lblProductos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.gpbProductos);
            this.splitContainer1.Panel2.Controls.Add(this.lstOpcion);
            this.splitContainer1.Panel2.Controls.Add(this.lblOpciones);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(13, 37);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(773, 129);
            this.dgvProducto.TabIndex = 2;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.White;
            this.lblProductos.Location = new System.Drawing.Point(279, 7);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(225, 26);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "LISTADO PRODUCTOS";
            // 
            // gpbProductos
            // 
            this.gpbProductos.BackColor = System.Drawing.Color.Transparent;
            this.gpbProductos.Controls.Add(this.txtCantidad);
            this.gpbProductos.Controls.Add(this.lblCantidad);
            this.gpbProductos.Controls.Add(this.txtPrecio_Vent);
            this.gpbProductos.Controls.Add(this.lblPrecio_vent);
            this.gpbProductos.Controls.Add(this.txtPrecio);
            this.gpbProductos.Controls.Add(this.lblPrecio);
            this.gpbProductos.Controls.Add(this.btnCategoria);
            this.gpbProductos.Controls.Add(this.lblCategoria);
            this.gpbProductos.Controls.Add(this.cboCategoria);
            this.gpbProductos.Controls.Add(this.txtDescripcion);
            this.gpbProductos.Controls.Add(this.lblDescripcion);
            this.gpbProductos.Controls.Add(this.txtProducto);
            this.gpbProductos.Controls.Add(this.btnCancelar);
            this.gpbProductos.Controls.Add(this.btnGuardar);
            this.gpbProductos.Controls.Add(this.lblProducto);
            this.gpbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductos.ForeColor = System.Drawing.Color.White;
            this.gpbProductos.Location = new System.Drawing.Point(158, 12);
            this.gpbProductos.Name = "gpbProductos";
            this.gpbProductos.Size = new System.Drawing.Size(617, 233);
            this.gpbProductos.TabIndex = 2;
            this.gpbProductos.TabStop = false;
            this.gpbProductos.Text = "CREACION/EDICION PROVEEDOR";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(230, 135);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(97, 21);
            this.txtCantidad.TabIndex = 17;
            this.txtCantidad.Text = "0";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(230, 118);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtPrecio_Vent
            // 
            this.txtPrecio_Vent.Location = new System.Drawing.Point(365, 86);
            this.txtPrecio_Vent.Name = "txtPrecio_Vent";
            this.txtPrecio_Vent.Size = new System.Drawing.Size(90, 21);
            this.txtPrecio_Vent.TabIndex = 15;
            // 
            // lblPrecio_vent
            // 
            this.lblPrecio_vent.AutoSize = true;
            this.lblPrecio_vent.Location = new System.Drawing.Point(365, 69);
            this.lblPrecio_vent.Name = "lblPrecio_vent";
            this.lblPrecio_vent.Size = new System.Drawing.Size(74, 15);
            this.lblPrecio_vent.TabIndex = 14;
            this.lblPrecio_vent.Text = "Precio venta";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(230, 86);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(97, 21);
            this.txtPrecio.TabIndex = 13;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(230, 69);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.DimGray;
            this.btnCategoria.Location = new System.Drawing.Point(461, 32);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(106, 27);
            this.btnCategoria.TabIndex = 11;
            this.btnCategoria.Text = "Agregar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(256, 20);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(60, 15);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(259, 35);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(196, 23);
            this.cboCategoria.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(10, 86);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 141);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 69);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(10, 36);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(211, 21);
            this.txtProducto.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(542, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Location = new System.Drawing.Point(461, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 27);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(7, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(103, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Nompre producto";
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
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.Color.White;
            this.lblOpciones.Location = new System.Drawing.Point(13, 14);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(115, 15);
            this.lblOpciones.TabIndex = 0;
            this.lblOpciones.Text = "ESCOGER OPCION";
            // 
            // ErrorName
            // 
            this.ErrorName.ContainerControl = this;
            // 
            // ErrorPrecio
            // 
            this.ErrorPrecio.ContainerControl = this;
            // 
            // ErrorCantidad
            // 
            this.ErrorCantidad.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.gpbProductos.ResumeLayout(false);
            this.gpbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.GroupBox gpbProductos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ListBox lstOpcion;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecio_Vent;
        private System.Windows.Forms.Label lblPrecio_vent;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ErrorProvider ErrorName;
        private System.Windows.Forms.ErrorProvider ErrorPrecio;
        private System.Windows.Forms.ErrorProvider ErrorCantidad;
    }
}