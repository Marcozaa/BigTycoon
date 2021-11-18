using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Timers;

namespace BigTycoon
{
    public partial class GiocoPrincipale : Form
    {
        PictureBox treno_t;
        public static bool acquistoImmobiliare = false;
        static String edificioAcquistato;
        static String tagEdificio;
        Stopwatch sw = new Stopwatch();
        Scraper sc;
        static Giocatore g;                                                                           // **********Aggiunta static
        // lista della spesa - vector
        //vector
        ArrayList edifici = new ArrayList();
        PictureBox[] arrayPicturebox = new PictureBox[20];  // Prima era a 5.
        // Uso dei datatype e puntatori (doppi e non)
        private bool animazioneGuida = true; // variabile booleana che indica se bisogna ancora muovere la picturebox della guida verso l'alto
        private int frasi = 0;  // Contatore di frasi che verranno dette dalla guida e scritte sulla label "dialogo"
        private bool vaiDestra = false;
        private bool vaiSinistra = false;
        private bool vaiGiu = false;
        private bool vaiSu = false;
        private bool puoiCostruire = false;
        private int tempoCostruzioneEdificio;
        int valoreProvaProgBAr = 0;
        int contaEdifici = -1;
        private PictureBox edificioDaSpostare; // Nome dell'edificio da spostare

        static bool edificioEliminato = false;
        static int posizioneEdificioEliminato;
        int acquisti = 0;

        static Industria[] industrie = new Industria[20]; // Array di industrie                           // **********Aggiunta static
        int contaIndustrie = 0;
        String[] edificiCostruiti = new String[20];
        int contaResidenziali = 0;
        int contaFabbriche = 0;
        static String sezione = "nullo";
        Residenziali[] edificiResidenziali = new Residenziali[20]; // Array di case residenziali
        Fabbrica[] fabbriche = new Fabbrica[20];
        private int percentualeInquinamento = 0;

        private static String[] NomiEdificiAcquistati = new String[20];
        private static int contatoreNomiEdificiAcquistati = 0;

        private bool salvataggioCaricato;

        private Negozio[] negozi = new Negozio[20];
        int contaNegozi = 0;

        private Infrastrutture[] infrastrutture = new Infrastrutture[20];
        int contaInfrastrutture = 0;

        List<Oggetto> giochi = new List<Oggetto>();
        List<Oggetto> tecnologia = new List<Oggetto>();
        List<Oggetto> bricolage = new List<Oggetto>();

        System.Timers.Timer[] produzioneIndustrie = new System.Timers.Timer[20]; // Array per gestione di produzione materiale delle industrie in background
        int nIndustrieAvviate = 0;

        public static bool trenoPartito = false;
        public GiocoPrincipale(Scraper sc, Giocatore g, bool salvataggioCaricato)
        {
            InitializeComponent();
            g.setLegno(1000);
            g.setFerro(1000);
            this.sc = sc;
            GiocoPrincipale.g = g;
            MessageBox.Show("Username: " + g.getUsername() + "\nPassword: " + g.getPassword());
            this.salvataggioCaricato = salvataggioCaricato;
            int conta = 0;
            int conta2 = 0;
            PictureBox[] caseCaricate = new PictureBox[20];
            if (salvataggioCaricato == true)
            {
                string[] linee = File.ReadAllLines(@"edifici.txt");
                do
                {

                    if (conta % 2 == 0)
                    {
                        if (linee[conta].ToString() != "{X=0,Y=0}")
                        {
                            caseCaricate[conta2] = new PictureBox();
                            caseCaricate[conta2].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(linee[conta + 1]);
                            MessageBox.Show(linee[conta + 1]);
                            caseCaricate[conta2].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            caseCaricate[conta2].BackColor = Color.Transparent;
                            var myStringWhichCantBeChanged = linee[conta];
                            var k = Regex.Replace(myStringWhichCantBeChanged, @"[\{\}a-zA-Z=]", "").Split(',');

                            Point pointResult = new Point(
                                              int.Parse(k[0]),
                                              int.Parse(k[1]));
                            caseCaricate[conta2].Location = pointResult;
                            calcolaGrandezza(linee[conta + 1], caseCaricate[conta2]);
                            this.Controls.Add(caseCaricate[conta2]);
                            conta2++;
                        }
                    }
                    conta++;
                } while (conta < 20);
            }
        }

        public static void acquistoImmobiliareAvvenuto(String edificio, String tag)
        {
            acquistoImmobiliare = true;
            edificioAcquistato = edificio;
            tagEdificio = tag;
            NomiEdificiAcquistati[contatoreNomiEdificiAcquistati] = edificio;
            contatoreNomiEdificiAcquistati++;

        }

        private void GiocoPrincipale_Load(object sender, EventArgs e)
        {
            timerGuida.Start();
            try
            {
                string[] linee = File.ReadAllLines(@"materiali.txt");
                //g.getOro().ToString() + "\n" + g.getArgento().ToString() + "\n" + g.getRame().ToString() + "\n" + g.getDiamanti() + "\n" + g.getLegno().ToString() + "\n" + g.getFerro().ToString() + "\n" + g.getPlastica().ToString() + "\n" + g.getAlluminio().ToString());
                g.setOro(Convert.ToInt32(linee[0]));
                g.setArgento(Convert.ToInt32(linee[1]));
                g.setRame(Convert.ToInt32(linee[2]));
                g.setDiamanti(Convert.ToInt32(linee[3]));
                g.setLegno(Convert.ToInt32(linee[4]));
                g.setFerro(Convert.ToInt32(linee[5]));
                g.setPlastica(Convert.ToInt32(linee[6]));
                g.setAlluminio(Convert.ToInt32(linee[7]));

            }
            catch (System.IO.FileNotFoundException)
            {

            }

        }

        private void GiocoPrincipale_Click(object sender, EventArgs e)
        {
            Point coordinates = Cursor.Position;

            if (coordinates == casaPlayer.Location)
            {
                MessageBox.Show("HEllo world");
            }
        }

        private void timerGuida_Tick(object sender, EventArgs e)
        {
            if (animazioneGuida == true)
            {
                guida.Top += -4;
                dialogo.Top += -1;
            }
            if (guida.Top <= 158)
            {
                animazioneGuida = false;
                guida.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("guida_parla1");
                dialogo.Visible = true;
                dialogo.Text = "Benvenuto su \nbig tycoon!";
                timerGuida.Stop();
                timerDialogo.Start();
            }
        }

        public static void eliminaEdificio(int posizione, String sez)
        {
            // Mettere "-" nella posizione in cui si elimina l'edificio, in modo da rimuoverlo anche nel top down.

            sezione = sez;
            edificioEliminato = true;
            posizioneEdificioEliminato = posizione;

        }

        private void timerDialogo_Tick(object sender, EventArgs e)
        {
            switch (frasi) {

                case 0:
                    dialogo.Text = "Ti hanno dato l’opportunità \ndi creare la tua rete di industrie";
                    frasi++;
                    break;

                case 1:
                    dialogo.Text = "per vendere prodotti sul mercato\n mondiale.";
                    frasi++;
                    break;

                case 2:
                    dialogo.Text = "Dovrai attivare tutte le tue abilità \ngestionali per riuscire ad ottenere\n il massimo profitto.";
                    frasi++;
                    break;

                case 3:
                    dialogo.Text = "Ecco a te 300.000 euro\ne una casa\n per iniziare!";
                    quantitaDenaroLabel.Text = "300.000";
                    g.setDenaro(300000);
                    frasi++;
                    break;

                case 4:
                    dialogo.Text = "Buona fortuna!";
                    frasi++;
                    timerDialogo.Stop();
                    animazioneGuida = true;
                    timerGuida2.Start();
                    guida.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("guida_parla1");
                    casaPlayer.Visible = true;
                   quantitaOroLabel.Text = g.getOro().ToString();
                    quantitaArgentoLabel.Text = g.getArgento().ToString();

                    break;
            }
        }

        private void timerGuida2_Tick(object sender, EventArgs e)
        {
            if (animazioneGuida == true)
            {
                guida.Top += +8;
                dialogo.Top += +2;
            }
            if (guida.Top >= 600)
            {
                timerGuida2.Stop();
                puoiCostruire = true;
                edificioDaSpostare = casaPlayer;
            }
        }


        private void GiocoPrincipale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && edificioAcquistato != "stazione")
            {
                vaiSinistra = true;
            }
            if (e.KeyCode == Keys.D && edificioAcquistato != "stazione")
            {
                vaiDestra = true;
            }
            if (e.KeyCode == Keys.W && edificioAcquistato != "stazione")
            {
                vaiSu = true;
            }
            if (e.KeyCode == Keys.S && edificioAcquistato != "stazione")
            {
                vaiGiu = true;
            }
            if (e.KeyCode == Keys.F)
            {
                // INtersects whith tag edificio
                edificioDaSpostare.BringToFront();
            }

            if (e.KeyCode == Keys.Enter && puoiCostruire == true)
            {


                Random r = new Random();

                // edificioCostruito = true;
                Point locationOnForm = edificioDaSpostare.FindForm().PointToClient(
                                         edificioDaSpostare.Parent.PointToScreen(edificioDaSpostare.Location));
                puoiCostruire = false;
                casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer_inCostruzione");
                progressBar1.Location = locationOnForm;
                progressBar1.Visible = true;
                pictureBox3.Visible = true;
                pictureBox5.Visible = true;
                pictureBox7.Visible = true;
                pictureBox9.Visible = true;
                progressBar1.Value = 0;
                tempoCostruzioneEdificio = r.Next(5000, 10000);
                timerEdificio.Interval = tempoCostruzioneEdificio;
                Casa casaGiocatore = new Casa(locationOnForm, tempoCostruzioneEdificio, "casaPlayer", "residenziale");
                sw.Start();
                timerEdificio.Start();
                timerEdificio2.Start();
                if (contaEdifici >= 0)
                {
                    edificiCostruiti[contaEdifici] = edificioAcquistato;
                    edifici.Add(edificioAcquistato + " " + tagEdificio);           // Uso della memoria dinamica per array con tutte le case costruite
                    
                }
                contaEdifici++;
                acquisto.Start(); // Hai posizionato e costruito un edificio, quindi ora puoi tornare a comprare.
            }

        }

        private void GiocoPrincipale_KeyUp(object sender, KeyEventArgs e)
        {
            if (vaiDestra == true)
            {
                vaiDestra = false;
            }
            if (vaiSinistra == true)
            {
                vaiSinistra = false;
            }
            if (vaiSu == true)
            {
                vaiSu = false;
            }
            if (vaiGiu == true)
            {
                vaiGiu = false;
            }
        }

        private void posizionamentoCasaSpostamento_Tick(object sender, EventArgs e)
        {
            //casaDaSpostare
            if (vaiDestra == true && edificioDaSpostare.Left + edificioDaSpostare.Width <= this.ClientSize.Width && puoiCostruire == true)
            {
                /*
                if (casaPlayer.Bounds.IntersectsWith(ZonaNonEdificabile.Bounds))
                {
                    casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer_zonaNonEdificabile1");
                    puoiCostruire = false;
                }
                else
                {
                    casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer");
                    puoiCostruire = true;
                }*/
                edificioDaSpostare.Left += 2;

            }
            if (vaiSinistra == true && edificioDaSpostare.Left > 0 && puoiCostruire == true)
            {
                /*
                    if (casaPlayer.Bounds.IntersectsWith(ZonaNonEdificabile.Bounds))
                    {
                        vaiSinistra = false;
                        casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer_zonaNonEdificabile1");
                        puoiCostruire = false;
                    }
                    else
                    {
                        casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer");
                        puoiCostruire = true;
                    }*/
                edificioDaSpostare.Left -= 2;

            }
            if (vaiSu == true && edificioDaSpostare.Top > 0 && puoiCostruire == true)
            {
                /*
                if (casaPlayer.Bounds.IntersectsWith(ZonaNonEdificabile.Bounds))
                {
                    casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer_zonaNonEdificabile1");
                    puoiCostruire = false;
                }
                else
                {
                    casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer");
                    puoiCostruire = true;
                }*/
                edificioDaSpostare.Top -= 2;

            }
            if (vaiGiu == true && edificioDaSpostare.Top + edificioDaSpostare.Height <= this.ClientSize.Height && puoiCostruire == true)
            {
                /*
                if (casaPlayer.Bounds.IntersectsWith(ZonaNonEdificabile.Bounds))
                {
                    casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer_zonaNonEdificabile1");
                }
                else
                {
                    casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer");
                }
                */
                edificioDaSpostare.Top += 2;

            }
        }

        private void timerEdificio_Tick(object sender, EventArgs e) // Casa costruita
        {
            progressBar1.Value = 100;
            casaPlayer.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("casaPlayer");
            progressBar1.Visible = false;
            timerEdificio2.Stop();
            timerEdificio.Stop();

        }

        private void timerEdificio2_Tick(object sender, EventArgs e)
        {
            int valore;
            valore = (int)(sw.ElapsedMilliseconds / 1000);
            Console.WriteLine(valore + "\n");
            try
            {
                if (valore % 2 == 0)
                {
                    valoreProvaProgBAr += 30;
                    progressBar1.Value = valoreProvaProgBAr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                progressBar1.Value = 100;
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            marketImmobili market = new marketImmobili(g);
            market.Show();
        }

        private int randomId()
        {
            Random r = new Random();
            int n = r.Next(10000, 99000);
            return n;
        }

        private void calcolaGrandezza(String edificioAcquistato, PictureBox edificio_acquistato)
        {
            if (edificioAcquistato == "condominio" || edificioAcquistato == "villa" || edificioAcquistato == "casa")
            {
                edificio_acquistato.Size = new Size(40, 45);
                switch (edificioAcquistato)
                {
                    case "condominio":
                        edificiResidenziali[contaResidenziali] = new Residenziali("condominio", randomId().ToString(), edificioAcquistato, 1);
                        contaResidenziali++;
                        break;
                    case "villa":
                        edificiResidenziali[contaResidenziali] = new Residenziali("villa", randomId().ToString(), edificioAcquistato, 2);
                        contaResidenziali++;
                        break;
                    case "casa":
                        edificiResidenziali[contaResidenziali] = new Residenziali("casa", randomId().ToString(), edificioAcquistato, 3);
                        contaResidenziali++;
                        break;
                }
            }

            if (edificioAcquistato == "fabbrica1" || edificioAcquistato == "fabbrica2" || edificioAcquistato == "fabbrica3")
            {
                edificio_acquistato.Size = new Size(120, 80);
            }

            if (edificioAcquistato == "boschetto")
            {
                edificio_acquistato.Size = new Size(120, 80);
            }

            if (edificioAcquistato == "miniera_dragdrop")
            {
                edificio_acquistato.Size = new Size(80, 60);
                infrastrutture[contaInfrastrutture] = new Infrastrutture("Miniera", randomId().ToString(), edificioAcquistato, 3);
                contaInfrastrutture++;
            }

            if (edificioAcquistato == "villa")
            {
                edificio_acquistato.Size = new Size(50, 55);
            }
            if (edificioAcquistato == "casa")
            {
                edificio_acquistato.Size = new Size(40, 45);
            }

            if (edificioAcquistato == "negozio1" || edificioAcquistato == "negozio2" || edificioAcquistato == "negozio3")
            {
                switch (edificioAcquistato)
                {
                    case "negozio1":
                        negozi[contaNegozi] = new Negozio(randomId().ToString(), "Negozio Giocattoli", 1, edificioAcquistato);
                        contaNegozi++;
                        break;
                    case "negozio2":
                        negozi[contaNegozi] = new Negozio(randomId().ToString(), "Negozio Bricolage", 2, edificioAcquistato);
                        contaNegozi++;
                        break;
                    case "negozio3":
                        negozi[contaNegozi] = new Negozio(randomId().ToString(), "Negozio Tecnologia", 3, edificioAcquistato);
                        contaNegozi++;
                        break;
                }
                edificio_acquistato.Size = new Size(40, 45);
            }

            if (edificioAcquistato == "industriaFerro1" || edificioAcquistato == "industriaRame" || edificioAcquistato == "industriaOro")
            {
                switch (edificioAcquistato)
                {
                    case "industriaFerro1":
                        industrie[contaIndustrie] = new Industria("Industria ferro", randomId().ToString(), edificioAcquistato, 1);
                        contaIndustrie++;
                        break;
                    case "industriaRame":
                        industrie[contaIndustrie] = new Industria("Industria rame", randomId().ToString(), edificioAcquistato, 2);
                        contaIndustrie++;
                        break;
                    case "industriaOro":
                        industrie[contaIndustrie] = new Industria("Industria oro", randomId().ToString(), edificioAcquistato, 3);
                        contaIndustrie++;
                        break;
                }

                edificio_acquistato.Size = new Size(40, 45);
            }
            if (edificioAcquistato == "fabbrica1" || edificioAcquistato == "fabbrica2" || edificioAcquistato == "fabbrica3")
            {
                switch (edificioAcquistato)
                {
                    case "fabbrica1":
                        fabbriche[contaFabbriche] = new Fabbrica("fabbrica giocattoli", randomId().ToString(), edificioAcquistato, 1);
                        contaFabbriche++;
                        break;
                    case "fabbrica2":
                        fabbriche[contaFabbriche] = new Fabbrica("fabbrica tecnologia", randomId().ToString(), edificioAcquistato, 2);
                        contaFabbriche++;
                        break;
                    case "fabbrica3":
                        fabbriche[contaFabbriche] = new Fabbrica("fabbrica bricolage", randomId().ToString(), edificioAcquistato, 3);
                        contaFabbriche++;
                        break;
                }

                edificio_acquistato.Size = new Size(70, 65);
            }
            if (edificioAcquistato == "stazione")
            {
                edificio_acquistato.Size = new Size(100, 100);
                infrastrutture[contaInfrastrutture] = new Infrastrutture("Stazione", randomId().ToString(), edificioAcquistato, 1);
                contaInfrastrutture++;

            }

            if (edificioAcquistato == "porto1")
            {
                edificio_acquistato.Size = new Size(100, 100);
            }
            /*else
            {
                edificio_acquistato.Size = new Size(40, 45);
            }*/
        }

        private void acquisto_Tick(object sender, EventArgs e)
        {
            if (acquistoImmobiliare == true)
            {
                PictureBox edificio_acquistato = new PictureBox();  // la variabile edificio_acquistato contiene il nome della picturebox dell'edificio acquistato
                edificio_acquistato.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(edificioAcquistato);
                edificio_acquistato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                edificio_acquistato.BackColor = Color.Transparent;

                switch (edificioAcquistato)
                {
                    case "stazione":
                        Treno t = new Treno();
                        edificio_acquistato.Location = new Point(0, 200);
                        treno_t = new PictureBox();
                        treno_t.Image = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("stazione");
                        treno_t.SizeMode = PictureBoxSizeMode.StretchImage;
                        //treno_t.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        
                        treno_t.BackColor = Color.Transparent;
                        treno_t.Location = new Point(-95, 200);
                        this.Controls.Add(treno_t);
                        arrivoTreno.Start();
                        //timerTreno1.Start();
                        break;

                    case "porto1":
                        edificio_acquistato.Location = new Point(650, 220);
                        break;

                    default:
                        edificio_acquistato.Location = new Point(100, 0);
                        break;
                }

                // implementare Funzione per calcolo grandezza ! *********************************************************************
                calcolaGrandezza(edificioAcquistato, edificio_acquistato);
                this.Controls.Add(edificio_acquistato);
                puoiCostruire = true;
                edificioDaSpostare = edificio_acquistato;
                edificio_acquistato.Tag = tagEdificio;
                arrayPicturebox[acquisti] = edificio_acquistato;
                acquistoImmobiliare = false;
                acquisto.Stop();
                acquisti++;
            }
        }

        private void checkSaldo_Tick(object sender, EventArgs e)
        {
            quantitaDenaroLabel.Text = g.getDenaro().ToString();
            quantitaArgentoLabel.Text = g.getArgento().ToString();
        }

        private void timerAffitti_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)  //Il foreach esegue un'istruzione o un blocco di istruzioni per ogni elemento in un'istanza del tipo che implementa
            {
                if (x is PictureBox && (string)x.Tag == "residenziale" && puoiCostruire == false)
                {
                    // QUEsto commento implementava il colore verde per significare che un affitto era pronto da riscuotere
                    //if (tagEdificio == "residenziale")
                    //{
                    //    x.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(edificioAcquistato + "_verde");
                    //}
                    g.setDenaro(1000);
                    //if (tagEdificio == "residenziale")
                    //{
                    //    x.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(edificioAcquistato);
                    //}

                }

                if (x is PictureBox && (string)x.Tag == "produttore" && puoiCostruire == false)
                {
                    g.setArgento(10);
                }

            }

        }

        private void timerGuadagnosecondario_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormEdifici fe = new FormEdifici(edificiCostruiti, arrayPicturebox, edifici, industrie, g, edificiResidenziali, fabbriche, negozi, giochi, tecnologia, bricolage, infrastrutture, trenoPartito);
            fe.Show();
        }

        private void prova_Tick(object sender, EventArgs e)
        {
            arrayPicturebox[0].Hide();
        }

        private void listenerEliminaEdifici_Tick(object sender, EventArgs e)
        {
            /*
             * Risoluzione bug - piazzando 1 industria -> una casa -> un industria eliminando la seconda industria viene eliminata la casa.
             * la variabile sezione indica quale strutture stiamo controllando 1- industrie 2- residenziali....
             * se siamo nella sezione industrie e nell'array abbiamo una casa, essa non verrà eliminata (tag residenziale) e passiamo al prossimo elemento ficnhè non troviamo l'elemento da eliminare.
             * 
             */
            if (edificioEliminato == true)
            {
                if (sezione == "industrie")
                {
                    if (arrayPicturebox[posizioneEdificioEliminato].Tag == "produttore")
                    {
                        arrayPicturebox[posizioneEdificioEliminato].Hide();
                        edificioEliminato = false;
                        industrie[posizioneEdificioEliminato].setNome("-");
                        arrayPicturebox.ElementAt(posizioneEdificioEliminato).Name = "-";
                    }
                    else
                    {
                        posizioneEdificioEliminato++;
                    }
                }
                if (sezione == "fabbriche")
                {
                    if (arrayPicturebox[posizioneEdificioEliminato].Tag == "fabbrica")
                    {
                        arrayPicturebox[posizioneEdificioEliminato].Hide();
                        edificioEliminato = false;
                        fabbriche[posizioneEdificioEliminato].setNome("-");
                        arrayPicturebox.ElementAt(posizioneEdificioEliminato).Name = "-";
                    }
                    else
                    {
                        posizioneEdificioEliminato++;
                    }
                }
                if (sezione == "negozi")
                {
                    if (arrayPicturebox[posizioneEdificioEliminato].Tag == "negozio")
                    {
                        arrayPicturebox[posizioneEdificioEliminato].Hide();
                        edificioEliminato = false;
                        negozi[posizioneEdificioEliminato].setNome("-");
                        arrayPicturebox.ElementAt(posizioneEdificioEliminato).Name = "-";
                    }
                    else
                    {
                        posizioneEdificioEliminato++;
                    }
                }
                if (sezione == "case")
                {
                    if (arrayPicturebox[posizioneEdificioEliminato].Tag == "residenziale")
                    {
                        arrayPicturebox[posizioneEdificioEliminato].Hide();
                        edificioEliminato = false;
                        edificiResidenziali[posizioneEdificioEliminato].setNome("-");
                        arrayPicturebox.ElementAt(posizioneEdificioEliminato).Name = "-";
                    }
                    else
                    {
                        posizioneEdificioEliminato++;
                    }
                }
                if (sezione == "infrastrutture")
                {
                    if (arrayPicturebox[posizioneEdificioEliminato].Tag == "infrastruttura")
                    {
                        arrayPicturebox[posizioneEdificioEliminato].Hide();
                        edificioEliminato = false;
                        infrastrutture[posizioneEdificioEliminato].setNome("-");
                        arrayPicturebox.ElementAt(posizioneEdificioEliminato).Name = "-";
                    }
                    else
                    {
                        posizioneEdificioEliminato++;
                    }
                }

            }
        }

        private void screenShot(bool visibilita)
        {
            pictureBox1.Visible = visibilita;
            pictureBox2.Visible = visibilita;
            pictureBox3.Visible = visibilita;
            pictureBox4.Visible = visibilita;
            pictureBox5.Visible = visibilita;
            pictureBox6.Visible = visibilita;
            pictureBox7.Visible = visibilita;
            pictureBox8.Visible = visibilita;
            pictureBox9.Visible = visibilita;
            quantitaArgentoLabel.Visible = visibilita;
            quantitaOroLabel.Visible = visibilita;
            quantitaDenaroLabel.Visible = visibilita;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            salvaStato s = new salvaStato(g, edificiCostruiti, arrayPicturebox);
            s.clientSalvaStato();


            screenShot(false);
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save("Screenshot.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            screenShot(true);


            String filePath = @"edifici.txt";

            try
            {
                File.WriteAllText(filePath, arrayPicturebox[0].Location + "\n" + NomiEdificiAcquistati[0] + "\n" + arrayPicturebox[1].Location + "\n" + NomiEdificiAcquistati[1] + "\n" + arrayPicturebox[2].Location + "\n" + NomiEdificiAcquistati[2] + "\n" + arrayPicturebox[3].Location + "\n" + NomiEdificiAcquistati[3] + "\n" + arrayPicturebox[4].Location + "\n" + NomiEdificiAcquistati[4] + "\n" + arrayPicturebox[5].Location + "\n" + NomiEdificiAcquistati[5] + "\n" + arrayPicturebox[6].Location + "\n" + NomiEdificiAcquistati[6] + "\n" + arrayPicturebox[7].Location + "\n" + NomiEdificiAcquistati[7] + "\n" + arrayPicturebox[8].Location + "\n" + NomiEdificiAcquistati[8] + "\n" + arrayPicturebox[9].Location + "\n" + NomiEdificiAcquistati[9] + "\n" + arrayPicturebox[10].Location + "\n" + NomiEdificiAcquistati[10] + "\n" + arrayPicturebox[11].Location + "\n" + NomiEdificiAcquistati[11] + "\n" + arrayPicturebox[12].Location + "\n" + NomiEdificiAcquistati[12] + "\n");
            }
            catch (System.ArgumentNullException)
            {

            }

            filePath = @"materiali.txt";

            try
            {
                File.WriteAllText(filePath, g.getOro().ToString() + "\n" + g.getArgento().ToString() + "\n" + g.getRame().ToString() + "\n" + g.getDiamanti() + "\n" + g.getLegno().ToString() + "\n" + g.getFerro().ToString() + "\n" + g.getPlastica().ToString() + "\n" + g.getAlluminio().ToString());
            }
            catch (System.ArgumentNullException)
            {

            }

            timer2.Start();
        }

        private void arrivoTreno_Tick(object sender, EventArgs e)
        {
            animazioneTreno.Start();
        }

        private void animazioneTreno_Tick(object sender, EventArgs e)
        {

            if (treno_t.Left > 20)
            {
                animazioneTrenoIndietro.Start();
                animazioneTreno.Stop();
            }
            treno_t.Top += -2;
            treno_t.Left += 6;
        }

        private void animazioneTrenoIndietro_Tick(object sender, EventArgs e)
        {
            if (treno_t.Left < -95)
            {
                animazioneTrenoIndietro.Stop();
                MessageBox.Show("STOP");
            }
            treno_t.Top += 2;
            treno_t.Left += -6;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = g.getLegno().ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Materiali m = new Materiali(g);
            m.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(Application.StartupPath + @"\yourimage.png");
            }
            timer2.Stop();
        }

        private void timerAmbiente_Tick(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ambiente")
                {
                    percentualeInquinamento += -10;

                }

                if (x is PictureBox && (string)x.Tag == "produttore")
                {
                    percentualeInquinamento += 5;

                }
            }
            if (percentualeInquinamento > 30)
            {
                g.setDenaro(-5000);
                //Felicità abitanti diminuisce
            }
            else
            {
                g.setDenaro(1000);
                //Felicità abitanti aumenta
            }
            label2.Text = percentualeInquinamento + "%";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Salvataggi s = new Salvataggi(this, edificiResidenziali, arrayPicturebox, edificiCostruiti, edifici);
            this.Hide();
            s.Show();
        }

        
        public static void produzione_Industrie()
        {

            for (int i = 0; i < 20; i++)
            {
                if (industrie[i] is null)
                {

                }
                else
                {
                    if (industrie[i].getAvviata() == true && industrie[i].getTimerAvviato() == false)
                    {

                        //MessageBox.Show("Industria attiva prodotto");
                        int icopia = i;
                        industrie[i].setTimerAvviato(true);
                        System.Timers.Timer aTimer = new System.Timers.Timer();
                        aTimer.Elapsed +=  delegate { produzioneMaterialeIndustria(icopia); };
                        aTimer.Interval = 5000;
                        aTimer.Enabled = true;

                    }
                }
                
            }
        }
    
        
        static void produzioneMaterialeIndustria(int i)
        {
            //MessageBox.Show("Ho prodotto" + i);
            int valore = 4;
            switch (industrie[i].getMateriale_inProduzione())
            {
                case "legno":

                    g.setLegno(valore);
                    break;
                case "oro":
                    g.setOro(valore);
                    break;
                case "argento":
                     g.setArgento(valore);
                    break;
                case "rame":
                    g.setRame(valore);
                    break;

                case "diamanti":
                   g.setDiamanti(valore);
                    break;
                case "ferro":
                    g.setFerro(valore);
                    break;

                case "plastica":
                    g.setPlastica(valore);
                    break;
                case "alluminio":
                    g.setAlluminio(valore);
                    break;
            }
            
        }
        

        private void produzioneIndustrieTimer_Tick(object sender, EventArgs e)
        {
            produzione_Industrie();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
