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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            sucursales.Items.Add("<--Seleccione-->");
            DataTable dt= ConexionBD.Data("SELECT * FROM sucursal");
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sucursales.Items.Add(dt.Rows[i]["Id"].ToString()+"-"+ dt.Rows[i]["Ubicacion"].ToString());
            }
            sucursales.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String valor = (String)sucursales.Text;
            String[] id = valor.Split('-');
            ConexionBD.SQL("INSERT INTO roles VALUES('','" + nombre.Text + "'," + id[0] + ")");
            MessageBox.Show("El Roll fue Creado Satisfactoriamente!");
            nombre.Text = "";
            sucursales.SelectedIndex = 0;
        }
    }
}
