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
        private string _culture;

        public string Culture
        {
            get { return _culture; }
            set { _culture = value; }
        }

        private Dictionary<string, double> DicoSemence = new Dictionary<string, double> { 
                {"ble", 59},
                {"colza", 119},
                {"carotte", 299},
                {"patate", 499},
                {"mais", 899}
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
            Console.WriteLine("Minutes : " + (DateTime.Now - _hourPlant).Minutes);
            Console.WriteLine("Secondes : " + (DateTime.Now - _hourPlant).Seconds);
            if ((DateTime.Now - _hourPlant).Seconds >= _tempsPousse)
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