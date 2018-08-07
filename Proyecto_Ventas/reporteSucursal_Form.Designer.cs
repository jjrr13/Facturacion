namespace Proyecto_Ventas
{
    partial class reporteSucursal_Form
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
            this.ReportViewerSucursal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewerSucursal
            // 
            this.ReportViewerSucursal.ActiveViewIndex = -1;
            this.ReportViewerSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerSucursal.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerSucursal.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerSucursal.Name = "ReportViewerSucursal";
            this.ReportViewerSucursal.Size = new System.Drawing.Size(993, 471);
            this.ReportViewerSucursal.TabIndex = 0;
            // 
            // reporteSucursal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 471);
            this.Controls.Add(this.ReportViewerSucursal);
            this.Name = "reporteSucursal_Form";
            this.Text = "reporteSucursal_Form";
            this.Load += new System.EventHandler(this.reporteSucursal_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerSucursal;
    }
}