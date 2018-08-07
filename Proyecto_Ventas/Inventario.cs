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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            getId();
            CargarPro();
            CargarSucur();
            btnActu.Enabled = false;
            LbFecha.Text = DateTime.Now.ToLongDateString();
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
                    else if (item is ComboBox)
                    {
                        if (item.Text == "")
                        {
                            MessageBox.Show("Debes seleccionar un item");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is NumericUpDown)
                    {
                        if (item.Text == "" || item.Text == "0")
                        {
                            MessageBox.Show("La cantidad no puede ser igual a 0");
                            item.Focus();
                            return false;
                        }
                    }
                }
                catch { }
            }
            return true;
        }

        public void CargarPro()
        {
            String Sql = String.Format("Select * from Producto");
            DataTable com = ConexionBD.Data(Sql);
            BoxPro.ValueMember = "Id";
            BoxPro.DisplayMember = "Nombre";
            BoxPro.DataSource = com;
        }

        public void CargarSucur()
        {
            String Sql = String.Format("Select Id, Ubicacion from Sucursal");
            DataTable com = ConexionBD.Data(Sql);
            boxSucur.ValueMember = "Id";
            boxSucur.DisplayMember = "Ubicacion";
            boxSucur.DataSource = com;
        }
        public void getId()
        {
            DataTable tb = ConexionBD.Data("CALL getIdTablas(1)");
            int numero = int.Parse(tb.Rows[0][0].ToString().Trim());

            numero = numero + 1;
            txtId.Text = "" + numero;
            //return numero;
        }

        //private void CargarId()
        //{
        //    String Sql = String.Format("Select max(Id) from Inventario");
        //    DataTable re = ConexionBD.Data(Sql);
        //    DataRow row = re.Rows[0];
        //    if(Convert.ToString(row["max(Id)"]) == "")
        //    {
        //        txtId.Text = 1 + "";
        //    }
        //    else
        //    { 
        //        int id = Convert.ToInt16(row["max(Id)"]) + 1;
        //        txtId.Text = id.ToString();
        //    }
        //}

        public void Reset()
        {
            spnCan.Value = 0;
            txtMovi.Text = "";
            BoxPro.SelectedIndex = 0;
            boxSucur.SelectedIndex = 0;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            btnActu.Enabled = true;
            btnIn.Enabled = false;
            String Sql = String.Format("Select Id,Producto_id,Sucursal_id,Movimiento,Cantidad_Pro from Inventario where Id ='" + txtId.Text + "'");
            DataTable re = ConexionBD.Data(Sql);
            DataRow row = re.Rows[0];

            if (row["Id"].ToString() != txtId.Text)
            {
                MessageBox.Show("El codigo del Id ingresado no existe o es erroneo");
            }
            else
            {
                this.BoxPro.SelectedValue = row["Producto_id"].ToString();
                this.boxSucur.SelectedValue = row["Sucursal_id"].ToString();
                this.txtMovi.Text = row["Movimiento"].ToString();
                this.spnCan.Value = Convert.ToInt16(row["Cantidad_Pro"]);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            validar();
            if (validar() == true)
            {
                String Sql = String.Format("Insert into Inventario values ('{0}', '{1}','{2}', '{3}', '{4}', CURRENT_TIMESTAMP())",
                    txtId.Text, BoxPro.SelectedValue, boxSucur.SelectedValue, txtMovi.Text, spnCan.Value);
                ConexionBD.SQL(Sql);
                getId();
                Reset();
            }
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            validar();
            if (validar() == true)
            {
                String Sql = String.Format("Update Inventario set Producto_id='{0}', Sucursal_id='{1}', Movimiento='{2}', Cantidad_Pro='{3}' where Id = " + txtId.Text,
                BoxPro.SelectedValue, boxSucur.SelectedValue, txtMovi.Text, spnCan.Value);
                ConexionBD.SQL(Sql);
                getId();
                Reset();
                btnActu.Enabled = false;
                btnIn.Enabled = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            //InvenView ps = new InvenView();
            //ps.ShowDialog();
            this.Show();
        }
    }
}
