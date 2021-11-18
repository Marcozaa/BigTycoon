using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTycoon
{
    public class Negozio
    {
        /*
         * 
         *  - ID Negozio
            - Nome negozio
            - Tipo negozio (giocattoli, attr. sportive, gioielli....)
            - Prezzo di vendita (o coefficiente di vendita)
            - Domanda di mercato (1-13 ogni 10 secondi)
            - Magazzino merce
         * 
         * 
         */

        private String IDnegozio;
        private String nomeNegozio;
        private int tipoNegozio;
        private String immagine;


        private String[] magazzino = new String[20];
        public Negozio(String id,String nome, int tipo, String immagine)
        {
            this.IDnegozio = id;
            this.nomeNegozio = nome;
            this.tipoNegozio = tipo;
            this.immagine = immagine;
        }

        public String getIDnegozio()
        {
            return IDnegozio;
        }

        public String getNomeNegozio()
        {
            return nomeNegozio;
        }

        public int getTipoNegozio()
        {
            return tipoNegozio;
        }

        public void setNome(String valore)
        {
            nomeNegozio = valore;
        }

        public String getImmagine()
        {
            return immagine;
        }
    }
}
