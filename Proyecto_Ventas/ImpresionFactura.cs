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
    public partial class ImpresionFactura : Form
    {
        public ImpresionFactura()
        {
            InitializeComponent();
            reportes1.SetDataSource(ConexionBD.Data("SELECT * FROM reporte WHERE 'No. Factura'= (SELECT MAX(Id) FROM ventas)"));
        }
    }
}
