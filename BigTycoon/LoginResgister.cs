using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace BigTycoon
{
    public partial class LoginResgister : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "WTkppHa0s7inMse8iVg4eRYhRDzDo0gQFCsJPpGN",  // Key segreta database
            BasePath = "https://bigtycoon-ee983-default-rtdb.firebaseio.com/" // Indirizzo del database
        };
        IFirebaseClient client;

        public LoginResgister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
 



            FirebaseResponse response = await client.GetTaskAsync("Informazioni/" + textBoxUsername.Text);  // Get - Ramo database
            try{
                Dati d = response.ResultAs<Dati>();
                if (d.password != GetHashString(textBoxPassword.Text))
                {
                    MessageBox.Show("Hai inserito una password sbagliata! ");
                }

                if(d.password == GetHashString(textBoxPassword.Text))
                {
                    MessageBox.Show("OK.");

                    Giocatore player = new Giocatore(textBoxPassword.Text, d.nome);
                    Form1.utenteRegistrato(player);
                    this.Close();
                }

            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Questo username non è presente nel database, controlla meglio...");
            }
        }

       

        private void LoginResgister_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private async void registrati(object sender, EventArgs e)
        {
            var dati = new Dati
            {
                nome = textBoxUsername.Text,
                password = GetHashString(textBoxPassword.Text),
            };

           //Console.WriteLine("HASH :"+ GetHashString(textBoxPassword.Text));
            SetResponse response = await client.SetTaskAsync("Informazioni/" + textBoxUsername.Text, dati);  // Set - Ramo database
            Dati result = response.ResultAs<Dati>();

            MessageBox.Show("Registrazione avvenuta con successo");

        }




        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
            }

        }
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }



    }
}
