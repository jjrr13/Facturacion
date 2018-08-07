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
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
            cargarCx();
            edad.Value = 18;
            getId();
            LbFecha.Text = DateTime.Now.ToLongDateString();
            BtEditar.Enabled=false;
            BtEliminar.Enabled = false;
            btActualiza.Enabled = false;
            //BtAgregar.Enabled = false;

            nombre.Focus();
            nombre.Select();
            //tabla.DataSource = Conexion.Data("SELECT * FROM productos");
            

        }
        Boolean verifica = true;
        string nombreC;
        string apellidoC;
        string tipDoC;
        string DoC;
        int edadC;
        String privilegiosC;
        String sucursalC;
        Int64 telefonoC=0;
        string direccionC;
        string correoC;

        public void getId()
        {
            DataTable tb = ConexionBD.Data("CALL getIdTablas(1)");
            int numero = int.Parse(tb.Rows[0][0].ToString().Trim());

            numero = numero + 1;
            LbId.Text = ""+numero;
            //return numero;
        }

        public Boolean Verifica()
        {
            nombreC = nombre.Text;
            apellidoC = apellido.Text;
            tipDoC =tipoDoc.SelectedItem.ToString();
            DoC = Docuemento.Text;
            edadC = (int)edad.Value;
            privilegiosC = privilegios.SelectedItem.ToString();
            sucursalC = cxSucursal.SelectedItem.ToString();
            if (telefono.Text == null) telefonoC = 0;
            else telefonoC = Int64.Parse(telefono.Text);
                         
            direccionC= direccion.Text;
            correoC= correo.Text;

            if (nombreC.Length <= 3) verifica = false;
            if (apellidoC.Length <= 3) verifica = false;
            if (DoC.Length <=3) verifica = false;
            if (tipDoC == "<--Seleccione-->") verifica = false;
            if (edadC < 18) verifica = false;
            if (privilegiosC == "<--Seleccione-->") verifica = false;
            if (sucursalC == "<--Seleccione-->") verifica = false;
            if (telefonoC <= 4) verifica = false;
            if (direccionC.Length <= 0) verifica = false;
            if (correoC.Length <= 0) verifica = false;


            return verifica;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void cargarCx()
        {
            
            tipoDoc.Items.Add("<--Seleccione-->");
            tipoDoc.Items.Add("CC");
            tipoDoc.Items.Add("TI");
            tipoDoc.Items.Add("PS");
            tipoDoc.SelectedIndex = 0;

            DataTable tb1 = ConexionBD.Data("SELECT * FROM roles");
            privilegios.Items.Add("<--Seleccione-->");

            for (int j = 0; j < tb1.Rows.Count; j++)
            {
                privilegios.Items.Add(tb1.Rows[j][0] + " - " + tb1.Rows[j][1]);
            }
            privilegios.SelectedIndex = 0;

            DataTable tb2 = ConexionBD.Data("SELECT * FROM sucursal");
            cxSucursal.Items.Add("<--Seleccione-->");
            for (int j = 0; j < tb2.Rows.Count; j++)
            {
                cxSucursal.Items.Add(tb2.Rows[j][0] + " - " + tb2.Rows[j][1]);
            }

            cxSucursal.SelectedIndex = 0;
        }
        public void search()
        {
           String capturas = captura.Text;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int edadC = (int)edad.Value;
            Console.WriteLine("Numero: " + edadC);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Verifica())
            {
                MessageBox.Show("Falta Ingresar algun Dato");
                verifica = true;
            }
            else
            {
                Char delimiter = '-';
                
                String[] roll = privilegiosC.Split(delimiter);
                String[] sucu = sucursalC.Split(delimiter);
                int tres = DoC.Length;
                String usuario = nombreC.Substring(0, 3) + apellidoC.Substring(0, 3) + DoC.Substring((tres - 3),3);

                //Console.WriteLine("valores" + usuario);
                //Console.WriteLine(roll[0]+" Valores");
                ConexionBD.SQL("INSERT INTO persona VALUES(NULL,'"+nombreC+"','"+apellidoC+"','"+ 
                   tipDoC+"',"+DoC+","+edadC+",'"+roll[0]+"','"+sucu[0]+"','"+usuario+"','"+DoC+"','"+telefonoC+"','"+direccionC+"','"+correoC +"')");

                MessageBox.Show("Usuario Correctamente Creado!", "Procedimiento Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //nombre.Text="";
                //apellido.Text="";
                //Docuemento.Text="";
                //edad.Value=18;
                //telefono.Text = "";
                //direccion.Text="";
                //correo.Text="";
                cargarCx();
                //getId();

                limpiar();
            }
        }

        private void captura_KeyPress(object sender, KeyPressEventArgs e)
        {

            tabla.DataSource= ConexionBD.Data("SELECT per.Id, per.Nombre, per.Apellido, Roll, Ubicacion FROM persona AS per " +
                "INNER JOIN roles ON Roll_Id = roles.Id " +
                "INNER JOIN sucursal ON Sucursal_Id= sucursal.id " +
                "WHERE nombre LIKE '%" + captura.Text + "%'");

        }

        private void tabla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("entro al cell mouse");
            //BtEditar.Enabled = true;
            //BtEliminar.Enabled = true;

            //DataGridView tb1 = DataGridView.Rows(e.RowIndex);
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            BtAgregar.Enabled = false;
            BtEditar.Enabled = false;

            LbId.Text = tb1.Rows[0][0].ToString();
            nombre.Text = tb1.Rows[0][1].ToString();
            apellido.Text = tb1.Rows[0][2].ToString();
            tipoDoc.SelectedItem = tb1.Rows[0][3].ToString();
            Docuemento.Text = tb1.Rows[0][4].ToString();
            edad.Value = int.Parse(tb1.Rows[0][5].ToString());
            //Console.WriteLine(tb1.Rows[0][3].ToString() + " primero " + tb1.Rows[0][6].ToString() + " segundo " + tb1.Rows[0][7].ToString());
            privilegios.SelectedIndex = int.Parse(tb1.Rows[0][6].ToString());
            cxSucursal.SelectedIndex = int.Parse(tb1.Rows[0][7].ToString());
            telefono.Text = tb1.Rows[0][10].ToString();
            direccion.Text = tb1.Rows[0][11].ToString();
            correo.Text = tb1.Rows[0][12].ToString();

            btActualiza.Enabled = true;
            BtEliminar.Enabled = false;
        }
        public void limpiar()
        {
            getId();
            nombre.Text = "";
            apellido.Text = "";
            tipoDoc.SelectedIndex = 0;
            Docuemento.Text = "";
            edad.Value = 18;
            privilegios.SelectedIndex = 0;
            telefono.Text = "";
            direccion.Text = "";
            correo.Text = "";

            BtEditar.Enabled = false;
            BtEliminar.Enabled = false;
            BtAgregar.Enabled = true;
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        DataTable tb1;

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("entro al cell click");
            int IDs = Convert.ToInt16(this.tabla.CurrentRow.Cells[0].Value);

            tb1 = ConexionBD.Data("SELECT * FROM persona where Id = "+IDs);
            //btActualiza.Enabled = false;
            BtEliminar.Enabled = true;

            BtEditar.Enabled = true;

        }
            public static Boolean bandera=true;

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            new ConfirmacionAdmin("Administrador").ShowDialog();
            this.Show();
            if (!bandera)
            {
                ConexionBD.SQL("DELETE FROM persona WHERE Id= "+tb1.Rows[0][0]);
                bandera = true;
            }
            else
            {
                MessageBox.Show("Se Ha denegado la Accion", "Error 1355", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btActualiza_Click(object sender, EventArgs e)
        {
            Boolean verifico = Verifica();
            if (!verifico)
            {
                MessageBox.Show("Falta Ingresar algun Dato");
            }
            else
            {
                Char delimiter = '-';

                String[] roll = privilegiosC.Split(delimiter);
                String[] sucu = sucursalC.Split(delimiter);
                int tres = DoC.Length;
                String usuario = nombreC.Substring(0, 3) + apellidoC.Substring(0, 3) + DoC.Substring((tres - 3), 3);
                //Console.WriteLine("valores" + usuario);
                //Console.WriteLine(roll[0]+" Valores");
                
            ConexionBD.SQL("UPDATE persona SET Nombre='"+ nombreC + "'," +
                                               "Apellido ='"+apellidoC + "'," +
                                               "Tipo ='" + tipDoC + "'," +
                                               "Numero ='" + DoC + "'," +
                                               "Edad =" + edadC + "," +
                                               "Roll_Id =" + roll[0] + "," +
                                               "Sucursal_Id =" + sucu[0] + "," +
                                               "Name ='" + usuario +"'," +
                                               "Pass ='" + DoC +"'," +
                                               "Telefono ='" + telefonoC +"'," +
                                               "Direccion ='" + direccionC +"'," +
                                               "Correo ='" + correoC +"'"+
                " WHERE Id= " + tb1.Rows[0][0]);

                limpiar();
                btActualiza.Enabled = false;
            }
        }
    }
}
