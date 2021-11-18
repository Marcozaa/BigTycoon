using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Rimuovere
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace BigTycoon
{
    public partial class Villaggio_amico : Form
    {
        String username;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "WTkppHa0s7inMse8iVg4eRYhRDzDo0gQFCsJPpGN",  // Key segreta database
            BasePath = "https://bigtycoon-ee983-default-rtdb.firebaseio.com/" // Indirizzo del database
        };
        IFirebaseClient client;



        public Villaggio_amico(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private async void Villaggio_amico_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Informazioni/" + username);  // Set - Ramo database
            datiCase result = response.ResultAs<datiCase>();
            PictureBox[] edifici = new PictureBox[20];
            String[] edificiIMG = new String[20];
            edificiIMG[0] = result.edificio1;
            edificiIMG[1] = result.edificio2;
            edificiIMG[2] = result.edificio3;
            edificiIMG[3] = result.edificio4;
            edificiIMG[4] = result.edificio5;
            edificiIMG[5] = result.edificio6;
            edificiIMG[6] = result.edificio7;
            edificiIMG[7] = result.edificio8;
            edificiIMG[8] = result.edificio9;
            String[] posizioniEdificici = new String[20];
            posizioniEdificici[0] = result.posizioneedificio1;
            posizioniEdificici[1] = result.posizioneedificio2;
            posizioniEdificici[2] = result.posizioneedificio3;
            posizioniEdificici[3] = result.posizioneedificio4;
            posizioniEdificici[4] = result.posizioneedificio5;
            posizioniEdificici[5] = result.posizioneedificio6;
            posizioniEdificici[6] = result.posizioneedificio7;
            posizioniEdificici[7] = result.posizioneedificio8;
            posizioniEdificici[8] = result.posizioneedificio9;

            try
            {
                for (int i = 0; i < 20; i++)
                {

                   //MessageBox.Show(result.edificio1 + " " + result.posizioneedificio+i);

                    //////////////////////////////////
                    var myStringWhichCantBeChanged = posizioniEdificici[i];
                    var g = Regex.Replace(myStringWhichCantBeChanged, @"[\{\}a-zA-Z=]", "").Split(',');

                    Point pointResult = new Point(
                                      int.Parse(g[0]),
                                      int.Parse(g[1]));

                    /////////////////////////////////////////
                    
                    edifici[i] = new PictureBox();
                    edifici[i].Location = pointResult;
                    edifici[i].Size = new Size(50, 60);
                    edifici[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(edificiIMG[i]);
                    edifici[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    edifici[i].BackColor = Color.Transparent;
                    this.Controls.Add(edifici[i]);
                    //////////////////*
                }
            }
            catch (System.NullReferenceException)
            {

            }
            catch (System.ArgumentNullException)
            {

            }
        }

        /*
         * 
         *  FirebaseResponse response = await client.GetTaskAsync("Informazioni/" + textBox1.Text);  // Set - Ramo database
            datiCase result = response.ResultAs<datiCase>();
            MessageBox.Show(result.edificio1 + " " + result.posizioneedificio1);
         */
    }
}
