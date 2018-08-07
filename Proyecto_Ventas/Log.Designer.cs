namespace Proyecto_Ventas
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.checkRestablece = new System.Windows.Forms.CheckBox();
            this.btRestablecer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbUser.Location = new System.Drawing.Point(364, 81);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(68, 22);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Usuario:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbPass.Location = new System.Drawing.Point(341, 154);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(91, 22);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Lavender;
            this.txtUser.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtUser.Location = new System.Drawing.Point(443, 78);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(152, 29);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Lavender;
            this.txtPass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtPass.Location = new System.Drawing.Point(443, 151);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(152, 29);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Lavender;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnIn.FlatAppearance.BorderSize = 2;
            this.btnIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnIn.Location = new System.Drawing.Point(349, 208);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(83, 37);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "Ingresar";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Lavender;
            this.btnOut.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnOut.FlatAppearance.BorderSize = 2;
            this.btnOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnOut.Location = new System.Drawing.Point(506, 208);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(89, 37);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Cancelar";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(459, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 13);
            this.lbDate.TabIndex = 6;
            // 
            // checkRestablece
            // 
            this.checkRestablece.AutoSize = true;
            this.checkRestablece.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRestablece.ForeColor = System.Drawing.Color.MediumBlue;
            this.checkRestablece.Location = new System.Drawing.Point(358, 262);
            this.checkRestablece.Name = "checkRestablece";
            this.checkRestablece.Size = new System.Drawing.Size(223, 26);
            this.checkRestablece.TabIndex = 7;
            this.checkRestablece.Text = "He Olvidado mi Contraseña!";
            this.checkRestablece.UseVisualStyleBackColor = true;
            this.checkRestablece.CheckedChanged += new System.EventHandler(this.checkRestablece_CheckedChanged);
            // 
            // btRestablecer
            // 
            this.btRestablecer.BackColor = System.Drawing.Color.MediumBlue;
            this.btRestablecer.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestablecer.ForeColor = System.Drawing.SystemColors.Info;
            this.btRestablecer.Location = new System.Drawing.Point(401, 294);
            this.btRestablecer.Name = "btRestablecer";
            this.btRestablecer.Size = new System.Drawing.Size(120, 37);
            this.btRestablecer.TabIndex = 8;
            this.btRestablecer.Text = "Restablecer";
            this.btRestablecer.UseVisualStyleBackColor = false;
            this.btRestablecer.Visible = false;
            this.btRestablecer.Click += new System.EventHandler(this.btRestablecer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 278);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 49);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(285, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 41);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(171, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Todos los derechos Reservados - Copyright@ J. Jonatan Rojas R.";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(657, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRestablecer);
            this.Controls.Add(this.checkRestablece);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "Log";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.CheckBox checkRestablece;
        private System.Windows.Forms.Button btRestablecer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}