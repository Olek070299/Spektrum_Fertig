using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Spektrum_Fertig
{
    public partial class Form1 : Form
    {
        Spektrum test1 = new Spektrum();

        public Form1()
        {
            InitializeComponent();
        }
        //Daten laden mit StreamReader
        private void loadData_Click(object sender, EventArgs e)
        {
            try
            {
                test1.Path = @ConfigurationManager.AppSettings["Speicherort"]; //setzt Eigenschaft "Path" der Instanz auf den gewÃ¼nschten Wert
            }
            catch { MessageBox.Show("Fehler im Dateipfad"); }
            {
                try
                {
                    test1.readTextFile(); //lese Wellenlänge und counts aus
                }
                catch { MessageBox.Show("Fehler beim beim Laden.(Datei unterschiedliche Lang? Nur nullen ?"); }
            }
            try
            {
                for (int i = 0; i <= test1.Counts.Count - 1; i++)
                {
                    Wirkfunktion.Series["Wirkfunktion"].Points.AddXY(test1.Wellenlaenge[i], test1.Counts[i]);

                }
            }
            catch { MessageBox.Show("Fehler in der Darstellung des Charts"); }

        }
        //Flag eingabe
        private void flag_Click(object sender, EventArgs e)
        {
            try
            {
                test1.Flag = Convert.ToBoolean(eingabeflag.Text);
            }
            catch { MessageBox.Show("Eingabe Flag überprüfen"); }
        }


        //Normieren
        private void Normieren_Click(object sender, EventArgs e)
        {
            test1.normierung(test1.Counts, test1.Einsnormiert);//normiert auf knopf druck counts und speichert es in einsnormiert ab

            for (int i = 0; i <= test1.Counts.Count - 1; i++)
            {
                Funktion_normiert.Series["Series1"].Points.AddXY(test1.Wellenlaenge[i], test1.Einsnormiert[i]);
            }
        }
        //Offset
        private void Offset_Abziehen_Click(object sender, EventArgs e)
        {   try
            {
                test1.X1 = Int32.Parse(x1.Text); //x1 eingabe
            }
            catch { MessageBox.Show("Eingabe x1 überprüfen"); }

            try
            {
                test1.X2 = Int32.Parse(x2.Text);//x2 eingabe
            }
            catch { MessageBox.Show("Eingabe x2 überprüfen"); }

            try
            {
                test1.offsetabziehen(test1.X1, test1.X2, test1.Counts, test1.Offset_liste);//Offset von x1 bis x2 bestimmen
            }
            catch { MessageBox.Show("Fehler in Offsetabziehen"); }
            try
            {
                for (int i = 0; i <= test1.Counts.Count - 1; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(test1.Wellenlaenge[i], test1.Offset_liste[i]);
                }
            }catch { MessageBox.Show("Fehler in der Darstellung der Offset Funktion"); }
        }


        //Segmentausschneiden
        private void Segmentausschneiden_Click(object sender, EventArgs e)
        {

            try
            {
                test1.X1 = Int32.Parse(vonx1.Text); //x1 eingabe
            }catch { MessageBox.Show("Fehler bei der Eingabe von x1"); }
            try
            {
                test1.X2 = Int32.Parse(bisx2.Text); //x2 eingabe
            }
            catch { MessageBox.Show("Fehler bei der Eingabe von x2"); }
            try
            {
                test1.segmentausschneiden(test1.X1, test1.X2, test1.Counts, test1.Counts_segment);
            }
            catch { MessageBox.Show("Fehler in Segmentausschneiden, bitte Prüfen"); }
            try
            {
                for (int i = 0; i <= test1.Counts.Count - 1; i++)
                {

                    segmentierung_counts.Series["Series1"].Points.AddXY(test1.Wellenlaenge[i], test1.Counts_segment[i]);

                }
            }
            catch { MessageBox.Show("Fehler im Chart Segmentausschneiden"); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
           
        }































        /* private void Wellenlänge_segmentieren_Click(object sender, EventArgs e)
         {
             test1.X1 = Int32.Parse(vonx11.Text); //x1 eingabe
             test1.X2 = Int32.Parse(x22.Text); //x2 eingabe

             test1.segmentausschneiden(test1.X1, test1.X2, test1.Wellenlaenge, test1.Well_segment);
         }*/

        /*private void Button_Chart_Click(object sender, EventArgs e)
        {
            for (int i=0; i <= test1.Counts.Count - 1; i++)
            {
                Wirkfunktion.Series["Wirkfunktion"].Points.AddXY(test1.Wellenlaenge[i], test1.Counts[i]);

            }

        }*/

        /* private void Normierte_funktion_laden_Click(object sender, EventArgs e)
         {
             for (int i = 0; i <= test1.Counts.Count - 1; i++)
             {
                 Funktion_normiert.Series["Series1"].Points.AddXY(test1.Wellenlaenge[i], test1.Einsnormiert[i]);
             }
         }

         private void button1_Click(object sender, EventArgs e)
         {
             for (int i = 0; i <= test1.Counts.Count - 1; i++)
             {
                 chart1.Series["Series1"].Points.AddXY(test1.Wellenlaenge[i], test1.Offset_liste[i]);
             }
         }

         private void button2_Click(object sender, EventArgs e)
         {

            /* for (int i = 0; i <= test1.Counts.Count - 1; i++)
             {
                 segmentierung_counts.Series["Series1"].Points.AddXY(test1.Wellenlaenge[i], test1.Counts_segment[i]);

             }*/
    }

       /*private void x1_TextChanged(object sender, EventArgs e)
        {

        }*/
    }

