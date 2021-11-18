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
    public partial class FormEdifici : Form
    {
        ArrayList edifici;
        String[] edificiCostruiti;
        PictureBox[] arrayPicturebox;
        Label[] labels = new Label[20];
        Button[] buttons = new Button[20];
        String[] prova = new String[10];
        PictureBox[] immagini_edifici = new PictureBox[20];
        Label[] labelsID = new Label[20];

        Label[] avviate = new Label[20];
        String sezione;
        Industria[] industrie;
        bool industrieSelezionate;
        Giocatore g;
        Fabbrica[] fabbriche;
        Residenziali[] edificiResidenziali;
        Negozio[] negozi;
        Infrastrutture[] infrastrutture;

        List<Oggetto> giochi;
        List<Oggetto> tecnologia;
        List<Oggetto> bricolage;

        bool trenoPartito;
        public FormEdifici(String[] edificiCostruiti, PictureBox[] arrayPicturebox, ArrayList edifici, Industria[] industrie, Giocatore g, Residenziali[] edificiResidenziali, Fabbrica[] fabbriche, Negozio[] negozi, List<Oggetto> giochi, List<Oggetto> tecnologia, List<Oggetto> bricolage, Infrastrutture[] infrastrutture, bool trenoPartito)
        {
            InitializeComponent();
            this.edificiCostruiti = edificiCostruiti;
            this.arrayPicturebox = arrayPicturebox;
            this.edifici = edifici;
            this.industrie = industrie;
            this.g = g;
            this.edificiResidenziali = edificiResidenziali;
            this.fabbriche = fabbriche;
            this.negozi = negozi;
            this.giochi = giochi;
            this.tecnologia = tecnologia;
            this.bricolage = bricolage;
            this.infrastrutture = infrastrutture;
            this.trenoPartito = trenoPartito;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEdifici_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                labels[i] = new Label();
                labelsID[i] = new Label();
                buttons[i] = new Button();
                immagini_edifici[i] = new PictureBox();
            }
        }
        /*
        protected void button_Click(object sender, EventArgs e, int i)
        {
            Button button = sender as Button;
            MessageBox.Show("Elimino edificio numero: " + i);
            GiocoPrincipale.eliminaEdificio(Convert.ToInt32(i));
        }
        */

        private void ClickBottoni_Tick(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiocoPrincipale.eliminaEdificio(Convert.ToInt32(textBox1.Text),sezione);
        }

        private int numeroElementiVettore()
        {
            int contaOutOFBounds = 0;
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    String n = industrie[i].getIDindustria();
                    contaOutOFBounds++;
                }
                catch (System.ArgumentOutOfRangeException)
                {

                }
                catch (System.NullReferenceException)
                {

                }
            }
            return contaOutOFBounds;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero industrie: " + numeroElementiVettore());
            industrieSelezionate = true; // Inutile
            int assey = 80;
            Font labelFont = new Font("Poppins", 10);
            Color viola = Color.FromArgb(170,96,224);
            sezione = "industrie";
            for (int i = 0; i < numeroElementiVettore(); i++)
            {
                /*labels[i] = new Label();
                labelsID[i] = new Label();
                buttons[i]= new Button();*/
                if (industrie[i].getNome() != "-")
                {
                    //MessageBox.Show(industrie[i].getNome());
                    labels[i].Text = industrie[i].getNome();
                    labels[i].ForeColor = Color.White;
                    labels[i].BackColor = Color.Transparent;
                    labels[i].Font = labelFont;
                    labels[i].Tag = i;
                    labels[i].Click += new EventHandler(this.label_Click);
                    buttons[i].Text = "Demolisci";
                    buttons[i].Tag = i;
                    buttons[i].Click += new EventHandler(this.buttonDem_Click);
                    labelsID[i].Text = industrie[i].getIDindustria();
                    labelsID[i].ForeColor = Color.White;
                    labelsID[i].BackColor = Color.Transparent;
                    labelsID[i].Font = labelFont;
                    avviate[i] = new Label();
                    avviate[i].Text = industrie[i].getAvviata().ToString();
                    avviate[i].ForeColor = Color.White;
                    avviate[i].BackColor = Color.Transparent;
                    avviate[i].Font = labelFont;
                    immagini_edifici[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(industrie[i].getImmagine());
                    immagini_edifici[i].Location = new Point(167, assey);
                    immagini_edifici[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    immagini_edifici[i].BackColor = Color.Transparent;
                    immagini_edifici[i].Size = new Size(40, 40);
                    labels[i].Location = new Point(250, assey);
                    labelsID[i].Location = new Point(350, assey);
                    avviate[i].Location = new Point(450, assey);
                    buttons[i].Location = new Point(550, assey);
                    labels[i].ForeColor = viola;
                    labelsID[i].ForeColor = viola;
                    this.Controls.Add(labels[i]);
                    this.Controls.Add(immagini_edifici[i]);
                    this.Controls.Add(buttons[i]);
                    this.Controls.Add(labelsID[i]);
                    this.Controls.Add(avviate[i]);
                    assey += 52;
                }
            }
        }

         public void label_Click(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            MessageBox.Show("Hai cliccato " + btn.Tag);
            if (sezione == "fabbriche")
            {
                if (fabbriche[(int)btn.Tag].getTipo() == 1)
                {
                    gestioneFabbrica gf = new gestioneFabbrica(g, fabbriche, btn.Tag.ToString(), giochi);
                    gf.Show();
                }
                if (fabbriche[(int)btn.Tag].getTipo() == 3)
                {
                    gestioneFabbrica gf = new gestioneFabbrica(g, fabbriche, btn.Tag.ToString(), tecnologia);
                    gf.Show();
                }
                if (fabbriche[(int)btn.Tag].getTipo() == 2)
                {
                    gestioneFabbrica gf = new gestioneFabbrica(g, fabbriche, btn.Tag.ToString(), bricolage);
                    gf.Show();
                }
            }
            if(sezione == "industrie") 
            {
                GestioneIndustria gs = new GestioneIndustria(industrie[(int)btn.Tag], g);
                gs.Show();
            }
            if(sezione == "negozi")
            {
                if (negozi[(int)btn.Tag].getTipoNegozio() == 1)
                {
                    gestioneNegozio gn = new gestioneNegozio(giochi, g);
                    gn.Show();
                }
                if (negozi[(int)btn.Tag].getTipoNegozio() == 2)
                {
                    gestioneNegozio gn = new gestioneNegozio(tecnologia, g);
                    gn.Show();
                }
                if (negozi[(int)btn.Tag].getTipoNegozio() == 3)
                {
                    gestioneNegozio gn = new gestioneNegozio(bricolage, g);
                    gn.Show();
                }
            }
            if(sezione == "infrastrutture")
            {
                if (infrastrutture[(int)btn.Tag].getTipo() == 1)
                {
                    gestioneStazione gs = new gestioneStazione(g, trenoPartito);
                    gs.Show();
                }
                if (infrastrutture[(int)btn.Tag].getTipo() == 3)
                {
                    giocoMiniera gm = new giocoMiniera(g);
                    gm.Show();
                }
            }
        }

        public void buttonDem_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
                GiocoPrincipale.eliminaEdificio(Convert.ToInt32(btn.Tag), sezione);
            

        }

        private int numeroElementi_Vettore()  //////////////////////////// FAre un unico metodo in seguito
        {
            if(sezione == "case")
            {
                int contaOutOFBounds = 0;
                for (int i = 0; i < 20; i++)
                {
                    try
                    {
                        String n = edificiResidenziali[i].getNome();
                        contaOutOFBounds++;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {

                    }
                    catch (System.NullReferenceException)
                    {

                    }
                }
                return contaOutOFBounds;
            }
            if (sezione == "fabbriche")
            {
                int contaOutOFBounds = 0;
                for (int i = 0; i < 20; i++)
                {
                    try
                    {
                        String n = fabbriche[i].getNome();
                        contaOutOFBounds++;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {

                    }
                    catch (System.NullReferenceException)
                    {

                    }
                }
                return contaOutOFBounds;
            }
            if (sezione == "negozi")
            {
                int contaOutOFBounds = 0;
                for (int i = 0; i < 20; i++)
                {
                    try
                    {
                        String n = negozi[i].getIDnegozio();
                        contaOutOFBounds++;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {

                    }
                    catch (System.NullReferenceException)
                    {

                    }
                }
                return contaOutOFBounds;
            }
            if(sezione == "infrastrutture")
            {
                int contaOutOFBounds = 0;
                for (int i = 0; i < 20; i++)
                {
                    try
                    {
                        String n = infrastrutture[i].getID();
                        
                        contaOutOFBounds++;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {

                    }
                    catch (System.NullReferenceException)
                    {

                    }
                }
                return contaOutOFBounds;
            }
            return 0;

        }

        private void azzera()
        {
            labels[0].Text = edificiResidenziali[0].getNome(); 
           // labelsID[0] = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Vettore che parte dopo indice 20 delle industrie o matrice. 
            /*
             * |__industria 1___||__casa      1___|
             * |__industria 2___||__casa      2___|
             * |____......______||____......______|
             * |________________||________________|
             * |________________||________________|              
             * */
            sezione = "case";
            MessageBox.Show("Numero Case: " + numeroElementi_Vettore());
            int assey = 85;
            Font labelFont = new Font("Arial", 8, FontStyle.Bold);
           //azzera();
             for (int i = 0; i < numeroElementi_Vettore(); i++)
            {
                if (edificiResidenziali[i].getNome() != "-")
                {
                    labels[i].Text = edificiResidenziali[i].getNome();
                    labels[i].ForeColor = Color.White;
                    labels[i].BackColor = Color.Transparent;
                    labels[i].Font = labelFont;
                    labels[i].Tag = i;
                    labels[i].Click += new EventHandler(this.label_Click);

                    buttons[i].Text = "Demolisci";
                    buttons[i].Tag = i;
                    buttons[i].Click += new EventHandler(this.buttonDem_Click);

                    labelsID[i].Text = edificiResidenziali[i].getIDedificio();
                    labelsID[i].ForeColor = Color.White;
                    labelsID[i].BackColor = Color.Transparent;
                    labelsID[i].Font = labelFont;

                    buttons[i].Location = new Point(550, assey);

                    //immagini_edifici[i] = new PictureBox();
                    immagini_edifici[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(edificiResidenziali[i].getImmagine());
                    immagini_edifici[i].Location = new Point(167, assey);
                    immagini_edifici[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    immagini_edifici[i].BackColor = Color.Transparent;
                    immagini_edifici[i].Size = new Size(40, 40);
                    labels[i].Location = new Point(250, assey);
                    labelsID[i].Location = new Point(350, assey);

                    this.Controls.Add(labels[i]);
                    this.Controls.Add(immagini_edifici[i]);
                    this.Controls.Add(labelsID[i]);
                    this.Controls.Add(buttons[i]);
                    assey += 52;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sezione = "fabbriche";
            MessageBox.Show("Numero FAbbriche: " + numeroElementi_Vettore());
            int assey = 85;
            Font labelFont = new Font("Arial", 8, FontStyle.Bold);
            
            Color viola = Color.FromArgb(170, 96, 224);
            for (int i = 0; i < numeroElementi_Vettore(); i++)
            {
                if (fabbriche[i].getNome() != "-")
                {
                    labels[i].Text = fabbriche[i].getNome();
                    labels[i].ForeColor = viola;
                    labels[i].BackColor = Color.Transparent;
                    labels[i].Font = labelFont;
                    labels[i].Tag = i;
                    labels[i].Click += new EventHandler(this.label_Click);
                    buttons[i].Text = "Demolisci";
                    buttons[i].Tag = i;
                    buttons[i].Click += new EventHandler(this.buttonDem_Click);
                    labelsID[i].Text = fabbriche[i].getIDfabbrica();
                    labelsID[i].ForeColor = viola;
                    labelsID[i].BackColor = Color.Transparent;
                    labelsID[i].Font = labelFont;
                    buttons[i].Location = new Point(550, assey);
                    //immagini_edifici[i] = new PictureBox();
                    immagini_edifici[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(fabbriche[i].getImmagine());
                    immagini_edifici[i].Location = new Point(167, assey);
                    immagini_edifici[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    immagini_edifici[i].BackColor = Color.Transparent;
                    immagini_edifici[i].Size = new Size(40, 40);
                    labels[i].Location = new Point(250, assey);
                    labelsID[i].Location = new Point(350, assey);

                    this.Controls.Add(labels[i]);
                    this.Controls.Add(immagini_edifici[i]);
                    this.Controls.Add(labelsID[i]);
                    this.Controls.Add(buttons[i]);
                    assey += 52;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            sezione = "negozi";
            MessageBox.Show("Numero negozi: " + numeroElementi_Vettore());
            int assey = 85;
            Font labelFont = new Font("Arial", 8, FontStyle.Bold);
            for (int i = 0; i < numeroElementi_Vettore(); i++)
            {
                if (negozi[i].getNomeNegozio() != "-")
                {
                    labels[i].Text = negozi[i].getNomeNegozio();
                    labels[i].ForeColor = Color.White;
                    labels[i].BackColor = Color.Transparent;
                    labels[i].Font = labelFont;
                    labels[i].Tag = i;
                    labels[i].Click += new EventHandler(this.label_Click);
                    buttons[i].Text = "Demolisci";
                    buttons[i].Tag = i;
                    buttons[i].Click += new EventHandler(this.buttonDem_Click);
                    labelsID[i].Text = negozi[i].getIDnegozio();
                    labelsID[i].ForeColor = Color.White;
                    labelsID[i].BackColor = Color.Transparent;
                    labelsID[i].Font = labelFont;
                    immagini_edifici[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(negozi[i].getImmagine());
                    immagini_edifici[i].Location = new Point(167, assey);
                    immagini_edifici[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    immagini_edifici[i].BackColor = Color.Transparent;
                    immagini_edifici[i].Size = new Size(40, 40);
                    labels[i].Location = new Point(250, assey);
                    labelsID[i].Location = new Point(350, assey);
                    buttons[i].Location = new Point(550, assey);
                    this.Controls.Add(labels[i]);
                    this.Controls.Add(immagini_edifici[i]);
                    this.Controls.Add(labelsID[i]);
                    this.Controls.Add(buttons[i]);
                    assey += 52;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            sezione = "infrastrutture";
            MessageBox.Show("Numero infrastrutture: " + numeroElementi_Vettore());
            int assey = 85;
            Font labelFont = new Font("Arial", 8, FontStyle.Bold);
            for (int i = 0; i < numeroElementi_Vettore(); i++)
            {
                if (infrastrutture[i].getNome() != "-")
                {
                    labels[i].Text = infrastrutture[i].getNome();
                    labels[i].ForeColor = Color.White;
                    labels[i].BackColor = Color.Transparent;
                    labels[i].Font = labelFont;
                    labels[i].Tag = i;
                    labels[i].Click += new EventHandler(this.label_Click);

                    buttons[i].Text = "Demolisci";
                    buttons[i].Tag = i;
                    buttons[i].Click += new EventHandler(this.buttonDem_Click);

                    labelsID[i].Text = infrastrutture[i].getID();
                    labelsID[i].ForeColor = Color.White;
                    labelsID[i].BackColor = Color.Transparent;
                    labelsID[i].Font = labelFont;
                    immagini_edifici[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(infrastrutture[i].getImmagine());
                    immagini_edifici[i].Location = new Point(167, assey);
                    immagini_edifici[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    immagini_edifici[i].BackColor = Color.Transparent;
                    immagini_edifici[i].Size = new Size(40, 40);
                    labels[i].Location = new Point(250, assey);
                    labelsID[i].Location = new Point(350, assey);
                    buttons[i].Location = new Point(550, assey);
                    this.Controls.Add(labels[i]);
                    this.Controls.Add(immagini_edifici[i]);
                    this.Controls.Add(labelsID[i]);
                    this.Controls.Add(buttons[i]);
                    assey += 52;
                }
            }
        }
    }
}
