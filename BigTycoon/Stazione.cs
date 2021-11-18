using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTycoon
{
    class Stazione
    {

        /*
         * Attributi minimi:
            - ID Treno
            - Tipo treno
            - Partenza (industria, fabrica, negozio)
            - Arrivo (industria, fabrica, negozio)
            - Quantità trasportata fissa (6 elementi)
            - Tempo di trasporto (1-5 secondi)
            - Attendere che siano pieni i vagoni (bool)

            Il treno è il modo per trasportare la merce da uno stabilimento
            ad un altro. Un treno ha un costo di realizzazione e avrà un
            tempo di trasporto (timer max 5 sec). Sarà possibile fare
            l’upgrade del treno e così ridurre questo tempo, per
            aumentare la produttività e la vendita dei prodotti per
            guadagnare di più.
            Verrà selezionata la partenza e l’arrivo. Successivamente
            verrà selezionato per ogni vagone (combobox del
            form/immagine) quale materia prima/prodotto viene
            trasportato.
            Può anche trasportare meno materiale e quindi alcuni vagoni
            possono esssere vuoti.
            La variabile booleana se è true significa che il treno prima di
            partire (e quindi prima di attivare il timer) dovrà essere pieno,
            e quindi attendere che il magazzino abbia tutte le merci,
            altrimenti partirà sempre anche se il treno non è
            completamente pieno.
         * 
         */
        private string IDtreno;
        private int tipoTreno;
        private int capacitaMassima;
        private int tempoTrasporto;
        private bool vagoniPieni;
        public Stazione()
        {
            
        }


        public String getIDtreno()
        {
            return IDtreno;
        }
        public int getTipoTreno()
        {
            return tipoTreno;
        }
        public int getCapacita()
        {
            return capacitaMassima;
        }
        public int getTempoTrasporto()
        {
            return tempoTrasporto;
        }
        public bool getVagoniPieni()
        {
            return vagoniPieni;
        }

    }
}
