using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Blau1 : Form
    {
        Boolean HaTocadoelAvion = false;
        int pelotasdegolf = 0;
        Boolean Instrucciones = false;

        Boolean pelotagolf1 = false;
        Boolean Cables = false;
        string background = "Blau1_CablesTallats";

        public Blau1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HaTocadoelAvion == false)
            {
                MessageBox.Show("Que te he dicho de tocarme... a la proxima te vas a arrepentir");
                HaTocadoelAvion = true;
            }
            else
            {
                MessageBox.Show("Pues te quedas sin pelotas de golf!");
                pelotasdegolf = 0;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pelotagolf1 == false)
            {
                pelotasdegolf = pelotasdegolf + 1;
                pelotagolf1 = true;
            }
            else
                MessageBox.Show("Esta pelota ya la has guardado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para intentar solucionar el panel
            if (Cables == false)
            {
                panel1.Visible = true;
                Resolver.Visible = true;
                Cables = true;
            }

            else
            {
                panel1.Visible = false;
                Resolver.Visible = false;
            }
        }

        private void Llibre_Click(object sender, EventArgs e)
        {
            if (Instrucciones == false)
            {
                MessageBox.Show("Te recomendamos que tomes apuntes de todo lo que ves... a veces en la universidad las cosas se pierden");
                Blau1_Instruccions form = new Blau1_Instruccions();
                form.ShowDialog();
                
            }
            else
                MessageBox.Show("Ups creo que hemos perdido el libro... lo siento");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tienes que cortar un cable rojo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los platanos hacen explotar los cables"); //No se si s'enten
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Blau1_2 form = new Blau1_2();
            form.ShowDialog();
            
        }

        private void Resolver_Click(object sender, EventArgs e)
        {
            if (V1.Checked == true && B2.Checked == true && G1.Checked == true)
            {
                MessageBox.Show("Eres una maquina!");

                //Cambia el fondo de pantalla
                
                //Bitmap img = new Bitmap(background);
                //this.Blau1.BackgroundImage = img;
                //this.BackgroundImageLayout = ImageLayout.Stretch;

                //Le da la pista
                MessageBox.Show("El numero que debes guardar es el 4");
                Solucionado.Visible = true;
            }

            else
            {
                MessageBox.Show("Lo siento te has equivocado");
            }
        }

        private void Solucionado_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Blau1_Load(object sender, EventArgs e)
        {
            Resolver.Visible = false;
            panel1.Visible = false;
            Solucionado.Visible = false;
        }
        
    }
}
