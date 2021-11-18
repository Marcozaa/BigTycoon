using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTycoon
{
    public class Casa
    {

        Point posizione;
        int tempoCostruzione;
        String immagineCasa;
        String tipoEdificio;

        public Casa(Point posizione, int tempoCostruzione, String immagineCasa, String tipoEdificio)
        {
            this.posizione = posizione;
            this.tempoCostruzione = tempoCostruzione;
            this.immagineCasa = immagineCasa;
            this.tipoEdificio = tipoEdificio;
        }


        public String getImmagineCasa()
        {
            return immagineCasa;
        }

    }
}
