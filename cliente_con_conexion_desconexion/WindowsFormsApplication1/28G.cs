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
    public partial class _28G : Form
    {
        public _28G()
        {
            InitializeComponent();
        }

        private void buttonTelefono_Click(object sender, EventArgs e)
        {
            if (textBoxTelefono.Text == "12:421")
                MessageBox.Show("Código obtenido para el siguient elemento: 5 y nombre elemento extraño en la clase");
            else
                MessageBox.Show("Marcación incorrecta, prúebalo de nuevo con otra combinación");

        }

        private void textBoxImpresora_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonImpresora_Click(object sender, EventArgs e)
        {
            if (textBoxImpresora.Text == "5 rata")
                MessageBox.Show("Puedes archivar el fax obtenido con el código 723");
            else
                MessageBox.Show("No tienes los elementos necesarios para obtener el fax");
        }

        private void buttonCarpeta_Click(object sender, EventArgs e)
        {
            if (textBoxCarpeta.Text == "723")
                MessageBox.Show("Código correcto, mensaje archivado y enigma resuelto. Anota el número 6");
            else
                MessageBox.Show("Código incorrecto, revisa que hayas seguido bien los pasos del proceso y vuélvelo a intentar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
