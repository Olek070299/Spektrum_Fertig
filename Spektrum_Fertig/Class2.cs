/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Spektrum_Fertig
    {
        class GefährdungBerechnen
        {
            public List<double> blaulichtgefahrwirkfkt;
            public List<double> Blaulichtgefahrwirkfkt
            {
                get { return blaulichtgefahrwirkfkt; }
                set { blaulichtgefahrwirkfkt = value; }
            }
            private List<double> uvgefahrwirkfkt;
            public List<double> UVgefahrwirkfkt
            {
                get { return uvgefahrwirkfkt; }
                set { uvgefahrwirkfkt = value; }
            }

            private List<double> verbrennungsgefahrwirkfkt;
            public List<double> Verbrennungsgefahrwirkfkt
            {
                get { return verbrennungsgefahrwirkfkt; }
                set { verbrennungsgefahrwirkfkt = value; }
            }

            public void getblaulichtwirk()
            {
                blaulichtgefahrwirkfkt = new List<double>();


                Spektrum blaulicht = new Spektrum();
                blaulicht.readTextFile(@"E:\Bachelorarbeit Versuch 1\Wirkfunktion_Blaulicht.txt");
                for (int i = 0; i < blaulicht.Counts.Count; i++)
                {
                    blaulichtgefahrwirkfkt.Add(blaulicht.Counts[i]);

                }
            }
            public void getuvwirkfkt()
            {
                Spektrum uvlicht = new Spektrum();

                uvgefahrwirkfkt = new List<double>();

                uvlicht.readTextFile(@"E:\Bachelorarbeit Versuch 1\Uvlichtspektrum.txt");

                for (int i = 0; i < uvlicht.Counts.Count; i++)
                {
                    uvgefahrwirkfkt.Add(uvlicht.Counts[i]);

                }

            }


            public void getverbrennungsgefahrwirkfkt()
            {
                Spektrum Verbrennung = new Spektrum();

                verbrennungsgefahrwirkfkt = new List<double>();

                Verbrennung.readTextFile(@"E:\Bachelorarbeit Versuch 1\Verbrennungsgefahrwirkfkt.txt");

                for (int i = 0; i < Verbrennung.Counts.Count; i++)
                {
                    verbrennungsgefahrwirkfkt.Add(Verbrennung.Counts[i]);

                }
            }


            public void getprozentualenhotspot()
            {




            }







        }
    }
*/