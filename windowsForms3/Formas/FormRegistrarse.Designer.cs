
namespace windowsForms3.Formas
{
    partial class FormRegistrarse
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.buttonMostrarContra = new System.Windows.Forms.Button();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxEmail.Location = new System.Drawing.Point(429, 82);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(328, 37);
            this.textBoxEmail.TabIndex = 37;
            this.textBoxEmail.Text = "Email";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxUsuario.Location = new System.Drawing.Point(86, 82);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(328, 37);
            this.textBoxUsuario.TabIndex = 36;
            this.textBoxUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 45);
            this.label1.TabIndex = 30;
            this.label1.Text = "Registrarse";
            // 
            // textContraseña
            // 
            this.textContraseña.BackColor = System.Drawing.Color.LemonChiffon;
            this.textContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textContraseña.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.ForeColor = System.Drawing.Color.SeaGreen;
            this.textContraseña.Location = new System.Drawing.Point(429, 140);
            this.textContraseña.Multiline = true;
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(275, 37);
            this.textContraseña.TabIndex = 31;
            this.textContraseña.Text = "Contraseña";
            this.textContraseña.TextChanged += new System.EventHandler(this.textContraseña_TextChanged);
            // 
            // textNombres
            // 
            this.textNombres.BackColor = System.Drawing.Color.LemonChiffon;
            this.textNombres.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombres.ForeColor = System.Drawing.Color.SeaGreen;
            this.textNombres.Location = new System.Drawing.Point(86, 203);
            this.textNombres.Multiline = true;
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(328, 32);
            this.textNombres.TabIndex = 32;
            this.textNombres.Text = "Nombre";
            // 
            // buttonMostrarContra
            // 
            this.buttonMostrarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMostrarContra.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonMostrarContra.Location = new System.Drawing.Point(710, 140);
            this.buttonMostrarContra.Name = "buttonMostrarContra";
            this.buttonMostrarContra.Size = new System.Drawing.Size(47, 37);
            this.buttonMostrarContra.TabIndex = 33;
            this.buttonMostrarContra.UseVisualStyleBackColor = true;
            this.buttonMostrarContra.Click += new System.EventHandler(this.buttonMostrarContra_Click);
            // 
            // textTelefono
            // 
            this.textTelefono.BackColor = System.Drawing.Color.LemonChiffon;
            this.textTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefono.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.ForeColor = System.Drawing.Color.SeaGreen;
            this.textTelefono.Location = new System.Drawing.Point(86, 140);
            this.textTelefono.Multiline = true;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(328, 37);
            this.textTelefono.TabIndex = 35;
            this.textTelefono.Text = "Telefono";
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonRegistrarse.Location = new System.Drawing.Point(175, 310);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(239, 42);
            this.buttonRegistrarse.TabIndex = 34;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxEdad.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEdad.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxEdad.Location = new System.Drawing.Point(682, 203);
            this.textBoxEdad.Multiline = true;
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(75, 32);
            this.textBoxEdad.TabIndex = 41;
            this.textBoxEdad.Text = "Edad";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxCodigo.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxCodigo.Location = new System.Drawing.Point(86, 254);
            this.textBoxCodigo.Multiline = true;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(110, 32);
            this.textBoxCodigo.TabIndex = 39;
            this.textBoxCodigo.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(254, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ingresa el codigo que se acaba de enviar a tu celular";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxApellidos.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidos.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxApellidos.Location = new System.Drawing.Point(429, 203);
            this.textBoxApellidos.Multiline = true;
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(247, 32);
            this.textBoxApellidos.TabIndex = 38;
            this.textBoxApellidos.Text = "Apellidos";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonEliminar.Location = new System.Drawing.Point(429, 310);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(239, 42);
            this.buttonEliminar.TabIndex = 42;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView2.Location = new System.Drawing.Point(1, 400);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(818, 125);
            this.dataGridView2.TabIndex = 43;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Usuario";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Contraseña";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre(s)";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Apellido(s)";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Edad";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Codigo";
            this.Column8.Name = "Column8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::windowsForms3.Properties.Resources.llave;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(202, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 32);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(816, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.buttonMostrarContra);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrarse";
            this.Text = "FormRegistrarse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.Button buttonMostrarContra;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}