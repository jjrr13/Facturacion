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
    public partial class Recuperar : Form
    {
        public int id;
        public Recuperar(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btAcpta_Click(object sender, EventArgs e)
        {
            if (txnueva.Text== txconfirma.Text)
            {
                ConexionBD.SQL("UPDATE persona SET pass ='"+txnueva.Text+"' WHERE Id = "+this.id);
                MessageBox.Show("Su contraseña ha sido Restaurada...", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Dispose();
                
            }
            else
            {
                MessageBox.Show("La contraseña NO Concuerda, Intente de Nuevo...", "Error 1356", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
