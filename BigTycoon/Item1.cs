using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTycoon
{

    // fare interfaccia per items
    class Item1
    {
        String immagine;
        double costo;

        public Item1(String immagine, double costo)
        {
            this.immagine = immagine;
            this.costo = costo;
        }
        public void compra()
        {
            // set personaggio.denaro - costo;
        }

        public String getImmagine()
        {
            return immagine;
        }
        public double getCosto()
        {
            return costo;
        }

        public void setImmagine(String immagine)
        {
            this.immagine = immagine;
        }

        public void setCosto(double costo)
        {
            this.costo = costo;
        }

    }
}
