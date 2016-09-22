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
        private DateTime _hourPlant;
        private double _tempsPousse;
        private PictureBox _pbxChamps;
        private double _temps;
        private string _culture;

        public string Culture
        {
            get { return _culture; }
            set { _culture = value; }
        }

        public double Temps
        {
            get { return _temps; }
            set { _temps = value; }
        }

        private Dictionary<string, double> DicoSemence = new Dictionary<string, double> { 
                {"ble", 1},
                {"colza", 2},
                {"carotte", 5},
                {"patate", 10},
                {"mais", 15}
            };

        //  Constructor:
        public Champs(DateTime hour, PictureBox Champs, string semence)
        {
            _hourPlant = hour;
            _pbxChamps = Champs;
            _tempsPousse = DicoSemence[semence];
            _culture = semence;
        }

        public bool calculTemps()
        {
            bool fini;
            if ((DateTime.Now - _hourPlant).Minutes >= _tempsPousse)
            {
                fini = true;
                _pbxChamps.Enabled = true;

                _pbxChamps.ImageLocation = "images\\dirt.png";
            }
            else
            {
                fini = false;
            }

            return fini;
        }
    }
}