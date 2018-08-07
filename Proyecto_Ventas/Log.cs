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
    public partial class Log : Form
    {
        public static int numero;
        public static String nombre;
        public static String rol;
        public static String sucursal;
        public static String sucurId;
        public Log()
        {
            InitializeComponent();
            btRestablecer.Visible = false;

            txtUser.Text = "JonRoj538";
            txtPass.Text = "9013";
            DateTime thisDay = new DateTime();

            lbDate.Text = thisDay.ToString("dd-MM-yyyy H:mm:ss");

            //if (checkRestablece.ThreeState)
            //{
            //    btRestablecer.Visible = true;
            //    this.Hide();

            //    new ValidaRestaura().Show();
            //}
        }

        private void Loger()
        {
            if (txtPass.Text.Length > 0 && txtUser.Text.Length > 0)
            {
                String sql = String.Format("Select pass, name from persona where pass= '"+ txtPass.Text+"' and name ='"+ txtUser.Text+"'");
                DataTable Tab = ConexionBD.Data(sql);

                if(Tab.Rows.Count > 0)
                {
                    DataTable datos=ConexionBD.Data("SELECT per.nombre, per.apellido, rol.Roll, suc.ubicacion, suc.Id " +
                        "FROM persona AS per " +
                        "INNER JOIN sucursal AS suc ON per.Sucursal_Id = suc.Id " +
                        "INNER JOIN roles AS rol ON per.Roll_Id = rol.Id " +
                        "WHERE per.pass='"+txtPass.Text+"'");

                    //--------------se asignan valores a las variables globales----------------------//
                    numero = int.Parse(txtPass.Text);
                    nombre = datos.Rows[0][0].ToString()+" "+ datos.Rows[0][1];
                    rol = datos.Rows[0][2].ToString();
                    sucursal = datos.Rows[0][3].ToString();
                    sucurId = datos.Rows[0][4].ToString();

                    //Console.WriteLine(numero + " " + nombre + " " + rol + " " + sucursal);

                    Hide();
                    txtUser.Text = "";
                    txtPass.Text = "";
                    //new Form1(Tab.Rows[0]).ShowDialog();
                    MessageBox.Show("Bienvenido señor@!!! " + nombre, "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Inicio().Show();
                }
                else
                    MessageBox.Show("Credenciales invalidas y/o usuario no exisente.", "Verifica tus detalles",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Formulario incompleto", "Verifica tus detalles",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Loger();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Loger();
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btRestablecer_Click(object sender, EventArgs e)
        {
            this.Hide();

            new ValidaRestaura().ShowDialog();
            this.Show();
            checkRestablece.Checked = false;
            btRestablecer.Visible = false;
        }

        private void checkRestablece_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRestablece.Checked)
            {
                btRestablecer.Visible = true;
            }
            else
            {
                btRestablecer.Visible = false;
            }
        }
    }
}