using System;
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
    public partial class gestioneFabbrica : Form
    {
        Font labelFont = new Font("Poppins", 10);
        Color viola = Color.FromArgb(77, 33, 110);
        Font labelFont2 = new Font("Avenir", 15);
        Giocatore g;
        Fabbrica[] fabbriche;
        String posizione;
        String materiale1, materiale2;
        int quantita1, quantita2;
        String nomeOggetto;

        List<Oggetto> oggetti = new List<Oggetto>();
        public gestioneFabbrica(Giocatore g, Fabbrica[] fabbriche, String posizione, List<Oggetto> oggetti)
        {
            InitializeComponent();
            this.oggetti = oggetti;
            this.g = g;
            this.fabbriche = fabbriche;
            this.posizione = posizione;
            label14.Text = fabbriche[Convert.ToInt32(posizione)].getIDfabbrica();
            if(fabbriche[Convert.ToInt32(posizione)].getTipo() == 1)
            {
                label13.Text = "Fabbrica giochi";
                label13.Font = labelFont2;
                label13.ForeColor = viola;
                pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("cavallo");
                pictureBox4.Tag = "cavallo";
                label12.Text = "Cavallo";
                //oggetti.ElementAt(0).setPrezzo(1000);
                pictureBox5.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("robot");
                pictureBox5.Tag = "robot";
                label11.Text = "Robot";
                //oggetti.ElementAt(2).setPrezzo(1500);
                pictureBox3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("peluche");
                pictureBox3.Tag = "peluche";
                label10.Text = "Peluche";

               //oggetti.ElementAt(3).setPrezzo(700);
                pictureBox2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("razzo");
                pictureBox2.Tag = "razzo";
                label9.Text = "Razzo";
                //oggetti.ElementAt(1).setPrezzo(2000);
            }
            if (fabbriche[Convert.ToInt32(posizione)].getTipo() == 2)
            {
                label13.Text = "Fabbrica tecnologia";
                label13.Font = labelFont2;
                label13.ForeColor = viola;
                pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("cpu");
                pictureBox4.Tag = "cpu";
                label12.Text = "cpu";
                //oggetti.ElementAt(0).setPrezzo(3000);
                pictureBox5.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("monitor");
                pictureBox5.Tag = "monitor";
                label11.Text = "Monitor";
                //oggetti.ElementAt(2).setPrezzo(2000);
                pictureBox3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("telefono");
                pictureBox3.Tag = "telefono";
                label10.Text = "Telefono";
                //oggetti.ElementAt(3).setPrezzo(1500);

                pictureBox2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("cuffie");
                pictureBox2.Tag = "cuffie";
                label9.Text = "Cuffie";
                //oggetti.ElementAt(1).setPrezzo(2000);
            }
            if (fabbriche[Convert.ToInt32(posizione)].getTipo() == 3)
            {
                label13.Text = "Fabbrica bricolage";
                label13.Font = labelFont2;
                label13.ForeColor = viola;
                pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("scala");
                pictureBox4.Tag = "scala";
                label12.Text = "scala";
                //oggetti.ElementAt(0).setPrezzo(3000);
                pictureBox5.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("cariola");
                pictureBox5.Tag = "cariola";
                label11.Text = "cariola";
                //oggetti.ElementAt(2).setPrezzo(2000);
                pictureBox3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("presa");
                pictureBox3.Tag = "presa";
                label10.Text = "presa";
                //oggetti.ElementAt(3).setPrezzo(1500);

                pictureBox2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("tubo");
                pictureBox2.Tag = "tubo";
                label9.Text = "tubo";
                //oggetti.ElementAt(1).setPrezzo(2000);
            }
            label1.Font = labelFont;
            label1.ForeColor = viola;
            label2.Font = labelFont;
            label2.ForeColor = viola;
            label3.Font = labelFont;
            label3.ForeColor = viola;
            label4.Font = labelFont;
            label4.ForeColor = viola;
            label5.Font = labelFont;
            label5.ForeColor = viola;
            label6.Font = labelFont;
            label6.ForeColor = viola;
            label7.Font = labelFont;
            label7.ForeColor = viola;
            label8.Font = labelFont;
            label8.ForeColor = viola;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listenerMateriali_Tick(object sender, EventArgs e)
        {

        }

        private void listenerMateriali_Tick_1(object sender, EventArgs e)
        {
            label1.Text = g.getOro().ToString();
            label2.Text = g.getArgento().ToString();
            label3.Text = g.getRame().ToString();
            label4.Text = g.getDiamanti().ToString();
            label5.Text = g.getLegno().ToString();
            label6.Text = g.getFerro().ToString();
            label7.Text = g.getPlastica().ToString();
            label8.Text = g.getAlluminio().ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (pictureBox4.Tag == "cavallo")
            {
                materiale1 = "legno";
                materiale2 = "ferro";
                quantita1 = 4;
                quantita2 = 2;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox4.Tag.ToString());
            }
            if (pictureBox4.Tag == "cpu")
            {
                materiale1 = "plastica";
                materiale2 = "ferro";
                quantita1 = 4;
                quantita2 = 2;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox4.Tag.ToString());
            }
            if (pictureBox4.Tag == "scala")
            {
                materiale1 = "ferro";
                materiale2 = "legno";
                quantita1 = 4;
                quantita2 = 2;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox4.Tag.ToString());
            }



        }

        private void produci(String materiale1, int quantita1, String materiale2, int quantita2, String nomeOggetto)
        {
            pictureBox6.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(materiale1);
            pictureBox7.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(materiale2);
            label15.Text = quantita1.ToString();
            label16.Text = quantita2.ToString();
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            int requisitiMateriali = 0;
            Double m1=0;
            this.nomeOggetto = nomeOggetto;
            requisitiMateriali=0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("LEgno:" + g.getLegno().ToString()+ "oro:" + g.getOro().ToString() + "argento:" + g.getArgento().ToString() + "rame:" + g.getRame().ToString() + "diamanti:" + g.getDiamanti().ToString() + "ferro:" + g.getFerro().ToString() + "plastica:" + g.getPlastica().ToString() + "alluminio:" + g.getAlluminio());
                
                if (i == 0)
                {
                    switch (materiale1)
                    {
                        case "legno":

                            m1 = g.getLegno();
                            break;
                        case "oro":
                            m1 = g.getOro();
                            break;
                        case "argento":
                            m1 = g.getArgento();
                            break;
                        case "rame":
                            m1 = g.getRame();
                            break;

                        case "diamanti":
                            m1 = g.getDiamanti();
                            break;
                        case "ferro":
                            m1 = g.getFerro();
                            break;

                        case "plastica":
                            m1 = g.getPlastica();
                            break;
                        case "alluminio":
                            m1 = g.getAlluminio();
                            break;
                    }
                    if (m1 >= quantita1)
                    {
                        requisitiMateriali++;
                    }
                }
                else
                {
                    switch (materiale2)
                    {
                        case "legno":

                            m1 = g.getLegno();
                            break;
                        case "oro":
                            m1 = g.getOro();
                            break;
                        case "argento":
                            m1 = g.getArgento();
                            break;
                        case "rame":
                            m1 = g.getRame();
                            break;

                        case "diamanti":
                            m1 = g.getDiamanti();
                            break;
                        case "ferro":
                            m1 = g.getFerro();
                            break;

                        case "plastica":
                            m1 = g.getPlastica();
                            break;
                        case "alluminio":
                            m1 = g.getAlluminio();
                            break;
                    }
                    if (m1 >= quantita2)
                    {
                        requisitiMateriali++;
                    }
                }
            }
            if (requisitiMateriali == 2)
            {
                button1.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (pictureBox3.Tag == "peluche")
            {
                materiale1 = "legno";
                materiale2 = "argento";
                quantita1 = 5;
                quantita2 = 2;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox3.Tag.ToString());
            }
            if (pictureBox3.Tag == "telefono")
            {
                materiale1 = "rame";
                materiale2 = "oro";
                quantita1 = 5;
                quantita2 = 2;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox3.Tag.ToString());
            }
            if (pictureBox3.Tag == "presa")
            {
                materiale1 = "rame";
                materiale2 = "ferro";
                quantita1 = 4;
                quantita2 = 4;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox3.Tag.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oggetto o = new Oggetto(materiale1, quantita1, materiale2, quantita2, nomeOggetto);
            oggetti.Add(o);
            for(int i = 0; i < oggetti.Count; i++)
            {
                Console.WriteLine(oggetti.ElementAt(i).getNomeOggetto());
            }
        }

        private void gestioneFabbrica_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (pictureBox2.Tag == "razzo")
            {
                materiale1 = "ferro";
                materiale2 = "diamanti";
                quantita1 = 5;
                quantita2 = 2;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox2.Tag.ToString());
            }
            if (pictureBox2.Tag == "cuffie")
            {
                materiale1 = "argento";
                materiale2 = "plastica";
                quantita1 = 5;
                quantita2 = 2;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox2.Tag.ToString());
            }
            if (pictureBox2.Tag == "tubo")
            {
                materiale1 = "ferro";
                materiale2 = "argento";
                quantita1 = 6;
                quantita2 = 1;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox2.Tag.ToString());
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (pictureBox5.Tag == "robot")
            {
                materiale1 = "diamanti";
                materiale2 = "rame";
                quantita1 = 2;
                quantita2 = 5;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox5.Tag.ToString());
            }
            if (pictureBox5.Tag == "monitor")
            {
                materiale1 = "alluminio";
                materiale2 = "oro";
                quantita1 = 5;
                quantita2 = 2;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox5.Tag.ToString());
            }
            if (pictureBox5.Tag == "cariola")
            {
                materiale1 = "ferro";
                materiale2 = "plastica";
                quantita1 = 5;
                quantita2 = 3;
                produci(materiale1, quantita1, materiale2, quantita2, pictureBox5.Tag.ToString());
            }
        }
    }
}
