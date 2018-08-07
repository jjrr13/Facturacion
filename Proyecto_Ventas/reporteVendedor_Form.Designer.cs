namespace Proyecto_Ventas
{
    partial class reporteVendedor_Form
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
            this.ReportViewerVendedor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewerVendedor
            // 
            this.ReportViewerVendedor.ActiveViewIndex = -1;
            this.ReportViewerVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerVendedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerVendedor.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerVendedor.Name = "ReportViewerVendedor";
            this.ReportViewerVendedor.Size = new System.Drawing.Size(889, 442);
            this.ReportViewerVendedor.TabIndex = 0;
            // 
            // reporteVendedor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 442);
            this.Controls.Add(this.ReportViewerVendedor);
            this.Name = "reporteVendedor_Form";
            this.Text = "reporteVendedor_Form";
            this.Load += new System.EventHandler(this.reporteVendedor_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerVendedor;
    }
}