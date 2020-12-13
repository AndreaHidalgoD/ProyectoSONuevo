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
    public partial class Blau1_2 : Form
    {
        Boolean pelotagolf2 = false;
        Boolean pelotagolf = false;
        public Blau1_2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recoger las pelotas de golf no sirve de nada jaja...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El ultimo cable a cortar es el segundo mas caliente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pelotagolf == false)
            {
                MessageBox.Show("Ha recogido la pelota de golf!");
                pelotagolf = true;
            }
            else
                MessageBox.Show("Esta pelota ya la has recogido");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pelotagolf2 == false)
            {
                MessageBox.Show("Ha recogido la pelota de golf!");
                pelotagolf2 = true;
            }
            else
                MessageBox.Show("Esta pelota ya la has recogido");
        }

        private void Blau1_2_Load(object sender, EventArgs e)
        {

        }
    }
}
