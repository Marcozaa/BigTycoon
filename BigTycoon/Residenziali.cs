using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTycoon
{
    public class Residenziali
    {
        private String nome;
        private String IDedificio;
        private int tipo;    // Tipo 1 -> Condominio    Tipo 2 -> casa    tipo 3 -> villa
        private int affitto;
        private String immagine;

        public Residenziali(String nome, String ID, String immagine, int tipo)
        {
            this.nome = nome;
            this.IDedificio = ID;
            this.immagine = immagine;
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

        public String getIDedificio()
        {
            return IDedificio;
        }

        public int getTipo()
        {
            return tipo;
        }

        public int getaffitto()
        {
            return affitto;
        }

        public String getImmagine()
        {
            return immagine;
        }


    }
}
