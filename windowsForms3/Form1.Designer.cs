
namespace windowsForms3
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textContra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMostrarCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(72, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Iniciar sesion";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox1.Location = new System.Drawing.Point(37, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 37);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "Usuario";
            // 
            // textContra
            // 
            this.textContra.BackColor = System.Drawing.Color.LemonChiffon;
            this.textContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textContra.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContra.ForeColor = System.Drawing.Color.SeaGreen;
            this.textContra.Location = new System.Drawing.Point(37, 159);
            this.textContra.Multiline = true;
            this.textContra.Name = "textContra";
            this.textContra.Size = new System.Drawing.Size(275, 37);
            this.textContra.TabIndex = 39;
            this.textContra.Text = "Contraseña";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Location = new System.Drawing.Point(88, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 31);
            this.button2.TabIndex = 41;
            this.button2.Text = "No tienes cuenta? Registrate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button1.Location = new System.Drawing.Point(88, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 42);
            this.button1.TabIndex = 40;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMostrarCont
            // 
            this.buttonMostrarCont.BackgroundImage = global::windowsForms3.Properties.Resources.ocultar;
            this.buttonMostrarCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMostrarCont.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonMostrarCont.Location = new System.Drawing.Point(318, 159);
            this.buttonMostrarCont.Name = "buttonMostrarCont";
            this.buttonMostrarCont.Size = new System.Drawing.Size(47, 37);
            this.buttonMostrarCont.TabIndex = 42;
            this.buttonMostrarCont.UseVisualStyleBackColor = true;
            this.buttonMostrarCont.Click += new System.EventHandler(this.buttonMostrarCont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.buttonMostrarCont);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textContra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMostrarCont;
    }
}

