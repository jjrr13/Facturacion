namespace Proyecto_Ventas
{
    partial class Persona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persona));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbtitulo = new System.Windows.Forms.Label();
            this.Lbnombre = new System.Windows.Forms.Label();
            this.Lbapellido = new System.Windows.Forms.Label();
            this.LbtipDoc = new System.Windows.Forms.Label();
            this.Lbdocumento = new System.Windows.Forms.Label();
            this.Lbedad = new System.Windows.Forms.Label();
            this.Lbprivilegios = new System.Windows.Forms.Label();
            this.Docuemento = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.tipoDoc = new System.Windows.Forms.ComboBox();
            this.edad = new System.Windows.Forms.NumericUpDown();
            this.privilegios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.captura = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.Lbtelefono = new System.Windows.Forms.Label();
            this.Lbdireccion = new System.Windows.Forms.Label();
            this.Lbcorreo = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.LbFecha = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.LbNota = new System.Windows.Forms.Label();
            this.Sucursal = new System.Windows.Forms.Label();
            this.cxSucursal = new System.Windows.Forms.ComboBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.btActualiza = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbtitulo
            // 
            this.Lbtitulo.AutoSize = true;
            this.Lbtitulo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbtitulo.Location = new System.Drawing.Point(392, 9);
            this.Lbtitulo.Name = "Lbtitulo";
            this.Lbtitulo.Size = new System.Drawing.Size(271, 45);
            this.Lbtitulo.TabIndex = 0;
            this.Lbtitulo.Text = "Bienvenidos VNT";
            // 
            // Lbnombre
            // 
            this.Lbnombre.AutoSize = true;
            this.Lbnombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbnombre.Location = new System.Drawing.Point(270, 108);
            this.Lbnombre.Name = "Lbnombre";
            this.Lbnombre.Size = new System.Drawing.Size(76, 22);
            this.Lbnombre.TabIndex = 1;
            this.Lbnombre.Text = "Nombre:";
            // 
            // Lbapellido
            // 
            this.Lbapellido.AutoSize = true;
            this.Lbapellido.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbapellido.Location = new System.Drawing.Point(270, 149);
            this.Lbapellido.Name = "Lbapellido";
            this.Lbapellido.Size = new System.Drawing.Size(86, 22);
            this.Lbapellido.TabIndex = 2;
            this.Lbapellido.Text = "Apaellido:";
            // 
            // LbtipDoc
            // 
            this.LbtipDoc.AutoSize = true;
            this.LbtipDoc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbtipDoc.Location = new System.Drawing.Point(270, 191);
            this.LbtipDoc.Name = "LbtipDoc";
            this.LbtipDoc.Size = new System.Drawing.Size(162, 22);
            this.LbtipDoc.TabIndex = 3;
            this.LbtipDoc.Text = "Tipo de Documento:";
            // 
            // Lbdocumento
            // 
            this.Lbdocumento.AutoSize = true;
            this.Lbdocumento.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbdocumento.Location = new System.Drawing.Point(270, 233);
            this.Lbdocumento.Name = "Lbdocumento";
            this.Lbdocumento.Size = new System.Drawing.Size(167, 22);
            this.Lbdocumento.TabIndex = 4;
            this.Lbdocumento.Text = "Numero Documento:";
            // 
            // Lbedad
            // 
            this.Lbedad.AutoSize = true;
            this.Lbedad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbedad.Location = new System.Drawing.Point(270, 275);
            this.Lbedad.Name = "Lbedad";
            this.Lbedad.Size = new System.Drawing.Size(52, 22);
            this.Lbedad.TabIndex = 5;
            this.Lbedad.Text = "Edad:";
            // 
            // Lbprivilegios
            // 
            this.Lbprivilegios.AutoSize = true;
            this.Lbprivilegios.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbprivilegios.Location = new System.Drawing.Point(270, 319);
            this.Lbprivilegios.Name = "Lbprivilegios";
            this.Lbprivilegios.Size = new System.Drawing.Size(137, 22);
            this.Lbprivilegios.TabIndex = 6;
            this.Lbprivilegios.Text = "Privilegios como:";
            // 
            // Docuemento
            // 
            this.Docuemento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Docuemento.CausesValidation = false;
            this.Docuemento.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docuemento.Location = new System.Drawing.Point(453, 226);
            this.Docuemento.Name = "Docuemento";
            this.Docuemento.Size = new System.Drawing.Size(136, 29);
            this.Docuemento.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(453, 101);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(136, 29);
            this.nombre.TabIndex = 1;
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(453, 142);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(136, 29);
            this.apellido.TabIndex = 2;
            // 
            // tipoDoc
            // 
            this.tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDoc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDoc.FormattingEnabled = true;
            this.tipoDoc.Location = new System.Drawing.Point(453, 183);
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Size = new System.Drawing.Size(136, 30);
            this.tipoDoc.TabIndex = 3;
            // 
            // edad
            // 
            this.edad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(453, 268);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(41, 29);
            this.edad.TabIndex = 5;
            // 
            // privilegios
            // 
            this.privilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privilegios.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegios.FormattingEnabled = true;
            this.privilegios.ItemHeight = 22;
            this.privilegios.Location = new System.Drawing.Point(451, 311);
            this.privilegios.Name = "privilegios";
            this.privilegios.Size = new System.Drawing.Size(136, 30);
            this.privilegios.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id:";
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbId.Location = new System.Drawing.Point(453, 69);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(22, 26);
            this.LbId.TabIndex = 14;
            this.LbId.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(755, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Buscar...";
            // 
            // captura
            // 
            this.captura.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captura.Location = new System.Drawing.Point(758, 80);
            this.captura.Name = "captura";
            this.captura.Size = new System.Drawing.Size(224, 29);
            this.captura.TabIndex = 16;
            this.captura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.captura_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(938, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 39);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtEditar.Location = new System.Drawing.Point(573, 583);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(95, 40);
            this.BtEditar.TabIndex = 18;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtAgregar
            // 
            this.BtAgregar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtAgregar.Location = new System.Drawing.Point(274, 583);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(95, 40);
            this.BtAgregar.TabIndex = 19;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtEliminar.Location = new System.Drawing.Point(728, 583);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(95, 40);
            this.BtEliminar.TabIndex = 20;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // Lbtelefono
            // 
            this.Lbtelefono.AutoSize = true;
            this.Lbtelefono.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbtelefono.Location = new System.Drawing.Point(270, 405);
            this.Lbtelefono.Name = "Lbtelefono";
            this.Lbtelefono.Size = new System.Drawing.Size(79, 22);
            this.Lbtelefono.TabIndex = 21;
            this.Lbtelefono.Text = "Telefono:";
            // 
            // Lbdireccion
            // 
            this.Lbdireccion.AutoSize = true;
            this.Lbdireccion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbdireccion.Location = new System.Drawing.Point(270, 447);
            this.Lbdireccion.Name = "Lbdireccion";
            this.Lbdireccion.Size = new System.Drawing.Size(85, 22);
            this.Lbdireccion.TabIndex = 22;
            this.Lbdireccion.Text = "Direccion:";
            // 
            // Lbcorreo
            // 
            this.Lbcorreo.AutoSize = true;
            this.Lbcorreo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbcorreo.Location = new System.Drawing.Point(270, 489);
            this.Lbcorreo.Name = "Lbcorreo";
            this.Lbcorreo.Size = new System.Drawing.Size(60, 22);
            this.Lbcorreo.TabIndex = 23;
            this.Lbcorreo.Text = "Em@il:";
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(449, 398);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(136, 29);
            this.telefono.TabIndex = 8;
            this.telefono.Text = "0";
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(449, 440);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(136, 29);
            this.direccion.TabIndex = 9;
            // 
            // correo
            // 
            this.correo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(449, 482);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(136, 29);
            this.correo.TabIndex = 10;
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Location = new System.Drawing.Point(12, 9);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(0, 13);
            this.LbFecha.TabIndex = 27;
            // 
            // tabla
            // 
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.GridColor = System.Drawing.SystemColors.ControlLight;
            this.tabla.Location = new System.Drawing.Point(637, 171);
            this.tabla.Name = "tabla";
            this.tabla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabla.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.tabla.Size = new System.Drawing.Size(356, 340);
            this.tabla.TabIndex = 28;
            this.tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellClick);
            this.tabla.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tabla_CellMouseClick);
            // 
            // LbNota
            // 
            this.LbNota.AutoSize = true;
            this.LbNota.Location = new System.Drawing.Point(637, 67);
            this.LbNota.Name = "LbNota";
            this.LbNota.Size = new System.Drawing.Size(0, 13);
            this.LbNota.TabIndex = 29;
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSize = true;
            this.Sucursal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sucursal.Location = new System.Drawing.Point(270, 362);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(78, 22);
            this.Sucursal.TabIndex = 30;
            this.Sucursal.Text = "Sucursal:";
            // 
            // cxSucursal
            // 
            this.cxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxSucursal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxSucursal.FormattingEnabled = true;
            this.cxSucursal.ItemHeight = 22;
            this.cxSucursal.Location = new System.Drawing.Point(450, 354);
            this.cxSucursal.Name = "cxSucursal";
            this.cxSucursal.Size = new System.Drawing.Size(139, 30);
            this.cxSucursal.TabIndex = 7;
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Limpiar.Location = new System.Drawing.Point(419, 583);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(95, 40);
            this.Limpiar.TabIndex = 32;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btActualiza
            // 
            this.btActualiza.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualiza.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btActualiza.Location = new System.Drawing.Point(872, 583);
            this.btActualiza.Name = "btActualiza";
            this.btActualiza.Size = new System.Drawing.Size(95, 40);
            this.btActualiza.TabIndex = 33;
            this.btActualiza.Text = "Actualizar";
            this.btActualiza.UseVisualStyleBackColor = true;
            this.btActualiza.Click += new System.EventHandler(this.btActualiza_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 676);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Ventas.Properties.Resources.LogoC_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1015, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btActualiza);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Sucursal);
            this.Controls.Add(this.LbNota);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.Lbcorreo);
            this.Controls.Add(this.Lbdireccion);
            this.Controls.Add(this.Lbtelefono);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtAgregar);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.captura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbprivilegios);
            this.Controls.Add(this.Lbnombre);
            this.Controls.Add(this.Lbapellido);
            this.Controls.Add(this.Lbedad);
            this.Controls.Add(this.Lbdocumento);
            this.Controls.Add(this.LbtipDoc);
            this.Controls.Add(this.Lbtitulo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.tipoDoc);
            this.Controls.Add(this.Docuemento);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.cxSucursal);
            this.Controls.Add(this.privilegios);
            this.Controls.Add(this.edad);
            this.Name = "Persona";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbtitulo;
        private System.Windows.Forms.Label Lbnombre;
        private System.Windows.Forms.Label Lbapellido;
        private System.Windows.Forms.Label LbtipDoc;
        private System.Windows.Forms.Label Lbdocumento;
        private System.Windows.Forms.Label Lbedad;
        private System.Windows.Forms.Label Lbprivilegios;
        private System.Windows.Forms.TextBox Docuemento;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.ComboBox tipoDoc;
        private System.Windows.Forms.NumericUpDown edad;
        private System.Windows.Forms.ComboBox privilegios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox captura;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Label Lbtelefono;
        private System.Windows.Forms.Label Lbdireccion;
        private System.Windows.Forms.Label Lbcorreo;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label LbNota;
        private System.Windows.Forms.Label Sucursal;
        private System.Windows.Forms.ComboBox cxSucursal;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button btActualiza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

