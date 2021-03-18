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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }








        public void controlBotonesusuario()
        {
            if (texusuario.Text.Trim()!= String.Empty&&textContraseña.Text.Trim() != String.Empty)
            {
                Ingresar.Enabled = true;
            }
            else {

                Ingresar.Enabled = false;
            }

        }
        public void controlBotonesContraseña()
        {
            Ingresar.Enabled = false;
            if (textContraseña.Text.Trim() != String.Empty&& texusuario.Text.Trim() != String.Empty)
            {
                Ingresar.Enabled = true;
            }
            else
            {
                Ingresar.Enabled = false;
            }

        }



        private void Ingresar_Click(object sender, EventArgs e)
        {
            using (menu ventamenu = new menu())
                ventamenu.ShowDialog();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            using ( ventanaregistro registro = new ventanaregistro())
                      registro.ShowDialog();
        }

        private void recuperar_Click(object sender, EventArgs e)
        {
            using (recuperarContraseña recuperarloperdido = new recuperarContraseña()) 
                    recuperarloperdido.ShowDialog();            
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            Ingresar.Enabled = false;
            //  recuperar.Enabled = false;
            // Registro.Enabled = false;
        }

        private void texusuario_TextChanged_1(object sender, EventArgs e)
        {
            controlBotonesusuario();
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            controlBotonesContraseña();
        }
    }
}
