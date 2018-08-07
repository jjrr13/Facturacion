namespace Proyecto_Ventas
{
    partial class reporteAnual_Form
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
            this.ReportViewerAnual = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewerAnual
            // 
            this.ReportViewerAnual.ActiveViewIndex = -1;
            this.ReportViewerAnual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerAnual.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerAnual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerAnual.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerAnual.Name = "ReportViewerAnual";
            this.ReportViewerAnual.Size = new System.Drawing.Size(1015, 499);
            this.ReportViewerAnual.TabIndex = 0;
            // 
            // reporteAnual_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 499);
            this.Controls.Add(this.ReportViewerAnual);
            this.Name = "reporteAnual_Form";
            this.Text = "reporteAnual_Form";
            this.Load += new System.EventHandler(this.reporteAnual_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerAnual;
    }
}