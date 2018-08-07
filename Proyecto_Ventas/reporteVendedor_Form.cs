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
    public partial class reporteVendedor_Form : Form
    {
        public reporteVendedor_Form()
        {
            InitializeComponent();
        }
            public string Finicio;
            public string Ffinal;
            public string Id;

        private void reporteVendedor_Form_Load(object sender, EventArgs e)
        {
            reporteVendedor rptVendedor = new reporteVendedor();
            rptVendedor.SetParameterValue("_Finicio", Finicio);
            rptVendedor.SetParameterValue("_Ffinal", Ffinal);
            rptVendedor.SetParameterValue("_IdVendedor", Id);

            ReportViewerVendedor.ReportSource = rptVendedor;
        }
    }
}
