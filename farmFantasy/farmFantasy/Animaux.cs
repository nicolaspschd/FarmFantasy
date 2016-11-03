/*
 * Auteurs : RAMUSHI Ardi && PASCHOUD Nicolas
 * Nom du programme : Farm Fantasy
 * Description : FarmFantasy est un jeu de gestion de ferme évolutif. 
 *               Plusieurs animaux et type de cultures seront 
 *               disponible ainsi que des améliorations de bâtiments.
 * Date : 1 Septembre 2016
 * Version 1.0
 */

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

        public int Temps
        {
            get { return _temps; }
            set { _temps = value; }
        }

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
            NbrAnimaux = nbrAnim;
            _prixV = prixV;
            Quantite = nbrAnim * qteProd;
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