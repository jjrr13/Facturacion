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
    public partial class Facturas : Form
    {
        public static DataTable dt = new DataTable();

        public static DataTable bt3 = new DataTable();

        List<String[]> lista = new List<String[]>();

        public static Boolean banderaConfirma = true;

        public static Boolean bandera = true;

        int cont = 0;
        String[] catch1 = new String[1];
        String catch2 = "";
        int catch3 = 0;

        int subt = 0;
        int cont4 = 0;
        double ivaFin = 0;

        int index;
        int cont2 = 0;
        int cont3 = 0;

        Boolean key = true;

        String idVendedor;

       

        public Facturas()
        {
            //dt = null;
            InitializeComponent();
            tablaVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            tablaVenta.EnableHeadersVisualStyles = false;

            

            int numero = ConexionBD.Id(5) + 1;
            CoansecutivoFac.Text = numero+"";

            lbSucursal.Text = Log.sucursal;
            lbEmpleado.Text = Log.nombre;
            lbFecha.Text= DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            txCantidad.Text = "1";
            txCliente.Text = "Some User No. "+numero;

            cxVendedores.Items.Add("<--Seleccione-->");
            cxVendedores.SelectedIndex = 0;
            DataTable dato = ConexionBD.Data("SELECT persona.Id, Nombre FROM persona " +
                "INNER JOIN roles ON roles.Id = persona.Roll_Id " +
                "INNER JOIN sucursal ON sucursal.Id = persona.Sucursal_Id " +
                "WHERE persona.Sucursal_id=" + Log.sucurId + " AND persona.Roll_Id=" + 1);

            for (int j = 0; j < dato.Rows.Count; j++)
            {
                cxVendedores.Items.Add(dato.Rows[j]["Id"].ToString() + " - " + dato.Rows[j]["Nombre"].ToString());
            }
            cxProducto();
            mensaje.Text = "Jamás debes abandonar tus \nsueños, lo que debes hacer es \nderrumbar y destruir todas las \nbarreras que te impiden lograr tus \nSUEÑOS...";
            mensaje1.Text = "Si te vas a caer, que sea \na propósito y para tomar impulso \npara dar un gran salto, cruzar \nlas barreras que se interponen en \ntu camino y logres todas tus\n METAS!!!.";
        }

        public void cxProducto()
        {
            //DataTable tb = ConexionBD.Data("SELECT Id, Nombre FROM producto WHERE Sucursal_Id =" + Log.sucurId);
            DataTable tb = ConexionBD.Data("SELECT Id, Nombre FROM producto WHERE Sucursal_Id =" + Log.sucurId);


            //Tuple<String> Tuple = new Tuple.Create(tb);

            cxProduc.Items.Add("<--Seleccione-->");

            for (int j = 0; j < tb.Rows.Count; j++)
            {
                cxProduc.Items.Add(tb.Rows[j]["Id"] + " - " + tb.Rows[j]["Nombre"]);
            }
            cxProduc.SelectedIndex = 0;
        }
        public void consulta(String tipo, String condicion)
        {
            DataTable tb2 = new DataTable();

            if (tipo == "codigo")
            {
                //MessageBox.Show("codigo " + Log.sucurId);
                tb2 = ConexionBD.Data("SELECT 1 Item, Id, Nombre, Cantidad as Disponibilidad, 1 as Cantidades, Precio, Iva*Precio AS Iva, Precio as SubTotal FROM Producto WHERE Id = " + condicion+" AND Sucursal_Id= "+Log.sucurId);

            }
            else if (tipo == "lista")
            {
               // MessageBox.Show("lista " + Log.sucurId);

                tb2 = ConexionBD.Data("SELECT 1 Item, Id, Nombre, Cantidad as Disponibilidad, 1 as Cantidad, Precio, Iva*Precio, Precio as SubTotal FROM Producto WHERE Id = '" + condicion + "' AND Sucursal_Id= " + Log.sucurId);
            }
            else if (tipo == "nombre")
            {
                MessageBox.Show("nombre " + Log.sucurId);

            }

            if (int.Parse(tb2.Rows[0][3].ToString()) > 0)
            {
                String[] datosBd = new String[8];

                for (int j = 0; j < tb2.Columns.Count; j++)
                {
                    datosBd[j] = tb2.Rows[0][j].ToString(); // agrego el resultado a un arraya
                }

                if (tb2.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra ningun producto con ese Codigo");
                }
                else
                {
                    if (tablaVenta.Rows.Count == 0)
                    {
                        lista.Add(datosBd); // agrego el array en la lista
                        dt = tb2;           //le paso el resultado a la table padre
                        tablaVenta.DataSource = dt; //le paso los valores a la view
                        txCantidad.Focus();
                    }
                    else
                    {
                        Boolean si = true;
                        for (int j = 0; j < lista.Count; j++)
                        {
                            if (datosBd[1] == lista[j][1]) //comparo lo que hay almacenado en el array con el list
                            {
                                tablaVenta.Rows[j].Cells[6].Value = datosBd[6]; //si hay algo le manda el verdadero valor del iva
                                tablaVenta.Rows[j].Cells[6].Selected = true;
                                txCantidad.Focus();
                                si = false;
                                break;
                            }
                        }
                        if (si)
                        {
                            //si es un producto nuevo se agraga normal a la tabla view

                            dt.Rows.Add(tb2.Rows[0][0], tb2.Rows[0][1], tb2.Rows[0][2], tb2.Rows[0][3], tb2.Rows[0][4], tb2.Rows[0][5], tb2.Rows[0][6], tb2.Rows[0][7]);
                            tablaVenta.DataSource = dt;
                            lista.Add(datosBd);
                            txCantidad.Focus();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Hay Suficientes Ariculos de " + tb2.Rows[0][1]);
            }


        }


        /// <summary>
        /// ---------------------- LISTADO ----------------------------------
        /// </summary>

        
        private void cxProduc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cont != 0)
            {
                if (cxProduc.SelectedItem.ToString() != "<--Seleccione-->")
                {
                    String[] captura = cxProduc.SelectedItem.ToString().Split('-');
                    String Id = captura[0];
                    String tipo = "lista";

                    DialogResult result = MessageBox.Show("Desea Agregar Este Producto??", "Confirmacion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    Console.WriteLine(result);

                    if (result == DialogResult.OK)
                    {
                        consulta(tipo, Id);
                    }
                    else
                    {
                        cxProduc.SelectedIndex = 0;
                    }

                }

                // Console.WriteLine("noooooooooooooooooooooooooo");
            }
            cont++;
        }

        /// <summary>
        /// ------------------------------------------- Cantidad con Enter ----------------------------------
        /// </summary>

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            String Id = TxCodigo.Text;
            String tipo = "codigo";

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TxCodigo.Focus();
                consulta(tipo, Id);
            }
            else if ((int)e.KeyChar == (int)Keys.Back)
            {
               
            }
        }


        /// <summary>
        /// ---------------------- CODIGO ------------------------------------------------------
        /// </summary>

        private void txPorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //this.Hide();
                VentaProducto.nombre = txPorNombre.Text;
                VentaProducto s = new VentaProducto();
                s.ShowDialog();

                this.Show();
                if (!bandera)
                {
                    String[] datosBd = new String[8];

                    for (int j = 0; j < bt3.Columns.Count; j++)
                    {
                        datosBd[j] = bt3.Rows[0][j].ToString(); // agrego el resultado a un arraya
                    }

                    if (bt3.Rows.Count == 0)
                    {
                        MessageBox.Show("No se escogio ningun producto");
                    }
                    else
                    {
                        if (tablaVenta.Rows.Count == 0)
                        {
                            lista.Add(datosBd); // agrego el array en la lista
                            dt = bt3;           //le paso el resultado a la table padre
                            tablaVenta.DataSource = dt; //le paso los valores a la view
                            txCantidad.Focus();
                            bt3 = new DataTable();
                            MessageBox.Show("No hay nada en la Tabla");
                        }
                        else
                        {
                            Boolean si = true;
                            for (int j = 0; j < lista.Count; j++)
                            {
                                if (datosBd[1] == lista[j][1]) //comparo lo que hay almacenado en el array con el list
                                {
                                    MessageBox.Show("encontro que son iguales");
                                    for (int r = 0; r < tablaVenta.Rows.Count; r++)
                                    {
                                        if (datosBd[1] == tablaVenta.Rows[r].Cells[1].Value.ToString())
                                        {
                                            MessageBox.Show("Vlor de array " + datosBd[1]);
                                            MessageBox.Show("Vlor de celda " + tablaVenta.Rows[r].Cells[1].Value.ToString());
                                            tablaVenta.Rows[r].Cells[6].Value = datosBd[6]; //si hay algo le manda el verdadero valor del iva
                                            tablaVenta.Rows[r].Cells[0].Selected = true;
                                            //textBox1.Focus();
                                            bt3.Clear();
                                            si = false;
                                            break;
                                        }
                                    }

                                }
                            }
                            if (si)
                            {
                                //si es un producto nuevo se agraga normal a la tabla view
                                MessageBox.Show("agrego la fila");
                                dt.Rows.Add(bt3.Rows[0][0], bt3.Rows[0][1], bt3.Rows[0][2], bt3.Rows[0][3], bt3.Rows[0][4], bt3.Rows[0][5], bt3.Rows[0][6], bt3.Rows[0][7]);
                                tablaVenta.DataSource = dt;
                                lista.Add(datosBd);
                                txCantidad.Focus();
                            }
                        }
                    }
                    //tablaVenta.DataSource = dt;
                    txPorNombre.Text = "";
                    txCantidad.Focus();
                    bandera = true;
                }
            }

        }

        public void detallesPago()
        {
            for (int j = 0; j < tablaVenta.RowCount; j++)
            {
                //Console.WriteLine("ENTRO AL CICLO   " + j);
                subt = subt + int.Parse(tablaVenta.Rows[j].Cells[7].Value.ToString());
                ivaFin = ivaFin + double.Parse(tablaVenta.Rows[j].Cells[6].Value.ToString());
            }
            txSubtotal.Text = subt + "";
            txIva.Text = ivaFin + "";
            txTotal.Text = (subt + ivaFin) + "";
        }

        public void resultado()
        {
            try
            {
                String nombre = tablaVenta.CurrentRow.Cells[2].Value.ToString();

                int cant = int.Parse(txCantidad.Text);
                int dispo = Convert.ToInt32(tablaVenta.CurrentRow.Cells[3].Value);
                int prec = Convert.ToInt32(tablaVenta.CurrentRow.Cells[5].Value);
                int sub = Convert.ToInt32(tablaVenta.CurrentRow.Cells[7].Value);
                double iva = Convert.ToDouble(tablaVenta.CurrentRow.Cells[6].Value);
                iva = iva / prec;
                Console.WriteLine(iva);

                if (dispo >= cant && dispo > 0)
                {
                    sub = cant * prec;
                    double ivaTotal = (cant * prec) * iva;

                    tablaVenta.Rows[tablaVenta.CurrentRow.Index].Cells[4].Value = cant;
                    tablaVenta.Rows[tablaVenta.CurrentRow.Index].Cells[6].Value = ivaTotal;
                    tablaVenta.Rows[tablaVenta.CurrentRow.Index].Cells[7].Value = sub;


                    detallesPago();
                    subt = 0;
                    ivaFin = 0;
                    cont4 = 0;
                    catch3 = catch3 - cant;
                }
                else
                {
                    MessageBox.Show("No Hay Suficientes Ariculos de " + nombre);
                    txCantidad.Text = dispo + "";
                    key = true;
                    txCantidad.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Debe Seleccionar primero el Producto!! FUCK!!", "Error 1313", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxCodigo.Focus();
            }

        }
        /// <summary>
        /// ---------------- ASIGNAR CANTIDAD -------------------------
        /// </summary>
        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (key)
            {
                cont4++;
                TxCodigo.Text = "";
                TxCodigo.Focus();

                if (cont4 > 0)
                {
                    resultado();

                }
                txCantidad.Text = "1";
            }
            else
            {
                key = true;
            }

        }

        private void tablaVenta_TabIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cambio el Index------------------------------" + e.ToString());
        }
        
        private void tablaVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Console.WriteLine("aquiiiiiiiiiiiiiiiii");

            cont2 = cont2 + 1;
            int valor = tablaVenta.Rows.Count;

            //Console.WriteLine("------------------------------"+valor);
            if (valor == 1)
            {

            }
            else
            {
                //tablaVenta.CurrentCell = tablaVenta.Rows[valor-2].Cells[0];
                ////tablaVenta.Rows[valor-2].Cells[0].Selected=true;
                ////tablaVenta.CurrentRow.Selected = true;

                index = tablaVenta.CurrentRow.Index;
                tablaVenta.Rows[index + 1].Cells[0].Selected = true;

                //Console.WriteLine("actual filaaaaaa "+ index);
                if (cont2 >= 7)
                {
                    cont3++;
                    tablaVenta.Rows[index].Cells[0].Value = cont3;
                }


            }
        }

        private void tablaVenta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("estoy en el focococococo " + tablaVenta.CurrentRow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaProducto.nombre = txPorNombre.Text;
            VentaProducto s = new VentaProducto();
            s.ShowDialog();

            this.Show();
            if (!bandera)
            {
                String[] datosBd = new String[8];

                for (int j = 0; j < bt3.Columns.Count; j++)
                {
                    datosBd[j] = bt3.Rows[0][j].ToString(); // agrego el resultado a un arraya
                }

                if (bt3.Rows.Count == 0)
                {
                    MessageBox.Show("No se escogio ningun producto");
                }
                else
                {
                    if (tablaVenta.Rows.Count == 0)
                    {
                        lista.Add(datosBd); // agrego el array en la lista
                        dt = bt3;           //le paso el resultado a la table padre
                        tablaVenta.DataSource = dt; //le paso los valores a la view
                        txCantidad.Focus();
                        bt3 = new DataTable();
                        MessageBox.Show("No hay nada en la Tabla");
                    }
                    else
                    {
                        Boolean si = true;
                        for (int j = 0; j < lista.Count; j++)
                        {
                            if (datosBd[1] == lista[j][1]) //comparo lo que hay almacenado en el array con el list
                            {
                                MessageBox.Show("encontro que son iguales");
                                for (int r = 0; r < tablaVenta.Rows.Count; r++)
                                {
                                    if (datosBd[1] == tablaVenta.Rows[r].Cells[1].Value.ToString())
                                    {
                                        MessageBox.Show("Vlor de array " + datosBd[1]);
                                        MessageBox.Show("Vlor de celda " + tablaVenta.Rows[r].Cells[1].Value.ToString());
                                        tablaVenta.Rows[r].Cells[6].Value = datosBd[6]; //si hay algo le manda el verdadero valor del iva
                                        tablaVenta.Rows[r].Cells[0].Selected = true;
                                        //textBox1.Focus();
                                        bt3.Clear();
                                        si = false;
                                        break;
                                    }
                                }

                            }
                        }
                        if (si)
                        {
                            //si es un producto nuevo se agraga normal a la tabla view
                            MessageBox.Show("agrego la fila");
                            dt.Rows.Add(bt3.Rows[0][0], bt3.Rows[0][1], bt3.Rows[0][2], bt3.Rows[0][3], bt3.Rows[0][4], bt3.Rows[0][5], bt3.Rows[0][6], bt3.Rows[0][7]);
                            tablaVenta.DataSource = dt;
                            lista.Add(datosBd);
                            txCantidad.Focus();
                        }
                    }
                }
                //tablaVenta.DataSource = dt;
                txPorNombre.Text = "";
                txCantidad.Focus();
                bandera = true;
            }
        }
        
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.Back)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {

                    key = false;

                    resultado();
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Debe Ingresar un Numero!! FUCK!!", "Error 1313", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("funciono");
        }

        private void mskCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            String valor = TxCodigo.Text;
            String tipo = "codigo";

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                consulta(tipo, valor);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fila = tablaVenta.CurrentCell.RowIndex;

            ConfirmacionAdmin cf = new ConfirmacionAdmin("Supervisor");
            cf.ShowDialog();

            if (!banderaConfirma)
            {
                tablaVenta.Rows.Remove(tablaVenta.Rows[fila]);
                detallesPago();
                banderaConfirma = true;
            }
            
        }

        private void cxVendedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String[] vendedorId = cxVendedores.Text.Split('-');
            idVendedor = vendedorId[0];
        }

        private void btFactura_Click(object sender, EventArgs e)
        {
            if (cxVendedores.Text!="<--Seleccione-->")
            {
                Console.WriteLine("" + idVendedor);
                Console.WriteLine("" + Log.sucurId);
                Console.WriteLine("" + txSubtotal.Text);
                Console.WriteLine("" + txIva.Text);
                Console.WriteLine("" + txTotal.Text);
                Console.WriteLine("" + lbFecha.Text);
                
                // Console.WriteLine("" +);

                ConexionBD.SQL("INSERT INTO ventas VALUES(NULL, '" + idVendedor + "','"+txCliente.Text+"', NULL, '"
                    + Log.sucurId + "','" + txSubtotal.Text + "','" + txIva.Text + "','" + txTotal.Text + "','" + lbFecha.Text + "')");

                //MessageBox.Show("Inserto Factura..........................");

                for (int j = 0; j < tablaVenta.RowCount; j++)
                {

                    subt = subt + int.Parse(tablaVenta.Rows[j].Cells[7].Value.ToString());
                    ivaFin = ivaFin + double.Parse(tablaVenta.Rows[j].Cells[6].Value.ToString());
                    ConexionBD.SQL("INSERT INTO detalles VALUES (NULL, '" + CoansecutivoFac.Text + "', '" + tablaVenta.Rows[j].Cells[1].Value.ToString() 
                        + "','" + tablaVenta.Rows[j].Cells[4].Value.ToString() + "','" + tablaVenta.Rows[j].Cells[5].Value.ToString() + "','" 
                        + tablaVenta.Rows[j].Cells[6].Value.ToString() + "','" + tablaVenta.Rows[j].Cells[7].Value.ToString() +"')");

                    //MessageBox.Show("Inserto Detalle No " + j + "..........................");

                }

                

                CrearTicket tk = new CrearTicket();
                tk.AbreCajon();
                tk.TextoCentrado("DISSFRUTA");
                tk.TextoIzquierda("EXPEDIDO EN: Cali");
                tk.TextoIzquierda("DIR: Ciudad Jardin");
                tk.TextoIzquierda("TEL: 314 786 02 94");
                tk.TextoIzquierda("EMAIL: dissfruta@gmail.com");
                tk.TextoIzquierda("");
                tk.TextoExtremos("Caja # 1", "Ticket #"+ NoFactura.Text + CoansecutivoFac.Text);
                tk.lineasAsteriscos();

                tk.TextoIzquierda("");
                tk.TextoIzquierda("ATENDIO: " + cxVendedores.SelectedItem);
                tk.TextoIzquierda("CLIENTE: " + txCliente.Text);
                tk.TextoIzquierda("FECHA: " + DateTime.Now.ToShortDateString() + " HORA: " + DateTime.Now.ToShortTimeString());
                tk.lineasAsteriscos();

                tk.EncabezadoVenta();
                tk.lineasAsteriscos();
                MessageBox.Show("Inserto Detalle No " + tablaVenta.RowCount+ "algo");
                for (int j = 0; j < tablaVenta.RowCount; j++)
                {
                    MessageBox.Show("Inserto Detalle No " + tablaVenta.Rows[j].Cells[2].Value.ToString() + "........jjj..................");
                    tk.AgregarArticulos(tablaVenta.Rows[j].Cells[2].Value.ToString(), int.Parse(tablaVenta.Rows[j].Cells[4].Value.ToString()),
                        decimal.Parse(tablaVenta.Rows[j].Cells[5].Value.ToString()), decimal.Parse(tablaVenta.Rows[j].Cells[6].Value.ToString()));

                }

                //foreach (DataGridViewRow fila in tablaVenta.Rows)
                //{
                //    MessageBox.Show("Inserto Detalle No " + fila.Cells[2].Value.ToString() + "........jjj..................");
                //    tk.AgregarArticulos(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[4].Value.ToString()),
                //        decimal.Parse(fila.Cells[5].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
                //}

                tk.lineasIgual();

                tk.AgregarTotales("          SUBTOTAL......$", decimal.Parse(txSubtotal.Text));
                tk.AgregarTotales("          IVA...........$", decimal.Parse(txIva.Text));
                tk.AgregarTotales("          TOTAL.........$", decimal.Parse(txTotal.Text));
                tk.TextoIzquierda("");
                tk.AgregarTotales("          EFECTIVO......$", 2000);
                tk.AgregarTotales("          CAMBIO........$", 0);

                tk.TextoIzquierda("");
                tk.TextoIzquierda("ARTICULOS VENDIDOS : "+ tablaVenta.RowCount);
                tk.TextoIzquierda("");
                tk.TextoCentrado("GRACIAS POR SU COMPRA by: J.J.");
                tk.CortarTicket();
                tk.ImprimirTicket("Microsoft XPS Document Writer");

                tablaVenta.DataSource = null;
                TxCodigo.Text = "";
                TxCodigo.Focus();
                txCantidad.Text = "";
                cxVendedores.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Debe Primero Un Vendedor!! FUCK!!", "Error 1313", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
