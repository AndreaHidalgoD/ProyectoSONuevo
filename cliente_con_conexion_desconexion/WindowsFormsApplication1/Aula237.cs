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
    public partial class Aula237 : Form
    {
        public Aula237()
        {
            InitializeComponent();
            if (Posvc == true)
            {
                button3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                button3.Visible = false;
                button4.Visible = false;
        }
        }

        private void PanelWaves_Paint(object sender, PaintEventArgs e)
        {

        }
        //Variamos la vertical
        bool PosI = true; //Inicio--> estas en 2
        bool Posv1 = false; //Bajar 1 del inicio-->estas en vertical= 1
        bool Posvc = false; // Bajar 2 del inicio, estas en 0--> vertical correcta
        bool Posv_1 = false; //Estas en vertical=-1
        bool Posv_2 = false; //Estas en vertical=-2

        //Variamos horizontal
        bool Posvc_hc = false; //Estas en 0 1D, correcta-->Fin del enigma
        bool Posvc_2D = false; //Estas en pi/2
        bool Posvc_3D = false; //Estas en pi
        bool Posvc_1I = false; //Estas en -pi

        //Fotos mov. vertical
        string ImagePosI = "PosInicial.png";
        string ImagePosv1 = "PosBajar1.png";
        string ImagePosvc = "PosBajar2Correcta.png"; //-pi/2
        string ImagePosv_1 = "PosCorrecta-1.png";
        string ImagePosv_2 = "PosCorrecta-2.png";
        //Fotos mov horizontal
        string ImagePosvc_hc="Posvc_solfinal.png"; //0, 1D
        string ImagePosvc_2D="Posvcpimedios.png"; //pi/2, 2D
        string ImagePosvc_3D="Posvcpi.png"; //pi, 3D
        string ImagePosvc_1I="Posvc_pi.png";//-pi, 1Izq
        private void button1_Click(object sender, EventArgs e)
        {
            //Partimos de la inicial
            if (PosI == false)
            {
                if (Posv1 == true)
                {
                    Bitmap img = new Bitmap(ImagePosI);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    PosI = true;
                    Posv1 = false;

                }
                else if (Posvc == true)
                {
                    Bitmap img = new Bitmap(ImagePosv1);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posv1 = true;
                    Posvc = false;
                }
                else if (Posv_1 == true)
                {
                    Bitmap img = new Bitmap(ImagePosvc);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button2.Visible = false;
                    button1.Visible = false;
                    Posv_1 = false;
                }
                else if (Posv_2 == true)
                {
                    Bitmap img = new Bitmap(ImagePosv_1);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posv_1 = true;
                    Posv_2 = false;
                }
            }
            else
            {
                PosI = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Posv_2==false)
                if(PosI==true)
                {
                    Bitmap img = new Bitmap(ImagePosv1);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posv1 = true;
                    PosI = false;

                }
                else if (Posv1==true)
                {
                    Bitmap img = new Bitmap(ImagePosvc);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button2.Visible = false;
                    button1.Visible = false;
                    Posv1 = false;
                }
                else if (Posvc==true)
                {
                    Bitmap img = new Bitmap(ImagePosv_1);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posv_1 = true;
                    Posvc = false;
                }
                else if (Posv_1==true)
                {
                    Bitmap img = new Bitmap(ImagePosv_2);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posv_2 = true;
                    Posv_1 = false;
                }

        }
        //Variamos horizontal
       
        private void button3_Click(object sender, EventArgs e)//Izq, solo si no esta en -pi
        {
            if (Posvc_1I == false)
            {
                if (Posvc == true) //-pi/2
                {
                    Bitmap img = new Bitmap(ImagePosvc_1I);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc_1I = true;
                    Posvc= false;
                }
                else if (Posvc_hc == true) //estas en 0
                {
                    Bitmap img = new Bitmap(ImagePosvc);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc = true;
                    Posvc_hc= false;
                    
                }
                else if (Posvc_2D == true) //estas en pi/2
                {
                    Bitmap img = new Bitmap(ImagePosvc_hc);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc_hc = true;
                    Posvc_2D = false;
                }
                else if (Posvc_3D == true) //estas en pi
                {
                    Bitmap img = new Bitmap(ImagePosvc_2D);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc_2D = true;
                    Posvc_3D = false;
                }
               
            }


        }

        private void button4_Click(object sender, EventArgs e) //boton para la derecha, si estas en +pi no
        {
            if (Posvc_3D==false)
                if (Posvc_2D == true) //pi/2
                {
                    Bitmap img = new Bitmap(ImagePosvc_3D);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc_3D = true;    
                    Posvc_2D = false;
                }
                else if (Posvc_hc == true) //0
                {
                    Bitmap img = new Bitmap(ImagePosvc_2D);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc_2D = true;
                    Posvc_hc = false;
                }
                else if (Posvc == true) //-pi/2
                {
                    Bitmap img = new Bitmap(ImagePosvc_hc);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc_hc = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    MessageBox.Show("Engima resuelto, anota el valor 1");
                    Posvc = false;
                }
                else if (Posvc_1I == true) //-pi
                {
                    Bitmap img = new Bitmap(ImagePosvc);
                    this.PanelWaves.BackgroundImage = img;
                    this.PanelWaves.BackgroundImageLayout = ImageLayout.Stretch;
                    Posvc = true;
                    Posvc_1I = false;
                }


        }

        private void Aula237_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        }

