using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaMn_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms) //revisa si ya hay un formulario del mismo tipo abierto
            {
                if(item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya se encuentra abierto.");
                    return;
                }
            }


            Form1 perfilPersona = new Form1();

            perfilPersona.MdiParent = this;
            perfilPersona.Show();
        }
    }
}
