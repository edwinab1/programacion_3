using SuperTienda.DB;
using SuperTienda.Models;
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
    public partial class RegistrarClientes : Form
    {
        DatabaseHelper helper = new DatabaseHelper();

        public RegistrarClientes()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (tbNombre.Text.Length > 0 || tbapellidos.Text.Length>0 || tbcinit.Text.Length>0)
            {
                Cliente cliente = new Cliente();
                cliente.nombre = tbNombre.Text;
                cliente.apellidos = tbapellidos.Text;
                cliente.ci_nit = tbcinit.Text;
                cliente.telefono = int.Parse(tbTelefono.Text);
                cliente.fecha_nac = dtpFechaNacimiento.Value;

                try

                {

                    SqlCommand command = new SqlCommand("spAgregarCliente", helper.openConnection());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Reference_nombre", SqlDbType.VarChar).Value = cliente.nombre;
                    command.Parameters.Add("@Reference_apellidos", SqlDbType.VarChar).Value = cliente.apellidos;
                    command.Parameters.Add("@Reference_cinit", SqlDbType.VarChar).Value = cliente.ci_nit;

                    command.Parameters.Add("@Reference_telefono", SqlDbType.Int).Value = cliente.telefono;
                    command.Parameters.Add("@Reference_fechanac", SqlDbType.Date).Value = cliente.fecha_nac;

                    command.ExecuteNonQuery();

                    MessageBox.Show("Cliente registrado");

                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepcion al registrar " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Los campos son obligatorios");
            }

          
        }
    }
}
