using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ventas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Persona().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Sucursales().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Facturas().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Inventario().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Productos().Show();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            new GeneraReporte().Show();
        }
    }
}
