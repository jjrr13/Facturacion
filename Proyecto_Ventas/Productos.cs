using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ventas
{
    public partial class Productos : Form
    {
        Boolean Nuevo = true;
        int ID;
        public Productos()
        {
            InitializeComponent();
            btnActu.Enabled = false;
            getId();
            CargarCombo();
            LbFecha.Text = DateTime.Now.ToLongDateString();
        }

        public Productos(int ID)
        {
            InitializeComponent();
            btnActu.Enabled = true;
            btnIn.Enabled = false;
            Nuevo = false;
            this.ID = ID;
            lbId.Text = ID + "";
            String Sql = String.Format("Select * from Producto where Id ='" + lbId.Text + "'");
            DataTable re = ConexionBD.Data(Sql);
            DataRow row = re.Rows[0];
            txtName.Text = row["Nombre"].ToString();
            txtPre.Text = row["Precio"].ToString();
            ComboxIva.SelectedItem = row["Iva"].ToString();
            txtBoxDescri.Text = row["Descripcion"].ToString();
        }

        bool validar()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        //Codigo comprobacion  de textbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is RichTextBox)
                    {
                        //codigo comprobacion de richtextbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is ComboBox)
                    {
                        if (item.Text == "<Seleccionar>")
                        {
                            MessageBox.Show("Debes seleccionar un item");
                            item.Focus();
                            return false;
                        }
                    }
                }
                catch { }
            }
            return true;
        }
        public void getId()
        {
            DataTable tb = ConexionBD.Data("CALL getIdTablas(2)");
            int numero = int.Parse(tb.Rows[0][0].ToString().Trim());

            numero = numero + 1;
            lbId.Text = "" + numero;
            //return numero;
        }

        //private void CargarId()
        //{
        //    if (Nuevo)
        //    {
        //        String Sql = String.Format("Select max(Id) from Producto");
        //        DataTable re = ConexionBD.Data(Sql);
        //        DataRow row = re.Rows[0];
        //        if (Convert.ToString(row["max(Id)"]) == "")
        //        {
        //            lbId.Text = 1 + "";
        //        }
        //        else
        //        {
        //            int id = Convert.ToInt16(row["max(Id)"]) + 1;
        //            lbId.Text = id.ToString();
        //        }
        //    }
        //}

        public void CargarCombo()
        {
            ComboxIva.SelectedIndex = 0;
        }

        public void reset()
        {
            txtName.Text = "";
            txtPre.Text = "";
            ComboxIva.SelectedIndex = 0;
            txtBoxDescri.Text = "";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            validar();
            if (validar()==true)
            {
                String Sql = String.Format("Insert into Producto values ('{0}', '{1}','{2}', '{3}', '{4}')",
                    lbId.Text, txtName.Text, txtPre.Text, ComboxIva.SelectedItem, txtBoxDescri.Text);
                ConexionBD.SQL(Sql);
                getId();
                reset();
            }
        }

        private void Busquedad_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProView ps = new ProView();
            ps.ShowDialog();
            //this.Show();

        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            validar();
            if (validar() == true)
            {
                String Sql = String.Format("Update Producto set Nombre='{0}', Precio='{1}', Iva='{2}', " +
                "Descripcion='{3}' where Id = " + lbId.Text,
                txtName.Text, txtPre.Text, ComboxIva.SelectedItem, txtBoxDescri.Text);
                ConexionBD.SQL(Sql);
                Nuevo = true;
                getId();
                reset();
                btnIn.Enabled = true;
                btnActu.Enabled = false;
            }
        }
    }
}
