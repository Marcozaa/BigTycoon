using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTycoon
{
    public class Oggetto
    {

        private int prezzo;
        private bool venduto;
        String nomeOggetto;
        
            string materiale1;
            string materiale2;
            int quantita1;
            int quantita2;
        
        public Oggetto(String materiale1,int quantita1,String materiale2, int quantita2,String nomeOggetto)
        {
            this.materiale1 = materiale1;
            this.materiale2 = materiale2;
            this.quantita1 = quantita1;
            this.quantita2 = quantita2;
            this.nomeOggetto = nomeOggetto;
        }

        public int getPrezzo()
        {
            return prezzo;
        }

        public void setPrezzo(int prezzo)
        {
            this.prezzo = prezzo;
        }

        public bool getVenduto()
        {
            return venduto;
        }

        public void setVenduto(bool venduto)
        {
            this.venduto = venduto;
        }
        public String getMateriale1()
        {
            return materiale1;
        }

        public String getNomeOggetto()
        {
            return nomeOggetto;
        }

        public void setNomeOggetto(String valore)
        {
            nomeOggetto = valore;
        }
    }
}
