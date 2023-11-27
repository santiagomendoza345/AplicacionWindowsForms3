
namespace windowsForms3.Formas
{
    partial class FormTrabajadoresReal
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
            this.botnEliminar = new System.Windows.Forms.Button();
            this.botnRegistrar = new System.Windows.Forms.Button();
            this.textprestamo = new System.Windows.Forms.TextBox();
            this.texttelefono = new System.Windows.Forms.TextBox();
            this.textcurp = new System.Windows.Forms.TextBox();
            this.textedad = new System.Windows.Forms.TextBox();
            this.textapellidos = new System.Windows.Forms.TextBox();
            this.textsalario = new System.Windows.Forms.TextBox();
            this.textfechaingreso = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textrfc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texthorario = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // botnEliminar
            // 
            this.botnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.botnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnEliminar.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnEliminar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.botnEliminar.Location = new System.Drawing.Point(656, 299);
            this.botnEliminar.Name = "botnEliminar";
            this.botnEliminar.Size = new System.Drawing.Size(122, 42);
            this.botnEliminar.TabIndex = 84;
            this.botnEliminar.Text = "Eliminar";
            this.botnEliminar.UseVisualStyleBackColor = false;
            this.botnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // botnRegistrar
            // 
            this.botnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.botnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnRegistrar.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnRegistrar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.botnRegistrar.Location = new System.Drawing.Point(528, 299);
            this.botnRegistrar.Name = "botnRegistrar";
            this.botnRegistrar.Size = new System.Drawing.Size(122, 42);
            this.botnRegistrar.TabIndex = 83;
            this.botnRegistrar.Text = "Registrar";
            this.botnRegistrar.UseVisualStyleBackColor = false;
            this.botnRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textprestamo
            // 
            this.textprestamo.BackColor = System.Drawing.Color.LemonChiffon;
            this.textprestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textprestamo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprestamo.ForeColor = System.Drawing.Color.SeaGreen;
            this.textprestamo.Location = new System.Drawing.Point(528, 254);
            this.textprestamo.Multiline = true;
            this.textprestamo.Name = "textprestamo";
            this.textprestamo.Size = new System.Drawing.Size(247, 36);
            this.textprestamo.TabIndex = 82;
            this.textprestamo.Text = "Prestamo";
            this.textprestamo.TextChanged += new System.EventHandler(this.textClave_TextChanged);
            // 
            // texttelefono
            // 
            this.texttelefono.BackColor = System.Drawing.Color.LemonChiffon;
            this.texttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texttelefono.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttelefono.ForeColor = System.Drawing.Color.SeaGreen;
            this.texttelefono.Location = new System.Drawing.Point(260, 254);
            this.texttelefono.Multiline = true;
            this.texttelefono.Name = "texttelefono";
            this.texttelefono.Size = new System.Drawing.Size(247, 36);
            this.texttelefono.TabIndex = 81;
            this.texttelefono.Text = "Telefono";
            this.texttelefono.TextChanged += new System.EventHandler(this.textIngredientes_TextChanged);
            // 
            // textcurp
            // 
            this.textcurp.AcceptsReturn = true;
            this.textcurp.BackColor = System.Drawing.Color.LemonChiffon;
            this.textcurp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textcurp.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcurp.ForeColor = System.Drawing.Color.SeaGreen;
            this.textcurp.Location = new System.Drawing.Point(528, 196);
            this.textcurp.Multiline = true;
            this.textcurp.Name = "textcurp";
            this.textcurp.Size = new System.Drawing.Size(199, 33);
            this.textcurp.TabIndex = 80;
            this.textcurp.Text = "CURP";
            this.textcurp.TextChanged += new System.EventHandler(this.textSabor_TextChanged);
            // 
            // textedad
            // 
            this.textedad.BackColor = System.Drawing.Color.LemonChiffon;
            this.textedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textedad.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedad.ForeColor = System.Drawing.Color.SeaGreen;
            this.textedad.Location = new System.Drawing.Point(528, 142);
            this.textedad.Multiline = true;
            this.textedad.Name = "textedad";
            this.textedad.Size = new System.Drawing.Size(122, 33);
            this.textedad.TabIndex = 79;
            this.textedad.Text = "Edad";
            this.textedad.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // textapellidos
            // 
            this.textapellidos.BackColor = System.Drawing.Color.LemonChiffon;
            this.textapellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textapellidos.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textapellidos.ForeColor = System.Drawing.Color.SeaGreen;
            this.textapellidos.Location = new System.Drawing.Point(528, 85);
            this.textapellidos.Multiline = true;
            this.textapellidos.Name = "textapellidos";
            this.textapellidos.Size = new System.Drawing.Size(247, 33);
            this.textapellidos.TabIndex = 78;
            this.textapellidos.Text = "Apellidos";
            this.textapellidos.TextChanged += new System.EventHandler(this.textFechacad_TextChanged);
            // 
            // textsalario
            // 
            this.textsalario.BackColor = System.Drawing.Color.LemonChiffon;
            this.textsalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textsalario.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsalario.ForeColor = System.Drawing.Color.SeaGreen;
            this.textsalario.Location = new System.Drawing.Point(656, 142);
            this.textsalario.Multiline = true;
            this.textsalario.Name = "textsalario";
            this.textsalario.Size = new System.Drawing.Size(119, 33);
            this.textsalario.TabIndex = 77;
            this.textsalario.Text = "Salario";
            this.textsalario.TextChanged += new System.EventHandler(this.textCalorias_TextChanged);
            // 
            // textfechaingreso
            // 
            this.textfechaingreso.BackColor = System.Drawing.Color.LemonChiffon;
            this.textfechaingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textfechaingreso.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfechaingreso.ForeColor = System.Drawing.Color.SeaGreen;
            this.textfechaingreso.Location = new System.Drawing.Point(260, 142);
            this.textfechaingreso.Multiline = true;
            this.textfechaingreso.Name = "textfechaingreso";
            this.textfechaingreso.Size = new System.Drawing.Size(247, 33);
            this.textfechaingreso.TabIndex = 76;
            this.textfechaingreso.Text = "Fecha de Ingreso";
            this.textfechaingreso.TextChanged += new System.EventHandler(this.textContenido_TextChanged);
            // 
            // textnombre
            // 
            this.textnombre.BackColor = System.Drawing.Color.LemonChiffon;
            this.textnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textnombre.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnombre.ForeColor = System.Drawing.Color.SeaGreen;
            this.textnombre.Location = new System.Drawing.Point(260, 85);
            this.textnombre.Multiline = true;
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(247, 33);
            this.textnombre.TabIndex = 75;
            this.textnombre.Text = "Nombre";
            this.textnombre.TextChanged += new System.EventHandler(this.textnombreProducto_TextChanged);
            // 
            // textrfc
            // 
            this.textrfc.BackColor = System.Drawing.Color.LemonChiffon;
            this.textrfc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textrfc.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrfc.ForeColor = System.Drawing.Color.SeaGreen;
            this.textrfc.Location = new System.Drawing.Point(260, 196);
            this.textrfc.Multiline = true;
            this.textrfc.Name = "textrfc";
            this.textrfc.Size = new System.Drawing.Size(196, 33);
            this.textrfc.TabIndex = 74;
            this.textrfc.Text = "RFC";
            this.textrfc.TextChanged += new System.EventHandler(this.textMarca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(389, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 45);
            this.label1.TabIndex = 85;
            this.label1.Text = "Trabajadores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // texthorario
            // 
            this.texthorario.BackColor = System.Drawing.Color.LemonChiffon;
            this.texthorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texthorario.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texthorario.ForeColor = System.Drawing.Color.SeaGreen;
            this.texthorario.Location = new System.Drawing.Point(260, 305);
            this.texthorario.Multiline = true;
            this.texthorario.Name = "texthorario";
            this.texthorario.Size = new System.Drawing.Size(247, 36);
            this.texthorario.TabIndex = 86;
            this.texthorario.Text = "Horario";
            this.texthorario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView5.Location = new System.Drawing.Point(-12, 364);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1042, 88);
            this.dataGridView5.TabIndex = 87;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellidos";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de Ingreso";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Salario";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "RFC";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CURP";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Telefono";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Prestamo";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Horario";
            this.Column10.Name = "Column10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::windowsForms3.Properties.Resources.llave;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(462, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::windowsForms3.Properties.Resources.llave;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(733, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 35);
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // FormTrabajadoresReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.texthorario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botnEliminar);
            this.Controls.Add(this.botnRegistrar);
            this.Controls.Add(this.textprestamo);
            this.Controls.Add(this.texttelefono);
            this.Controls.Add(this.textcurp);
            this.Controls.Add(this.textedad);
            this.Controls.Add(this.textapellidos);
            this.Controls.Add(this.textsalario);
            this.Controls.Add(this.textfechaingreso);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textrfc);
            this.Name = "FormTrabajadoresReal";
            this.Text = "FormTrabajadoresReal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botnEliminar;
        private System.Windows.Forms.Button botnRegistrar;
        private System.Windows.Forms.TextBox textprestamo;
        private System.Windows.Forms.TextBox texttelefono;
        private System.Windows.Forms.TextBox textcurp;
        private System.Windows.Forms.TextBox textedad;
        private System.Windows.Forms.TextBox textapellidos;
        private System.Windows.Forms.TextBox textsalario;
        private System.Windows.Forms.TextBox textfechaingreso;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textrfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texthorario;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}