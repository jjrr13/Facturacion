namespace Proyecto_Ventas
{
    partial class GeneraReporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.cxReporte = new System.Windows.Forms.ComboBox();
            this.cxSucursal = new System.Windows.Forms.ComboBox();
            this.cxVendedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAño = new System.Windows.Forms.Label();
            this.cxPeriodo = new System.Windows.Forms.ComboBox();
            this.lbPeriodo = new System.Windows.Forms.Label();
            this.años = new System.Windows.Forms.NumericUpDown();
            this.tablaReport = new System.Windows.Forms.DataGridView();
            this.Consultar = new System.Windows.Forms.Button();
            this.btReportar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.años)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes VNT";
            // 
            // cxReporte
            // 
            this.cxReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxReporte.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxReporte.FormattingEnabled = true;
            this.cxReporte.Location = new System.Drawing.Point(299, 115);
            this.cxReporte.Name = "cxReporte";
            this.cxReporte.Size = new System.Drawing.Size(136, 30);
            this.cxReporte.TabIndex = 1;
            this.cxReporte.SelectionChangeCommitted += new System.EventHandler(this.cxReporte_SelectionChangeCommitted);
            // 
            // cxSucursal
            // 
            this.cxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxSucursal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxSucursal.FormattingEnabled = true;
            this.cxSucursal.Location = new System.Drawing.Point(303, 209);
            this.cxSucursal.Name = "cxSucursal";
            this.cxSucursal.Size = new System.Drawing.Size(136, 30);
            this.cxSucursal.TabIndex = 2;
            this.cxSucursal.SelectionChangeCommitted += new System.EventHandler(this.cxSucursal_SelectionChangeCommitted);
            // 
            // cxVendedor
            // 
            this.cxVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxVendedor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxVendedor.FormattingEnabled = true;
            this.cxVendedor.Location = new System.Drawing.Point(580, 209);
            this.cxVendedor.Name = "cxVendedor";
            this.cxVendedor.Size = new System.Drawing.Size(152, 30);
            this.cxVendedor.TabIndex = 3;
            this.cxVendedor.SelectionChangeCommitted += new System.EventHandler(this.cxVendedor_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reporte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Por Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Por Vendedor:";
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAño.Location = new System.Drawing.Point(464, 76);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(109, 22);
            this.lbAño.TabIndex = 8;
            this.lbAño.Text = "Ingrese el Año:";
            // 
            // cxPeriodo
            // 
            this.cxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxPeriodo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxPeriodo.FormattingEnabled = true;
            this.cxPeriodo.Location = new System.Drawing.Point(598, 113);
            this.cxPeriodo.Name = "cxPeriodo";
            this.cxPeriodo.Size = new System.Drawing.Size(130, 30);
            this.cxPeriodo.TabIndex = 9;
            this.cxPeriodo.SelectionChangeCommitted += new System.EventHandler(this.cxPeriodo_SelectionChangeCommitted);
            // 
            // lbPeriodo
            // 
            this.lbPeriodo.AutoSize = true;
            this.lbPeriodo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriodo.Location = new System.Drawing.Point(594, 76);
            this.lbPeriodo.Name = "lbPeriodo";
            this.lbPeriodo.Size = new System.Drawing.Size(138, 22);
            this.lbPeriodo.TabIndex = 10;
            this.lbPeriodo.Text = "Seleccione Periodo:";
            // 
            // años
            // 
            this.años.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.años.Location = new System.Drawing.Point(483, 114);
            this.años.Name = "años";
            this.años.ReadOnly = true;
            this.años.Size = new System.Drawing.Size(63, 29);
            this.años.TabIndex = 11;
            this.años.ValueChanged += new System.EventHandler(this.años_ValueChanged);
            // 
            // tablaReport
            // 
            this.tablaReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaReport.BackgroundColor = System.Drawing.Color.Lavender;
            this.tablaReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReport.Location = new System.Drawing.Point(304, 263);
            this.tablaReport.Name = "tablaReport";
            this.tablaReport.Size = new System.Drawing.Size(428, 135);
            this.tablaReport.TabIndex = 12;
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(362, 419);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(147, 38);
            this.Consultar.TabIndex = 13;
            this.Consultar.Text = "Consultal";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click_1);
            // 
            // btReportar
            // 
            this.btReportar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportar.Location = new System.Drawing.Point(545, 418);
            this.btReportar.Name = "btReportar";
            this.btReportar.Size = new System.Drawing.Size(138, 38);
            this.btReportar.TabIndex = 14;
            this.btReportar.Text = "Generar Reporte";
            this.btReportar.UseVisualStyleBackColor = true;
            this.btReportar.Click += new System.EventHandler(this.btReportar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 456);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Ventas.Properties.Resources.LogoC_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GeneraReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btReportar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.tablaReport);
            this.Controls.Add(this.años);
            this.Controls.Add(this.lbPeriodo);
            this.Controls.Add(this.cxPeriodo);
            this.Controls.Add(this.lbAño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cxVendedor);
            this.Controls.Add(this.cxSucursal);
            this.Controls.Add(this.cxReporte);
            this.Controls.Add(this.label1);
            this.Name = "GeneraReporte";
            this.Text = "GeneraReporte";
            ((System.ComponentModel.ISupportInitialize)(this.años)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReport)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cxReporte;
        private System.Windows.Forms.ComboBox cxSucursal;
        private System.Windows.Forms.ComboBox cxVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAño;
        private System.Windows.Forms.ComboBox cxPeriodo;
        private System.Windows.Forms.Label lbPeriodo;
        private System.Windows.Forms.NumericUpDown años;
        private System.Windows.Forms.DataGridView tablaReport;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button btReportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}