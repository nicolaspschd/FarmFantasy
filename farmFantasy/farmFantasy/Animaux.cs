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
        private int _quantite;

        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }

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

        public Animaux(double prixV, double tempsProd, string typAnim, int nbrAnim, int qteProd)
        {
            _tempsProduction = tempsProd;
            _typeAnimal = typAnim;
            _nbrAnimaux = nbrAnim;
            _prixV = prixV;
            _quantite = nbrAnim * qteProd;
        }

        public void majPrix()
        {
            _prixVenteTot = _prixV * _nbrAnimaux;
            _quantite = _nbrAnimaux * 2;
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