
namespace SuperTienda
{
    partial class Productos
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
            this.btAgregarProducto = new System.Windows.Forms.Button();
            this.tbBuscarProductos = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(21)))));
            this.btAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btAgregarProducto.Location = new System.Drawing.Point(729, 33);
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(124, 34);
            this.btAgregarProducto.TabIndex = 5;
            this.btAgregarProducto.Text = "Agregar Producto";
            this.btAgregarProducto.UseVisualStyleBackColor = false;
            this.btAgregarProducto.Click += new System.EventHandler(this.btAgregarProducto_Click);
            // 
            // tbBuscarProductos
            // 
            this.tbBuscarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarProductos.Location = new System.Drawing.Point(23, 45);
            this.tbBuscarProductos.Name = "tbBuscarProductos";
            this.tbBuscarProductos.Size = new System.Drawing.Size(374, 22);
            this.tbBuscarProductos.TabIndex = 4;
            this.tbBuscarProductos.Text = "Buscar por nombre o apellido";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 109);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(841, 361);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(876, 513);
            this.Controls.Add(this.btAgregarProducto);
            this.Controls.Add(this.tbBuscarProductos);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregarProducto;
        private System.Windows.Forms.TextBox tbBuscarProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}