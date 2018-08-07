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
    public partial class reporteAnual_Form : Form
    {
        public reporteAnual_Form()
        {
            InitializeComponent();
        }

        public string Finicio;
        public string Ffinal;
        public string Id;

        private void reporteAnual_Form_Load(object sender, EventArgs e)
        {
            reporteAnual rptAnual = new reporteAnual();
            rptAnual.SetParameterValue("_FInicio", Finicio);
            rptAnual.SetParameterValue("_Ffinal", Ffinal);

            ReportViewerAnual.ReportSource = rptAnual;
        }
    }
}
