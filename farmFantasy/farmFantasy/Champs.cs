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

        public int Temps
        {
            get { return _temps; }
            set { _temps = value; }
        }

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

        public double TempsPousse
        {
            get { return _tempsPousse; }
            set { _tempsPousse = value; }
        }

        private Dictionary<string, double> DicoSemence = new Dictionary<string, double> { 
                {"ble", 60},
                {"colza", 120},
                {"carotte", 300},
                {"patate", 500},
                {"mais", 900}
            };

        //  Constructor:
        public Champs(PictureBox champs, string semence) : this(champs, semence, 0) { }

        public Champs(PictureBox Champs, string semence, int tempsActu)
        {
            PbxChamps = Champs;
            TempsPousse = DicoSemence[semence];
            Culture = semence;
            Temps = tempsActu;
        }

        public bool calculTemps()
        {
            bool fini = false;
            Temps += 1;

            if (Temps >= TempsPousse)
            {
                fini = true;
                PbxChamps.Enabled = true;
                PbxChamps.Image = Properties.Resources.terre;
                Temps = 0;
            }

            return fini;
        }
    }
}