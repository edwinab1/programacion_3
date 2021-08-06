using SuperTienda.DB;
using SuperTienda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTienda
{
    public partial class RegistrarProducto : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        private string rutaImagen ="";
        private string imagenesdeProducto = Environment.CurrentDirectory + "\\Imagenes\\Productos";
       
        public RegistrarProducto()
        {
            InitializeComponent();

            cargarCategorias();
        }


        private void cargarCategorias()
        {
            try
            {
                string consulta = "Select * from categorias";
                SqlCommand comando = new SqlCommand(consulta, db.openConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                cbCategorias.DisplayMember = "nombre_categoria";
                cbCategorias.ValueMember = "id_categoria";
                cbCategorias.DataSource = dataTable;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pbImagenProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Solo imagenes(*.jpg; *png; *jpeg)|*.jpg;*.png;*.jpeg"; //filtrar imagenes
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbImagenProducto.Image = new Bitmap(dialog.FileName);
                Console.WriteLine("FILENAME " + dialog.FileName);
                rutaImagen = dialog.FileName;

            }
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Seleccionado "+cbCategorias.SelectedValue.ToString());
            Console.WriteLine("Seleccionado " + cbCategorias.Text);

            string imagenProduct = cargarImagen();

            if (imagenProduct.Length > 0 || tbNombre.Text.Length>0 )
            {

                   Producto producto = new Producto();
                   producto.nombre = tbNombre.Text;
                   producto.descripcion = tbDescripcion.Text;
                   producto.precioCompra = double.Parse(tbPrecioCompra.Text);
                   producto.precioVenta = double.Parse(tbPrecioVenta.Text);
                   producto.idCategoria = int.Parse(cbCategorias.SelectedValue.ToString());
                   producto.disponible = cbDisponible.Checked;
                   producto.imagen = imagenProduct;



                   try

                   {

                       SqlCommand command = new SqlCommand("spAgregarProducto", db.openConnection());
                       command.CommandType = CommandType.StoredProcedure;
                       command.Parameters.Add("@nombre_producto", SqlDbType.VarChar).Value = producto.nombre;
                       command.Parameters.Add("descripcion_producto", SqlDbType.VarChar).Value = producto.descripcion;
                       command.Parameters.Add("@imagen", SqlDbType.VarChar).Value = producto.imagen;

                       command.Parameters.Add("@precio_compra", SqlDbType.Money).Value = producto.precioCompra;
                       command.Parameters.Add("@precio_venta", SqlDbType.Money).Value = producto.precioVenta;
                       command.Parameters.Add("@disponible", SqlDbType.Bit).Value = producto.disponible;
                       command.Parameters.Add("@categoria", SqlDbType.Int).Value = producto.idCategoria;


                       command.ExecuteNonQuery();

                       MessageBox.Show("producto registrado");

                      // this.Hide();

                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Excepcion al registrar " + ex.Message);
                   }
                 
            }
            else
            {
                MessageBox.Show("No se cargo la imagen");
            }


            

        }

        private string cargarImagen()
        {
            try
            {
                File.Copy(rutaImagen, Path.Combine(imagenesdeProducto, Path.GetFileName(rutaImagen)), true);
                return imagenesdeProducto +"\\"+ Path.GetFileName(rutaImagen);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }


        }





    }
}
