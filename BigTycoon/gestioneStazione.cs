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
    public partial class gestioneStazione : Form
    {
        private string selected1;
        private string selected2;
        private bool okvagone1;
        private bool okvagone2;
        Giocatore g;
        int quantita;
        int quantita2;
        bool trenoPartito;
        public gestioneStazione(Giocatore g, bool trenoPartito)
        {
            InitializeComponent();
            this.g = g;
            if(trenoPartito == false)
            {
                label4.Text = "Treno in stazione";
            }
            else
            {
                label4.Text = "Treno partito";
            }
        }
        private void hide(int i)
        {
            if (i == 1)
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            else
            {
                button15.Visible = false;
                button14.Visible = false;
                button13.Visible = false;
                button12.Visible = false;
                button11.Visible = false;
                button10.Visible = false;
                button9.Visible = false;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button7.Text);
            selected1 = button7.Text;
            hide(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button1.Text);
            selected1 = button1.Text;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button2.Text);
            selected1 = button2.Text;
            hide(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button3.Text);
            selected1 = button3.Text;
            hide(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button4.Text);
            selected1 = button4.Text;
            hide(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button5.Text);
            selected1 = button5.Text;
            hide(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button6.Text);
            selected1 = button6.Text;
            hide(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button8.Text);
            hide(1); 
        }

        private void checkMateriale1_Tick(object sender, EventArgs e)
        {
            if(textBox1.Text!=null && selected1 != null)
            {
                double m1 = 0;
                // Se il giocatore ha abbastanza checkv_treno
                switch (selected1)
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
                        Console.WriteLine("Il player possiede " + g.getFerro());
                        break;

                    case "plastica":
                        m1 = g.getPlastica();
                        break;
                    case "alluminio":
                        m1 = g.getAlluminio();
                        break;
                }

                if (m1 >= Convert.ToInt32(textBox1.Text))
                {
                    pictureBox2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("checkv_treno");
                    quantita = Convert.ToInt32(textBox1.Text);
                    okvagone1 = true;
                }
                else
                {
                    okvagone1 = false;
                    pictureBox2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("checkx_treno");
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            if (okvagone1 && okvagone2)
            {
                trenoPartitoTimer.Start();
                label4.Text = "Treno partito";
               
                trenoPartitoTimer.Start();
                switch (selected1)
                {
                    case "legno":

                        g.setLegno(-quantita);
                        Console.WriteLine("INseriti");
                        break;
                    case "oro":
                        g.setOro(-quantita);
                        Console.WriteLine("INseriti");
                        break;
                    case "argento":
                        g.setArgento(-quantita);
                        Console.WriteLine("INseriti");
                        break;
                    case "rame":
                        g.setRame(-quantita);
                        break;

                    case "diamanti":
                        g.setDiamanti(-quantita);
                        break;
                    case "ferro":
                        g.setFerro(-quantita);
                        break;

                    case "plastica":
                        g.setPlastica(-quantita);
                        break;
                    case "alluminio":
                        g.setAlluminio(-quantita);
                        break;
                }
            }
        }

        private void listenerPartito_Tick(object sender, EventArgs e)
        {
            //if(GiocoPrincipale.trenoPartito == true)
            //{
            //    label4.Text = "Il treno è partito";
            //}
            //else
            //{
            //    label4.Text = "Il treno è in stazione";
            //}
        }

        private void trenoPartitoTimer_Tick(object sender, EventArgs e)
        {
            label4.Text = "Treno arrivato a destinazione, sta ritornando.";
            pictureBox3.Visible = false;
            trenoArrivatoTimer.Start();
            trenoPartitoTimer.Stop();
            trenoPartito = true;
        }

        private void trenoArrivatoTimer_Tick(object sender, EventArgs e)
        {
            label4.Text = "Treno arrivato in stazione";
            pictureBox3.Visible = false;
            inStazione.Start();
            trenoArrivatoTimer.Stop();
            trenoPartito = false;
        }

        private void inStazione_Tick(object sender, EventArgs e)
        {
            label4.Text = "Carica i materiali!";
            pictureBox3.Visible = true;
            trenoPartitoTimer.Start();
            inStazione.Stop();
            trenoPartito = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button15.Visible = true;
            button14.Visible = true;
            button13.Visible = true;
            button12.Visible = true;
            button11.Visible = true;
            button10.Visible = true;
            button9.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button15.Text);
            selected2 = button15.Text;
            hide(2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button14.Text);
            selected2 = button15.Text;
            hide(2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button13.Text);
            selected2 = button15.Text;
            hide(2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button11.Text);
            selected2 = button15.Text;
            hide(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button12.Text);
            selected2 = button15.Text;
            hide(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button10.Text);
            selected2 = button15.Text;
            hide(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(button9.Text);
            selected2 = button15.Text;
            hide(2);
        }

        private void checkMateriale2_Tick(object sender, EventArgs e)
        {
            if (textBox2.Text != null && selected2 != null)
            {
                double m1 = 0;
                // Se il giocatore ha abbastanza checkv_treno
                switch (selected2)
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

                if (m1 >= Convert.ToInt32(textBox2.Text))
                {
                    pictureBox5.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("checkv_treno");
                    quantita2 = Convert.ToInt32(textBox2.Text);
                    okvagone2 = true;
                }
                else
                {
                    okvagone2 = false;
                    pictureBox5.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("checkx_treno");
                }
            }
        }

        private void gestioneStazione_Load(object sender, EventArgs e)
        {
           
        }
    }
}
