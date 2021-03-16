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
    public partial class ventanaregistro : Form
    {
        string[] sexo = {"Masculino","Femenino"};
        //string[] paises_disponible;


        public ventanaregistro()
        {
            InitializeComponent();

          //  string listado_paises = Properties.Resources.paises.ToString();
           // paises_disponible = listado_paises.Split(new[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries);
        }


        private void Resgistro_Load(object sender, EventArgs e)
        {
            recorridosexo();
            //registrarme.Enabled = false;
  
        }
        void recorridosexo() {
            for (int i=0;i<sexo.Length;i++) {
                rsexo.Items.Add(sexo[i]);  
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void registrarme_Click(object sender, EventArgs e)
        {
            switch (validacion())
            {
                case 0:
                    {
                        errorProvider1.SetError(rnombre, "");
                        errorProvider1.SetError(rapellido, "");
                        errorProvider1.SetError(rcontraseña, "");
                        errorProvider1.SetError(rconfirmecontra, "");
                        errorProvider1.SetError(rcontraseña, "");
                        errorProvider1.SetError(rsexo, "");
                        String mensaje = "Se creo la cuenta,\n" + "Se te envió un correo para activar tu cuenta.\n" + "Es necesario activarla para entrar al sitio.";
                        MessageBoxButtons boton = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "CONFIRMACION", boton);



                        break;
                    }
                     case 1:
                    {
                        errorProvider1.SetError(panel1, "Selecione un sexo");
                        errorProvider1.SetError(panel1, "");
                        break;
                    }
                     case 2:
                    {
                        errorProvider1.SetError(panel1, "error en datos personales");
                        errorProvider1.SetError(panel1, "");
                        break;
                    }


            }

        }
        int validacion()
        {
            if (rsexo.SelectedIndex <= -1)
            {
                return 1;
            }
            else
            {
                if (rnombre.Text.Trim()!= String.Empty || rapellido.Text.Trim()!= String.Empty||rcontraseña.Text.Trim() != String.Empty||rcontraseña.Text.Trim() != String.Empty||rconfirmecontra.Text.Trim()!= String.Empty)
                { 
                return 0;
                }
                else
                {
                    return 2;
                }

              // else
              //  {
                   // return 0;
              ///  }

            }
        }

        private void AtrasR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }


    

