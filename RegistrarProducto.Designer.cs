
namespace SuperTienda
{
    partial class RegistrarProducto
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.tbPrecioCompra = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.cbDisponible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(295, 223);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(236, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.Location = new System.Drawing.Point(295, 402);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(236, 20);
            this.tbPrecioVenta.TabIndex = 1;
            // 
            // tbPrecioCompra
            // 
            this.tbPrecioCompra.Location = new System.Drawing.Point(295, 343);
            this.tbPrecioCompra.Name = "tbPrecioCompra";
            this.tbPrecioCompra.Size = new System.Drawing.Size(236, 20);
            this.tbPrecioCompra.TabIndex = 2;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(295, 284);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(236, 20);
            this.tbDescripcion.TabIndex = 3;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(352, 173);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(179, 21);
            this.cbCategorias.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio de Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripción";
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.Image = global::SuperTienda.Properties.Resources.noimage;
            this.pbImagenProducto.Location = new System.Drawing.Point(407, 34);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(124, 87);
            this.pbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenProducto.TabIndex = 5;
            this.pbImagenProducto.TabStop = false;
            this.pbImagenProducto.Click += new System.EventHandler(this.pbImagenProducto_Click);
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(295, 508);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(134, 31);
            this.btnRegistrarProducto.TabIndex = 11;
            this.btnRegistrarProducto.Text = "Registrar";
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // cbDisponible
            // 
            this.cbDisponible.AutoSize = true;
            this.cbDisponible.Location = new System.Drawing.Point(456, 455);
            this.cbDisponible.Name = "cbDisponible";
            this.cbDisponible.Size = new System.Drawing.Size(75, 17);
            this.cbDisponible.TabIndex = 12;
            this.cbDisponible.Text = "Disponible";
            this.cbDisponible.UseVisualStyleBackColor = true;
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 622);
            this.Controls.Add(this.cbDisponible);
            this.Controls.Add(this.btnRegistrarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagenProducto);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbPrecioCompra);
            this.Controls.Add(this.tbPrecioVenta);
            this.Controls.Add(this.tbNombre);
            this.Name = "RegistrarProducto";
            this.Text = "RegistrarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.TextBox tbPrecioCompra;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.CheckBox cbDisponible;
    }
}