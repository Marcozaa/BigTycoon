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
    
    public partial class gestioneNegozio : Form
    {
        int x = 40;         //0
        bool vai = false;
        Point[] punti = new Point[20];
        int nPunto = 0;
        int prezzo = 500;
        int chiudi_apri_menu = 0;
        Giocatore g;
        int offertaCorrente;

        List<Oggetto> oggetti;
        List<Oggetto> magazzino = new List<Oggetto>();

        Label[] labels = new Label[20];
        PictureBox[] immagini = new PictureBox[20];

        private Oggetto oggettoAsta;

        bool asta_finita = false;
        private String nomeOggettoAsta;

        string sezione;

        public gestioneNegozio(List<Oggetto> oggetti, Giocatore g)
        {
            InitializeComponent();
           
            punti[0] = new Point();
            punti[1] = new Point();
            this.g = g;
            this.oggetti = oggetti;
            for (int i = 0; i < oggetti.Count; i++)
            {
                immagini[i] = new PictureBox();
                Console.WriteLine(i + "Oggetto ");
                if (i > 3) // Ci saranno solo 4 oggetti in vendita (Vetrina) Il resto sarà posizionato nel magazzino e venduto nell'asta.
                {
                    magazzino.Add(oggetti.ElementAt(i));
                }
                else
                {
                    
                }
            }

        }

        FlowLayoutPanel flowLayoutPanel1;
        FlowLayoutPanel flowLayoutPanel2;

        public void DrawLinePoint(PaintEventArgs e)
        {


        }

        public void inserisciPunto(PictureBox puntata, int nPunto)
        {
            
            
            
            punti[nPunto] = puntata.Location;




            if (nPunto >= 1)
            {
                vai = true;
                // MessageBox.Show(punti[0].ToString());
                //MessageBox.Show("Vai");
                this.Refresh();
            }
        }


        int i = 0;
        private void soldi_Tick(object sender, EventArgs e)
        {
            if (asta_finita == false)
            {
                //MessageBox.Show(x.ToString());
                Random r = new Random();
                int valore;
                //astaFinita.Start();
                
                int prec = 0;
                do
                {
                    valore = r.Next(0, 600);
                } while (valore > this.ClientSize.Height && valore < prezzo);


                if (valore < prezzo)
                {
                    prezzo = valore;
                    //astaFinita.Start();
                    Label puntata_label = new Label();
                    puntata_label.Location = new Point(300, 130);
                    puntata_label.Text = oggettoAsta.getNomeOggetto();
                    puntata_label.ForeColor = Color.White;
                    Console.WriteLine("Offerta corrente: " + (600 - prezzo));
                    label6.Text = (600 - prezzo).ToString();
                    offertaCorrente = 600 - prezzo;
                        this.Controls.Add(puntata_label);
                    PictureBox puntata = new PictureBox();  // la variabile edificio_acquistato contiene il nome della picturebox dell'edificio acquistato
                    puntata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    puntata.BackColor = Color.Black;
                    puntata.Size = new Size(10, 10);
                    puntata.Location = new Point(x, valore);
                    x = x + 90;
                    this.Controls.Add(puntata);

                    inserisciPunto(puntata, nPunto);

                    //astaFinita.Stop();
                    nPunto++;
                }
            }
            else
            {
                soldi.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //button2.Click += new System.Windows.Forms.PaintEventHandler(this.DrawLinePoint);
        }

        private void DrawLinePoint(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Creazione penna.
            Pen blackPen = new Pen(Color.FromArgb(164, 73, 215), 3);
            if (vai == true)
            {
        

                // Create points that define line.   

                //Point point1 = punti[0]; 
                //Point point2 = punti[1];

                // Draw line to screen.   
                //e.Graphics.DrawLine(blackPen, point1, point2);


                // Conta elementi nel vettore
                int contaOutOFBounds = 0;
                for (int i = 0; i < 20; i++)
                {
                    if(punti[i].X == 0 && punti[i].Y == 0)
                    {
                        break;
                    }
                    else
                    {
                        contaOutOFBounds++;
                    }

                }
            


            List<Point> list = new List<Point>();

               

                for (int i = 0; i < contaOutOFBounds; i++)
                {
                    Console.WriteLine(punti[5]);
                   
                        list.Add(punti[i]);
                    
                }

                //   //Draw lines to screen.
                e.Graphics.DrawLines(blackPen, list.ToArray());
            }
        }

        private void gestioneNegozio_Paint(object sender, PaintEventArgs e)
        {
            if (vai == true)
            {
                this.OnPaint(e);

            
            }
        }

        private void gestioneNegozio_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                labels[i] = new Label();
                immagini[i] = new PictureBox();

            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("icona_grafico_hover");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("icona_grafico");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("Dashboard_1");
            label6.Visible = true;
            label5.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            BackgroundImageLayout = ImageLayout.Stretch;
           
            label5.Text= nomeOggettoAsta;
            
            Label nome = new Label();
            nome.Location = new Point(50, 100);
            nome.Text = oggettoAsta.getNomeOggetto();
            Console.WriteLine(oggettoAsta.getNomeOggetto());
            nome.ForeColor = Color.White;
            this.Controls.Add(nome);
            soldi.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (chiudi_apri_menu % 2 == 0)
            {
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("CLOSE-131994911256789607");
                pictureBox1.BackColor = Color.FromArgb(164, 73, 215);
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                chiudi_apri_menu++;
            }
            else
            {
                pictureBox1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("Hamburger_icon_bianca");
                pictureBox1.BackColor = Color.FromArgb(24, 25, 29);
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                chiudi_apri_menu++;
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sezione = "magazzino";
            label6.Visible = false;
            label5.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            try
            {
                label1.Text = magazzino.ElementAt(0).getNomeOggetto();
            }
            catch (System.NullReferenceException)
            {
                label1.Text = "vuoto";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                label1.Text = "vuoto";
            }
            try
            {
                label2.Text = magazzino.ElementAt(1).getNomeOggetto();
            }
            catch (System.NullReferenceException)
            {
                label2.Text = "vuoto";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                label2.Text = "vuoto";
            }
            try
            {
                label3.Text = magazzino.ElementAt(2).getNomeOggetto();
            }
            catch (System.NullReferenceException)
            {
                label3.Text = "vuoto";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                label3.Text = "vuoto";
            }
            try
            {
                label4.Text = magazzino.ElementAt(3).getNomeOggetto();
            }
            catch (System.NullReferenceException)
            {
                label4.Text = "vuoto";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                label4.Text = "vuoto";
            }
            int assey = 197;
            int assex = 246;
            for (int i = 0; i < 20; i++)
            {
                immagini[i].Hide();

            }

            for (int i = 0; i < magazzino.Count; i++)
            {

                immagini[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(magazzino.ElementAt(i).getNomeOggetto());
                switch (i)
                {
                    case 1:
                        assex += 250;
                        break;
                    case 2:
                        assex -= 250;
                        assey += 123;
                        break;
                    case 3:
                        assex += 250;
                        break;
                }
                if (magazzino.ElementAt(i).getNomeOggetto() != "-")
                {
                    immagini[i].Name = magazzino.ElementAt(i).getNomeOggetto();
                    immagini[i].Tag = i;
                    immagini[i].Show();
                    immagini[i].Location = new Point(assex, assey);
                    immagini[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    immagini[i].BackColor = Color.Transparent;
                    immagini[i].Size = new Size(50, 50);
                    immagini[i].Click += new EventHandler(this.oggettoMagazzino_Click);
                    this.Controls.Add(immagini[i]);
                }
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("magazzino_icon_bianca");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("magazzino");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label5.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            sezione = "negozio";
            try
            {
                label1.Text = oggetti.ElementAt(0).getNomeOggetto();
            }
            catch (System.NullReferenceException)
            {
                label1.Text = "vuoto";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                label1.Text = "vuoto";
            }
            try
            {
                label2.Text = oggetti.ElementAt(1).getNomeOggetto();
            }
            catch (System.NullReferenceException)
            {
                label2.Text = "vuoto";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                label2.Text = "vuoto";
            }
            try
            {
                label3.Text = oggetti.ElementAt(2).getNomeOggetto();
            }
            catch (System.NullReferenceException)
            {
                label3.Text = "vuoto";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                label3.Text = "vuoto";
            }
            try
            {
                label4.Text = oggetti.ElementAt(3).getNomeOggetto();
            }
            catch (System.NullReferenceException)
            {
                label4.Text = "vuoto";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                label4.Text = "vuoto";
            }
            for (int i = 0; i < 20; i++)
            {
                immagini[i].Hide();

            }

            BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("negozio_dashboard");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //BackgroundImage = null;
            //Console.WriteLine(oggetti.ElementAt(0).getMateriale1());
            int assey = 197;
            int assex = 246;
            for (int i = 0; i < oggetti.Count; i++)
            {
                if (i > 3) // Ci saranno solo 4 oggetti in vendita (Vetrina) Il resto sarà posizionato nel magazzino e sarà venduto nell'asta.
                {
                   
                }
                else
                {
                    //labels[i].Text = oggetti.ElementAt(i).getNomeOggetto();
                    //labels[i].ForeColor = Color.White;
                    //labels[i].BackColor = Color.Transparent;
                    ////labels[i].Font = labelFont;
                    //labels[i].Tag = i;
                    //labels[i].Location = new Point(250, assey);
                    //assey += 52;
                    //this.Controls.Add(labels[i]);
                    
                    immagini[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(oggetti.ElementAt(i).getNomeOggetto());
                    switch (i)
                    {
                        case 1:
                            assex += 250;
                            break;
                        case 2:
                            assex -= 250;
                            assey += 123;
                            break;
                        case 3:
                            assex += 250;
                            break;

                    }
                    immagini[i].Name = oggetti.ElementAt(i).getNomeOggetto();
                    immagini[i].Tag = i;
                    //oggetti.ElementAt(i).getPrezzo();
                    immagini[i].Show();
                    immagini[i].Location = new Point(assex, assey);
                    immagini[i].Click += new EventHandler(this.vendita_Click);
                    immagini[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    immagini[i].BackColor = Color.Transparent;
                    immagini[i].Size = new Size(50, 50);
                    this.Controls.Add(immagini[i]);
                }
            }
        }

        public void vendita_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            DialogResult result = MessageBox.Show("");
            // If sezione == Vendita __________
            if (sezione == "negozio")
            {
                result = MessageBox.Show("vuoi vendere " + btn.Name + " per 1000$?", "", MessageBoxButtons.YesNo);
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                
                
              
                oggetti.ElementAt(Convert.ToInt32(btn.Tag)).setNomeOggetto("-");
                


            }
            if (result == System.Windows.Forms.DialogResult.No)
            {

            }
        }

        public void oggettoMagazzino_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            DialogResult result = MessageBox.Show(""); ;
            //IF sezione == asta ______________________________________________________________-
            if (sezione == "magazzino")
            {
                result = MessageBox.Show("sei sicuro di voler mettere all'asta " + btn.Name + " ?", "", MessageBoxButtons.YesNo);
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Inizio asta
                astaFinita.Start();

                oggettoAsta = magazzino[Convert.ToInt32(btn.Tag)];
                //magazzino.RemoveAt(Convert.ToInt32(btn.Tag));
                nomeOggettoAsta = magazzino.ElementAt(Convert.ToInt32(btn.Tag)).getNomeOggetto();
                magazzino.ElementAt(Convert.ToInt32(btn.Tag)).setNomeOggetto("-");
                pictureBox2_Click(sender, e);
                try
                {
                    for (int i = 0; i < immagini.Length; i++)
                    {
                        immagini[i].Hide();
                    }
                }
                catch (System.NullReferenceException)
                {

                }

                
            }
            if (result == System.Windows.Forms.DialogResult.No)
            {

            }
        }

        private void astaFinita_Tick(object sender, EventArgs e)
        {
            asta_finita = true;
            MessageBox.Show("L'asta si è conclusa con la vendita di " + nomeOggettoAsta + " per " +offertaCorrente);
            g.setDenaro(offertaCorrente);
            this.Close();
            
        }
    }
}
