
namespace SuperTienda
{
    partial class mostrarClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.btAgregarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(27, 83);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(841, 361);
            this.dgvClientes.TabIndex = 0;
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarCliente.Location = new System.Drawing.Point(27, 30);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(374, 22);
            this.tbBuscarCliente.TabIndex = 1;
            this.tbBuscarCliente.Text = "Buscar por nombre o apellido";
            // 
            // btAgregarCliente
            // 
            this.btAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(21)))));
            this.btAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btAgregarCliente.Location = new System.Drawing.Point(766, 24);
            this.btAgregarCliente.Name = "btAgregarCliente";
            this.btAgregarCliente.Size = new System.Drawing.Size(102, 34);
            this.btAgregarCliente.TabIndex = 2;
            this.btAgregarCliente.Text = "Agregar Cliente";
            this.btAgregarCliente.UseVisualStyleBackColor = false;
            this.btAgregarCliente.Click += new System.EventHandler(this.btAgregarCliente_Click);
            // 
            // mostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 470);
            this.Controls.Add(this.btAgregarCliente);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mostrarClientes";
            this.Text = "mostrarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.Button btAgregarCliente;
    }
}