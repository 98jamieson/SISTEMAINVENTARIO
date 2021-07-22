
namespace SISTEMAINVENTARIO
{
    partial class frmReportFactura
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
            this.rptFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_obtenerEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteFactura = new SISTEMAINVENTARIO.ReporteFactura();
            this.sp_obtenerEncabezadoTableAdapter = new SISTEMAINVENTARIO.ReporteFacturaTableAdapters.sp_obtenerEncabezadoTableAdapter();
            this.sp_obtenerDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_obtenerDetalleTableAdapter = new SISTEMAINVENTARIO.ReporteFacturaTableAdapters.sp_obtenerDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_obtenerEncabezadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_obtenerDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptFactura
            // 
            this.rptFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_obtenerEncabezadoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.sp_obtenerDetalleBindingSource;
            this.rptFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rptFactura.LocalReport.DataSources.Add(reportDataSource2);
            this.rptFactura.LocalReport.ReportEmbeddedResource = "SISTEMAINVENTARIO.FacturaReport.rdlc";
            this.rptFactura.Location = new System.Drawing.Point(0, 0);
            this.rptFactura.Name = "rptFactura";
            this.rptFactura.ServerReport.BearerToken = null;
            this.rptFactura.Size = new System.Drawing.Size(510, 370);
            this.rptFactura.TabIndex = 0;
            // 
            // sp_obtenerEncabezadoBindingSource
            // 
            this.sp_obtenerEncabezadoBindingSource.DataMember = "sp_obtenerEncabezado";
            this.sp_obtenerEncabezadoBindingSource.DataSource = this.ReporteFactura;
            // 
            // ReporteFactura
            // 
            this.ReporteFactura.DataSetName = "ReporteFactura";
            this.ReporteFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_obtenerEncabezadoTableAdapter
            // 
            this.sp_obtenerEncabezadoTableAdapter.ClearBeforeFill = true;
            // 
            // sp_obtenerDetalleBindingSource
            // 
            this.sp_obtenerDetalleBindingSource.DataMember = "sp_obtenerDetalle";
            this.sp_obtenerDetalleBindingSource.DataSource = this.ReporteFactura;
            // 
            // sp_obtenerDetalleTableAdapter
            // 
            this.sp_obtenerDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 370);
            this.Controls.Add(this.rptFactura);
            this.Name = "frmReportFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportFactura";
            this.Load += new System.EventHandler(this.frmReportFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_obtenerEncabezadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_obtenerDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFactura;
        private System.Windows.Forms.BindingSource sp_obtenerEncabezadoBindingSource;
        private ReporteFactura ReporteFactura;
        private ReporteFacturaTableAdapters.sp_obtenerEncabezadoTableAdapter sp_obtenerEncabezadoTableAdapter;
        private System.Windows.Forms.BindingSource sp_obtenerDetalleBindingSource;
        private ReporteFacturaTableAdapters.sp_obtenerDetalleTableAdapter sp_obtenerDetalleTableAdapter;
    }
}