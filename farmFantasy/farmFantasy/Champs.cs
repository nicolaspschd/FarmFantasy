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
        private double _tempsPousse;
        private PictureBox _pbxChamps;
        private string _culture;
        private int _temps = 0;

        public PictureBox PbxChamps
        {
            get { return _pbxChamps; }
            set { _pbxChamps = value; }
        }


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
        public Champs(PictureBox Champs, string semence)
        {
            _pbxChamps = Champs;
            _tempsPousse = DicoSemence[semence];
            _culture = semence;
        }

        public bool calculTemps()
        {
            bool fini = false;
            _temps += 1;
            if (_temps >= _tempsPousse)
            {
                fini = true;
                _pbxChamps.Enabled = true;
                _temps = 0;
                _pbxChamps.Image = Properties.Resources.terre;
            }

            return fini;
        }
    }
}