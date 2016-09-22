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
        double _prixVenteProduit;

        int _production;

        public int Production
        {
            get { return _production; }
            set { _production = value; }
        }

        double _tempsProduction = 10;
        DateTime _heureDebut;

        public DateTime HeureDebut
        {
            get { return _heureDebut; }
            set { _heureDebut = value; }
        }

        public Animaux(double prixV, int tempsProd)
        {
            _tempsProduction = tempsProd;
            _prixVenteProduit = prixV;
            _production = (int)(_nbrAnimaux * _prixVenteProduit);
        }

        public bool calculTempsProd()
        {
            return ((DateTime.Now - _heureDebut).Minutes >= _tempsProduction);
        }
    }
}
