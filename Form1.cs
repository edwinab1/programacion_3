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
    public partial class formularioPrincipal : Form
    {
        private bool arrastrar = false;
        private Point window_location = new Point(0, 0);


        //CRUD (create, read, update, delete)


        public formularioPrincipal()
        {
            InitializeComponent();


            panelMenu.BackColor = Color.FromArgb(59, 75, 100);

            btnClientes.FlatAppearance.BorderColor = Color.FromArgb(20, 255, 255, 255);
            btnEmpleados.FlatAppearance.BorderColor = Color.FromArgb(59, 75, 100);
            btnProductos.FlatAppearance.BorderColor = Color.FromArgb(59, 75, 100);

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            mostrarClientes mostrarCli = new mostrarClientes();
            agregarFormularioAlpanel(mostrarCli);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            window_location = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrar)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.window_location.X, p.Y - this.window_location.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;)|*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                Console.WriteLine("FILENAME " + open.FileName);
                Console.WriteLine("EXT " + open.DefaultExt);

            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            agregarFormularioAlpanel(productos);
        }

        private void agregarFormularioAlpanel(Form form)
        {
            if (panelFormularios.Controls.Count > 0)
            {
                panelFormularios.Controls.Clear();
                

            }
            form.TopLevel = false;
            form.AutoScroll = true;

            panelFormularios.Controls.Add(form);
            form.Show();

        }

    }
}
