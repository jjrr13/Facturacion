namespace Proyecto_Ventas
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMovi = new System.Windows.Forms.TextBox();
            this.spnCan = new System.Windows.Forms.NumericUpDown();
            this.BoxPro = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.PictureBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnActu = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.LbFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxSucur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spnCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(96, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtMovi
            // 
            this.txtMovi.Location = new System.Drawing.Point(90, 122);
            this.txtMovi.Name = "txtMovi";
            this.txtMovi.Size = new System.Drawing.Size(140, 20);
            this.txtMovi.TabIndex = 6;
            // 
            // spnCan
            // 
            this.spnCan.Location = new System.Drawing.Point(90, 156);
            this.spnCan.Name = "spnCan";
            this.spnCan.Size = new System.Drawing.Size(140, 20);
            this.spnCan.TabIndex = 7;
            // 
            // BoxPro
            // 
            this.BoxPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxPro.FormattingEnabled = true;
            this.BoxPro.Location = new System.Drawing.Point(90, 56);
            this.BoxPro.Name = "BoxPro";
            this.BoxPro.Size = new System.Drawing.Size(140, 21);
            this.BoxPro.TabIndex = 9;
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.Location = new System.Drawing.Point(203, 26);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(27, 24);
            this.Buscar.TabIndex = 10;
            this.Buscar.TabStop = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(19, 202);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(58, 23);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "Agregar";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnActu
            // 
            this.btnActu.Location = new System.Drawing.Point(99, 202);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(63, 23);
            this.btnActu.TabIndex = 12;
            this.btnActu.Text = "Actualizar";
            this.btnActu.UseVisualStyleBackColor = true;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(179, 202);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(51, 23);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "Vista";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Location = new System.Drawing.Point(96, 244);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(0, 13);
            this.LbFecha.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sucursal";
            // 
            // boxSucur
            // 
            this.boxSucur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSucur.FormattingEnabled = true;
            this.boxSucur.Location = new System.Drawing.Point(90, 91);
            this.boxSucur.Name = "boxSucur";
            this.boxSucur.Size = new System.Drawing.Size(140, 21);
            this.boxSucur.TabIndex = 16;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 266);
            this.Controls.Add(this.boxSucur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.BoxPro);
            this.Controls.Add(this.spnCan);
            this.Controls.Add(this.txtMovi);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.spnCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMovi;
        private System.Windows.Forms.NumericUpDown spnCan;
        private System.Windows.Forms.ComboBox BoxPro;
        private System.Windows.Forms.PictureBox Buscar;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxSucur;
    }
}