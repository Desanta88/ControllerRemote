using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELECOMANDO
{
    public class tele
    {
        private string produttori = "";
        private string modello = "";
        private string operationMode = "";
        private int canale;
        private Television TV;

        public tele(string p, string m, string oM,Television T)
        {
            produttori = p;
            modello = m;
            operationMode = oM;
        }
        public tele( Television T)
        {
    
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
            
        }
        public void Spegni()
        {
            
        }
        /*public void AccSpe()
        {
            TV.spegniAccendiTV(TV.getStato());
        }*/
        /*public void setVolume(string v)
        {
            TV.setVolume(v);
        }*/
        public void alzaVolume()
        {
            TV.alzaVolume();
        }
        public void abbassaVolume()
        {
            TV.abbassaVolume();
        }
        public void setCanale(int c)
        {
            TV.setCanale(c);
        }
        public int  getVolume()
        {
            return TV.getVolume();
        }
    }
}
