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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // *** aca se vera lo que esta punteado abajo
            // lo de abajo es una coleccion de Openforms y la recorrere con 
            // for each 
            foreach (var items in Application.OpenForms)
            {
                if (items.GetType() == typeof(Form1))// typeof es palabra reservada
                {                                  // == en este contexto no va directo el nombre del formulario
                    MessageBox.Show("ya existe una ventana abierta de form persona");
                    
                    return; // uso el return para terminar ejecucion
                            // porque esta dentro de un metodo estatico
                }
            }

            // voy a navegar  otra persona
            //CREO EL OBJETO VENTANA DEL tipo Form1 ( adonde quiero ir)
            Form1 ventana = new Form1();

            /*ventana.Show();*/
            // nota cada vez que hago click se abrira una form1
            //esto se ouede resolver de distintas maneras:
            /*ventana.ShowDialog();*///abre la ventana el contexto de momento
                                 //nota: puedo manejar con objetos como abrir las ventanas

            // para que la ventana de form persona quede contenida en frmPrincipal
            ventana.MdiParent = this;
            ventana.Show();// al sacar el 'show dialog tenddremos el porblema
                           //   que se abriran muchas de las mismas planillas
            //entonces haremos en este caso una evaluacion de si hay una ventana
            //.. abierta que no se abran mas
            //*****NOTA: NO SIEMPRE ES NECESARIO EVITAR QUE SE ABRAN MAS DE UNA VENTANA 
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            //aca tendria que hacer la logica  para el boto directo como arriba para el menu

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
