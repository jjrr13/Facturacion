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
    public partial class InvenView : Form
    {
        private object tabview;

        public InvenView()
        {
            InitializeComponent();
        }

        private void InvenView_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            String Sql = String.Format("Select * from Inventario");
            DataTable tabview = ConexionBD.Data(Sql);
            /*DataColumn col = tabview.Columns[5];
            Convert.ToDateTime(col["Fecha"]);*/
            View.DataSource = tabview;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            String Sql = String.Format("Select * from Inventario Where concat (Id, Producto_id, Sucursal_id, Movimiento, Cantidad_Pro) LIKE '%" + txtFiltro.Text + "%'");
            DataTable consul = ConexionBD.Data(Sql);
            View.DataSource = consul;
        }
    }
}
