
namespace windowsForms3.Formas
{
    partial class FormProductos
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textClave = new System.Windows.Forms.TextBox();
            this.textIngredientes = new System.Windows.Forms.TextBox();
            this.textSabor = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textFechacad = new System.Windows.Forms.TextBox();
            this.textCalorias = new System.Windows.Forms.TextBox();
            this.textContenido = new System.Windows.Forms.TextBox();
            this.textnombreProducto = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreColumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saborColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonRegistrar.Location = new System.Drawing.Point(466, 285);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(122, 42);
            this.buttonRegistrar.TabIndex = 60;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textClave
            // 
            this.textClave.BackColor = System.Drawing.Color.LemonChiffon;
            this.textClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textClave.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClave.ForeColor = System.Drawing.Color.SeaGreen;
            this.textClave.Location = new System.Drawing.Point(466, 240);
            this.textClave.Multiline = true;
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(197, 36);
            this.textClave.TabIndex = 58;
            this.textClave.Text = "Clave";
            this.textClave.TextChanged += new System.EventHandler(this.textClave_TextChanged);
            // 
            // textIngredientes
            // 
            this.textIngredientes.BackColor = System.Drawing.Color.LemonChiffon;
            this.textIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIngredientes.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIngredientes.ForeColor = System.Drawing.Color.SeaGreen;
            this.textIngredientes.Location = new System.Drawing.Point(198, 240);
            this.textIngredientes.Multiline = true;
            this.textIngredientes.Name = "textIngredientes";
            this.textIngredientes.Size = new System.Drawing.Size(247, 87);
            this.textIngredientes.TabIndex = 57;
            this.textIngredientes.Text = "Ingredientes";
            this.textIngredientes.TextChanged += new System.EventHandler(this.textIngredientes_TextChanged);
            // 
            // textSabor
            // 
            this.textSabor.BackColor = System.Drawing.Color.LemonChiffon;
            this.textSabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSabor.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSabor.ForeColor = System.Drawing.Color.SeaGreen;
            this.textSabor.Location = new System.Drawing.Point(466, 182);
            this.textSabor.Multiline = true;
            this.textSabor.Name = "textSabor";
            this.textSabor.Size = new System.Drawing.Size(247, 33);
            this.textSabor.TabIndex = 56;
            this.textSabor.Text = "Sabor";
            this.textSabor.TextChanged += new System.EventHandler(this.textSabor_TextChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.LemonChiffon;
            this.textPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrecio.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.ForeColor = System.Drawing.Color.SeaGreen;
            this.textPrecio.Location = new System.Drawing.Point(466, 128);
            this.textPrecio.Multiline = true;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(122, 33);
            this.textPrecio.TabIndex = 55;
            this.textPrecio.Text = "Precio";
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // textFechacad
            // 
            this.textFechacad.BackColor = System.Drawing.Color.LemonChiffon;
            this.textFechacad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFechacad.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFechacad.ForeColor = System.Drawing.Color.SeaGreen;
            this.textFechacad.Location = new System.Drawing.Point(466, 71);
            this.textFechacad.Multiline = true;
            this.textFechacad.Name = "textFechacad";
            this.textFechacad.Size = new System.Drawing.Size(247, 33);
            this.textFechacad.TabIndex = 54;
            this.textFechacad.Text = "Fecha de caducidad";
            this.textFechacad.TextChanged += new System.EventHandler(this.textFechacad_TextChanged);
            // 
            // textCalorias
            // 
            this.textCalorias.BackColor = System.Drawing.Color.LemonChiffon;
            this.textCalorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCalorias.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCalorias.ForeColor = System.Drawing.Color.SeaGreen;
            this.textCalorias.Location = new System.Drawing.Point(594, 128);
            this.textCalorias.Multiline = true;
            this.textCalorias.Name = "textCalorias";
            this.textCalorias.Size = new System.Drawing.Size(119, 33);
            this.textCalorias.TabIndex = 53;
            this.textCalorias.Text = "Calorias";
            this.textCalorias.TextChanged += new System.EventHandler(this.textCalorias_TextChanged);
            // 
            // textContenido
            // 
            this.textContenido.BackColor = System.Drawing.Color.LemonChiffon;
            this.textContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textContenido.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContenido.ForeColor = System.Drawing.Color.SeaGreen;
            this.textContenido.Location = new System.Drawing.Point(198, 128);
            this.textContenido.Multiline = true;
            this.textContenido.Name = "textContenido";
            this.textContenido.Size = new System.Drawing.Size(247, 33);
            this.textContenido.TabIndex = 52;
            this.textContenido.Text = "Contenido";
            this.textContenido.TextChanged += new System.EventHandler(this.textContenido_TextChanged);
            // 
            // textnombreProducto
            // 
            this.textnombreProducto.BackColor = System.Drawing.Color.LemonChiffon;
            this.textnombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textnombreProducto.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnombreProducto.ForeColor = System.Drawing.Color.SeaGreen;
            this.textnombreProducto.Location = new System.Drawing.Point(198, 71);
            this.textnombreProducto.Multiline = true;
            this.textnombreProducto.Name = "textnombreProducto";
            this.textnombreProducto.Size = new System.Drawing.Size(247, 33);
            this.textnombreProducto.TabIndex = 51;
            this.textnombreProducto.Text = "Nombre";
            this.textnombreProducto.TextChanged += new System.EventHandler(this.textnombreProducto_TextChanged);
            // 
            // textMarca
            // 
            this.textMarca.BackColor = System.Drawing.Color.LemonChiffon;
            this.textMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMarca.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMarca.ForeColor = System.Drawing.Color.SeaGreen;
            this.textMarca.Location = new System.Drawing.Point(198, 182);
            this.textMarca.Multiline = true;
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(247, 33);
            this.textMarca.TabIndex = 50;
            this.textMarca.Text = "Marca";
            this.textMarca.TextChanged += new System.EventHandler(this.textMarca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(358, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 45);
            this.label1.TabIndex = 49;
            this.label1.Text = "Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumb,
            this.fechacadColumn,
            this.contenidoColumn,
            this.precioColumn,
            this.marcaColumn,
            this.saborColumn,
            this.ingredientesColumn,
            this.claveColumn,
            this.caloriasColumn});
            this.dataGridView1.GridColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 150);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreColumb
            // 
            this.nombreColumb.HeaderText = "Nombre";
            this.nombreColumb.Name = "nombreColumb";
            // 
            // fechacadColumn
            // 
            this.fechacadColumn.HeaderText = "Fecha de caducidad";
            this.fechacadColumn.Name = "fechacadColumn";
            // 
            // contenidoColumn
            // 
            this.contenidoColumn.HeaderText = "Contenido";
            this.contenidoColumn.Name = "contenidoColumn";
            // 
            // precioColumn
            // 
            this.precioColumn.HeaderText = "Precio";
            this.precioColumn.Name = "precioColumn";
            // 
            // marcaColumn
            // 
            this.marcaColumn.HeaderText = "Marca";
            this.marcaColumn.Name = "marcaColumn";
            // 
            // saborColumn
            // 
            this.saborColumn.HeaderText = "Sabor";
            this.saborColumn.Name = "saborColumn";
            // 
            // ingredientesColumn
            // 
            this.ingredientesColumn.HeaderText = "Ingredientes";
            this.ingredientesColumn.Name = "ingredientesColumn";
            // 
            // claveColumn
            // 
            this.claveColumn.HeaderText = "Clave";
            this.claveColumn.Name = "claveColumn";
            // 
            // caloriasColumn
            // 
            this.caloriasColumn.HeaderText = "Calorias";
            this.caloriasColumn.Name = "caloriasColumn";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnEliminar.Location = new System.Drawing.Point(594, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 42);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::windowsForms3.Properties.Resources.llave;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(667, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(905, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textIngredientes);
            this.Controls.Add(this.textSabor);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textFechacad);
            this.Controls.Add(this.textCalorias);
            this.Controls.Add(this.textContenido);
            this.Controls.Add(this.textnombreProducto);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.label1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contenidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saborColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriasColumn;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.TextBox textIngredientes;
        private System.Windows.Forms.TextBox textSabor;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textFechacad;
        private System.Windows.Forms.TextBox textCalorias;
        private System.Windows.Forms.TextBox textContenido;
        private System.Windows.Forms.TextBox textnombreProducto;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}