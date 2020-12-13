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
    public partial class G1 : Form
    {
        bool ApagadoLuces = false;
        public G1()
        {
            InitializeComponent();

        }
        string background1 = "Groga1llum.png";
        string background2 = "Groga1Nollum.png";
        private void buttonLlum_Click(object sender, EventArgs e)
        {
            if (ApagadoLuces == false)
            {
                Bitmap img = new Bitmap(background2);
                this.BackgroundImage = img;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                ApagadoLuces = true;
            }
            else
            {
                Bitmap img = new Bitmap(background1);
                this.BackgroundImage = img;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                ApagadoLuces = false;
            }

        }

        private void buttonG1_Click(object sender, EventArgs e)
        {
            if (textBoxG1.Text =="7")
                MessageBox.Show("Respuesta correcta, enigma resuelto. Anota el valor 7");
            else
                MessageBox.Show("Respuesta incorrecta, sigue pensando");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
