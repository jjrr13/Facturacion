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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBD.SQL("INSERT INTO sucursal VALUES('','"+TxtNombre.Text+"')" );
            MessageBox.Show("La Sucursal fue Creada Correctamente");
            TxtNombre.Text = "";
        }
    }
}
