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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Especialidades_Click(object sender, EventArgs e)
        {
            using (especialides ventaespecialidades = new especialides())
                ventaespecialidades.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ventamenu_Load(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
