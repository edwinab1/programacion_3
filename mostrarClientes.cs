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
    public partial class mostrarClientes : Form
    {
        DatabaseHelper helper = new DatabaseHelper();

        public mostrarClientes()
        {
            InitializeComponent();

            string consulta = "select * from selectEmpleados";

            helper.sqlQuery(consulta);

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, helper.openConnection());
            DataTable dataPersona = new DataTable();
            adaptador.Fill(dataPersona);
            dgvClientes.DataSource = dataPersona;
      

        }

        private void btAgregarCliente_Click(object sender, EventArgs e)
        {
            RegistrarClientes registrarClientes = new RegistrarClientes();
            registrarClientes.Show();
        }
    }
}
