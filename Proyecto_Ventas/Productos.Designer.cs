namespace Proyecto_Ventas
{
    partial class Productos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.lbIva = new System.Windows.Forms.Label();
            this.ComboxIva = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDescri = new System.Windows.Forms.RichTextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.Busquedad = new System.Windows.Forms.PictureBox();
            this.btnActu = new System.Windows.Forms.Button();
            this.LbFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Busquedad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(128, 93);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(146, 20);
            this.txtPre.TabIndex = 7;
            // 
            // lbIva
            // 
            this.lbIva.AutoSize = true;
            this.lbIva.Location = new System.Drawing.Point(29, 128);
            this.lbIva.Name = "lbIva";
            this.lbIva.Size = new System.Drawing.Size(22, 13);
            this.lbIva.TabIndex = 8;
            this.lbIva.Text = "Iva";
            // 
            // ComboxIva
            // 
            this.ComboxIva.FormattingEnabled = true;
            this.ComboxIva.Items.AddRange(new object[] {
            "<Seleccionar>",
            "0",
            "5",
            "19"});
            this.ComboxIva.Location = new System.Drawing.Point(128, 128);
            this.ComboxIva.Name = "ComboxIva";
            this.ComboxIva.Size = new System.Drawing.Size(146, 21);
            this.ComboxIva.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Id";
            // 
            // txtBoxDescri
            // 
            this.txtBoxDescri.Location = new System.Drawing.Point(128, 161);
            this.txtBoxDescri.Name = "txtBoxDescri";
            this.txtBoxDescri.Size = new System.Drawing.Size(146, 66);
            this.txtBoxDescri.TabIndex = 12;
            this.txtBoxDescri.Text = "";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(32, 247);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(92, 23);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "Ingresar";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(128, 32);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(13, 13);
            this.lbId.TabIndex = 17;
            this.lbId.Text = "0";
            // 
            // Busquedad
            // 
            this.Busquedad.Image = global::Proyecto_Ventas.Properties.Resources.busqueda;
            this.Busquedad.Location = new System.Drawing.Point(249, 29);
            this.Busquedad.Name = "Busquedad";
            this.Busquedad.Size = new System.Drawing.Size(25, 26);
            this.Busquedad.TabIndex = 19;
            this.Busquedad.TabStop = false;
            this.Busquedad.Click += new System.EventHandler(this.Busquedad_Click);
            // 
            // btnActu
            // 
            this.btnActu.Location = new System.Drawing.Point(199, 247);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(75, 23);
            this.btnActu.TabIndex = 20;
            this.btnActu.Text = "Actualizar";
            this.btnActu.UseVisualStyleBackColor = true;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Location = new System.Drawing.Point(125, 290);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(0, 13);
            this.LbFecha.TabIndex = 21;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 321);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.Busquedad);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtBoxDescri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboxIva);
            this.Controls.Add(this.lbIva);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Productos";
            this.Text = "Ingreso Producto";
            ((System.ComponentModel.ISupportInitialize)(this.Busquedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Label lbIva;
        private System.Windows.Forms.ComboBox ComboxIva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtBoxDescri;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.PictureBox Busquedad;
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Label LbFecha;
    }
}

