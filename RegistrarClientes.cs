﻿using SuperTienda.Models;
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
    public partial class RegistrarClientes : Form
    {
        public RegistrarClientes()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            cliente.nombre = tbNombre.Text;
            cliente.apellidos = tbapellidos.Text;
            cliente.ci_nit = tbcinit.Text;
            cliente.fecha_nac = dtpFechaNacimiento.Value;


            Console.WriteLine(cliente.fecha_nac.ToString());

        }
    }
}
