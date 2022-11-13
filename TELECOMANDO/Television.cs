using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELECOMANDO
{
    public class Television
    {
            private string NumeroDiSerie = "";
            private string produttore = "";
            private string[] connettori = { };
            private int risoluzione = 0;
            private int volume = 0;
            private int canale = 0;
            private bool stato = false;

            private float prezzo;

            public Television(string Serie, string pro, int ris, string[] p)
            {
                setSerie(Serie);
                setProduttore(pro);
                setRisoluzione(ris);
                setConnettori(p);
            }
            public Television(string Serie, string pro, int ris)
            {
                setSerie(Serie);
                setProduttore(pro);
                setRisoluzione(ris);
            }
            public Television(string Serie, int ris, string[] p)
            {
                setSerie(Serie);
                setRisoluzione(ris);
                setConnettori(p);
            }
            public Television(string Serie, string pro)
            {
                setSerie(Serie);
                setProduttore(pro);
            }
            public Television(string Serie, int ris)
            {
                setSerie(Serie);
                setRisoluzione(ris);
            }
            public Television(int ris, string[] p)
            {
                setRisoluzione(ris);
                setConnettori(p);
            }
            public Television(string Serie, string[] p)
            {
                setSerie(Serie);
                setConnettori(p);
            }
            public Television(string[] p)
            {
               setConnettori(p);
            }
            public Television(int ris)
            {
               setRisoluzione(ris);
            }
            public Television(string Serie)
            {
               setSerie(Serie);
            }
            private void setSerie(string se)
            {
                NumeroDiSerie = se;
            }
            private void setProduttore(string p)
            {
                produttore = p;
            }
            private void setRisoluzione(int r)
            {
               risoluzione = r;
            }
            private void setConnettori(string[] c)
            {
               connettori = c;
            }

        public float Prezzo
            {
                get
                {
                   return prezzo;
                }
                set
                {
                  prezzo = value;
                }

            }

            /*public void setVolume(string vol)
            {
                if (vol == "+")
                {
                    volume = volume + 1;
                }
                else if (vol == "-")
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
            }*/
            public void alzaVolume()
            {
                if(volume>=100)
                  volume = 100;
                else
                  volume = volume + 1;
            }
            public void abbassaVolume()
            {
                if (volume <= 0)
                  volume = 0;
                else
                  volume = volume - 1;
            }
            public int getVolume()
            {
                return volume;
            }
            /*public void spegniAccendiTV(bool state)
            {
               state = !stato; 
            }*/
            public bool getStato()
            {
               return stato;
            }
            public int getCanale()
            {
               return canale;
            }
            public void setCanale(int channel)
            {
               canale = channel;
            }
            public void accendi()
            {
               stato = true;
            }
            public void spegni()
            {
               stato = false;
            }

    }
    }
