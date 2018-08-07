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
    public partial class reporteSucursal_Form : Form
    {
        public reporteSucursal_Form()
        {
            InitializeComponent();
        }

        public string Finicio;
        public string Ffinal;
        public string Id;

        private void reporteSucursal_Form_Load(object sender, EventArgs e)
        {
            reporteSucursal rptSucursal = new reporteSucursal();
            rptSucursal.SetParameterValue("_Finicio", Finicio);
            rptSucursal.SetParameterValue("_Ffinal", Ffinal);
            rptSucursal.SetParameterValue("_IdSucursal", Id);

            ReportViewerSucursal.ReportSource = rptSucursal;
        }
    }
}
