using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTycoon
{

  
    public class Fabbrica
    {
        private int tipo;
        private String nome;
        private String ID;
        private String immagine;
        public Fabbrica(String nome, String ID, String immagine, int tipo)
        {
            this.nome = nome;
            this.ID = ID;
            this.immagine = immagine;
            this.tipo = tipo;
            if (tipo == 1)
            {
                // i 4 item saranno giocattoli
            }
            if (tipo == 2)
            {
                // i 4 item saranno bricolage
            }
            if (tipo == 3)
            {
                // i 4 item saranno bricolage
            }
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String valore)
        {
            nome = valore;
        }

        public String getIDfabbrica()
        {
            return ID;
        }

        public int getTipo()
        {
            return tipo;
        }
       /* public double getCostoMateriaPrima()
        {
            return costoMateriaPrima;
        }*/
        /*public int getProduttivita()
        {
            return produttivita;
        }*/

        public String getImmagine()
        {
            return immagine;
        }

        /*public bool getAvviata()
        {
            return avviata;
        }*/

       /*public void setAvviata(bool valore)
        {
            avviata = valore;
        }*/
    }
}
