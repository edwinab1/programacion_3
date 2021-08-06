
namespace SuperTienda
{
    partial class DetalleProducto
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
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.lbProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.Location = new System.Drawing.Point(224, 82);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(241, 252);
            this.pbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenProducto.TabIndex = 0;
            this.pbImagenProducto.TabStop = false;
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(302, 32);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(70, 25);
            this.lbProducto.TabIndex = 1;
            this.lbProducto.Text = "label1";
            // 
            // DetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.pbImagenProducto);
            this.Name = "DetalleProducto";
            this.Text = "DetalleProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Label lbProducto;
    }
}