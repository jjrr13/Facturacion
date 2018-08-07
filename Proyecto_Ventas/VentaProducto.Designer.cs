namespace Proyecto_Ventas
{
    partial class VentaProducto
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
            this.txProducto = new System.Windows.Forms.TextBox();
            this.TablaNombres = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNombres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txProducto
            // 
            this.txProducto.Location = new System.Drawing.Point(115, 25);
            this.txProducto.Name = "txProducto";
            this.txProducto.Size = new System.Drawing.Size(198, 20);
            this.txProducto.TabIndex = 1;
            this.txProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txProducto_KeyPress);
            // 
            // TablaNombres
            // 
            this.TablaNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaNombres.Location = new System.Drawing.Point(31, 73);
            this.TablaNombres.Name = "TablaNombres";
            this.TablaNombres.Size = new System.Drawing.Size(761, 147);
            this.TablaNombres.TabIndex = 2;
            this.TablaNombres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaNombres_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(435, 253);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(160, 33);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Cancelar";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // VentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 321);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablaNombres);
            this.Controls.Add(this.txProducto);
            this.Controls.Add(this.label1);
            this.Name = "VentaProducto";
            this.Text = "VentaProducto";
            this.Load += new System.EventHandler(this.VentaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaNombres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txProducto;
        private System.Windows.Forms.DataGridView TablaNombres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSalir;
    }
}