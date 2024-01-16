using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Blanco");
        }

        private void cboColorFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
           
            DateTime fecha = dtpFechaNacimiento.Value;
            
            //OPERADOR TERNARIO ( COMO UN IF) '?'
            string chocolate = ckbChocolate.Checked == true ? "le gusta": "no le gusta";

            string tipo;
            if (rbtWizard.Checked)
                tipo = "Wizard";
            else if (rbtMuggle.Checked)
                tipo = "Muggle";
            else
                tipo = "Squbs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            string numeroFavorito = numNumFavorito.Value.ToString();

            string message = chocolate + ", es " + tipo + ", su color favorito es: " + colorFavorito + ", su numero favortio es el " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " fecha: " + fecha + ", " + message);
        }
    }
}
