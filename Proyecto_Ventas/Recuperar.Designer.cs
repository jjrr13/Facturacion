namespace Proyecto_Ventas
{
    partial class Recuperar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txnueva = new System.Windows.Forms.TextBox();
            this.txconfirma = new System.Windows.Forms.TextBox();
            this.btAcpta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirme Constraseña";
            // 
            // txnueva
            // 
            this.txnueva.Location = new System.Drawing.Point(164, 37);
            this.txnueva.Name = "txnueva";
            this.txnueva.Size = new System.Drawing.Size(151, 20);
            this.txnueva.TabIndex = 2;
            // 
            // txconfirma
            // 
            this.txconfirma.Location = new System.Drawing.Point(161, 95);
            this.txconfirma.Name = "txconfirma";
            this.txconfirma.Size = new System.Drawing.Size(153, 20);
            this.txconfirma.TabIndex = 3;
            // 
            // btAcpta
            // 
            this.btAcpta.Location = new System.Drawing.Point(108, 176);
            this.btAcpta.Name = "btAcpta";
            this.btAcpta.Size = new System.Drawing.Size(141, 31);
            this.btAcpta.TabIndex = 4;
            this.btAcpta.Text = "Continuar";
            this.btAcpta.UseVisualStyleBackColor = true;
            this.btAcpta.Click += new System.EventHandler(this.btAcpta_Click);
            // 
            // Recuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 301);
            this.Controls.Add(this.btAcpta);
            this.Controls.Add(this.txconfirma);
            this.Controls.Add(this.txnueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Recuperar";
            this.Text = "Recuperar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txnueva;
        private System.Windows.Forms.TextBox txconfirma;
        private System.Windows.Forms.Button btAcpta;
    }
}