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
    public partial class _237General : Form
    {
        public _237General()
        {
            InitializeComponent();
        }

        private void MesaMezclas_Click(object sender, EventArgs e)
        {
            Aula237 form = new Aula237();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
