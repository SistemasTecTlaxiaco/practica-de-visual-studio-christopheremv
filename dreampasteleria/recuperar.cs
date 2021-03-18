using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dreampasteleria
{
    public partial class recuperarContraseña : Form
    {
        public recuperarContraseña()
        {
            InitializeComponent();
        }



        private void recuperar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mensaje = "Se te envio un correo con tu contraseña";
            MessageBoxButtons boton = MessageBoxButtons.OK;
            MessageBox.Show(mensaje, "CONFIRMACION", boton);

        }
    }
}
