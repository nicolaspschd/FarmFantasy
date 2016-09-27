using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmFantasy
{
    class Animaux
    {
        string _typeAnimal;
        int _nbrAnimaux;
        double _tempsProduction;
        double _prixVenteProduit;
        int _temps = 0;

        public double PrixVenteProduit
        {
            get { return _prixVenteProduit; }
            set { _prixVenteProduit = value; }
        }

        public Animaux(double prixV, int tempsProd, string typAnim, int nbrAnim)
        {
            _tempsProduction = tempsProd;
            _typeAnimal = typAnim;
            _nbrAnimaux = nbrAnim;
            _prixVenteProduit = prixV * _nbrAnimaux;
        }

        public bool calculTempsProd()
        {
            bool fini = false;
            _temps += 1;
            if (_temps >= _tempsProduction)
            {
                fini = true;
                _temps = 1;
            }

            return fini;
        }
    }
}
