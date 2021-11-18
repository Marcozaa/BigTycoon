using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace BigTycoon
{
    
    
    class salvaStato : LoginResgister
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "WTkppHa0s7inMse8iVg4eRYhRDzDo0gQFCsJPpGN",  // Key segreta database
            BasePath = "https://bigtycoon-ee983-default-rtdb.firebaseio.com/" // Indirizzo del database
        };
        IFirebaseClient client;
        Giocatore player;
        String[] edificiCostruiti;
        PictureBox edificio_acquistato;
        PictureBox[] arrayPicturebox;
        public salvaStato(Giocatore player, String[] edificiCostruiti, PictureBox[] arrayPicturebox)
        {
            client = new FireSharp.FirebaseClient(config);
            this.player = player;
            this.edificiCostruiti = edificiCostruiti;
            this.edificio_acquistato = edificio_acquistato;
            this.arrayPicturebox = arrayPicturebox;
            //for(int i = 0; i < 20; i++)
            //{
            //    MessageBox.Show(arrayPicturebox[i].Location.ToString());
            //}
        }

        public async void clientSalvaStato()
        {

            // Bug -  edificio 2 ha posizione 0,0 far partire outofbounds da una posziione dopo.
            int contaOutOFBounds = 0;
            for(int i = 0; i < 20; i++)
            {
                try
                {
                    MessageBox.Show(arrayPicturebox[i].ToString());
                    contaOutOFBounds++;
                }
                catch (System.ArgumentOutOfRangeException)
                {

                }
                catch (System.NullReferenceException)
                {
                    
                }
            }
            for (int i=contaOutOFBounds; i < 20; i++)
            {
                arrayPicturebox[i] = new PictureBox();
                arrayPicturebox[i].Location = new Point(0, 0);
            }

            MessageBox.Show("LUnghezza: " + contaOutOFBounds);
           //MessageBox.Show(sizeof(arrayPicturebox) / sizeof(arrayPicturebox[0]);.ToString());
           var edificiClient = new datiCase
            {
                edificio1 = edificiCostruiti[0],
                posizioneedificio1 = arrayPicturebox[0].Location.ToString(), // INiziavano a 1 non a zero
                edificio2 = edificiCostruiti[1],
                posizioneedificio2 = arrayPicturebox[1].Location.ToString(),
                edificio3 = edificiCostruiti[2],
                posizioneedificio3 = arrayPicturebox[2].Location.ToString(),
                edificio4 = edificiCostruiti[3],
                posizioneedificio4 = arrayPicturebox[3].Location.ToString(),
                edificio5 = edificiCostruiti[4],
                posizioneedificio5 = arrayPicturebox[4].Location.ToString(),
                //edificio6 = edificiCostruiti[6],
                //edificio7 = edificiCostruiti[7],
                //edificio8 = edificiCostruiti[8],
                //edificio9 = edificiCostruiti[9],
                //edificio10 = edificiCostruiti[10],
                //edificio11 = edificiCostruiti[11],
                //edificio12 = edificiCostruiti[12],
                //edificio13 = edificiCostruiti[13],
                //edificio14 = edificiCostruiti[14],
                //edificio15 = edificiCostruiti[15],
                //edificio16 = edificiCostruiti[16],
                //edificio17 = edificiCostruiti[17],
                //edificio18 = edificiCostruiti[18],
            };

            var posizioniClient = new posizioniCase
            {
                //posizioneedificio1 = 3;
            };
            SetResponse response = await client.SetTaskAsync("Informazioni/" + player.getUsername(), edificiClient);  // Set - Ramo database
            datiCase result = response.ResultAs<datiCase>();
            
        }
    }
}
