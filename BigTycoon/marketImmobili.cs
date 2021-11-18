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
    public partial class marketImmobili : Form
    {

        Item1 item_n1;
        Item2 item_n2;
        Item3 item_n3;
        private int clickItem1 = 0;
        private int clickItem2 = 0;
        private int clickItem3 = 0;
        Giocatore g;
        public marketImmobili(Giocatore g)
        {
            InitializeComponent();
            this.g = g;
            Item1 item_1 = new Item1("Stazione_ferroviaria_NOTclicked", 50000);
            this.item_n1 = item_1;
            prezzo1.Text = item_1.getCosto().ToString();
            item1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(item_1.getImmagine());

            Item2 item_2 = new Item2("porto_NOTclicked", 65000);
            this.item_n2 = item_2;
            prezzo2.Text = item_2.getCosto().ToString();
            item2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(item_2.getImmagine());

            Item3 item_3 = new Item3("Stazione_ferroviaria_NOTclicked", 50000);
            this.item_n3 = item_3;
            prezzo3.Text = item_3.getCosto().ToString();
            item3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(item_3.getImmagine());
        }

  
        /*
        private void item1_MouseMove(object sender, MouseEventArgs e)
        {
            item1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("Stazione_ferroviaria_clicked");
        }

        private void item1_MouseLeave(object sender, EventArgs e)
        {
            item1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(item_n1.getImmagine());
        }
        */

        private void item1_Click(object sender, EventArgs e)
        {
            if (clickItem1 % 2 == 0)
            {
                DialogResult result = MessageBox.Show("Confermi l'aquisto? ", "", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes && (g.getDenaro() - item_n1.getCosto()) > 0)
                {

                    label3.Text = item_n1.getImmagine();


                if (label3.Text == "Stazione_ferroviaria_NOTclicked")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("stazione", "infrastruttura");
                }

                if (label3.Text == "industriaFerro_NOTclicked")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("industriaFerro1", "produttore");
                }

                if (label3.Text == "condominio_NOTclicked")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("condominio", "residenziale");
                }

                if (label3.Text == "fabbricaGiocattoli")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("fabbrica1", "fabbrica");
                }

                if (label3.Text == "alberi_market")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("boschetto", "ambiente");
                }

                if (label3.Text == "negozioGiocattoli")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("negozio1", "negozio");
                }


                    GiocoPrincipale.acquistoImmobiliare = true;
                    g.setDenaro(-item_n1.getCosto());




                }
                if (result == System.Windows.Forms.DialogResult.No)
                {

                }

            }
            else
            {
          label3.Text = "";
            }
            clickItem1++;
        }
        private void item2_Click(object sender, EventArgs e)
        {
            if (clickItem2 % 2 == 0)
            {
                DialogResult result = MessageBox.Show("Confermi l'aquisto? ", "", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes && (g.getDenaro()-item_n2.getCosto())>0)
                {

                    

                    label3.Text = item_n2.getImmagine();

                if (label3.Text == "casa_NOTclicked")
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("casa", "residenziale");

                if (label3.Text == "industriaRame_NOTclicked")
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("industriaRame", "produttore");

                if (label3.Text == "porto_NOTclicked")
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("porto1", "infrastruttura");

                if (label3.Text == "fabbricaTecnologia")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("fabbrica2", "fabbrica");
                }

                if (label3.Text == "laghetto_market")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("laghetto", "ambiente");
                }

                if (label3.Text == "negozioBricolage")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("negozio2", "negozio");
                }


                    GiocoPrincipale.acquistoImmobiliare = true;
                    g.setDenaro(-item_n2.getCosto());




                }
                if (result == System.Windows.Forms.DialogResult.No)
                {

                }
            }
            else
            {
                label3.Text = "";
            }
            clickItem2++;
        }

        private void item3_Click(object sender, EventArgs e)
        {
            if (clickItem3 % 2 == 0)
            {
                DialogResult result = MessageBox.Show("Confermi l'aquisto? ", "", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes && (g.getDenaro() - item_n3.getCosto()) > 0)
                {
                    label3.Text = item_n3.getImmagine();

                if (label3.Text == "villa_NOTclicked")
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("villa", "residenziale");

                if (label3.Text == "industriaOro_NOTclicked")
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("industriaOro", "produttore");

                if (label3.Text == "fabbricaBricolage")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("fabbrica3", "fabbrica");
                }

                if (label3.Text == "negozioTecnologia")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("negozio3", "negozio");
                }

                if (label3.Text == "miniera_NOTclicked")
                {
                    GiocoPrincipale.acquistoImmobiliareAvvenuto("miniera_dragdrop", "infrastruttura");
                }

                    GiocoPrincipale.acquistoImmobiliare = true;
                    g.setDenaro(-item_n3.getCosto());




                }
                if (result == System.Windows.Forms.DialogResult.No)
                {

                }
            }
            else
            {
                label3.Text = "";
            }
            clickItem3++;
        }

        private void Infrastrutture_label_Click(object sender, EventArgs e)
        {
            item_n1.setImmagine("Stazione_ferroviaria_NOTclicked");
            item_n1.setCosto(50000);
            item_n2.setImmagine("porto_NOTclicked");
            item_n2.setCosto(65000);
            item_n3.setImmagine("miniera_NOTclicked");
            item_n3.setCosto(105000);
        }

        private void Residenziali_label_Click(object sender, EventArgs e)
        {
            item_n1.setImmagine("condominio_NOTclicked");
            item_n1.setCosto(35000);
            item_n2.setImmagine("casa_NOTclicked");
            item_n2.setCosto(10000);
            item_n3.setImmagine("villa_NOTclicked");
            item_n3.setCosto(25000);
        }

        private void TimerItems_Tick(object sender, EventArgs e)
        {
            prezzo1.Text = item_n1.getCosto().ToString();
            item1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(item_n1.getImmagine());
            prezzo2.Text = item_n2.getCosto().ToString();
            item2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(item_n2.getImmagine());
            prezzo3.Text = item_n3.getCosto().ToString();
            item3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(item_n3.getImmagine());
            // prezzo2.Text = item_2.getCosto().ToString();
            //  item2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(item_2.getImmagine());
        }

        private void Fabbriche_label_Click(object sender, EventArgs e)
        {
            item_n1.setImmagine("industriaFerro_NOTclicked");
            item_n1.setCosto(45000);
            item_n2.setImmagine("industriaRame_NOTclicked");
            item_n2.setCosto(65000);
            item_n3.setImmagine("industriaOro_NOTclicked");
            item_n3.setCosto(85000);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            item_n1.setImmagine("fabbricaGiocattoli");
            item_n1.setCosto(45000);
            item_n2.setImmagine("fabbricaTecnologia");
            item_n2.setCosto(65000);
            item_n3.setImmagine("fabbricaBricolage");
            item_n3.setCosto(85000);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            item_n1.setImmagine("alberi_market");
            item_n1.setCosto(45000);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            item_n1.setImmagine("negozioGiocattoli");
            item_n1.setCosto(45000);
            item_n2.setImmagine("negozioBricolage");
            item_n2.setCosto(45000);
            item_n3.setImmagine("negozioTecnologia");
            item_n3.setCosto(45000);
        }
    }
}
