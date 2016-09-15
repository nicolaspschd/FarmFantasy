using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmFantasy
{
    class Champs
    {
        private DateTime hourPlant;
        private double tempsPousse;
        private PictureBox pbxChamps;
        private double temps;

        public double Temps
        {
            get { return temps; }
            set { temps = value; }
        }

        private Dictionary<string, double> DicoSemence = new Dictionary<string, double> { 
                {"ble", 1},
                {"colza", 2},
                {"carotte", 5},
                {"patate", 10} 
            };

        //  Constructor:
        public Champs(DateTime hour, PictureBox Champs, string semence)
        {
            hourPlant = hour;
            pbxChamps = Champs;
            tempsPousse = DicoSemence[semence];
        }

        public bool calculTemps()
        {
            bool fini;
            if ((DateTime.Now - hourPlant).Minutes >= tempsPousse)
            {
                fini = true;
                pbxChamps.Enabled = true;

                pbxChamps.ImageLocation = "images\\dirt.png";
                pbxChamps.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                fini = false;
            }

            return fini;
        }
    }
}