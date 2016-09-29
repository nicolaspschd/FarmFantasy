using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmFantasy
{
    public class Animaux
    {
        private string _typeAnimal;
        private int _nbrAnimaux;
        private double _tempsProduction;
        private double _prixVenteTot;
        private int _temps = 0;
        private double _prixV;

        public int NbrAnimaux
        {
            get { return _nbrAnimaux; }
            set { _nbrAnimaux = value; }
        }

        public double PrixVenteTot
        {
            get { return _prixVenteTot; }
            set { _prixVenteTot = value; }
        }

        public Animaux(double prixV, int tempsProd, string typAnim, int nbrAnim)
        {
            _tempsProduction = tempsProd;
            _typeAnimal = typAnim;
            _nbrAnimaux = nbrAnim;
            _prixV = prixV;
        }

        public void majPrix()
        {
            _prixVenteTot = _prixV * _nbrAnimaux;
        }

        public bool calculTempsProd()
        {
            bool fini = false;
            _temps += 1;
            if (_temps >= _tempsProduction)
            {
                fini = true;
                _temps = 1;
                Console.WriteLine(_typeAnimal + " : " + _prixVenteTot);
            }

            return fini;
        }
    }
}