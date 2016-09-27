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
        double _tempsProduction = 10;
        DateTime _heureDebut;
        double _prixVenteProduit;
        int _production;

        public int NbrAnimaux
        {
            get { return _nbrAnimaux; }
            set { _nbrAnimaux = value; }
        }


        public int Production
        {
            get { return _production; }
            set { _production = value; }
        }

        public DateTime HeureDebut
        {
            get { return _heureDebut; }
            set { _heureDebut = value; }
        }

        public Animaux(double prixV, int tempsProd)
        {
            _tempsProduction = tempsProd;
            _prixVenteProduit = prixV;
        }

        public bool calculTempsProd()
        {
            return ((DateTime.Now - _heureDebut).Seconds >= _tempsProduction);
        }
    }
}
