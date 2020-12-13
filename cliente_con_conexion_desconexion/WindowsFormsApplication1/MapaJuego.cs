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
    public partial class MapaJuego : Form
    {
        public MapaJuego()
        {
            InitializeComponent();
        }

        private void buttonG1_Click(object sender, EventArgs e)
        {
            G1 form = new G1();
            form.ShowDialog();
            

        }

        private void Vermella_Click(object sender, EventArgs e)
        {
            Vermella form = new Vermella();
            form.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _237General form = new _237General();
            form.ShowDialog();
            
        }

        private void TextBox237_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AulaDrones form = new AulaDrones();
            form.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _28G form = new _28G();
            form.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Blau1 form = new Blau1();
            form.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalaActos form = new SalaActos();
            form.ShowDialog();
            
        }
    }
}
