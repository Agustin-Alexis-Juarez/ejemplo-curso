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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            lwNombres.Items.Add(nombre);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Azul");
        }

        private void btnVerperfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //Nombre de este tipo de if: operador ternario       true                     false
            string chocolate = ckbChocolate.Checked == true? "Te gusta el chocolate" : "No te gusta el chocolate";
            string tipo = "Eres un ";

            if (rdbWizard.Checked)
                tipo += "Wizard";
            else if (rdbMuggle.Checked)
                tipo += "Muggle";
            else
                tipo += "Squibs";

            string colorFav = cboColorFavorito.SelectedItem.ToString();

            MessageBox.Show("nombre: " + nombre + " Fecha: " + fecha + ", " + chocolate + ", " + tipo + ", Color favorito: " + colorFav);
        }
    }
}
