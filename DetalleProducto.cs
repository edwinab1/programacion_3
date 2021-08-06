using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTienda
{
    public partial class DetalleProducto : Form
    {
        public DetalleProducto(string rutaimagen, string nombreProducto="")
        {
            Console.WriteLine("Ruta "+rutaimagen);
            InitializeComponent();

            try
            {
                lbProducto.Text = nombreProducto;
                pbImagenProducto.Image = Image.FromFile(rutaimagen);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
