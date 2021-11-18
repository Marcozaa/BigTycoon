using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTycoon
{
    public class Giocatore
    {
        
          

        String username;
        String password;


        private double denaro = 0;
        private int legno = 0;
        private int plastica = 0;
        private int alluminio = 0;
        private int argento = 0; 
        private int rame = 0;
        private int oro = 0;
        private int diamanti = 0;
        private int ferro = 0;

        public Giocatore(String password, String username)
        {
            Scraper s = new Scraper();

           

            this.username = username;
            this.password = password;

        }





        public double getArgento()
        {
            return argento;
        }
        public int getLegno()
        {
            return legno;
        }

        public int getOro()
        {
            return oro;
        }
        public int getPlastica()
        {
            return plastica;
        }
        public int getAlluminio()
        {
            return alluminio;
        }
        public int getDiamanti()
        {
            return diamanti;
        }
        public int getFerro()
        {
            return ferro;
        }
        public int getRame()
        {
            return rame;
        }

        public void setArgento(int val)
        {
            argento += val;
        }

        public void setDenaro(double valore)
        {
            denaro += valore;
        }
        public double getDenaro()
        {
            return denaro;
        }
        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }


        public void setLegno(int val)
        {
            legno += val;
        }
        public void setOro(int val)
        {
            oro += val;
        }
        public void setPlastica(int val)
        {
            plastica += val;
        }
        public void setAlluminio(int val)
        {
            alluminio += val;
        }
        public void setDiamanti(int val)
        {
            diamanti += val;
        }
        public void setFerro(int val)
        {
            ferro += val;
        }
        public void setRame(int val)
        {
            rame += val;
        }


    }
}
