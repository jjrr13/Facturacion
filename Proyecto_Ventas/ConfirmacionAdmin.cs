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
    public partial class ConfirmacionAdmin : Form
    {
        DataTable tb12 = new DataTable();
        String tipo;

        public ConfirmacionAdmin(String tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            if (tipo=="Administrador")
            {
                tb12 = ConexionBD.Data("SELECT * FROM persona WHERE name='" + txUsuario.Text + "' and pass='" + txPass.Text + "' and Roll_Id =" + 5);

                //Console.WriteLine(txUsuario + " usuario" + txPass + " passwords\n " + tb12.Rows[0][0]);
                if (tb12.Rows.Count > 0)
                {
                    this.Dispose();
                    Persona.bandera = false;
                    MessageBox.Show("La Persona ha Sido Eliminada Satisfactoriamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Las Credenciales Son Incorrectas\n Intente de Nuevo", "Error 1355", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }else if (tipo == "Supervisor")
            {
                label1.Text = "Necesita las Credenciales de un Supervisor";
                tb12 = ConexionBD.Data("SELECT * FROM persona WHERE name='" + txUsuario.Text + "' and pass='" + txPass.Text + "' and Roll_Id ="+ 5);

                //Console.WriteLine(txUsuario + " usuario" + txPass + " passwords\n " + tb12.Rows[0][0]);
                if (tb12.Rows.Count > 0)
                {
                    this.Dispose();
                    Facturas.banderaConfirma = false;
                    MessageBox.Show("El producto ha sido Eliminado de la Tabla Satisfactoriamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Las Credenciales Son Incorrectas\n Intente de Nuevo", "Error 1355", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error de Parametro", "Error 1308", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



        }
    }
}
