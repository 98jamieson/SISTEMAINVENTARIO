
namespace SISTEMAINVENTARIO
{
    partial class frmReporteCompra
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_obtenerEncabezadoComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteCompra = new SISTEMAINVENTARIO.ReporteCompra();
            this.sp_obtenerDetalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptReporteCompra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_obtenerEncabezadoComprasTableAdapter = new SISTEMAINVENTARIO.ReporteCompraTableAdapters.sp_obtenerEncabezadoComprasTableAdapter();
            this.sp_obtenerDetalleCompraTableAdapter = new SISTEMAINVENTARIO.ReporteCompraTableAdapters.sp_obtenerDetalleCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_obtenerEncabezadoComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_obtenerDetalleCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_obtenerEncabezadoComprasBindingSource
            // 
            this.sp_obtenerEncabezadoComprasBindingSource.DataMember = "sp_obtenerEncabezadoCompras";
            this.sp_obtenerEncabezadoComprasBindingSource.DataSource = this.ReporteCompra;
            // 
            // ReporteCompra
            // 
            this.ReporteCompra.DataSetName = "ReporteCompra";
            this.ReporteCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_obtenerDetalleCompraBindingSource
            // 
            this.sp_obtenerDetalleCompraBindingSource.DataMember = "sp_obtenerDetalleCompra";
            this.sp_obtenerDetalleCompraBindingSource.DataSource = this.ReporteCompra;
            // 
            // rptReporteCompra
            // 
            this.rptReporteCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_obtenerEncabezadoComprasBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.sp_obtenerDetalleCompraBindingSource;
            this.rptReporteCompra.LocalReport.DataSources.Add(reportDataSource1);
            this.rptReporteCompra.LocalReport.DataSources.Add(reportDataSource2);
            this.rptReporteCompra.LocalReport.ReportEmbeddedResource = "SISTEMAINVENTARIO.CompraReport.rdlc";
            this.rptReporteCompra.Location = new System.Drawing.Point(0, 0);
            this.rptReporteCompra.Name = "rptReporteCompra";
            this.rptReporteCompra.ServerReport.BearerToken = null;
            this.rptReporteCompra.Size = new System.Drawing.Size(502, 450);
            this.rptReporteCompra.TabIndex = 0;
            // 
            // sp_obtenerEncabezadoComprasTableAdapter
            // 
            this.sp_obtenerEncabezadoComprasTableAdapter.ClearBeforeFill = true;
            // 
            // sp_obtenerDetalleCompraTableAdapter
            // 
            this.sp_obtenerDetalleCompraTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.rptReporteCompra);
            this.Name = "frmReporteCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteCompra";
            this.Load += new System.EventHandler(this.frmReporteCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_obtenerEncabezadoComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_obtenerDetalleCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptReporteCompra;
        private System.Windows.Forms.BindingSource sp_obtenerEncabezadoComprasBindingSource;
        private ReporteCompra ReporteCompra;
        private System.Windows.Forms.BindingSource sp_obtenerDetalleCompraBindingSource;
        private ReporteCompraTableAdapters.sp_obtenerEncabezadoComprasTableAdapter sp_obtenerEncabezadoComprasTableAdapter;
        private ReporteCompraTableAdapters.sp_obtenerDetalleCompraTableAdapter sp_obtenerDetalleCompraTableAdapter;
    }
}