using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTycoon
{
    public partial class Salvataggi : Form
    {
        private bool vaiDestra;
        private bool vaiSinistra;
        private bool vaiSu;
        private bool vaiGiu;
        private int velocitaPlayer;

        private String verso;

        private int animazione = 0;

        GiocoPrincipale g;
        Residenziali[] edificiResidenziali;
        PictureBox[] arrayPicturebox;
        String[] edificioCostruito;
        ArrayList edifici;
        public Salvataggi(GiocoPrincipale g, Residenziali[] edificiResidenziali, PictureBox[] arrayPicturebox, String [] edificioCostruito, ArrayList edifici)
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_back");
            this.g = g;
            this. edificiResidenziali = edificiResidenziali;
            this.arrayPicturebox = arrayPicturebox;
            this.edificioCostruito = edificioCostruito;
            this.edifici = edifici;
        }

        private void Salvataggi_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            for (int i=0; i < edifici.Count; i++)
            {
                if (arrayPicturebox.ElementAt(i).Name != "-")
                {
                    Point puntoEdificio = arrayPicturebox[i].Location;
                    PictureBox edificio = new PictureBox();

                    MessageBox.Show(edificioCostruito[i]);
                    edificio.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(edificioCostruito[i] + "_topdown");
                    edificio.Size = new Size(100, 100);
                    edificio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    edificio.BackColor = Color.Transparent;
                    edificio.Location = puntoEdificio;
                    edificio.Tag = "edificio";
                    this.Controls.Add(edificio);
                }
            }
          

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Salvataggi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                vaiSinistra = true;
            }
            if (e.KeyCode == Keys.D)
            {
                vaiDestra = true;
            }
            if (e.KeyCode == Keys.W)
            {
                vaiSu = true;
            }
            if (e.KeyCode == Keys.S)
            {
                vaiGiu = true;
            }

        }

        private void Salvataggi_KeyUp(object sender, KeyEventArgs e)
        {
            if(vaiDestra == true)
            {
                vaiDestra = false;
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_right");
                verso = "destra";
            }
            if (vaiSinistra == true)
            {
                vaiSinistra = false;
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_left");
            }
            if (vaiSu == true)
            {
                vaiSu = false;
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_back");
            }
            if (vaiGiu == true)
            {
                vaiGiu = false;
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_front");
            }
        }

        private void movimento()
        {

 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vaiDestra == true)
            {

                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_right");
                verso = "destra";

                timer2.Start();
                switch (animazione)
                {
                    case 0:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_right_1");
                        pictureBox1.Left += 2;
                        timerWait.Start();
                        verso = "destra";
                        break;

                    case 1:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_right_2");
                        pictureBox1.Left += 2;
                        timerWait.Start();
                        verso = "destra";
                        break;

                    case 2:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_right_3");
                        pictureBox1.Left += 2;
                        timerWait.Start();
                        timer2.Stop();
                        verso = "destra";
                        break;
                }
            }
            if (vaiSinistra == true)
            {
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_left");

                switch (animazione)
                {
                    case 0:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_left_1");
                        pictureBox1.Left += -2;
                        timerWait.Start();
                        break;

                    case 1:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_left_2");
                        pictureBox1.Left += -2;
                        timerWait.Start();
                        break;

                    case 2:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_left_3");
                        pictureBox1.Left += -2;
                        timerWait.Start();
                        timer2.Stop();
                        break;
                }
            }
            if (vaiSu == true)
            {
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_back");
                switch (animazione)
                {
                    case 0:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_back_1");
                        pictureBox1.Top += -2;
                        timerWait.Start();
                        break;

                    case 1:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_back_nuovo");
                        pictureBox1.Top += -2;
                        timerWait.Start();
                        break;

                    case 2:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_back_3");
                        pictureBox1.Top += -2;
                        timerWait.Start();
                        timer2.Stop();
                        break;
                }
            }
            if (vaiGiu == true)
            {
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_front");
                switch (animazione)
                {
                    case 0:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_front_1");
                        pictureBox1.Top += 2;
                        timerWait.Start();
                        //animazione++;

                        break;

                    case 1:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_front_nuovo");
                        pictureBox1.Top += 2;
                        timerWait.Start();
                        //animazione++;
                        break;

                    case 2:
                        pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("player_idle_front");
                        pictureBox1.Top += 2;
                        timerWait.Start();
                        //animazione = 0;
                        timer2.Stop();
                        break;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)  //Il foreach esegue un'istruzione o un blocco di istruzioni per ogni elemento in un'istanza del tipo che implementa
            {
                if (x is PictureBox && (string)x.Tag == "edificio")
                {
                    if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                    {
                        vaiSu = false;
                    }
                }

            
                  /*  if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                    {
                    label1.Text = "Parla";
                    vaiSu = false;
                }*/

            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds)){
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
          
        }

        private void timerWait_Tick(object sender, EventArgs e)
        {
            if (animazione == 2)
            {
                animazione = 0;
            }
            else
            {
                animazione++;
            }
            timerWait.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            g.Show();
        }
    }
}
