using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELECOMANDO
{
    internal class tele
    {
        private string produttori = "";
        private string modello = "";
        private string operationMode = "";
        private bool stato;
        private int canale;
        private int volume;

        public tele(string p, string m, string oM)
        {
            produttori = p;
            modello = m;
            operationMode = oM;
        }
        public tele(string p, string m)
        {
            produttori = p;
            modello = m;
        }
        public tele(string p)
        {
            produttori = p;
        }

        public void Accendi()
        {
            stato = true;
        }
        public void Spegni()
        {
            stato = false;
        }
        public void setVolume(string v)
        {
            volume = 0;
            if (v == "+")
            {
                volume = volume + 1;
            }
            else if (v == "-")
            {
                volume = volume - 1;
            }
            if (volume < 0)
            {
                volume = 0;
            }
            if (volume > 100)
            {
                volume = 100;
            }
        }
        public void setCanale(int c)
        {
            canale = c;
        }
        public int getVolume()
        {
            return volume;
        }
    }
}
