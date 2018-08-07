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
    public partial class VentaProducto : Form
    {
        public static String nombre;
        public VentaProducto()
        {
            InitializeComponent();
            txProducto.Text = nombre;
        }
        DataTable dt1;
        //Boolean accion = true;
        DataGridViewRow rw;
        int position = 0;

        private void txProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            dt1 = ConexionBD.Data("SELECT 1 Item, Id, Nombre, Cantidad as Disponibilidad, 1 as Cantidad, Precio, Iva*Precio, Precio as SubTotal FROM Producto " +
               "WHERE Nombre LIKE '%" + txProducto.Text + "%' AND Sucursal_Id ="+Log.sucurId);

            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("No se encuentra ningun producto con ese Codigo");
            }
            else
            {
                TablaNombres.DataSource = dt1;

            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rw.Cells[0].Value != null)
            {

                DialogResult result = MessageBox.Show("Desea Agregar Este Producto??", "Confirmacion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    if (Facturas.bt3.Columns.Count > 0)
                    {
                        MessageBox.Show("entro al lleno");
                        for (int j = 0; j < Facturas.bt3.Rows.Count; j++)
                        {
                            MessageBox.Show("" + Facturas.bt3.Rows[j][2] );

                            
                        }
                        Facturas.bandera = false;
                        Facturas.bt3.Rows.Add(rw.Cells[0].Value, rw.Cells[1].Value, rw.Cells[2].Value, rw.Cells[3].Value, rw.Cells[4].Value, rw.Cells[5].Value, rw.Cells[6].Value, rw.Cells[7].Value);
                        //Facturas.consulta()
                        Dispose();
                        //MessageBox.Show("No se escogio ningun producto");

                    }
                    else
                    {
                        MessageBox.Show("entro al vacio");

                        Facturas.bandera = false;

                        Facturas.bt3.Columns.Add("Item");
                        Facturas.bt3.Columns.Add("Id");
                        Facturas.bt3.Columns.Add("Nombre");
                        Facturas.bt3.Columns.Add("Disponibilidad");
                        Facturas.bt3.Columns.Add("Cantidad");
                        Facturas.bt3.Columns.Add("Precio");
                        Facturas.bt3.Columns.Add("Iva");
                        Facturas.bt3.Columns.Add("SubTotal");

                        Facturas.bt3.Rows.Add(rw.Cells[0].Value, rw.Cells[1].Value, rw.Cells[2].Value, rw.Cells[3].Value, rw.Cells[4].Value, rw.Cells[5].Value, rw.Cells[6].Value, rw.Cells[7].Value);
                        
                        Dispose();
                    }

                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un Producto FUCK!!!");

                }


            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Producto FUCK!!!");
            }

        }

        private void TablaNombres_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            rw = TablaNombres.Rows[e.RowIndex];
            position = e.RowIndex;
            
        }

        private void VentaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
