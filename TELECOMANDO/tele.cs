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
            setProduttore(p);
            setModello(m);
            setOperationMode(oM);
            setTV(T);
        }
        public tele(string p, string m)
        {
            setProduttore(p);
            setModello(m);
        }
        public tele(string p)
        {
            setProduttore(p);
        }
        private void setProduttore(string pro)
        {
            produttori = pro;
        }
        private void setModello(string mo)
        {
            modello = mo;
        }
        private void setOperationMode(string ope)
        {
            operationMode=ope;
        }
        private void setTV(Television tv)
        {
            TV = tv;
        }

        public void Accendi()
        {
            TV.accendi();
        }
        public void Spegni()
        {
            TV.spegni();
        }
        public void getStato()
        {
            TV.getStato();
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
        public void getCanale()
        {
            TV.getCanale();
        }
        public int  getVolume()
        {
            return TV.getVolume();
        }
    }
}
