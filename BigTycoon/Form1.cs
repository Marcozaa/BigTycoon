using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace BigTycoon
{
    // SCcreenshot villaggi per salvataggi

    public partial class Form1 : Form
    {
        Scraper sc;
        private static bool registrato = false;
        static Giocatore player_;
        public Form1()
        {
            InitializeComponent();
            //label2.Text = s.getOro().ToString();
        }

        public static void utenteRegistrato(Giocatore player)
        {
            player_ = player;
            registrato = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginResgister lr = new LoginResgister();
            lr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Scraper sc = new Scraper();
            sc.cerca();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gioca(object sender, EventArgs e)
        {
            Giocatore g = new Giocatore("-","-"); 
            bool primaPartita;
            String filePath = @"Giocatore.txt";
            try
            {
               
                string[] linee = File.ReadAllLines(filePath);
            }
            catch (System.IO.FileNotFoundException)
            {
                
                primaPartita = true;
                File.WriteAllText(filePath,"");
            }
            if (registrato == true)
            {
                GiocoPrincipale gp = new GiocoPrincipale(sc, player_, false);
                File.WriteAllText(filePath, player_.getUsername() + "\n" + player_.getPassword());
                gp.Show();
                this.Hide();
            }
            else
            {
                GiocoPrincipale gp = new GiocoPrincipale(sc, g, false);
                File.WriteAllText(filePath, g.getUsername() + "\n" + g.getPassword());
                gp.Show();
                this.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InserisciNomeUtente nm = new InserisciNomeUtente();
            nm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                villaggioSalvato.BackgroundImage = (Bitmap)System.Drawing.Bitmap.FromFile("Screenshot.png");
                string[] linee = File.ReadAllLines(@"Giocatore.txt");
                usernameLabel.Visible = true;
                usernameLabel.Text = linee[0];
                villaggioSalvato.Visible = true;
                carica.Visible = true;
            }
            catch (System.IO.FileNotFoundException)
            {
                noSalvataggi.Visible = true;
            }
        }

        private void carica_Click(object sender, EventArgs e)
        {
            // Creo un istanza di player leggendo dal file
            string[] linee = File.ReadAllLines(@"Giocatore.txt");
            Giocatore gi = new Giocatore(linee[0],linee[1]);
            GiocoPrincipale gp = new GiocoPrincipale(sc, gi, true);
            gp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // gestioneNegozio gss = new gestioneNegozio();
            //gss.Show();
           // gestioneStazione gs = new gestioneStazione();
            //gs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //giocoMiniera gm = new giocoMiniera();
            //gm.Show();
        }
    }
}
