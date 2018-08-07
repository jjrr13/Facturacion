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
    public partial class ProView : Form
    {
        public int ID { get; set; }
        public ProView()
        {
            InitializeComponent();
        }

        private void ProView_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            String Sql = String.Format("Select * from Producto");
            DataTable tabview = ConexionBD.Data(Sql);
            View.DataSource = tabview;
        }

        private void BtnEdi_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ID = Convert.ToInt16(this.View.CurrentRow.Cells[0].Value);
            new Productos(this.ID).Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String Sql = String.Format("Select * from Producto Where concat (Id, Nombre, Precio, Iva, Descripcion) LIKE '%" + txtSearch.Text + "%'");
            DataTable consul = ConexionBD.Data(Sql);
            View.DataSource = consul;
        }
    }
}
