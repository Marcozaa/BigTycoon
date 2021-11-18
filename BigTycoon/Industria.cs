using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BigTycoon
{
    public class Industria
    {

        private String nome;
        private String IDindustria;
        private int tipo;    // Tipo 1 -> Ferro, legno, plastica    Tipo 2 -> Alluminio, rame    tipo 3 -> Oro, Argento, Diamanti
        private double costoMateriaPrima;
        private int produttivita;
        private String immagine;
        private bool avviata = false;
        private String materialeInProduzione;

       
        bool timerAvviato;

        public Industria(String nome, String ID, String immagine, int tipo)
        {
            this.nome = nome;
            this.IDindustria = ID;
            this.immagine = immagine;
            costoMateriaPrima = 15;
            this.tipo = tipo;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String valore)
        {
            nome = valore;
        }

        public String getIDindustria()
        {
            return IDindustria;
        }

        public int getTipo()
        {
            return tipo;
        }
        public double getCostoMateriaPrima()
        {
            return costoMateriaPrima;
        }
        public int getProduttivita()
        {
            return produttivita;
        }

        public void setMaterialeInProduzione(String materiale)
        {
            materialeInProduzione = materiale;
        }

        public String setMaterialeInProduzione()
        {
            return materialeInProduzione;
        }
        public String getImmagine()
        {
            return immagine;
        }

        public bool getAvviata()
        {
            return avviata;
        }

        public void setAvviata(bool valore)
        {
            avviata = valore;
        }

        public bool getTimerAvviato()
        {
            return timerAvviato;
        }

        public void setTimerAvviato(bool valore)
        {
            timerAvviato = valore;
        }

        public String getMateriale_inProduzione()
        {
            return materialeInProduzione;
        }

    }
}
