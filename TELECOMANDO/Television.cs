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

            public Television(string Serie, string pro, int ris, string[] p)
            {
                NumeroDiSerie = Serie;
                produttore = pro;
                risoluzione = ris;
                connettori = p;
            }
            public Television(string Serie, string pro, int ris)
            {
                NumeroDiSerie = Serie;
                produttore = pro;
                risoluzione = ris;
            }
            public Television(string Serie, int ris, string[] p)
            {
                NumeroDiSerie = Serie;
                risoluzione = ris;
                connettori = p;
            }
            public Television(string Serie, string pro)
            {
                NumeroDiSerie = Serie;
                produttore = pro;
            }
            public Television(string Serie, int ris)
            {
                NumeroDiSerie = Serie;
                risoluzione = ris;
            }
            public Television(int ris, string[] p)
            {
                risoluzione = ris;
                connettori = p;
            }
            public Television(string Serie, string[] p)
            {
                NumeroDiSerie = Serie;
                connettori = p;
            }
            public Television(string[] p)
            {
                connettori = p;
            }
            public Television(int ris)
            {
                risoluzione = ris;
            }
            public Television(string Serie)
            {
                NumeroDiSerie = Serie;
            }

            public void setVolume(string vol)
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
            }
            public int getVolume()
            {
                return volume;
            }
            public void spegniAccendiTV(bool state)
            {
               state = !stato; 
            }
            public bool getStato()
            {
               return stato;
            }
            public void setCanale(int channel)
            {
               canale = channel;
            }

        }
    }
