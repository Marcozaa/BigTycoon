using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTycoon
{
    public partial class giocoMiniera : Form
    {
        Label[] numeriDaIndovinare = new Label[3];
        TextBox[] scritturaPlayer = new TextBox[3];
        PictureBox oggetto = new PictureBox();
        Stopwatch sp = new Stopwatch();
        int mineraliScavati = 0;
        int tempo = 0;
        private bool notNull = true;
        Button bottone;

        int oro1Scavato = 0;
        int oro2Scavato=0;
        int argento1Scavato=0;
        int argento2Scavato = 0;

        Giocatore g;

        public giocoMiniera(Giocatore g)
        {
            InitializeComponent();
            this.g = g;


        }

        private void giocoMiniera_Load(object sender, EventArgs e)
        {
            oggettoTrovato.Enabled = true;
            for (int i = 0; i < 3; i++)
            {
                scritturaPlayer[i] = new TextBox();
                numeriDaIndovinare[i] = new Label();
                bottone = new Button();
            }
        }
        public void oggetto_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;


            Random n = new Random();

            notNull = false;
            for (int i = 0; i < 3; i++)
            {

                scritturaPlayer[i].Text = null;
                numeriDaIndovinare[i].Text = null;

            }

            int assex1 = 230;
            for (int i = 0; i < 3; i++)
            {
                numeriDaIndovinare[i].Visible = true;
                numeriDaIndovinare[i].Text = n.Next(1, 10).ToString();
                numeriDaIndovinare[i].Size = new Size(20, 20);
                numeriDaIndovinare[i].Location = new Point(assex1, 100);
                numeriDaIndovinare[i].Cursor = Cursors.Hand;
                numeriDaIndovinare[i].BackColor = Color.Brown;
                assex1 += 50;
                this.Controls.Add(numeriDaIndovinare[i]);
            }


            button2.Visible = true;
            button2.Size = new Size(30, 20);
            button2.Location = new Point(360, 180);
            button2.Cursor = Cursors.Hand;



            int assex = 230;
            for (int i = 0; i < 3; i++)
            {
                scritturaPlayer[i].Visible = true;
                scritturaPlayer[i].Size = new Size(30, 20);
                scritturaPlayer[i].Location = new Point(assex, 180);
                scritturaPlayer[i].Cursor = Cursors.Hand;
                scritturaPlayer[i].Tag = i;
                this.Controls.Add(scritturaPlayer[i]);
                notNull = true;
                if (i == 0)
                {
                    scritturaPlayer[0].Focus();
                }
                assex += 50;

                if (notNull == true)
                {
                    scritturaPlayer[i].TextChanged += new EventHandler(this.NumeroScritto);
                }
            }
        }


        public void bottone_Click(object sender, EventArgs e)
        {
            uguali = 0;
            Button btn = sender as Button;
            //button1.Focus();
            for (int i = 0; i < 3; i++)
            {
                if (scritturaPlayer[i].Text == numeriDaIndovinare[i].Text)
                {

                    uguali++;

                }
            }

            if (uguali == 3)
            {

              
                if (oggetto.Tag == "oro1")
                {
                    oro1Scavato++;
                    g.setOro(500);
                }
                if (oggetto.Tag == "oro2")
                {
                    oro2Scavato++;
                    g.setOro(100);
                }
                if (oggetto.Tag == "argento1")
                {
                    argento1Scavato++;
                    g.setArgento(500);
                }
                if (oggetto.Tag == "argento2")
                {
                    argento2Scavato++;
                    g.setArgento(100);
                }
            }

           //MessageBox.Show(uguali.ToString());
            oggetto.Hide();
            for (int i = 0; i < 3; i++)
            {
                scritturaPlayer[i].Hide();
                numeriDaIndovinare[i].Hide();

            }
            scadenzaTempo.Stop();
            oggettoTrovato.Start();
            timerStopWatch.Stop();

        }

        int uguali = 0;
        private void NumeroScritto(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (Convert.ToInt32(tb.Tag) + 1 < 3)
            {
                scritturaPlayer[Convert.ToInt32(tb.Tag) + 1].Focus();
                Console.WriteLine("Focus su " + (tb.Tag) + 1);
            }
            else
            {
                //MessageBox.Show("else");
                //for(int i = 0; i < 3; i++)
                //{
                //    if (scritturaPlayer[i].Text == numeriDaIndovinare[i].Text)
                //    {

                //        uguali++;

                //    }
                //}
                //if (uguali == 3)
                //{
                //    Console.WriteLine("uguali");
                //    mineraliScavati++;
                //    oggetto.Hide();
                //    for (int i = 0; i < 3; i++)
                //    {
                //        scritturaPlayer[i].Hide();
                //        numeriDaIndovinare[i].Hide();
                //    }
                //    scadenzaTempo.Stop();
                //    //oggettoTrovato.Start();
                //    timerStopWatch.Stop();
                //    giocoMiniera_Load(sender, e);
                //}
            }
        }
        private void oggettoTrovato_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int tipoMinerale = r.Next(0, 4);

            switch (tipoMinerale)
            {
                case 0:
                    oggetto.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("pepita_oro_1");
                    oggetto.Tag = "oro1";
                    break;

                case 1:
                    oggetto.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("pepita_oro_2");
                    oggetto.Tag = "oro2";
                    break;

                case 2:
                    oggetto.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("pepita_argento_1");
                    oggetto.Tag = "argento1";
                    break;

                case 3:
                    oggetto.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("pepita_argento_2");
                    oggetto.Tag = "argento2";
                    break;
            }

            int assey = r.Next(250, 400);

            int assex = r.Next(0, 800);
            //int posizione = r.Next();
            for (int i = 0; i < 3; i++)
            {
                scritturaPlayer[i] = new TextBox();
                numeriDaIndovinare[i] = new Label();
            }
            scadenzaTempo.Enabled = true;
            oggetto.Visible = true;
            timerStopWatch.Start();
            
            oggetto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            oggetto.BackColor = Color.Transparent;
            oggetto.Size = new Size(60, 50);
            oggetto.Location = new Point(assex, assey);
            //MessageBox.Show(assex + "-" + assey);
            oggetto.Cursor = Cursors.Hand;
            oggetto.Click += new EventHandler(this.oggetto_Click);
            this.Controls.Add(oggetto);
            oggettoTrovato.Enabled = false;
        }

        private void scadenzaTempo_Tick(object sender, EventArgs e)
        {
            oggetto.Hide();
            button2.Hide();
            for (int i = 0; i < 3; i++)
            {
                scritturaPlayer[i].Hide();
                numeriDaIndovinare[i].Hide();
            }
            scadenzaTempo.Stop();
            oggettoTrovato.Start();
        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            label1.Text = tempo.ToString();
            tempo++;
        }

        private void scavati_Tick(object sender, EventArgs e)
        {
            label2.Text = oro1Scavato.ToString();
            label3.Text = argento1Scavato.ToString();
            label4.Text = oro2Scavato.ToString();
            label5.Text = argento2Scavato.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uguali = 0;
            Button btn = sender as Button;
            //button1.Focus();
            for (int i = 0; i < 3; i++)
            {
                if (scritturaPlayer[i].Text == numeriDaIndovinare[i].Text)
                {
                    uguali++;
                }
            }

            if (uguali == 3)
            {
                mineraliScavati++;
            }

            MessageBox.Show(uguali.ToString());
            oggetto.Hide();
            for (int i = 0; i < 3; i++)
            {
                scritturaPlayer[i].Hide();
                numeriDaIndovinare[i].Hide();

            }
            scadenzaTempo.Stop();
            oggettoTrovato.Start();
            timerStopWatch.Stop();

        }
    }
}
