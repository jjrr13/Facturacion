namespace Proyecto_Ventas
{
    partial class reporteTodas_Form
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
            this.ReportViewerTodas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewerTodas
            // 
            this.ReportViewerTodas.ActiveViewIndex = -1;
            this.ReportViewerTodas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerTodas.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerTodas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerTodas.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerTodas.Name = "ReportViewerTodas";
            this.ReportViewerTodas.Size = new System.Drawing.Size(945, 475);
            this.ReportViewerTodas.TabIndex = 0;
            // 
            // reporteTodas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 475);
            this.Controls.Add(this.ReportViewerTodas);
            this.Name = "reporteTodas_Form";
            this.Text = "reporteTodas_Form";
            this.Load += new System.EventHandler(this.reporteTodas_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerTodas;
    }
}