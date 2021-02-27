using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bernabe.mattia._4j.giocoDiCarte.models
{
    class Carta
    {
        public int valore;
        public int seme;

        public Carta(int V, string S)
        {
            valore = V;
            if (S == "cuori")
                seme = 4;
            if (S == "quadri")
                seme = 3;
            if (S == "fiori")
                seme = 2;
            if (S == "picche")
                seme = 1;
        }
        public string visualizza()
        {
            string value = Convert.ToString(valore);
            string ris = "";
            if (seme == 4)
                ris = "♥";
            if (seme == 3)
                ris = "♦";
            if (seme == 2)
                ris = "♣";
            if (seme == 1)
                ris = "♠";
            if (value == "11")
                value = "J";
            if (value == "12")
                value = "Q";
            if (value == "13")
                value = "K";
            if (value == "14")
                value = "A";

            string frase = value +" "+ ris;
            return  frase;
        }
        public bool vince(Carta carta2)
        {
            if(valore > carta2.valore)
            {
                return true;
            }
            else if(valore < carta2.valore)
            {
                return false;
            }
            else if (valore == carta2.valore)
            {
                if(seme > carta2.seme)
                    return true;
                else
                    return false;
            }
            return true;
        }
    }
}
