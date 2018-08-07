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
    public partial class GeneraReporte : Form
    {
        Boolean verifica = true;
        String tipoReporte;
        String periodoSem;
        String peridoTri;
        String año;
        String condicion;
        String sucuralId;
        String vendedorId;
        String sql = "";
        String Finicio;
        String Ffinal;
        String bandera;

        public GeneraReporte()
        {
            InitializeComponent();

            cargarCX(0);
            cargarCX(3);
            cargarCX(4);


            lbPeriodo.Visible = false;
            cxPeriodo.Visible = false;

            lbAño.Visible = false;
            años.Minimum = 2000;
            años.Maximum = int.Parse(DateTime.Now.ToString("yyyy"));
            años.Value = int.Parse(DateTime.Now.ToString("yyyy"));
            años.Visible = false;

        }

        public void cargarCX(int tipo)
        {
            if (tipo == 0)
            {
                cxReporte.Items.Add("<--Seleccione-->");
                cxReporte.Items.Add("Trimestral");
                cxReporte.Items.Add("Semestral");
                cxReporte.Items.Add("Anual");
                cxReporte.SelectedIndex = 0;
            }
            else if (tipo == 1)
            {
                cxPeriodo.Items.Clear();
                cxPeriodo.Items.Add("<--Seleccione-->");
                cxPeriodo.SelectedIndex = 0;
                cxPeriodo.Items.Add("1 - Periodo");
                cxPeriodo.Items.Add("2 - Periodo");
                cxPeriodo.Items.Add("3 - Periodo");
                cxPeriodo.Items.Add("4 - Periodo");
            }
            else if (tipo == 2)
            {
                cxPeriodo.Items.Clear();
                cxPeriodo.Items.Add("<--Seleccione-->");
                cxPeriodo.SelectedIndex = 0;
                cxPeriodo.Items.Add("1 - Semestre");
                cxPeriodo.Items.Add("2 - Semestre");
            }
            else if (tipo == 3)
            {
                cxSucursal.Items.Add("<--Seleccione-->");
                cxSucursal.Items.Add("0 - Todas");
                DataTable tb = ConexionBD.Data("SELECT * FROM sucursal");

                if (tb.Rows.Count > 0 && cxSucursal.Text != "<--Seleccione-->")
                {
                    for (int j = 0; j < tb.Rows.Count; j++)
                    {
                        cxSucursal.Items.Add(tb.Rows[j]["Id"].ToString() + " - " + tb.Rows[j]["Ubicacion"].ToString());
                    }
                }
                cxSucursal.SelectedIndex = 0;
                //cxSucursal.DataSource = ConexionBD.Data("SELECT * FROM sucursal");
                //cxSucursal.DisplayMember="Ubicacion";
                //cxSucursal.ValueMember = "Id";
            } else if (tipo == 4)
            {
                cxVendedor.Items.Add("<--Seleccione-->");
                DataTable tb = ConexionBD.Data("SELECT Id, concat(Nombre, ' ', Apellido) as Nombre FROM persona WHERE Roll_Id =" + 1);
                if (tb.Rows.Count > 0 && cxSucursal.Text == "<--Seleccione-->")
                {
                    for (int j = 0; j < tb.Rows.Count; j++)
                    {
                        cxVendedor.Items.Add(tb.Rows[j]["Id"].ToString() + " - " + tb.Rows[j]["Nombre"].ToString());
                    }
                }
                cxVendedor.SelectedIndex = 0;
            }
            else if (tipo == 5)
            {
                cxVendedor.Items.Clear();
                //cxVendedor.ResetText();

                cxVendedor.Items.Add("<--Seleccione-->");

                DataTable tb = ConexionBD.Data("SELECT Id, concat(Nombre, ' ', Apellido) as Nombre FROM persona WHERE Roll_Id =" + 1 + " AND Sucursal_Id=" + sucuralId);

                if (tb.Rows.Count > 0 && (cxSucursal.Text != "<--Seleccione-->" || cxSucursal.Text != "0 - Todas"))
                {
                    //MessageBox.Show("aqui");
                    for (int j = 0; j < tb.Rows.Count; j++)
                    {
                        cxVendedor.Items.Add(tb.Rows[j]["Id"].ToString() + " - " + tb.Rows[j]["Nombre"].ToString());
                    }
                }
                cxVendedor.SelectedIndex = 0;
            }
        }

        private void cxReporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tipoReporte = cxReporte.Text;
            año = años.Value.ToString();



            if (tipoReporte == "Trimestral")
            {
                lbAño.Visible = true;
                años.Visible = true;
                lbPeriodo.Visible = true;
                cxPeriodo.Visible = true;

                cargarCX(1);

            }
            else if (tipoReporte == "Semestral")
            {
                lbAño.Visible = true;
                años.Visible = true;
                lbPeriodo.Visible = true;
                cxPeriodo.Visible = true;

                cargarCX(2);
            }
            else if (tipoReporte == "Anual")
            {
                lbAño.Visible = true;
                años.Visible = true;
                lbPeriodo.Visible = false;
                cxPeriodo.Visible = false;
                Finicio =  año + "-01-01"; Ffinal = año + "-12-3 ";

            }
            else
            {
                lbAño.Visible = false;
                años.Visible = false;
                lbPeriodo.Visible = false;
                cxPeriodo.Visible = false;
                verifica = false;
            }
        }



        private void cxPeriodo_SelectionChangeCommitted(object sender, EventArgs e)
        {


            if (tipoReporte == "Trimestral")
            {
                peridoTri = cxPeriodo.Text;

                if (peridoTri == "1 - Periodo") { Finicio =  año + "-01-01"; Ffinal =  año + "-03-31 "; }
                else if (peridoTri == "2 - Periodo") { Finicio = año + "-04-01"; Ffinal =  año + "-06-30 "; }
                else if (peridoTri == "3 - Periodo") { Finicio =  año + "-07-01"; Ffinal =  año + "-09-30 "; }
                else if (peridoTri == "4 - Periodo") { Finicio =  año + "-10-01"; Ffinal =  año + "-12-31 "; }
            }
            else if (tipoReporte == "Semestral")
            {
                periodoSem = cxPeriodo.Text;

                if (periodoSem == "1 - Semestre") { Finicio =  año + "-01-01"; Ffinal =  año + "-06-30 "; }
                else if (periodoSem == "2 - Semestre") { Finicio =  año + "-07-01"; Ffinal =  año + "-12-31 "; }

            }
            else condicion = "";
        }

        private void años_ValueChanged(object sender, EventArgs e)
        {
            
            año = años.Value.ToString();
            //MessageBox.Show("entro al evento de fecha " + año +" = "+ años.Value);
            condicion = "YEAR(Fecha)=" + año;
            // MessageBox.Show(año);
        }

        private void cxSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String[] sucursal = cxSucursal.Text.Split('-');
            if (cxSucursal.Text== "0 - Todas")
            {
                cxVendedor.Enabled = false;
            }
            else if (cxSucursal.Text == "<--Seleccione-->")
            {
                cxVendedor.Enabled = true;
                cargarCX(4);
            }
            else
            {
                cxVendedor.Enabled = true;
                sucuralId = sucursal[0];
                cargarCX(5);
            }
        }

        private void cxVendedor_SelectionChangeCommitted(object sender, EventArgs e)
        {

            String[] vendedor = cxVendedor.Text.Split('-');
            vendedorId = vendedor[0];

            //MessageBox.Show("" + vendedorId);

            if (cxVendedor.Text!="<--Seleccione-->" && (cxSucursal.Text== "<--Seleccione-->" || cxSucursal.Text == "0 - Todas"))
            {
                

                sql = "SELECT suc.Ubicacion, per.Id, concat(per.Nombre, ' ',per.Apellido) AS Nombre, sum(ven.TotalFatura) AS 'Total Vendido' FROM ventas AS ven " +
                    "INNER JOIN persona AS per ON per.Id = ven.Vendedor_Id " +
                    "INNER JOIN sucursal AS suc ON suc.Id = ven.Sucursal_Id " +
                    "WHERE ven.Vendedor_Id = "+ vendedorId + " AND (Fecha BETWEEN '"+ Finicio+"' AND '"+Ffinal+"' ) ";
            }
            else
            {
                sql = "SELECT suc.Ubicacion, per.Id, concat(per.Nombre, ' ',per.Apellido) AS Nombre, sum(ven.TotalFatura) AS 'Total Vendido' FROM ventas AS ven " +
                    "INNER JOIN persona AS per ON per.Id = ven.Vendedor_Id " +
                    "INNER JOIN sucursal AS suc ON suc.Id = ven.Sucursal_Id " +
                    "WHERE ven.Vendedor_Id = " + vendedorId + " AND (Fecha BETWEEN '" + Finicio + "' AND '" + Ffinal + "' ) AND Sucursal_Id =" + sucuralId;

                MessageBox.Show("en el else  " + vendedorId);
            }
        }

        

        private void Consultar_Click_1(object sender, EventArgs e)
        {
            ///////////////////////////////
            MessageBox.Show("entro al evento " + condicion);
            Boolean ok = true;


            if (tipoReporte != "<--Seleccione-->")
            {
                if (tipoReporte != "Anual" && cxPeriodo.Text == "<--Seleccione-->")
                {
                    ok = false;
                    MessageBox.Show("Debese Seleccionar El periodo que desea seleccionar", "Error 1355", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(tipoReporte == "Anual" && cxSucursal.Text=="<--Seleccione-->")
                {
                    MessageBox.Show(Finicio + "   -...-anual" + Ffinal);
                    tablaReport.DataSource = null;

                    sql = "SELECT suc.Id, Ubicacion, SUM(TotalFatura) AS 'Total Vendido' FROM ventas AS ven " +
                            "INNER JOIN sucursal AS suc ON suc.Id = ven.Sucursal_Id " +
                            "WHERE (Fecha BETWEEN '" + Finicio + "' AND '" + Ffinal + "' ) " +
                            "GROUP BY Ubicacion";

                    tablaReport.DataSource = ConexionBD.Data(sql);

                    bandera = "anual";
                }
                else
                {
                    if (cxSucursal.Text != "<--Seleccione-->" && cxSucursal.Text != "0 - Todas")
                    {
                        if (cxVendedor.Text != "<--Seleccione-->")
                        {
                            tablaReport.DataSource = null;

                            sql = "SELECT ven.Id, concat(Nombre, ' ', Apellido) AS Nombre, SUM(TotalFatura) AS 'Total' FROM ventas AS ven " +
                                "INNER JOIN persona AS per ON per.Id = ven.Vendedor_Id " +
                                "INNER JOIN sucursal AS suc ON suc.Id = ven.Sucursal_Id " +
                                "WHERE (Fecha BETWEEN '" + Finicio + "' AND '" + Ffinal + "' ) AND Vendedor_Id = " + vendedorId;

                            
                            tablaReport.DataSource = ConexionBD.Data(sql);

                            bandera = "vendedor";
                        }
                        else
                        {
                            MessageBox.Show("AQUI EN ESTA" + condicion, "Error 1355", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tablaReport.DataSource = null;

                            sql = "SELECT suc.Id, Ubicacion, TotalFatura AS 'Total Vendido' FROM ventas AS ven " +
                                "INNER JOIN sucursal AS suc ON suc.Id = ven.Sucursal_Id " +
                                "WHERE  (Fecha BETWEEN '" + Finicio + "' AND '" + Ffinal + "' ) AND Sucursal_Id = " + sucuralId;

                            tablaReport.DataSource = ConexionBD.Data(sql);

                            bandera = "sucursal";
                        }
                    }
                    else if (cxSucursal.Text == "0 - Todas")
                    {
                        tablaReport.DataSource = null;

                        sql = "SELECT suc.Id, Ubicacion Fecha, SUM(TotalFatura) AS 'Total Vendido' FROM ventas AS ven " +
                                "INNER JOIN sucursal AS suc ON suc.Id = ven.Sucursal_Id " +
                                "WHERE (Fecha BETWEEN '" + Finicio + "' AND '" + Ffinal + "' )"+
                                "GROUP BY ven.Id";

                        tablaReport.DataSource = ConexionBD.Data(sql);

                        bandera = "todas";

                    }
                    else
                    {
                        if (cxVendedor.Text != "<--Seleccione-->")
                        {
                            tablaReport.DataSource = null;

                            sql = "SELECT ven.Id, concat(Nombre, ' ', Apellido) AS Nombre, SUM(TotalFatura) AS 'Total' FROM ventas AS ven " +
                                "INNER JOIN persona AS per ON per.Id = ven.Vendedor_Id " +
                                "INNER JOIN sucursal AS suc ON suc.Id = ven.Sucursal_Id " +
                                "WHERE (Fecha BETWEEN '" + Finicio + "' AND '" + Ffinal + "' ) AND Vendedor_Id = " + vendedorId;


                            tablaReport.DataSource = ConexionBD.Data(sql);

                            bandera = "vendedor";
                        }
                    }
                    
                }
            }
            else
            {
                ok = false;
                MessageBox.Show("Debese Seleccionar Un tipo de Reporte Primero", "Error 1355", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /////////////////////////////////
        }

        private void btReportar_Click(object sender, EventArgs e)
        {
            //DataTable tb = new DataTable();
            //tb = (DataTable)tablaReport.DataSource;
            if (bandera=="anual")
            {
                MessageBox.Show("f.i. " + Finicio + " f.f. " + Ffinal +"  anual");

                reporteAnual_Form rptA = new reporteAnual_Form();
                rptA.Finicio = this.Finicio;
                rptA.Ffinal = this.Ffinal;
                rptA.ShowDialog();

                bandera = "";
            }
            else if (bandera=="vendedor")
            {
                MessageBox.Show("f.i. " + Finicio + " f.f. " + Ffinal + "  vendedor");

                reporteVendedor_Form rptV = new reporteVendedor_Form();
                rptV.Finicio = this.Finicio;
                rptV.Ffinal = this.Ffinal;
                rptV.Id = this.vendedorId;

                rptV.ShowDialog();
                bandera = "";
            }
            else if (bandera == "sucursal")
            {
                MessageBox.Show("f.i. " + Finicio + " f.f. " + Ffinal + "  sucursal");

                reporteSucursal_Form rptS = new reporteSucursal_Form();
                rptS.Finicio = this.Finicio;
                rptS.Ffinal = this.Ffinal;
                rptS.Id = this.sucuralId;

                rptS.ShowDialog();
                bandera = "";
            }
        }
    }
}
