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
    public partial class GestioneIndustria : Form
    {
        Industria industria;
        int avviabtnconta = 0;
        Giocatore g;
        Stopwatch sw = new Stopwatch();
        bool selezionato1;
        bool selezionato2;
        bool selezionato3;
        int contaClick1 = 0;
        int contaClick2 = 0;
        int contaClick3 = 0;
        double costoAvvio;
        String primoItem;
        String secondoItem;
        String terzoItem;
        String materiale_produzione = "NULLA";
        int denaroRimanente = 0;
        public GestioneIndustria(Industria industria, Giocatore g)
        {
            InitializeComponent();
            this.industria = industria;
            this.g = g;
            switch (industria.getTipo())
            {
                case 1:
                    costoAvvio = 5000;
                    primoItem = "legno_indsutria";
                    secondoItem = "ferro_industria";
                    terzoItem = "plastica_industria";
                    item1.Tag = "legno";
                    item2.Tag = "ferro";
                    item3.Tag = "plastica";
                    break;
                case 2:
                    costoAvvio = 10000;
                    primoItem = "alluminio_industria";
                    secondoItem = "rame_industria";
                    terzoItem = null;
                    item1.Tag = "alluminio";
                    item2.Tag = "rame";
                    item3.Tag = null;
                    break;
                case 3:
                    costoAvvio = 20000;
                    primoItem = "oro_industria";
                    secondoItem = "argento_industria";
                    terzoItem = "diamanti_industria";
                    item1.Tag = "oro";
                    item2.Tag = "argento";
                    item3.Tag = "diamanti";
                    break;
            }
            item1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(primoItem);
            item2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(secondoItem);
            try
            {
                item3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(terzoItem);
            }
            catch (System.ArgumentNullException)
            {
                item3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("blocco_");
                bottone3.Visible = false;
            }

            if (industria.getAvviata()==true)
            {
                btn_StartIndustria.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("toggle-switch-design1");
                producendoLabel.Text = industria.getMateriale_inProduzione();
            }
            else
            {
                btn_StartIndustria.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("toggle-switch-design2");
                producendoLabel.Text = "NULLA";
            }
        }

        private void btn_StartIndustria_Click(object sender, EventArgs e)
        {
            denaroRimanente = Convert.ToInt32(textBox1.Text);
            if (avviabtnconta % 2 == 0 && Convert.ToInt32(textBox1.Text) >= costoAvvio)
            {

                if (selezionato1 == false && selezionato2 == false && selezionato3 == false)
                {
                    MessageBox.Show("Seleziona un materiale da produrre.");
                }
                else
                {
                    MessageBox.Show("Industria Attivata");
                    g.setDenaro(-Convert.ToInt32(textBox1.Text));
                    btn_StartIndustria.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("toggle-switch-design1");
                    avviabtnconta++;
                    timerIndustria.Start();
                    secondipassati_suLabel.Start();
                    controlloSoldi.Start();
                    industria.setAvviata(true);
                    industria.setMaterialeInProduzione(materiale_produzione);
                }
            }
            else
            {
                MessageBox.Show("Industria Fermata.");
                btn_StartIndustria.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("toggle-switch-design2");
                industria.setAvviata(false);
                avviabtnconta++;
                timerIndustria.Stop();
            }
        }

        private void GestioneIndustria_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            nomeIndustrialabel.Text = industria.getNome();
            IdIndustrialabel.Text = industria.getIDindustria();
        }

        private void timerIndustria_Tick(object sender, EventArgs e)
        {
            switch (industria.getTipo()){
                case 1:
                    produzione();
                    break;
                case 2:
                    produzione();
                    break;
                case 3:
                    produzione();
                    break;
                default:
                    MessageBox.Show("Errore nel codice. ");
                break;
            }
        }

        private void produzione()
        {
            if(selezionato1==true && selezionato2==false && selezionato3 == false)
            {
                switch (industria.getTipo())
                {
                    case 1:
                        g.setLegno(10);
                        MessageBox.Show("Hai prodotto 10 di legno ");
                        break;
                    case 2:
                        g.setAlluminio(10);
                        MessageBox.Show("Hai prodotto 10 di alluminio ");
                        break;

                    case 3:
                        g.setOro(10);
                        MessageBox.Show("Hai prodotto 10 di oro ");
                        break;
                }
            }
            if (selezionato1 == false && selezionato2 == true && selezionato3 == false)   // Selezionato è l'item!!!  ITEM 2 SELEZIONATO
            {
                switch (industria.getTipo())
                {
                    case 1:
                        g.setFerro(10);
                        MessageBox.Show("Hai prodotto 10 di ferro ");
                        break;
                    case 2:
                        g.setRame(10);
                        MessageBox.Show("Hai prodotto 10 di rame ");
                        break;
                    case 3:
                        g.setArgento(10);
                        MessageBox.Show("Hai prodotto 10 di argento ");
                        break;
                }
            }
            if (selezionato1 == false && selezionato2 == false && selezionato3 == true)
            {
                switch (industria.getTipo())
                {
                    case 1:
                        g.setPlastica(10);
                        MessageBox.Show("Hai prodotto 10 di Plastica ");
                        break;
                    case 2:
                        break;
                    case 3:
                        g.setDiamanti(10);
                        MessageBox.Show("Hai prodotto 10 di diamanti ");
                        break;
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
             n += 100;
            textBox1.Text = n.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            n += -100;
            textBox1.Text = n.ToString();
        }

        private void secondipassati_suLabel_Tick(object sender, EventArgs e)
        {
            sw.Start();
            label2.Text = (sw.ElapsedMilliseconds / 1000).ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (contaClick1 % 2 == 0)
            {
                bottone1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneCliccato_industria");
                bottone2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                selezionato1 = true;
                selezionato2 = false;
                selezionato3 = false;
                producendoLabel.Text = item1.Tag.ToString();
                materiale_produzione = item1.Tag.ToString();
                contaClick1++;
            }
            else
            {
                bottone1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                selezionato1 = false;
                selezionato2 = false;
                selezionato3 = false;
                producendoLabel.Text = "nulla";
                contaClick1++;
            }
        }

        private void bottone2_Click(object sender, EventArgs e)
        {
            if (contaClick2 % 2 == 0)
            {
                bottone2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneCliccato_industria");
                bottone1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                selezionato2 = true;
                selezionato1 = false;
                selezionato3 = false;
                producendoLabel.Text = item2.Tag.ToString();
                materiale_produzione = item2.Tag.ToString();
                contaClick2++;
            }
            else
            {
                bottone2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                selezionato2 = false;
                selezionato1 = false;
                selezionato3 = false;
                producendoLabel.Text = "nulla";
                contaClick2++;
            }
        }

        private void bottone3_Click(object sender, EventArgs e)
        {
            if (contaClick3 % 2 == 0)
            {
                bottone3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneCliccato_industria");
                bottone1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                selezionato3 = true;
                selezionato2 = false;
                selezionato1 = false;
                producendoLabel.Text = item3.Tag.ToString();
                materiale_produzione = item3.Tag.ToString();
                contaClick3++;
            }
            else
            {
                bottone3.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone1.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                bottone2.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("bottoneNonCliccato_industria");
                selezionato3 = false;
                selezionato2 = false;
                selezionato1 = false;
                producendoLabel.Text = "nulla";
                contaClick3++;
            }
        }

        private void controlloSoldi_Tick(object sender, EventArgs e)
        {
            if (denaroRimanente > 0)
            {
                denaroRimanente = denaroRimanente - 100;
                Console.WriteLine("denaro rimanente: " + denaroRimanente);
            }
            else
            {
                btn_StartIndustria.BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject("toggle-switch-design2");
                industria.setAvviata(false);
                avviabtnconta++;
                timerIndustria.Stop();
            }
        }
    }
}
