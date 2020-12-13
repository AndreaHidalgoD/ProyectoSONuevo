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
    public partial class SalaActos : Form
    {
        //Si algun listillo no fa el que li diu el message box hi haura errors, i a més a més si volen corregir tampoc hi ha la opció
        //I jo crec que estaria prou be
        int intentos = 0;
        int contador = 0; //Lo que va a hacer es contar el orden en el que le da a los botones

        int vermell = 0;
        int taronja = 0;
        int groc = 0;
        int verd = 0;
        int blau = 0;
        int lila = 0;
        int rosa = 0;

        public SalaActos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (intentos < 3)
            {
                if (groc == 7 && vermell == 3 && blau == 2 && lila == 4 && taronja == 1 && verd == 6 && rosa == 5)
                {
                    MessageBox.Show("Eres un craack lo has solucionado!");
                }
                else
                {
                    MessageBox.Show("Te has equivocado vuelve a empezar");
                    intentos = intentos + 1;
                    textBox1.Text = Convert.ToString(intentos);
                    contador = 0;
                }
            }
            else
            {
                MessageBox.Show("BOOOOOM");
                this.Close();
            }

        }

        private void Vermell_Click(object sender, EventArgs e)
        {
            vermell = contador;
            if (contador == 7)
            {
                MessageBox.Show("Dale al boton para ver si lo has hecho bien");
            }
            else
            {
                contador = contador + 1;
            }
        }

        private void Taronja_Click(object sender, EventArgs e)
        {
            taronja = contador;
            if (contador == 7)
            {
                MessageBox.Show("Dale al boton para ver si lo has hecho bien");
            }
            else
            {
                contador = contador + 1;
            }
        }

        private void Groc_Click(object sender, EventArgs e)
        {
            groc = contador;
            if (contador == 7)
            {
                MessageBox.Show("Dale al boton para ver si lo has hecho bien");
            }
            else
            {
                contador = contador + 1;
            }
        }

        private void Verd_Click(object sender, EventArgs e)
        {
            verd = contador;
            if (contador == 7)
            {
                MessageBox.Show("Dale al boton para ver si lo has hecho bien");
            }
            else
            {
                contador = contador + 1;
            }
        }

        private void Blau_Click(object sender, EventArgs e)
        {
            blau = contador;
            if (contador == 7)
            {
                MessageBox.Show("Dale al boton para ver si lo has hecho bien");
            }
            else
            {
                contador = contador + 1;
            }
        }

        private void Lila_Click(object sender, EventArgs e)
        {
            lila = contador;
            if (contador == 7)
            {
                MessageBox.Show("Dale al boton para ver si lo has hecho bien");
            }
            else
            {
                contador = contador + 1;
            }
        }

        private void Rosa_Click(object sender, EventArgs e)
        {
            rosa = contador;
            if (contador == 7)
            {
                MessageBox.Show("Dale al boton para ver si lo has hecho bien");
            }
            else
            {
                contador = contador + 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapaJuego form = new MapaJuego();
            form.ShowDialog();
            this.Close();
        }
    }
}
