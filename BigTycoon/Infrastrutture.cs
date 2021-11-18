using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTycoon
{
    public class Infrastrutture
    {
        String nome;
        String id;
        String immagine;
        int tipo;
        public Infrastrutture(String nome, String id, String immagine, int tipo)
        {
            this.nome = nome;
            this.id = id;
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

        public String getID()
        {
            return id;
        }

        public String getImmagine()
        {
            return immagine;
        }
        public int getTipo()
        {
            return tipo;
        }

    }
}
