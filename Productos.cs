using SuperTienda.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTienda
{
    public partial class Productos : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        public Productos()
        {
            InitializeComponent();
            cargarProductos();        }

        private void btAgregarProducto_Click(object sender, EventArgs e)
        {
            RegistrarProducto registrarProducto = new RegistrarProducto();
            registrarProducto.Show();
        }

        void cargarProductos()
        {
            string consulta = "select * from vProductos";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, db.openConnection());

            DataSet dataSetProductos = new DataSet();
            adapter.Fill(dataSetProductos,"productos");
            dgvProductos.DataSource = dataSetProductos.Tables["productos"].DefaultView;

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
           foreach(DataGridViewRow fila in dgvProductos.SelectedRows)
            {
                string imagen = fila.Cells[3].Value.ToString();
                string nombreProducto = fila.Cells[1].Value.ToString();

                DetalleProducto detalleProducto = new DetalleProducto(imagen, nombreProducto);
                detalleProducto.Show();
            }
        }
    }
}
